/*
Copyright 2013 Intel Corporation

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;


namespace Intel.SerialCapture
{
  /// <summary>
  /// This is the class that implements the package exposed by this assembly.
  ///
  /// The minimum requirement for a class to be considered a valid package for Visual Studio
  /// is to implement the IVsPackage interface and register itself with the shell.
  /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
  /// to do it: it derives from the Package class that provides the implementation of the 
  /// IVsPackage interface and uses the registration attributes defined in the framework to 
  /// register itself and its components with the shell.
  /// </summary>
  // This attribute tells the PkgDef creation utility (CreatePkgDef.exe) that this class is
  // a package.
  [PackageRegistration(UseManagedResourcesOnly = true)]
  [ProvideOptionPage(typeof(SerialCaptureToolOptionsSessionPage), "Serial Output", "General", 115, 116, true)]
  [ProvideOptionPage(typeof(SerialCaptureToolOptionsLoggingPage), "Serial Output", "Logging", 115, 117, true)]
  // This attribute is used to register the information needed to show this package
  // in the Help/About dialog of Visual Studio.
  [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
  // This attribute is needed to let the shell know that this package exposes some menus.
  [ProvideMenuResource("Menus.ctmenu", 1)]
  [Guid(GuidList.guidSerialCaptureToolPkgString)]
  [ProvideAutoLoad("ADFC4E64-0397-11D1-9F4E-00A0C911004F")]
  [ProvideAutoLoad("f1536ef8-92ec-443c-9ed7-fdadf150da82")]
  public sealed class SerialCaptureToolPackage : Package, IDisposable
  {
    // Data I/O handles
    private SerialPort port;
    private StreamWriter fs;

    // GUI
    private IVsOutputWindowPane customPane;
    private Window outputWindow;

    // Status Indicators/Commands
    private OleMenuCommand startMenuItem;
    private OleMenuCommand pauseMenuItem;
    private OleMenuCommand stopMenuItem;

    private bool first;
    private bool running;
    private bool paused;

    private char last;

    public SerialCaptureToolOptionsSessionPage SessionOptions
    {
      get
      {
        return (SerialCaptureToolOptionsSessionPage)GetDialogPage(typeof(SerialCaptureToolOptionsSessionPage));
      }
    }

    public SerialCaptureToolOptionsLoggingPage LoggingOptions
    {
      get
      {
        return (SerialCaptureToolOptionsLoggingPage)GetDialogPage(typeof(SerialCaptureToolOptionsLoggingPage));
      }
    }

    public SerialCaptureToolPackage()
    {
      Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", this.ToString()));
    }

    public void Dispose()
    {
      base.Dispose(true);

      if (port != null && port.IsOpen) port.Close();
      if (fs != null) fs.Close();
    }

    /////////////////////////////////////////////////////////////////////////////
    // Overridden Package Implementation
    #region Package Members

    /// <summary>
    /// Initialization of the package; this method is called right after the package is sited.
    /// </summary>
    protected override void Initialize()
    {
      Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));
      base.Initialize();

      // Option page handlers
      SessionOptions.PropertyChanged += new PropertyChangedEventHandler(OptionChangedHandler);
      LoggingOptions.PropertyChanged += new PropertyChangedEventHandler(OptionChangedHandler);

      //@TODO(curzona): I'm not handling the case where mcs is null
      // Add our command handlers for menu (commands must exist in the .vsct file)
      OleMenuCommandService mcs = GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
      if (null != mcs)
      {
        // Create the command for the menu item.
        CommandID menuCommandID;

        menuCommandID = new CommandID(GuidList.guidSerialCaptureToolCmdSet, (int)PkgCmdIDList.cmdidStartCmd);
        startMenuItem = new OleMenuCommand(StartCapture, menuCommandID);
        startMenuItem.Enabled = true;
        mcs.AddCommand(startMenuItem);

        menuCommandID = new CommandID(GuidList.guidSerialCaptureToolCmdSet, (int)PkgCmdIDList.cmdidPauseCmd);
        pauseMenuItem = new OleMenuCommand(PauseCapture, menuCommandID);
        pauseMenuItem.Enabled = false;
        mcs.AddCommand(pauseMenuItem);

        menuCommandID = new CommandID(GuidList.guidSerialCaptureToolCmdSet, (int)PkgCmdIDList.cmdidStopCmd);
        stopMenuItem = new OleMenuCommand(StopCapture, menuCommandID);
        stopMenuItem.Enabled = false;
        mcs.AddCommand(stopMenuItem);
      }

      running = paused = false;
      first = true;
      last = '\n';
    }
    #endregion

    private void OptionChangedHandler(Object sender, PropertyChangedEventArgs e)
    {
      if(port != null && port.IsOpen) StopCapture(null, null);

      // Reinitialize the serial port since the user changed the options
      InitSerialPort();
    }

    private void DataReceivedHandler(
                    object sender,
                    SerialDataReceivedEventArgs e)
    {
      SerialPort sp = (SerialPort)sender;

      try
      {
        OutputString(sp.ReadExisting());
      }
      catch (InvalidOperationException x)
      {
        // Serial Port closed before we could read the data
      }
    }

    private void OutputString(string message)
    {
      if (customPane != null)
      {
        customPane.OutputString(message);
      }

      if (fs != null)
      {
        fs.Write(message);
      }

      last = message[message.Length - 1];
    }

    private void OutputStatus(string message)
    {
      // Status messages (Start, Stop, Pause) should always appear on a new line.
      if(last != '\n')
      {
        message = "\n" + message;
      }

      OutputString(message);
    }

    private void InitOutputPane()
    {
      Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering InitOutputPane() of: {0}", this.ToString()));

      // Create the serial output window
      IVsOutputWindow outWindow = Package.GetGlobalService(typeof(SVsOutputWindow)) as IVsOutputWindow;
      Guid customGuid = GuidList.guidSerialCaptureToolOutputPane;
      string customTitle = "Serial";
      outWindow.CreatePane(ref customGuid, customTitle, 1, 1);
      outWindow.GetPane(ref customGuid, out customPane);
      customPane.Activate(); // Brings this pane into view
      OutputStatus("Initializing Serial OutputString " + DateTime.Now + "\n");

      // Get the Output window so we can pop it later when the user starts serial capture
      EnvDTE.DTE dte = (EnvDTE.DTE)this.GetService(typeof(EnvDTE.DTE));
      outputWindow = dte.Windows.Item(EnvDTE.Constants.vsWindowKindOutput);
    }

    private void InitSerialPort()
    {
      Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering InitializePort() of: {0}", this.ToString()));

      if (port != null)
      {
        port.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
        if (port.IsOpen) port.Close();
      }

      port = new SerialPort();
      port.PortName = SessionOptions.PortName;
      port.BaudRate = SessionOptions.BaudRate;
      port.Parity = SessionOptions.Parity;
      port.DataBits = SessionOptions.DataBits;
      port.StopBits = SessionOptions.StopBits;
      port.Handshake = SessionOptions.Handshake;
    }

    private bool TryOpenPort()
    {
      if (port.IsOpen) return true;

      try
      {
        port.Open();
      }
      catch (UnauthorizedAccessException x)
      {
        // The port is open by another program

        // Show a Message Box to prove we were here
        IVsUIShell uiShell = (IVsUIShell)GetService(typeof(SVsUIShell));
        Guid clsid = Guid.Empty;
        int result;
        Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(uiShell.ShowMessageBox(
                   0,
                   ref clsid,
                   "Serial OutputString Tool",
                   string.Format(CultureInfo.CurrentCulture, "Unable to open {0}. {0} is open by another program.", port.PortName),
                   string.Empty,
                   0,
                   OLEMSGBUTTON.OLEMSGBUTTON_OK,
                   OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST,
                   OLEMSGICON.OLEMSGICON_CRITICAL,
                   0,        // false
                   out result));

        return false;
      }

      return true;
    }

    private bool TryOpenFile()
    {
      if(LoggingOptions.OutputOption == OutputOptions.NoLogging) return true;

      try
      {
        bool append = false;

        if (LoggingOptions.FileOption == FileOptions.AppendToExisting)
        {
          append = true;
        }
        else if (LoggingOptions.FileOption == FileOptions.AskIfExisting)
        {
          if (File.Exists(LoggingOptions.FileName))
          {
            IVsUIShell uiShell = (IVsUIShell) GetService(typeof (SVsUIShell));
            Guid clsid = Guid.Empty;
            int result;
            Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(uiShell.ShowMessageBox(
              0,
              ref clsid,
              "Serial OutputString Tool",
              string.Format(CultureInfo.CurrentCulture, "{0} already exists, whould you like to overwrite it.",
                            LoggingOptions.FileName),
              string.Empty,
              0,
              OLEMSGBUTTON.OLEMSGBUTTON_YESNO,
              OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST,
              OLEMSGICON.OLEMSGICON_WARNING,
              0, // false
              out result));

            Debug.WriteLine("result = {0}", result);

            append = (result == 7); // IDNO
          }
          else
          {
            // Users expect overwrites only to occur when they first open Visual Studio
            append = !first;
          }
        }

        fs = new StreamWriter(LoggingOptions.FileName, append);

        first = false;
      }
      catch (IOException x)
      {
        IVsUIShell uiShell = (IVsUIShell)GetService(typeof(SVsUIShell));
        Guid clsid = Guid.Empty;
        int result;
        Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(uiShell.ShowMessageBox(
                   0,
                   ref clsid,
                   "Serial OutputString Tool",
                   string.Format(CultureInfo.CurrentCulture, "Unable to open {0}. {0} is open by another program.", LoggingOptions.FileName),
                   string.Empty,
                   0,
                   OLEMSGBUTTON.OLEMSGBUTTON_OK,
                   OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST,
                   OLEMSGICON.OLEMSGICON_CRITICAL,
                   0,        // false
                   out result));
      }

      return true;
    }

    private void StartCapture(object sender, EventArgs e)
    {
      Debug.Assert(!running);

      Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering StartCapture() of: {0}", this.ToString()));

      if (!paused)
      {
        if (customPane == null) InitOutputPane();

        if (port == null) InitSerialPort();

        if (!TryOpenPort()) return;

        if (!TryOpenFile()) return; 
      }

      OutputStatus("Starting Serial OutputString " + DateTime.Now + "\n");

      port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

      // Update Buttons
      startMenuItem.Enabled = false;
      pauseMenuItem.Enabled = true;
      stopMenuItem.Enabled = true;

      // Update State
      running = true;
      paused = false;

      // Pop the custom output pane so the user can see it
      if (outputWindow != null) outputWindow.Visible = true;
    }

    private void PauseCapture(object sender, EventArgs e)
    {
      Debug.Assert(running);
      Debug.Assert(!paused);

      Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering PauseCapture() of: {0}", this.ToString()));

      OutputStatus("Pausing Serial OutputString " + DateTime.Now + "\n");

      // Stop listing to the port
      if (port != null)
      {
        port.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
      }

      // Update Buttons
      startMenuItem.Enabled = true;
      pauseMenuItem.Enabled = false;
      stopMenuItem.Enabled = true;

      // Update State
      running = false;
      paused = true;
    }

    private void StopCapture(object sender, EventArgs e)
    {
      Debug.Assert(running);

      Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering StopCapture() of: {0}", this.ToString()));

      OutputStatus("Stopping Serial OutputString " + DateTime.Now + "\n");

      // Close the SerialPort
      if (port != null)
      {
        port.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
        if (port.IsOpen) port.Close();
      }

      // Close the FileStream
      if (fs != null)
      {
        fs.Close();
        fs = null;
      }

      // Update Buttons
      startMenuItem.Enabled = true;
      pauseMenuItem.Enabled = false;
      stopMenuItem.Enabled = false;

      // Update State
      running = false;
      paused = false;
    }
  }
}

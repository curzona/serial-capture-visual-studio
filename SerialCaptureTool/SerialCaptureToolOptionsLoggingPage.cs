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

using Microsoft.VisualStudio.Shell;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Intel.SerialCapture
{
  public enum OutputOptions
  {
    NoLogging,
    LogAll
  }

  public enum FileOptions
  {
    OverwriteExisting,
    AppendToExisting,
    AskIfExisting
  }

  [ComVisible(true)]
  [ClassInterface(ClassInterfaceType.AutoDual)]
  [Guid("773FA5AB-D5C0-4A8A-8D1E-AF1721F2B891")]
  public class SerialCaptureToolOptionsLoggingPage : DialogPage, INotifyPropertyChanged
  {
    private OutputOptions loggingOption;
    private string fileName;
    private FileOptions fileOption;

    public SerialCaptureToolOptionsLoggingPage()
    {
      ResetSettings();
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(
        DesignerSerializationVisibility.Hidden)]
    protected override IWin32Window Window
    {
      get
      {
        SerialCaptureToolOptionsLoggingControl page = new SerialCaptureToolOptionsLoggingControl();
        page.optionsPage = this;
        page.Initialize();
        return page;
      }
    }

    public OutputOptions OutputOption
    {
      get { return loggingOption; }
      set
      {
        loggingOption = value;
        OnPropertyChanged("LoggingOption");
      }
    }

    public string FileName
    {
      get { return fileName; }
      set
      {
        fileName = value;
        OnPropertyChanged("FileName");
      }
    }

    public FileOptions FileOption
    {
      get { return fileOption; }
      set
      {
        fileOption = value;
        OnPropertyChanged("FileOption");
      }
    }

    public override void ResetSettings()
    {
      loggingOption = OutputOptions.LogAll;
      fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\serial.log";
      fileOption = FileOptions.OverwriteExisting;

      base.ResetSettings();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler handler = PropertyChanged;
      if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}

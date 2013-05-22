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

using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace Intel.SerialCapture
{
  public partial class SerialCaptureToolOptionsLoggingControl : UserControl
  {
    SaveFileDialog dialog;

    public SerialCaptureToolOptionsLoggingControl()
    {
      InitializeComponent();
    }

    internal SerialCaptureToolOptionsLoggingPage optionsPage;

    public void Initialize()
    {
      Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering Initialize for: {0}", this.ToString()));

      logFileNameTextBox.Text = optionsPage.FileName;

      dialog = new SaveFileDialog();
      dialog.FileName = dialog.FileName = logFileNameTextBox.Text;

      if (optionsPage.FileOption == FileOptions.OverwriteExisting)
      {
        overwriteRadioButton.Checked = true;
      }
      else if (optionsPage.FileOption == FileOptions.AppendToExisting)
      {
        appendRadioButton.Checked = true;
      }
      else if (optionsPage.FileOption == FileOptions.AskIfExisting)
      {
        askRadioButton.Checked = true;
      }

      if (optionsPage.OutputOption == OutputOptions.NoLogging)
      {
        noLoggingradioButton.Checked = true;
      }
      else if (optionsPage.OutputOption == OutputOptions.LogAll)
      {
        allLoggingRadioButton.Checked = true;
      }
    }

    private void logFileNameTextBox_TextChanged(object sender, EventArgs e)
    {
      if (logFileNameTextBox.Text.Length == 0)
      {
        logFileNameTextBox.Text = optionsPage.FileName;

        IVsUIShell uiShell = (IVsUIShell)GetService(typeof(SVsUIShell));
        Guid clsid = Guid.Empty;
        int result;
        Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(uiShell.ShowMessageBox(
                   0,
                   ref clsid,
                   "Serial Capture Tool",
                   string.Format(CultureInfo.CurrentCulture, "\"{0}\" is an invalid file name.", logFileNameTextBox.Text),
                   string.Empty,
                   0,
                   OLEMSGBUTTON.OLEMSGBUTTON_OK,
                   OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST,
                   OLEMSGICON.OLEMSGICON_CRITICAL,
                   0,        // false
                   out result));
      } else {
        optionsPage.FileName = logFileNameTextBox.Text;
      }
    }

    private void logFileNameButton_Click(object sender, EventArgs e)
    {
      dialog.Filter = "All Types (*.*)|*.*";
      dialog.FilterIndex = 1;
      if (dialog.ShowDialog() == DialogResult.OK)
      {
        optionsPage.FileName = logFileNameTextBox.Text = dialog.FileName;
      }
    }

    private void overwriteRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      if (overwriteRadioButton.Checked)
      {
        optionsPage.FileOption = FileOptions.OverwriteExisting;
      }
    }

    private void appendRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      if (appendRadioButton.Checked)
      {
        optionsPage.FileOption = FileOptions.AppendToExisting;
      }
    }

    private void askRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      if (askRadioButton.Checked)
      {
        optionsPage.FileOption = FileOptions.AskIfExisting;
      }
    }

    private void noLoggingradioButton_CheckedChanged(object sender, EventArgs e)
    {
      if (noLoggingradioButton.Checked)
      {
        optionsPage.OutputOption = OutputOptions.NoLogging;
      }
    }

    private void allLoggingRadioButton_CheckedChanged(object sender, EventArgs e)
    {
      if (allLoggingRadioButton.Checked)
      {
        optionsPage.OutputOption = OutputOptions.LogAll;
      }
    }
  }
}

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

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace Intel.SerialCapture
{
  public partial class SerialCaptureToolOptionsSessionControl : UserControl
  {
    public SerialCaptureToolOptionsSessionControl()
    {
      InitializeComponent();
    }

    internal SerialCaptureToolOptionsSessionPage optionsPage;

    public void Initialize()
    {
      Debug.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering Initialize for: {0}", this.ToString()));

      string[] portNames = SerialPort.GetPortNames();
      portNameCombo.Items.AddRange(portNames);
      portNameCombo.SelectedIndex = Array.IndexOf(portNames, optionsPage.PortName);

      baudRateTestBox.Text = Convert.ToString(optionsPage.BaudRate);

      parityCombo.Items.AddRange(Enum.GetNames(typeof(Parity)));
      parityCombo.SelectedIndex = (int)optionsPage.Parity;

      int[] dataBitsArray = new int[] { 7, 8 };
      dataBitsCombo.Items.AddRange(dataBitsArray.Select(x => Convert.ToString(x)).ToArray());
      dataBitsCombo.SelectedIndex = Array.IndexOf(dataBitsArray, optionsPage.DataBits);

      stopBitsCombo.Items.AddRange(Enum.GetNames(typeof(StopBits)));
      stopBitsCombo.SelectedIndex = (int)optionsPage.StopBits;

      handshakeCombo.SelectedIndex = (int)optionsPage.Handshake;
    }

    private void portNameCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
      optionsPage.PortName = portNameCombo.SelectedItem.ToString();
    }

    private void baudRateTestBox_TextChanged(object sender, EventArgs e)
    {
      optionsPage.BaudRate = Convert.ToInt32(baudRateTestBox.Text);
    }

    private void parityCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
      Parity parity;
      Enum.TryParse(parityCombo.SelectedItem.ToString(), out parity);
      optionsPage.Parity = parity;
    }

    private void dataBitsCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
      optionsPage.DataBits = Convert.ToInt32(dataBitsCombo.SelectedItem.ToString());
    }

    private void stopBitsCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
      StopBits stopBits;
      Enum.TryParse(stopBitsCombo.SelectedItem.ToString(), out stopBits);
      optionsPage.StopBits = stopBits;
    }

    private void handshakeCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
      Handshake[] handshake = (Handshake[])Enum.GetValues(typeof(Handshake));
      optionsPage.Handshake = handshake[handshakeCombo.SelectedIndex];
    }
  }
}

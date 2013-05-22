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
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Intel.SerialCapture
{

  [ComVisible(true)]
  [ClassInterface(ClassInterfaceType.AutoDual)]
  [Guid("08C66A47-7570-408E-A5DA-8F1542D33D95")]
  public class SerialCaptureToolOptionsSessionPage : DialogPage, INotifyPropertyChanged
  {
    private string portName;
    private int baudRate;
    private Parity parity;
    private int dataBits;
    private StopBits stopBits;
    private Handshake handshake;

    public SerialCaptureToolOptionsSessionPage()
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
        SerialCaptureToolOptionsSessionControl page = new SerialCaptureToolOptionsSessionControl();
        page.optionsPage = this;
        page.Initialize();
        return page;
      }
    }

    public string PortName
    {
      get { return portName; }
      set
      {
        portName = value;
        OnPropertyChanged("PortName");
      }
    }

    public int BaudRate
    {
      get { return baudRate; }
      set
      {
        baudRate = value;
        OnPropertyChanged("BaudRate");
      }
    }

    public Parity Parity
    {
      get { return parity; }
      set
      {
        parity = value;
        OnPropertyChanged("Parity");
      }
    }

    public int DataBits
    {
      get { return dataBits; }
      set
      {
        dataBits = value;
        OnPropertyChanged("DataBits");
      }
    }

    public StopBits StopBits
    {
      get { return stopBits; }
      set
      {
        stopBits = value;
        OnPropertyChanged("StopBits");
      }
    }

    public Handshake Handshake
    {
      get { return handshake; }
      set
      {
        handshake = value;
        OnPropertyChanged("Handshake");
      }
    }

    public override void ResetSettings()
    {
      portName = "COM1";
      baudRate = 115200;
      parity = Parity.None;
      dataBits = 8;
      stopBits = StopBits.One;
      handshake = Handshake.None;

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

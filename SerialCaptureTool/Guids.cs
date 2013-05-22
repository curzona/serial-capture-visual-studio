// Guids.cs
// MUST match guids.h
using System;

namespace Intel.SerialCapture
{
  static class GuidList
  {
    public const string guidSerialCaptureToolPkgString = "2D3AA110-14D9-4608-9097-B28AE6E57C4F";
    public const string guidSerialCaptureToolCmdSetString = "2B7FF720-5F19-4385-A944-8C6DCD3A41F4";
    public const string guidSerialCaptureToolOutputPaneString = "906638AA-3EC2-47C0-A68C-F7375174CBDF";

    public static readonly Guid guidSerialCaptureToolCmdSet = new Guid(guidSerialCaptureToolCmdSetString);
    public static readonly Guid guidSerialCaptureToolOutputPane = new Guid(guidSerialCaptureToolOutputPaneString);
  };
}
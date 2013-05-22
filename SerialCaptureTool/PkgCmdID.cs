// PkgCmdID.cs
// MUST match PkgCmdID.h
using System;

namespace Intel.SerialCapture
{
  static class PkgCmdIDList
  {
    public const uint cmdidTestCmd = 0x100;
    public const uint cmdidStartCmd = 0x101;
    public const uint cmdidPauseCmd = 0x102;
    public const uint cmdidStopCmd = 0x103;
    public const uint cmdidFileCmd = 0x104;
  };
}
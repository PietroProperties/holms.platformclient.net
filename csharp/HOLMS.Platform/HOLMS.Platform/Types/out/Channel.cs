// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/channels/channel.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Channels {

  /// <summary>Holder for reflection information generated from booking/channels/channel.proto</summary>
  public static partial class ChannelReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/channels/channel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5ib29raW5nL2NoYW5uZWxzL2NoYW5uZWwucHJvdG8SHGhvbG1zLnR5cGVz",
            "LmJvb2tpbmcuY2hhbm5lbHMqTwoHQ2hhbm5lbBITCg9DSEFOTkVMX0xPREdF",
            "SUMQABIWChJDSEFOTkVMX0RJUkVDVF9XRUIQARIXChNDSEFOTkVMX0NIQU5O",
            "RUxSVVNIEAJCH6oCHEhPTE1TLlR5cGVzLkJvb2tpbmcuQ2hhbm5lbHNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Booking.Channels.Channel), }, null));
    }
    #endregion

  }
  #region Enums
  public enum Channel {
    [pbr::OriginalName("CHANNEL_LODGEIC")] Lodgeic = 0,
    [pbr::OriginalName("CHANNEL_DIRECT_WEB")] DirectWeb = 1,
    [pbr::OriginalName("CHANNEL_CHANNELRUSH")] Channelrush = 2,
  }

  #endregion

}

#endregion Designer generated code

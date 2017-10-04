// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/query_filter.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking {

  /// <summary>Holder for reflection information generated from booking/query_filter.proto</summary>
  public static partial class QueryFilterReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/query_filter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryFilterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chpib29raW5nL3F1ZXJ5X2ZpbHRlci5wcm90bxITaG9sbXMudHlwZXMuYm9v",
            "a2luZyprCgtRdWVyeUZpbHRlchINCglBTExfREFURVMQABIMCghBUlJJVkFM",
            "UxABEhYKEkNVUlJFTlRfQU5EX0ZVVFVSRRACEg4KCkRFUEFSVFVSRVMQAxIM",
            "CghJTl9IT1VTRRAEEgkKBVRPREFZEAVCH1oHYm9va2luZ6oCE0hPTE1TLlR5",
            "cGVzLkJvb2tpbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Booking.QueryFilter), }, null));
    }
    #endregion

  }
  #region Enums
  public enum QueryFilter {
    [pbr::OriginalName("ALL_DATES")] AllDates = 0,
    [pbr::OriginalName("ARRIVALS")] Arrivals = 1,
    [pbr::OriginalName("CURRENT_AND_FUTURE")] CurrentAndFuture = 2,
    [pbr::OriginalName("DEPARTURES")] Departures = 3,
    [pbr::OriginalName("IN_HOUSE")] InHouse = 4,
    [pbr::OriginalName("TODAY")] Today = 5,
  }

  #endregion

}

#endregion Designer generated code
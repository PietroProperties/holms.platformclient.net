// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/checkout/departure_date_checkout_acceptibility.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Checkout {

  /// <summary>Holder for reflection information generated from booking/checkout/departure_date_checkout_acceptibility.proto</summary>
  public static partial class DepartureDateCheckoutAcceptibilityReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/checkout/departure_date_checkout_acceptibility.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DepartureDateCheckoutAcceptibilityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxib29raW5nL2NoZWNrb3V0L2RlcGFydHVyZV9kYXRlX2NoZWNrb3V0X2Fj",
            "Y2VwdGliaWxpdHkucHJvdG8SHGhvbG1zLnR5cGVzLmJvb2tpbmcuY2hlY2tv",
            "dXQqggEKIkRlcGFydHVyZURhdGVDaGVja291dEFjY2VwdGliaWxpdHkSFQoR",
            "T25UaW1lRm9yQ2hlY2tvdXQQABIXChNUb29FYXJseUZvckNoZWNrb3V0EAES",
            "FgoST3ZlcmR1ZUZvckNoZWNrb3V0EAISFAoQVGFyZHlGb3JDaGVja291dBAD",
            "Qh+qAhxIT0xNUy5UeXBlcy5Cb29raW5nLkNoZWNrb3V0YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Booking.Checkout.DepartureDateCheckoutAcceptibility), }, null));
    }
    #endregion

  }
  #region Enums
  public enum DepartureDateCheckoutAcceptibility {
    [pbr::OriginalName("OnTimeForCheckout")] OnTimeForCheckout = 0,
    [pbr::OriginalName("TooEarlyForCheckout")] TooEarlyForCheckout = 1,
    [pbr::OriginalName("OverdueForCheckout")] OverdueForCheckout = 2,
    [pbr::OriginalName("TardyForCheckout")] TardyForCheckout = 3,
  }

  #endregion

}

#endregion Designer generated code
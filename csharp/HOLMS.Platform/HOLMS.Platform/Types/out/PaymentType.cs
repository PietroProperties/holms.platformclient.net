// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/folio/payment_type.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Folio {

  /// <summary>Holder for reflection information generated from money/folio/payment_type.proto</summary>
  public static partial class PaymentTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for money/folio/payment_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaymentTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5tb25leS9mb2xpby9wYXltZW50X3R5cGUucHJvdG8SF2hvbG1zLnR5cGVz",
            "Lm1vbmV5LmZvbGlvKlMKC1BheW1lbnRUeXBlEhUKEVBBWU1FTlRfVFlQRV9D",
            "QVNIEAASFgoSUEFZTUVOVF9UWVBFX0NIRUNLEAESFQoRUEFZTUVOVF9UWVBF",
            "X0NBUkQQAkInWgttb25leS9mb2xpb6oCF0hPTE1TLlR5cGVzLk1vbmV5LkZv",
            "bGlvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Money.Folio.PaymentType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PaymentType {
    [pbr::OriginalName("PAYMENT_TYPE_CASH")] Cash = 0,
    [pbr::OriginalName("PAYMENT_TYPE_CHECK")] Check = 1,
    [pbr::OriginalName("PAYMENT_TYPE_CARD")] Card = 2,
  }

  #endregion

}

#endregion Designer generated code
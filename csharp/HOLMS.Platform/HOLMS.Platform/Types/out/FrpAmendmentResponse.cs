// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/reservations/frp_amendment_response.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Reservations {

  /// <summary>Holder for reflection information generated from booking/reservations/frp_amendment_response.proto</summary>
  public static partial class FrpAmendmentResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/reservations/frp_amendment_response.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FrpAmendmentResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFib29raW5nL3Jlc2VydmF0aW9ucy9mcnBfYW1lbmRtZW50X3Jlc3BvbnNl",
            "LnByb3RvEiBob2xtcy50eXBlcy5ib29raW5nLnJlc2VydmF0aW9ucxouYm9v",
            "a2luZy9pbmRpY2F0b3JzL3Jlc2VydmF0aW9uX2luZGljYXRvci5wcm90byKW",
            "AgoURlJQQW1lbmRtZW50UmVzcG9uc2USSwoNcmVzX2luZGljYXRvchgBIAEo",
            "CzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5SZXNlcnZhdGlv",
            "bkluZGljYXRvchJWCgZyZXN1bHQYAiABKA4yRi5ob2xtcy50eXBlcy5ib29r",
            "aW5nLnJlc2VydmF0aW9ucy5GUlBBbWVuZG1lbnRSZXNwb25zZS5BbWVuZG1l",
            "bnRSZXN1bHQiWQoPQW1lbmRtZW50UmVzdWx0Eg4KClNVQ0NFU1NGVUwQABIP",
            "CgtVTkFWQUlMQUJMRRABEg8KC1VOUFJJQ0VBQkxFEAISFAoQUE9MSUNZX1ZJ",
            "T0xBVElPThADQjlaFGJvb2tpbmcvcmVzZXJ2YXRpb25zqgIgSE9MTVMuVHlw",
            "ZXMuQm9va2luZy5SZXNlcnZhdGlvbnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse), global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse.Parser, new[]{ "ResIndicator", "Result" }, null, new[]{ typeof(global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse.Types.AmendmentResult) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FRPAmendmentResponse : pb::IMessage<FRPAmendmentResponse> {
    private static readonly pb::MessageParser<FRPAmendmentResponse> _parser = new pb::MessageParser<FRPAmendmentResponse>(() => new FRPAmendmentResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FRPAmendmentResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Reservations.FrpAmendmentResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FRPAmendmentResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FRPAmendmentResponse(FRPAmendmentResponse other) : this() {
      ResIndicator = other.resIndicator_ != null ? other.ResIndicator.Clone() : null;
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FRPAmendmentResponse Clone() {
      return new FRPAmendmentResponse(this);
    }

    /// <summary>Field number for the "res_indicator" field.</summary>
    public const int ResIndicatorFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator resIndicator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator ResIndicator {
      get { return resIndicator_; }
      set {
        resIndicator_ = value;
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 2;
    private global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse.Types.AmendmentResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse.Types.AmendmentResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FRPAmendmentResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FRPAmendmentResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ResIndicator, other.ResIndicator)) return false;
      if (Result != other.Result) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (resIndicator_ != null) hash ^= ResIndicator.GetHashCode();
      if (Result != 0) hash ^= Result.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (resIndicator_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ResIndicator);
      }
      if (Result != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Result);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (resIndicator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResIndicator);
      }
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FRPAmendmentResponse other) {
      if (other == null) {
        return;
      }
      if (other.resIndicator_ != null) {
        if (resIndicator_ == null) {
          resIndicator_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        ResIndicator.MergeFrom(other.ResIndicator);
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (resIndicator_ == null) {
              resIndicator_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(resIndicator_);
            break;
          }
          case 16: {
            result_ = (global::HOLMS.Types.Booking.Reservations.FRPAmendmentResponse.Types.AmendmentResult) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the FRPAmendmentResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum AmendmentResult {
        [pbr::OriginalName("SUCCESSFUL")] Successful = 0,
        [pbr::OriginalName("UNAVAILABLE")] Unavailable = 1,
        [pbr::OriginalName("UNPRICEABLE")] Unpriceable = 2,
        [pbr::OriginalName("POLICY_VIOLATION")] PolicyViolation = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
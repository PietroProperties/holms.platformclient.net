// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/guarantees/guarantee_changes.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Guarantees {

  /// <summary>Holder for reflection information generated from booking/guarantees/guarantee_changes.proto</summary>
  public static partial class GuaranteeChangesReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/guarantees/guarantee_changes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GuaranteeChangesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipib29raW5nL2d1YXJhbnRlZXMvZ3VhcmFudGVlX2NoYW5nZXMucHJvdG8S",
            "HmhvbG1zLnR5cGVzLmJvb2tpbmcuZ3VhcmFudGVlcxouYm9va2luZy9pbmRp",
            "Y2F0b3JzL3Jlc2VydmF0aW9uX2luZGljYXRvci5wcm90bxouYm9va2luZy9n",
            "dWFyYW50ZWVzL3ZvaWRfZ3VhcmFudGVlX3Jlc3VsdC5wcm90byJhChRWb2lk",
            "R3VhcmFudGVlUmVxdWVzdBJJCgtyZXNlcnZhdGlvbhgBIAEoCzI0LmhvbG1z",
            "LnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5SZXNlcnZhdGlvbkluZGljYXRv",
            "ciJrChVWb2lkR3VhcmFudGVlUmVzcG9uc2USUgoVdm9pZF9ndWFyYW50ZWVf",
            "cmVzdWx0GAEgASgOMjMuaG9sbXMudHlwZXMuYm9va2luZy5ndWFyYW50ZWVz",
            "LlZvaWRHdWFyYW50ZWVSZXN1bHRCIaoCHkhPTE1TLlR5cGVzLkJvb2tpbmcu",
            "R3VhcmFudGVlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Guarantees.VoidGuaranteeResultReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Guarantees.VoidGuaranteeRequest), global::HOLMS.Types.Booking.Guarantees.VoidGuaranteeRequest.Parser, new[]{ "Reservation" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Guarantees.VoidGuaranteeResponse), global::HOLMS.Types.Booking.Guarantees.VoidGuaranteeResponse.Parser, new[]{ "VoidGuaranteeResult" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VoidGuaranteeRequest : pb::IMessage<VoidGuaranteeRequest> {
    private static readonly pb::MessageParser<VoidGuaranteeRequest> _parser = new pb::MessageParser<VoidGuaranteeRequest>(() => new VoidGuaranteeRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VoidGuaranteeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Guarantees.GuaranteeChangesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VoidGuaranteeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VoidGuaranteeRequest(VoidGuaranteeRequest other) : this() {
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VoidGuaranteeRequest Clone() {
      return new VoidGuaranteeRequest(this);
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VoidGuaranteeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VoidGuaranteeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reservation, other.Reservation)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (reservation_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Reservation);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VoidGuaranteeRequest other) {
      if (other == null) {
        return;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
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
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class VoidGuaranteeResponse : pb::IMessage<VoidGuaranteeResponse> {
    private static readonly pb::MessageParser<VoidGuaranteeResponse> _parser = new pb::MessageParser<VoidGuaranteeResponse>(() => new VoidGuaranteeResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VoidGuaranteeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Guarantees.GuaranteeChangesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VoidGuaranteeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VoidGuaranteeResponse(VoidGuaranteeResponse other) : this() {
      voidGuaranteeResult_ = other.voidGuaranteeResult_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VoidGuaranteeResponse Clone() {
      return new VoidGuaranteeResponse(this);
    }

    /// <summary>Field number for the "void_guarantee_result" field.</summary>
    public const int VoidGuaranteeResultFieldNumber = 1;
    private global::HOLMS.Types.Booking.Guarantees.VoidGuaranteeResult voidGuaranteeResult_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Guarantees.VoidGuaranteeResult VoidGuaranteeResult {
      get { return voidGuaranteeResult_; }
      set {
        voidGuaranteeResult_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VoidGuaranteeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VoidGuaranteeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VoidGuaranteeResult != other.VoidGuaranteeResult) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (VoidGuaranteeResult != 0) hash ^= VoidGuaranteeResult.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (VoidGuaranteeResult != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) VoidGuaranteeResult);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (VoidGuaranteeResult != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) VoidGuaranteeResult);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VoidGuaranteeResponse other) {
      if (other == null) {
        return;
      }
      if (other.VoidGuaranteeResult != 0) {
        VoidGuaranteeResult = other.VoidGuaranteeResult;
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
          case 8: {
            voidGuaranteeResult_ = (global::HOLMS.Types.Booking.Guarantees.VoidGuaranteeResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

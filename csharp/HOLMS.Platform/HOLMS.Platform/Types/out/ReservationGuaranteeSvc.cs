// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/rpc/reservation_guarantee_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio.RPC {

  /// <summary>Holder for reflection information generated from folio/rpc/reservation_guarantee_svc.proto</summary>
  public static partial class ReservationGuaranteeSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/rpc/reservation_guarantee_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationGuaranteeSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilmb2xpby9ycGMvcmVzZXJ2YXRpb25fZ3VhcmFudGVlX3N2Yy5wcm90bxIX",
            "aG9sbXMudHlwZXMuYm9va2luZy5ycGMaH3ByaW1pdGl2ZS9tb25ldGFyeV9h",
            "bW91bnQucHJvdG8aNWJvb2tpbmcvZ3VhcmFudGVlcy9jYXJkX2d1YXJhbnRl",
            "ZV90ZW5kZXJfcmVzdWx0LnByb3RvGi5ib29raW5nL2luZGljYXRvcnMvcmVz",
            "ZXJ2YXRpb25faW5kaWNhdG9yLnByb3RvGjFtb25leS9jYXJkcy9jdXN0b21l",
            "cl9wYXltZW50X2NhcmRfaW5kaWNhdG9yLnByb3RvGiptb25leS9jYXJkcy9u",
            "b3RfcHJlc2VudF9wYXltZW50X2NhcmQucHJvdG8ixQEKIlJlc0dTdmNUZW5k",
            "ZXJDaGVja0d1YXJhbnRlZVJlcXVlc3QSSQoLcmVzZXJ2YXRpb24YASABKAsy",
            "NC5ob2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuUmVzZXJ2YXRpb25J",
            "bmRpY2F0b3ISPgoPYW1vdW50X3RlbmRlcmVkGAIgASgLMiUuaG9sbXMudHlw",
            "ZXMucHJpbWl0aXZlLk1vbmV0YXJ5QW1vdW50EhQKDGNoZWNrX251bWJlchgD",
            "IAEoCSI1CiNSZXNHU3ZjVGVuZGVyQ2hlY2tHdWFyYW50ZWVSZXNwb25zZRIO",
            "CgZyZXN1bHQYASABKAgiuQEKLlJlc0dTdmNUZW5kZXJOZXdOb3RQcmVzZW50",
            "Q2FyZEd1YXJhbnRlZVJlcXVlc3QSSQoLcmVzZXJ2YXRpb24YASABKAsyNC5o",
            "b2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuUmVzZXJ2YXRpb25JbmRp",
            "Y2F0b3ISPAoEY2FyZBgCIAEoCzIuLmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRz",
            "Lk5vdFByZXNlbnRQYXltZW50Q2FyZCLDAQoxUmVzR1N2Y1RlbmRlclN0b3Jl",
            "ZE5vdFByZXNlbnRDYXJkR3VhcmFudGVlUmVxdWVzdBJJCgtyZXNlcnZhdGlv",
            "bhgBIAEoCzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5SZXNl",
            "cnZhdGlvbkluZGljYXRvchJDCgRjYXJkGAIgASgLMjUuaG9sbXMudHlwZXMu",
            "bW9uZXkuY2FyZHMuQ3VzdG9tZXJQYXltZW50Q2FyZEluZGljYXRvciJ5CixS",
            "ZXNHU3ZjVGVuZGVyTm90UHJlc2VudENhcmRHdWFyYW50ZWVSZXNwb25zZRJJ",
            "CgZyZXN1bHQYASABKA4yOS5ob2xtcy50eXBlcy5ib29raW5nLmd1YXJhbnRl",
            "ZXMuQ2FyZEd1YXJhbnRlZVRlbmRlclJlc3VsdCJpChZSZXNHU3ZjUHJlVGVu",
            "ZGVyU3RhdHVzEj8KEHJlbWFpbmluZ19hbW91bnQYASABKAsyJS5ob2xtcy50",
            "eXBlcy5wcmltaXRpdmUuTW9uZXRhcnlBbW91bnQSDgoGaXNfZHVlGAIgASgI",
            "MpoFChdSZXNlcnZhdGlvbkd1YXJhbnRlZVN2YxJ7ChJHZXRQcmVUZW5kZXJT",
            "dGF0dXMSNC5ob2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuUmVzZXJ2",
            "YXRpb25JbmRpY2F0b3IaLy5ob2xtcy50eXBlcy5ib29raW5nLnJwYy5SZXNH",
            "U3ZjUHJlVGVuZGVyU3RhdHVzEpEBChRUZW5kZXJDaGVja0d1YXJhbnRlZRI7",
            "LmhvbG1zLnR5cGVzLmJvb2tpbmcucnBjLlJlc0dTdmNUZW5kZXJDaGVja0d1",
            "YXJhbnRlZVJlcXVlc3QaPC5ob2xtcy50eXBlcy5ib29raW5nLnJwYy5SZXNH",
            "U3ZjVGVuZGVyQ2hlY2tHdWFyYW50ZWVSZXNwb25zZRKyAQogVGVuZGVyTmV3",
            "Tm90UHJlc2VudENhcmRHdWFyYW50ZWUSRy5ob2xtcy50eXBlcy5ib29raW5n",
            "LnJwYy5SZXNHU3ZjVGVuZGVyTmV3Tm90UHJlc2VudENhcmRHdWFyYW50ZWVS",
            "ZXF1ZXN0GkUuaG9sbXMudHlwZXMuYm9va2luZy5ycGMuUmVzR1N2Y1RlbmRl",
            "ck5vdFByZXNlbnRDYXJkR3VhcmFudGVlUmVzcG9uc2USuAEKI1RlbmRlclN0",
            "b3JlZE5vdFByZXNlbnRDYXJkR3VhcmFudGVlEkouaG9sbXMudHlwZXMuYm9v",
            "a2luZy5ycGMuUmVzR1N2Y1RlbmRlclN0b3JlZE5vdFByZXNlbnRDYXJkR3Vh",
            "cmFudGVlUmVxdWVzdBpFLmhvbG1zLnR5cGVzLmJvb2tpbmcucnBjLlJlc0dT",
            "dmNUZW5kZXJOb3RQcmVzZW50Q2FyZEd1YXJhbnRlZVJlc3BvbnNlQiNaCWZv",
            "bGlvL3JwY6oCFUhPTE1TLlR5cGVzLkZvbGlvLlJQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Booking.Guarantees.CardGuaranteeTenderResultReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.CustomerPaymentCardIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.NotPresentPaymentCardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.RPC.ResGSvcTenderCheckGuaranteeRequest), global::HOLMS.Types.Folio.RPC.ResGSvcTenderCheckGuaranteeRequest.Parser, new[]{ "Reservation", "AmountTendered", "CheckNumber" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.RPC.ResGSvcTenderCheckGuaranteeResponse), global::HOLMS.Types.Folio.RPC.ResGSvcTenderCheckGuaranteeResponse.Parser, new[]{ "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.RPC.ResGSvcTenderNewNotPresentCardGuaranteeRequest), global::HOLMS.Types.Folio.RPC.ResGSvcTenderNewNotPresentCardGuaranteeRequest.Parser, new[]{ "Reservation", "Card" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.RPC.ResGSvcTenderStoredNotPresentCardGuaranteeRequest), global::HOLMS.Types.Folio.RPC.ResGSvcTenderStoredNotPresentCardGuaranteeRequest.Parser, new[]{ "Reservation", "Card" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.RPC.ResGSvcTenderNotPresentCardGuaranteeResponse), global::HOLMS.Types.Folio.RPC.ResGSvcTenderNotPresentCardGuaranteeResponse.Parser, new[]{ "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.RPC.ResGSvcPreTenderStatus), global::HOLMS.Types.Folio.RPC.ResGSvcPreTenderStatus.Parser, new[]{ "RemainingAmount", "IsDue" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ResGSvcTenderCheckGuaranteeRequest : pb::IMessage<ResGSvcTenderCheckGuaranteeRequest> {
    private static readonly pb::MessageParser<ResGSvcTenderCheckGuaranteeRequest> _parser = new pb::MessageParser<ResGSvcTenderCheckGuaranteeRequest>(() => new ResGSvcTenderCheckGuaranteeRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResGSvcTenderCheckGuaranteeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.RPC.ReservationGuaranteeSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderCheckGuaranteeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderCheckGuaranteeRequest(ResGSvcTenderCheckGuaranteeRequest other) : this() {
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      AmountTendered = other.amountTendered_ != null ? other.AmountTendered.Clone() : null;
      checkNumber_ = other.checkNumber_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderCheckGuaranteeRequest Clone() {
      return new ResGSvcTenderCheckGuaranteeRequest(this);
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

    /// <summary>Field number for the "amount_tendered" field.</summary>
    public const int AmountTenderedFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount amountTendered_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount AmountTendered {
      get { return amountTendered_; }
      set {
        amountTendered_ = value;
      }
    }

    /// <summary>Field number for the "check_number" field.</summary>
    public const int CheckNumberFieldNumber = 3;
    private string checkNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CheckNumber {
      get { return checkNumber_; }
      set {
        checkNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResGSvcTenderCheckGuaranteeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResGSvcTenderCheckGuaranteeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (!object.Equals(AmountTendered, other.AmountTendered)) return false;
      if (CheckNumber != other.CheckNumber) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (amountTendered_ != null) hash ^= AmountTendered.GetHashCode();
      if (CheckNumber.Length != 0) hash ^= CheckNumber.GetHashCode();
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
      if (amountTendered_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AmountTendered);
      }
      if (CheckNumber.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CheckNumber);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      if (amountTendered_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AmountTendered);
      }
      if (CheckNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CheckNumber);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResGSvcTenderCheckGuaranteeRequest other) {
      if (other == null) {
        return;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      if (other.amountTendered_ != null) {
        if (amountTendered_ == null) {
          amountTendered_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        AmountTendered.MergeFrom(other.AmountTendered);
      }
      if (other.CheckNumber.Length != 0) {
        CheckNumber = other.CheckNumber;
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
          case 18: {
            if (amountTendered_ == null) {
              amountTendered_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(amountTendered_);
            break;
          }
          case 26: {
            CheckNumber = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ResGSvcTenderCheckGuaranteeResponse : pb::IMessage<ResGSvcTenderCheckGuaranteeResponse> {
    private static readonly pb::MessageParser<ResGSvcTenderCheckGuaranteeResponse> _parser = new pb::MessageParser<ResGSvcTenderCheckGuaranteeResponse>(() => new ResGSvcTenderCheckGuaranteeResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResGSvcTenderCheckGuaranteeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.RPC.ReservationGuaranteeSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderCheckGuaranteeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderCheckGuaranteeResponse(ResGSvcTenderCheckGuaranteeResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderCheckGuaranteeResponse Clone() {
      return new ResGSvcTenderCheckGuaranteeResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private bool result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResGSvcTenderCheckGuaranteeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResGSvcTenderCheckGuaranteeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != false) hash ^= Result.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != false) {
        output.WriteRawTag(8);
        output.WriteBool(Result);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResGSvcTenderCheckGuaranteeResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != false) {
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
          case 8: {
            Result = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ResGSvcTenderNewNotPresentCardGuaranteeRequest : pb::IMessage<ResGSvcTenderNewNotPresentCardGuaranteeRequest> {
    private static readonly pb::MessageParser<ResGSvcTenderNewNotPresentCardGuaranteeRequest> _parser = new pb::MessageParser<ResGSvcTenderNewNotPresentCardGuaranteeRequest>(() => new ResGSvcTenderNewNotPresentCardGuaranteeRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResGSvcTenderNewNotPresentCardGuaranteeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.RPC.ReservationGuaranteeSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderNewNotPresentCardGuaranteeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderNewNotPresentCardGuaranteeRequest(ResGSvcTenderNewNotPresentCardGuaranteeRequest other) : this() {
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      Card = other.card_ != null ? other.Card.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderNewNotPresentCardGuaranteeRequest Clone() {
      return new ResGSvcTenderNewNotPresentCardGuaranteeRequest(this);
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

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 2;
    private global::HOLMS.Types.Money.Cards.NotPresentPaymentCard card_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.NotPresentPaymentCard Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResGSvcTenderNewNotPresentCardGuaranteeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResGSvcTenderNewNotPresentCardGuaranteeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (!object.Equals(Card, other.Card)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (card_ != null) hash ^= Card.GetHashCode();
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
      if (card_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Card);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      if (card_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Card);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResGSvcTenderNewNotPresentCardGuaranteeRequest other) {
      if (other == null) {
        return;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      if (other.card_ != null) {
        if (card_ == null) {
          card_ = new global::HOLMS.Types.Money.Cards.NotPresentPaymentCard();
        }
        Card.MergeFrom(other.Card);
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
          case 18: {
            if (card_ == null) {
              card_ = new global::HOLMS.Types.Money.Cards.NotPresentPaymentCard();
            }
            input.ReadMessage(card_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ResGSvcTenderStoredNotPresentCardGuaranteeRequest : pb::IMessage<ResGSvcTenderStoredNotPresentCardGuaranteeRequest> {
    private static readonly pb::MessageParser<ResGSvcTenderStoredNotPresentCardGuaranteeRequest> _parser = new pb::MessageParser<ResGSvcTenderStoredNotPresentCardGuaranteeRequest>(() => new ResGSvcTenderStoredNotPresentCardGuaranteeRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResGSvcTenderStoredNotPresentCardGuaranteeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.RPC.ReservationGuaranteeSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderStoredNotPresentCardGuaranteeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderStoredNotPresentCardGuaranteeRequest(ResGSvcTenderStoredNotPresentCardGuaranteeRequest other) : this() {
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      Card = other.card_ != null ? other.Card.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderStoredNotPresentCardGuaranteeRequest Clone() {
      return new ResGSvcTenderStoredNotPresentCardGuaranteeRequest(this);
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

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 2;
    private global::HOLMS.Types.Money.Cards.CustomerPaymentCardIndicator card_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.CustomerPaymentCardIndicator Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResGSvcTenderStoredNotPresentCardGuaranteeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResGSvcTenderStoredNotPresentCardGuaranteeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (!object.Equals(Card, other.Card)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (card_ != null) hash ^= Card.GetHashCode();
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
      if (card_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Card);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      if (card_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Card);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResGSvcTenderStoredNotPresentCardGuaranteeRequest other) {
      if (other == null) {
        return;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      if (other.card_ != null) {
        if (card_ == null) {
          card_ = new global::HOLMS.Types.Money.Cards.CustomerPaymentCardIndicator();
        }
        Card.MergeFrom(other.Card);
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
          case 18: {
            if (card_ == null) {
              card_ = new global::HOLMS.Types.Money.Cards.CustomerPaymentCardIndicator();
            }
            input.ReadMessage(card_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ResGSvcTenderNotPresentCardGuaranteeResponse : pb::IMessage<ResGSvcTenderNotPresentCardGuaranteeResponse> {
    private static readonly pb::MessageParser<ResGSvcTenderNotPresentCardGuaranteeResponse> _parser = new pb::MessageParser<ResGSvcTenderNotPresentCardGuaranteeResponse>(() => new ResGSvcTenderNotPresentCardGuaranteeResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResGSvcTenderNotPresentCardGuaranteeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.RPC.ReservationGuaranteeSvcReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderNotPresentCardGuaranteeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderNotPresentCardGuaranteeResponse(ResGSvcTenderNotPresentCardGuaranteeResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcTenderNotPresentCardGuaranteeResponse Clone() {
      return new ResGSvcTenderNotPresentCardGuaranteeResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Booking.Guarantees.CardGuaranteeTenderResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Guarantees.CardGuaranteeTenderResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResGSvcTenderNotPresentCardGuaranteeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResGSvcTenderNotPresentCardGuaranteeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResGSvcTenderNotPresentCardGuaranteeResponse other) {
      if (other == null) {
        return;
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
          case 8: {
            result_ = (global::HOLMS.Types.Booking.Guarantees.CardGuaranteeTenderResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ResGSvcPreTenderStatus : pb::IMessage<ResGSvcPreTenderStatus> {
    private static readonly pb::MessageParser<ResGSvcPreTenderStatus> _parser = new pb::MessageParser<ResGSvcPreTenderStatus>(() => new ResGSvcPreTenderStatus());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResGSvcPreTenderStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.RPC.ReservationGuaranteeSvcReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcPreTenderStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcPreTenderStatus(ResGSvcPreTenderStatus other) : this() {
      RemainingAmount = other.remainingAmount_ != null ? other.RemainingAmount.Clone() : null;
      isDue_ = other.isDue_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResGSvcPreTenderStatus Clone() {
      return new ResGSvcPreTenderStatus(this);
    }

    /// <summary>Field number for the "remaining_amount" field.</summary>
    public const int RemainingAmountFieldNumber = 1;
    private global::HOLMS.Types.Primitive.MonetaryAmount remainingAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount RemainingAmount {
      get { return remainingAmount_; }
      set {
        remainingAmount_ = value;
      }
    }

    /// <summary>Field number for the "is_due" field.</summary>
    public const int IsDueFieldNumber = 2;
    private bool isDue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsDue {
      get { return isDue_; }
      set {
        isDue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResGSvcPreTenderStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResGSvcPreTenderStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RemainingAmount, other.RemainingAmount)) return false;
      if (IsDue != other.IsDue) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (remainingAmount_ != null) hash ^= RemainingAmount.GetHashCode();
      if (IsDue != false) hash ^= IsDue.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (remainingAmount_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RemainingAmount);
      }
      if (IsDue != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsDue);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (remainingAmount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RemainingAmount);
      }
      if (IsDue != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResGSvcPreTenderStatus other) {
      if (other == null) {
        return;
      }
      if (other.remainingAmount_ != null) {
        if (remainingAmount_ == null) {
          remainingAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        RemainingAmount.MergeFrom(other.RemainingAmount);
      }
      if (other.IsDue != false) {
        IsDue = other.IsDue;
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
            if (remainingAmount_ == null) {
              remainingAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(remainingAmount_);
            break;
          }
          case 16: {
            IsDue = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/reservations/reservation_frp_amendment_request.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Reservations {

  /// <summary>Holder for reflection information generated from booking/reservations/reservation_frp_amendment_request.proto</summary>
  public static partial class ReservationFrpAmendmentRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/reservations/reservation_frp_amendment_request.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationFrpAmendmentRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxib29raW5nL3Jlc2VydmF0aW9ucy9yZXNlcnZhdGlvbl9mcnBfYW1lbmRt",
            "ZW50X3JlcXVlc3QucHJvdG8SIGhvbG1zLnR5cGVzLmJvb2tpbmcucmVzZXJ2",
            "YXRpb25zGipwcmltaXRpdmUvcGJfaW5jbHVzaXZlX29wc2RhdGVfcmFuZ2Uu",
            "cHJvdG8aLmJvb2tpbmcvaW5kaWNhdG9ycy9yZXNlcnZhdGlvbl9pbmRpY2F0",
            "b3IucHJvdG8aK3N1cHBseS9yb29tX3R5cGVzL3Jvb21fdHlwZV9pbmRpY2F0",
            "b3IucHJvdG8i4AIKHlJlc2VydmF0aW9uRlJQQW1lbmRtZW50UmVxdWVzdBJC",
            "CgpkYXRlX3JhbmdlGAEgASgLMi4uaG9sbXMudHlwZXMucHJpbWl0aXZlLlBi",
            "SW5jbHVzaXZlT3BzZGF0ZVJhbmdlEkkKC3Jlc2VydmF0aW9uGAIgASgLMjQu",
            "aG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3JzLlJlc2VydmF0aW9uSW5k",
            "aWNhdG9yEkMKCXJvb21fdHlwZRgDIAEoCzIwLmhvbG1zLnR5cGVzLnN1cHBs",
            "eS5yb29tX3R5cGVzLlJvb21UeXBlSW5kaWNhdG9yEhkKEWFkdWx0X2d1ZXN0",
            "X2NvdW50GAYgASgFEhkKEWNoaWxkX2d1ZXN0X2NvdW50GAcgASgFEgwKBHRh",
            "Z3MYCCADKAkSJgoeaXNfZ3JvdXBfaG9sZF91cGRhdGVfcmVxdWVzdGVkGAkg",
            "ASgIQjlaFGJvb2tpbmcvcmVzZXJ2YXRpb25zqgIgSE9MTVMuVHlwZXMuQm9v",
            "a2luZy5SZXNlcnZhdGlvbnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest), global::HOLMS.Types.Booking.Reservations.ReservationFRPAmendmentRequest.Parser, new[]{ "DateRange", "Reservation", "RoomType", "AdultGuestCount", "ChildGuestCount", "Tags", "IsGroupHoldUpdateRequested" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationFRPAmendmentRequest : pb::IMessage<ReservationFRPAmendmentRequest> {
    private static readonly pb::MessageParser<ReservationFRPAmendmentRequest> _parser = new pb::MessageParser<ReservationFRPAmendmentRequest>(() => new ReservationFRPAmendmentRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationFRPAmendmentRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Reservations.ReservationFrpAmendmentRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFRPAmendmentRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFRPAmendmentRequest(ReservationFRPAmendmentRequest other) : this() {
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      RoomType = other.roomType_ != null ? other.RoomType.Clone() : null;
      adultGuestCount_ = other.adultGuestCount_;
      childGuestCount_ = other.childGuestCount_;
      tags_ = other.tags_.Clone();
      isGroupHoldUpdateRequested_ = other.isGroupHoldUpdateRequested_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFRPAmendmentRequest Clone() {
      return new ReservationFRPAmendmentRequest(this);
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 1;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 2;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    /// <summary>Field number for the "room_type" field.</summary>
    public const int RoomTypeFieldNumber = 3;
    private global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator roomType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator RoomType {
      get { return roomType_; }
      set {
        roomType_ = value;
      }
    }

    /// <summary>Field number for the "adult_guest_count" field.</summary>
    public const int AdultGuestCountFieldNumber = 6;
    private int adultGuestCount_;
    /// <summary>
    ///bool tax_exempt = 5;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AdultGuestCount {
      get { return adultGuestCount_; }
      set {
        adultGuestCount_ = value;
      }
    }

    /// <summary>Field number for the "child_guest_count" field.</summary>
    public const int ChildGuestCountFieldNumber = 7;
    private int childGuestCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ChildGuestCount {
      get { return childGuestCount_; }
      set {
        childGuestCount_ = value;
      }
    }

    /// <summary>Field number for the "tags" field.</summary>
    public const int TagsFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _repeated_tags_codec
        = pb::FieldCodec.ForString(66);
    private readonly pbc::RepeatedField<string> tags_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Tags {
      get { return tags_; }
    }

    /// <summary>Field number for the "is_group_hold_update_requested" field.</summary>
    public const int IsGroupHoldUpdateRequestedFieldNumber = 9;
    private bool isGroupHoldUpdateRequested_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsGroupHoldUpdateRequested {
      get { return isGroupHoldUpdateRequested_; }
      set {
        isGroupHoldUpdateRequested_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationFRPAmendmentRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationFRPAmendmentRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DateRange, other.DateRange)) return false;
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (!object.Equals(RoomType, other.RoomType)) return false;
      if (AdultGuestCount != other.AdultGuestCount) return false;
      if (ChildGuestCount != other.ChildGuestCount) return false;
      if(!tags_.Equals(other.tags_)) return false;
      if (IsGroupHoldUpdateRequested != other.IsGroupHoldUpdateRequested) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (roomType_ != null) hash ^= RoomType.GetHashCode();
      if (AdultGuestCount != 0) hash ^= AdultGuestCount.GetHashCode();
      if (ChildGuestCount != 0) hash ^= ChildGuestCount.GetHashCode();
      hash ^= tags_.GetHashCode();
      if (IsGroupHoldUpdateRequested != false) hash ^= IsGroupHoldUpdateRequested.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (dateRange_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DateRange);
      }
      if (reservation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Reservation);
      }
      if (roomType_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RoomType);
      }
      if (AdultGuestCount != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(AdultGuestCount);
      }
      if (ChildGuestCount != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(ChildGuestCount);
      }
      tags_.WriteTo(output, _repeated_tags_codec);
      if (IsGroupHoldUpdateRequested != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsGroupHoldUpdateRequested);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      if (roomType_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoomType);
      }
      if (AdultGuestCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AdultGuestCount);
      }
      if (ChildGuestCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ChildGuestCount);
      }
      size += tags_.CalculateSize(_repeated_tags_codec);
      if (IsGroupHoldUpdateRequested != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationFRPAmendmentRequest other) {
      if (other == null) {
        return;
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      if (other.roomType_ != null) {
        if (roomType_ == null) {
          roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator();
        }
        RoomType.MergeFrom(other.RoomType);
      }
      if (other.AdultGuestCount != 0) {
        AdultGuestCount = other.AdultGuestCount;
      }
      if (other.ChildGuestCount != 0) {
        ChildGuestCount = other.ChildGuestCount;
      }
      tags_.Add(other.tags_);
      if (other.IsGroupHoldUpdateRequested != false) {
        IsGroupHoldUpdateRequested = other.IsGroupHoldUpdateRequested;
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
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
          case 18: {
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
          case 26: {
            if (roomType_ == null) {
              roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator();
            }
            input.ReadMessage(roomType_);
            break;
          }
          case 48: {
            AdultGuestCount = input.ReadInt32();
            break;
          }
          case 56: {
            ChildGuestCount = input.ReadInt32();
            break;
          }
          case 66: {
            tags_.AddEntriesFrom(input, _repeated_tags_codec);
            break;
          }
          case 72: {
            IsGroupHoldUpdateRequested = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/reservations/cancelled_reservation.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Reservations {

  /// <summary>Holder for reflection information generated from booking/reservations/cancelled_reservation.proto</summary>
  public static partial class CancelledReservationReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/reservations/cancelled_reservation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CancelledReservationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBib29raW5nL3Jlc2VydmF0aW9ucy9jYW5jZWxsZWRfcmVzZXJ2YXRpb24u",
            "cHJvdG8SIGhvbG1zLnR5cGVzLmJvb2tpbmcucmVzZXJ2YXRpb25zGh9wcmlt",
            "aXRpdmUvbW9uZXRhcnlfYW1vdW50LnByb3RvGipwcmltaXRpdmUvcGJfaW5j",
            "bHVzaXZlX29wc2RhdGVfcmFuZ2UucHJvdG8aIWJvb2tpbmcvY2FuY2VsbGF0",
            "aW9uX3BvbGljeS5wcm90bxouYm9va2luZy9pbmRpY2F0b3JzL3Jlc2VydmF0",
            "aW9uX2luZGljYXRvci5wcm90bxosYm9va2luZy9yZXNlcnZhdGlvbnMvcmVz",
            "ZXJ2YXRpb25fc3RhdGUucHJvdG8aFmNybS9ndWVzdHMvZ3Vlc3QucHJvdG8a",
            "IXN1cHBseS9yb29tX3R5cGVzL3Jvb21fdHlwZS5wcm90bxoac3VwcGx5L3F1",
            "YWxpZmljYXRpb24ucHJvdG8i5gUKFENhbmNlbGxlZFJlc2VydmF0aW9uEkcK",
            "CWVudGl0eV9pZBgBIAEoCzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNh",
            "dG9ycy5SZXNlcnZhdGlvbkluZGljYXRvchISCgpib29raW5nX2lkGAIgASgJ",
            "EkEKBXN0YXRlGAMgASgOMjIuaG9sbXMudHlwZXMuYm9va2luZy5yZXNlcnZh",
            "dGlvbnMuUmVzZXJ2YXRpb25TdGF0ZRIsCgVndWVzdBgEIAEoCzIdLmhvbG1z",
            "LnR5cGVzLmNybS5ndWVzdHMuR3Vlc3QSQgoKZGF0ZV9yYW5nZRgFIAEoCzIu",
            "LmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5QYkluY2x1c2l2ZU9wc2RhdGVSYW5n",
            "ZRIVCg1udW1iZXJfYWR1bHRzGAYgASgFEhcKD251bWJlcl9jaGlsZHJlbhgH",
            "IAEoBRI6Cglyb29tX3R5cGUYCCABKAsyJy5ob2xtcy50eXBlcy5zdXBwbHku",
            "cm9vbV90eXBlcy5Sb29tVHlwZRI4ChFhZGRpdGlvbmFsX2d1ZXN0cxgJIAMo",
            "CzIdLmhvbG1zLnR5cGVzLmNybS5ndWVzdHMuR3Vlc3QSOAoNcXVhbGlmaWNh",
            "dGlvbhgKIAEoCzIhLmhvbG1zLnR5cGVzLnN1cHBseS5RdWFsaWZpY2F0aW9u",
            "EhIKCnRheF9leGVtcHQYCyABKAgSSwocY2FuY2VsbGF0aW9uX3BlbmFsdHlf",
            "YXBwbGllZBgMIAEoCzIlLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5Nb25ldGFy",
            "eUFtb3VudBIbChNjYW5jZWxsYXRpb25fcmVhc29uGA0gASgJEkQKE2NhbmNl",
            "bGxhdGlvbl9wb2xpY3kYDiABKAsyJy5ob2xtcy50eXBlcy5ib29raW5nLkNh",
            "bmNlbGxhdGlvblBvbGljeRIYChByZXF1ZXN0aW5nX3BhcnR5GA8gASgJQjla",
            "FGJvb2tpbmcvcmVzZXJ2YXRpb25zqgIgSE9MTVMuVHlwZXMuQm9va2luZy5S",
            "ZXNlcnZhdGlvbnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Booking.CancellationPolicyReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Reservations.ReservationStateReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeReflection.Descriptor, global::HOLMS.Types.Supply.QualificationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Reservations.CancelledReservation), global::HOLMS.Types.Booking.Reservations.CancelledReservation.Parser, new[]{ "EntityId", "BookingId", "State", "Guest", "DateRange", "NumberAdults", "NumberChildren", "RoomType", "AdditionalGuests", "Qualification", "TaxExempt", "CancellationPenaltyApplied", "CancellationReason", "CancellationPolicy", "RequestingParty" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CancelledReservation : pb::IMessage<CancelledReservation> {
    private static readonly pb::MessageParser<CancelledReservation> _parser = new pb::MessageParser<CancelledReservation>(() => new CancelledReservation());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CancelledReservation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Reservations.CancelledReservationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancelledReservation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancelledReservation(CancelledReservation other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      bookingId_ = other.bookingId_;
      state_ = other.state_;
      Guest = other.guest_ != null ? other.Guest.Clone() : null;
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
      numberAdults_ = other.numberAdults_;
      numberChildren_ = other.numberChildren_;
      RoomType = other.roomType_ != null ? other.RoomType.Clone() : null;
      additionalGuests_ = other.additionalGuests_.Clone();
      Qualification = other.qualification_ != null ? other.Qualification.Clone() : null;
      taxExempt_ = other.taxExempt_;
      CancellationPenaltyApplied = other.cancellationPenaltyApplied_ != null ? other.CancellationPenaltyApplied.Clone() : null;
      cancellationReason_ = other.cancellationReason_;
      CancellationPolicy = other.cancellationPolicy_ != null ? other.CancellationPolicy.Clone() : null;
      requestingParty_ = other.requestingParty_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancelledReservation Clone() {
      return new CancelledReservation(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "booking_id" field.</summary>
    public const int BookingIdFieldNumber = 2;
    private string bookingId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BookingId {
      get { return bookingId_; }
      set {
        bookingId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 3;
    private global::HOLMS.Types.Booking.Reservations.ReservationState state_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Reservations.ReservationState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "guest" field.</summary>
    public const int GuestFieldNumber = 4;
    private global::HOLMS.Types.CRM.Guests.Guest guest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Guests.Guest Guest {
      get { return guest_; }
      set {
        guest_ = value;
      }
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 5;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    /// <summary>Field number for the "number_adults" field.</summary>
    public const int NumberAdultsFieldNumber = 6;
    private int numberAdults_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumberAdults {
      get { return numberAdults_; }
      set {
        numberAdults_ = value;
      }
    }

    /// <summary>Field number for the "number_children" field.</summary>
    public const int NumberChildrenFieldNumber = 7;
    private int numberChildren_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumberChildren {
      get { return numberChildren_; }
      set {
        numberChildren_ = value;
      }
    }

    /// <summary>Field number for the "room_type" field.</summary>
    public const int RoomTypeFieldNumber = 8;
    private global::HOLMS.Types.Supply.RoomTypes.RoomType roomType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RoomTypes.RoomType RoomType {
      get { return roomType_; }
      set {
        roomType_ = value;
      }
    }

    /// <summary>Field number for the "additional_guests" field.</summary>
    public const int AdditionalGuestsFieldNumber = 9;
    private static readonly pb::FieldCodec<global::HOLMS.Types.CRM.Guests.Guest> _repeated_additionalGuests_codec
        = pb::FieldCodec.ForMessage(74, global::HOLMS.Types.CRM.Guests.Guest.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.CRM.Guests.Guest> additionalGuests_ = new pbc::RepeatedField<global::HOLMS.Types.CRM.Guests.Guest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.CRM.Guests.Guest> AdditionalGuests {
      get { return additionalGuests_; }
    }

    /// <summary>Field number for the "qualification" field.</summary>
    public const int QualificationFieldNumber = 10;
    private global::HOLMS.Types.Supply.Qualification qualification_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.Qualification Qualification {
      get { return qualification_; }
      set {
        qualification_ = value;
      }
    }

    /// <summary>Field number for the "tax_exempt" field.</summary>
    public const int TaxExemptFieldNumber = 11;
    private bool taxExempt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool TaxExempt {
      get { return taxExempt_; }
      set {
        taxExempt_ = value;
      }
    }

    /// <summary>Field number for the "cancellation_penalty_applied" field.</summary>
    public const int CancellationPenaltyAppliedFieldNumber = 12;
    private global::HOLMS.Types.Primitive.MonetaryAmount cancellationPenaltyApplied_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount CancellationPenaltyApplied {
      get { return cancellationPenaltyApplied_; }
      set {
        cancellationPenaltyApplied_ = value;
      }
    }

    /// <summary>Field number for the "cancellation_reason" field.</summary>
    public const int CancellationReasonFieldNumber = 13;
    private string cancellationReason_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CancellationReason {
      get { return cancellationReason_; }
      set {
        cancellationReason_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cancellation_policy" field.</summary>
    public const int CancellationPolicyFieldNumber = 14;
    private global::HOLMS.Types.Booking.CancellationPolicy cancellationPolicy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.CancellationPolicy CancellationPolicy {
      get { return cancellationPolicy_; }
      set {
        cancellationPolicy_ = value;
      }
    }

    /// <summary>Field number for the "requesting_party" field.</summary>
    public const int RequestingPartyFieldNumber = 15;
    private string requestingParty_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RequestingParty {
      get { return requestingParty_; }
      set {
        requestingParty_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CancelledReservation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CancelledReservation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (BookingId != other.BookingId) return false;
      if (State != other.State) return false;
      if (!object.Equals(Guest, other.Guest)) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      if (NumberAdults != other.NumberAdults) return false;
      if (NumberChildren != other.NumberChildren) return false;
      if (!object.Equals(RoomType, other.RoomType)) return false;
      if(!additionalGuests_.Equals(other.additionalGuests_)) return false;
      if (!object.Equals(Qualification, other.Qualification)) return false;
      if (TaxExempt != other.TaxExempt) return false;
      if (!object.Equals(CancellationPenaltyApplied, other.CancellationPenaltyApplied)) return false;
      if (CancellationReason != other.CancellationReason) return false;
      if (!object.Equals(CancellationPolicy, other.CancellationPolicy)) return false;
      if (RequestingParty != other.RequestingParty) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (BookingId.Length != 0) hash ^= BookingId.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
      if (guest_ != null) hash ^= Guest.GetHashCode();
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      if (NumberAdults != 0) hash ^= NumberAdults.GetHashCode();
      if (NumberChildren != 0) hash ^= NumberChildren.GetHashCode();
      if (roomType_ != null) hash ^= RoomType.GetHashCode();
      hash ^= additionalGuests_.GetHashCode();
      if (qualification_ != null) hash ^= Qualification.GetHashCode();
      if (TaxExempt != false) hash ^= TaxExempt.GetHashCode();
      if (cancellationPenaltyApplied_ != null) hash ^= CancellationPenaltyApplied.GetHashCode();
      if (CancellationReason.Length != 0) hash ^= CancellationReason.GetHashCode();
      if (cancellationPolicy_ != null) hash ^= CancellationPolicy.GetHashCode();
      if (RequestingParty.Length != 0) hash ^= RequestingParty.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (entityId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EntityId);
      }
      if (BookingId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BookingId);
      }
      if (State != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) State);
      }
      if (guest_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Guest);
      }
      if (dateRange_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(DateRange);
      }
      if (NumberAdults != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(NumberAdults);
      }
      if (NumberChildren != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(NumberChildren);
      }
      if (roomType_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RoomType);
      }
      additionalGuests_.WriteTo(output, _repeated_additionalGuests_codec);
      if (qualification_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Qualification);
      }
      if (TaxExempt != false) {
        output.WriteRawTag(88);
        output.WriteBool(TaxExempt);
      }
      if (cancellationPenaltyApplied_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CancellationPenaltyApplied);
      }
      if (CancellationReason.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(CancellationReason);
      }
      if (cancellationPolicy_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(CancellationPolicy);
      }
      if (RequestingParty.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(RequestingParty);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (BookingId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BookingId);
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (guest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Guest);
      }
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      if (NumberAdults != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumberAdults);
      }
      if (NumberChildren != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumberChildren);
      }
      if (roomType_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoomType);
      }
      size += additionalGuests_.CalculateSize(_repeated_additionalGuests_codec);
      if (qualification_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Qualification);
      }
      if (TaxExempt != false) {
        size += 1 + 1;
      }
      if (cancellationPenaltyApplied_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CancellationPenaltyApplied);
      }
      if (CancellationReason.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CancellationReason);
      }
      if (cancellationPolicy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CancellationPolicy);
      }
      if (RequestingParty.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestingParty);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CancelledReservation other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.BookingId.Length != 0) {
        BookingId = other.BookingId;
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.guest_ != null) {
        if (guest_ == null) {
          guest_ = new global::HOLMS.Types.CRM.Guests.Guest();
        }
        Guest.MergeFrom(other.Guest);
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
      }
      if (other.NumberAdults != 0) {
        NumberAdults = other.NumberAdults;
      }
      if (other.NumberChildren != 0) {
        NumberChildren = other.NumberChildren;
      }
      if (other.roomType_ != null) {
        if (roomType_ == null) {
          roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomType();
        }
        RoomType.MergeFrom(other.RoomType);
      }
      additionalGuests_.Add(other.additionalGuests_);
      if (other.qualification_ != null) {
        if (qualification_ == null) {
          qualification_ = new global::HOLMS.Types.Supply.Qualification();
        }
        Qualification.MergeFrom(other.Qualification);
      }
      if (other.TaxExempt != false) {
        TaxExempt = other.TaxExempt;
      }
      if (other.cancellationPenaltyApplied_ != null) {
        if (cancellationPenaltyApplied_ == null) {
          cancellationPenaltyApplied_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        CancellationPenaltyApplied.MergeFrom(other.CancellationPenaltyApplied);
      }
      if (other.CancellationReason.Length != 0) {
        CancellationReason = other.CancellationReason;
      }
      if (other.cancellationPolicy_ != null) {
        if (cancellationPolicy_ == null) {
          cancellationPolicy_ = new global::HOLMS.Types.Booking.CancellationPolicy();
        }
        CancellationPolicy.MergeFrom(other.CancellationPolicy);
      }
      if (other.RequestingParty.Length != 0) {
        RequestingParty = other.RequestingParty;
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
            if (entityId_ == null) {
              entityId_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            BookingId = input.ReadString();
            break;
          }
          case 24: {
            state_ = (global::HOLMS.Types.Booking.Reservations.ReservationState) input.ReadEnum();
            break;
          }
          case 34: {
            if (guest_ == null) {
              guest_ = new global::HOLMS.Types.CRM.Guests.Guest();
            }
            input.ReadMessage(guest_);
            break;
          }
          case 42: {
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
          case 48: {
            NumberAdults = input.ReadInt32();
            break;
          }
          case 56: {
            NumberChildren = input.ReadInt32();
            break;
          }
          case 66: {
            if (roomType_ == null) {
              roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomType();
            }
            input.ReadMessage(roomType_);
            break;
          }
          case 74: {
            additionalGuests_.AddEntriesFrom(input, _repeated_additionalGuests_codec);
            break;
          }
          case 82: {
            if (qualification_ == null) {
              qualification_ = new global::HOLMS.Types.Supply.Qualification();
            }
            input.ReadMessage(qualification_);
            break;
          }
          case 88: {
            TaxExempt = input.ReadBool();
            break;
          }
          case 98: {
            if (cancellationPenaltyApplied_ == null) {
              cancellationPenaltyApplied_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(cancellationPenaltyApplied_);
            break;
          }
          case 106: {
            CancellationReason = input.ReadString();
            break;
          }
          case 114: {
            if (cancellationPolicy_ == null) {
              cancellationPolicy_ = new global::HOLMS.Types.Booking.CancellationPolicy();
            }
            input.ReadMessage(cancellationPolicy_);
            break;
          }
          case 122: {
            RequestingParty = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

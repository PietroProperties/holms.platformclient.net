// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/reservations/complete_open_reservation.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Reservations {

  /// <summary>Holder for reflection information generated from booking/reservations/complete_open_reservation.proto</summary>
  public static partial class CompleteOpenReservationReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/reservations/complete_open_reservation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompleteOpenReservationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRib29raW5nL3Jlc2VydmF0aW9ucy9jb21wbGV0ZV9vcGVuX3Jlc2VydmF0",
            "aW9uLnByb3RvEiBob2xtcy50eXBlcy5ib29raW5nLnJlc2VydmF0aW9ucxof",
            "cHJpbWl0aXZlL21vbmV0YXJ5X2Ftb3VudC5wcm90bxoqcHJpbWl0aXZlL3Bi",
            "X2luY2x1c2l2ZV9vcHNkYXRlX3JhbmdlLnByb3RvGjdib29raW5nL3Jlc2Vy",
            "dmF0aW9ucy9yZXNlcnZhdGlvbl9ndWFyYW50ZWVfc3RhdHVzLnByb3RvGi5i",
            "b29raW5nL2luZGljYXRvcnMvcmVzZXJ2YXRpb25faW5kaWNhdG9yLnByb3Rv",
            "Gixib29raW5nL3Jlc2VydmF0aW9ucy9yZXNlcnZhdGlvbl9zdGF0ZS5wcm90",
            "bxoWY3JtL2d1ZXN0cy9ndWVzdC5wcm90bxohc3VwcGx5L3Jvb21fdHlwZXMv",
            "cm9vbV90eXBlLnByb3RvGhpzdXBwbHkvcXVhbGlmaWNhdGlvbi5wcm90bxov",
            "b3BlcmF0aW9ucy9ob3VzZWtlZXBpbmcvaG91c2VrZWVwaW5nX3RpbWUucHJv",
            "dG8aJW9wZXJhdGlvbnMvcm9vbXMvcm9vbV9pbmRpY2F0b3IucHJvdG8isQgK",
            "F0NvbXBsZXRlT3BlblJlc2VydmF0aW9uEkcKCWVudGl0eV9pZBgBIAEoCzI0",
            "LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5SZXNlcnZhdGlvbklu",
            "ZGljYXRvchISCgpib29raW5nX2lkGAIgASgJEkEKBXN0YXRlGAMgASgOMjIu",
            "aG9sbXMudHlwZXMuYm9va2luZy5yZXNlcnZhdGlvbnMuUmVzZXJ2YXRpb25T",
            "dGF0ZRIsCgVndWVzdBgEIAEoCzIdLmhvbG1zLnR5cGVzLmNybS5ndWVzdHMu",
            "R3Vlc3QSQgoKZGF0ZV9yYW5nZRgFIAEoCzIuLmhvbG1zLnR5cGVzLnByaW1p",
            "dGl2ZS5QYkluY2x1c2l2ZU9wc2RhdGVSYW5nZRIVCg1udW1iZXJfYWR1bHRz",
            "GAYgASgFEhcKD251bWJlcl9jaGlsZHJlbhgHIAEoBRI6Cglyb29tX3R5cGUY",
            "CCABKAsyJy5ob2xtcy50eXBlcy5zdXBwbHkucm9vbV90eXBlcy5Sb29tVHlw",
            "ZRI4ChFhZGRpdGlvbmFsX2d1ZXN0cxgJIAMoCzIdLmhvbG1zLnR5cGVzLmNy",
            "bS5ndWVzdHMuR3Vlc3QSOAoNcXVhbGlmaWNhdGlvbhgKIAEoCzIhLmhvbG1z",
            "LnR5cGVzLnN1cHBseS5RdWFsaWZpY2F0aW9uEhIKCnRheF9leGVtcHQYCyAB",
            "KAgSVgoQZ3VhcmFudGVlX3N0YXR1cxgMIAEoDjI8LmhvbG1zLnR5cGVzLmJv",
            "b2tpbmcucmVzZXJ2YXRpb25zLlJlc2VydmF0aW9uR3VhcmFudGVlU3RhdHVz",
            "EkcKGHVucGFpZF9ndWFyYW50ZWVfYmFsYW5jZRgNIAEoCzIlLmhvbG1zLnR5",
            "cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudBJRChJoa190aW1lX3ByZWZl",
            "cmVuY2UYDyABKAsyNS5ob2xtcy50eXBlcy5vcGVyYXRpb25zLmhvdXNla2Vl",
            "cGluZy5Ib3VzZWtlZXBpbmdUaW1lEiEKGXZlaGljbGVfcGxhdGVfaW5mb3Jt",
            "YXRpb24YECABKAkSJAocY3VycmVudF9vY2N1cGllZF9yb29tX251bWJlchgR",
            "IAEoCRJKChVjdXJyZW50X29jY3VwaWVkX3Jvb20YEiABKAsyKy5ob2xtcy50",
            "eXBlcy5vcGVyYXRpb25zLnJvb21zLlJvb21JbmRpY2F0b3ISJQoddGVybWlu",
            "YWxfb2NjdXBpZWRfcm9vbV9udW1iZXIYEyABKAkSSwoWdGVybWluYWxfb2Nj",
            "dXBpZWRfcm9vbRgUIAEoCzIrLmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMucm9v",
            "bXMuUm9vbUluZGljYXRvchITCgthY3RpdmVfdGFncxgVIAMoCUI5WhRib29r",
            "aW5nL3Jlc2VydmF0aW9uc6oCIEhPTE1TLlR5cGVzLkJvb2tpbmcuUmVzZXJ2",
            "YXRpb25zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatusReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Reservations.ReservationStateReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeReflection.Descriptor, global::HOLMS.Types.Supply.QualificationReflection.Descriptor, global::HOLMS.Types.Operations.Housekeeping.HousekeepingTimeReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation), global::HOLMS.Types.Booking.Reservations.CompleteOpenReservation.Parser, new[]{ "EntityId", "BookingId", "State", "Guest", "DateRange", "NumberAdults", "NumberChildren", "RoomType", "AdditionalGuests", "Qualification", "TaxExempt", "GuaranteeStatus", "UnpaidGuaranteeBalance", "HkTimePreference", "VehiclePlateInformation", "CurrentOccupiedRoomNumber", "CurrentOccupiedRoom", "TerminalOccupiedRoomNumber", "TerminalOccupiedRoom", "ActiveTags" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompleteOpenReservation : pb::IMessage<CompleteOpenReservation> {
    private static readonly pb::MessageParser<CompleteOpenReservation> _parser = new pb::MessageParser<CompleteOpenReservation>(() => new CompleteOpenReservation());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompleteOpenReservation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Reservations.CompleteOpenReservationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteOpenReservation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteOpenReservation(CompleteOpenReservation other) : this() {
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
      guaranteeStatus_ = other.guaranteeStatus_;
      UnpaidGuaranteeBalance = other.unpaidGuaranteeBalance_ != null ? other.UnpaidGuaranteeBalance.Clone() : null;
      HkTimePreference = other.hkTimePreference_ != null ? other.HkTimePreference.Clone() : null;
      vehiclePlateInformation_ = other.vehiclePlateInformation_;
      currentOccupiedRoomNumber_ = other.currentOccupiedRoomNumber_;
      CurrentOccupiedRoom = other.currentOccupiedRoom_ != null ? other.CurrentOccupiedRoom.Clone() : null;
      terminalOccupiedRoomNumber_ = other.terminalOccupiedRoomNumber_;
      TerminalOccupiedRoom = other.terminalOccupiedRoom_ != null ? other.TerminalOccupiedRoom.Clone() : null;
      activeTags_ = other.activeTags_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteOpenReservation Clone() {
      return new CompleteOpenReservation(this);
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

    /// <summary>Field number for the "guarantee_status" field.</summary>
    public const int GuaranteeStatusFieldNumber = 12;
    private global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatus guaranteeStatus_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatus GuaranteeStatus {
      get { return guaranteeStatus_; }
      set {
        guaranteeStatus_ = value;
      }
    }

    /// <summary>Field number for the "unpaid_guarantee_balance" field.</summary>
    public const int UnpaidGuaranteeBalanceFieldNumber = 13;
    private global::HOLMS.Types.Primitive.MonetaryAmount unpaidGuaranteeBalance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount UnpaidGuaranteeBalance {
      get { return unpaidGuaranteeBalance_; }
      set {
        unpaidGuaranteeBalance_ = value;
      }
    }

    /// <summary>Field number for the "hk_time_preference" field.</summary>
    public const int HkTimePreferenceFieldNumber = 15;
    private global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime hkTimePreference_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime HkTimePreference {
      get { return hkTimePreference_; }
      set {
        hkTimePreference_ = value;
      }
    }

    /// <summary>Field number for the "vehicle_plate_information" field.</summary>
    public const int VehiclePlateInformationFieldNumber = 16;
    private string vehiclePlateInformation_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VehiclePlateInformation {
      get { return vehiclePlateInformation_; }
      set {
        vehiclePlateInformation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "current_occupied_room_number" field.</summary>
    public const int CurrentOccupiedRoomNumberFieldNumber = 17;
    private string currentOccupiedRoomNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrentOccupiedRoomNumber {
      get { return currentOccupiedRoomNumber_; }
      set {
        currentOccupiedRoomNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "current_occupied_room" field.</summary>
    public const int CurrentOccupiedRoomFieldNumber = 18;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator currentOccupiedRoom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator CurrentOccupiedRoom {
      get { return currentOccupiedRoom_; }
      set {
        currentOccupiedRoom_ = value;
      }
    }

    /// <summary>Field number for the "terminal_occupied_room_number" field.</summary>
    public const int TerminalOccupiedRoomNumberFieldNumber = 19;
    private string terminalOccupiedRoomNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TerminalOccupiedRoomNumber {
      get { return terminalOccupiedRoomNumber_; }
      set {
        terminalOccupiedRoomNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "terminal_occupied_room" field.</summary>
    public const int TerminalOccupiedRoomFieldNumber = 20;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator terminalOccupiedRoom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator TerminalOccupiedRoom {
      get { return terminalOccupiedRoom_; }
      set {
        terminalOccupiedRoom_ = value;
      }
    }

    /// <summary>Field number for the "active_tags" field.</summary>
    public const int ActiveTagsFieldNumber = 21;
    private static readonly pb::FieldCodec<string> _repeated_activeTags_codec
        = pb::FieldCodec.ForString(170);
    private readonly pbc::RepeatedField<string> activeTags_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ActiveTags {
      get { return activeTags_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompleteOpenReservation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompleteOpenReservation other) {
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
      if (GuaranteeStatus != other.GuaranteeStatus) return false;
      if (!object.Equals(UnpaidGuaranteeBalance, other.UnpaidGuaranteeBalance)) return false;
      if (!object.Equals(HkTimePreference, other.HkTimePreference)) return false;
      if (VehiclePlateInformation != other.VehiclePlateInformation) return false;
      if (CurrentOccupiedRoomNumber != other.CurrentOccupiedRoomNumber) return false;
      if (!object.Equals(CurrentOccupiedRoom, other.CurrentOccupiedRoom)) return false;
      if (TerminalOccupiedRoomNumber != other.TerminalOccupiedRoomNumber) return false;
      if (!object.Equals(TerminalOccupiedRoom, other.TerminalOccupiedRoom)) return false;
      if(!activeTags_.Equals(other.activeTags_)) return false;
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
      if (GuaranteeStatus != 0) hash ^= GuaranteeStatus.GetHashCode();
      if (unpaidGuaranteeBalance_ != null) hash ^= UnpaidGuaranteeBalance.GetHashCode();
      if (hkTimePreference_ != null) hash ^= HkTimePreference.GetHashCode();
      if (VehiclePlateInformation.Length != 0) hash ^= VehiclePlateInformation.GetHashCode();
      if (CurrentOccupiedRoomNumber.Length != 0) hash ^= CurrentOccupiedRoomNumber.GetHashCode();
      if (currentOccupiedRoom_ != null) hash ^= CurrentOccupiedRoom.GetHashCode();
      if (TerminalOccupiedRoomNumber.Length != 0) hash ^= TerminalOccupiedRoomNumber.GetHashCode();
      if (terminalOccupiedRoom_ != null) hash ^= TerminalOccupiedRoom.GetHashCode();
      hash ^= activeTags_.GetHashCode();
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
      if (GuaranteeStatus != 0) {
        output.WriteRawTag(96);
        output.WriteEnum((int) GuaranteeStatus);
      }
      if (unpaidGuaranteeBalance_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(UnpaidGuaranteeBalance);
      }
      if (hkTimePreference_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(HkTimePreference);
      }
      if (VehiclePlateInformation.Length != 0) {
        output.WriteRawTag(130, 1);
        output.WriteString(VehiclePlateInformation);
      }
      if (CurrentOccupiedRoomNumber.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(CurrentOccupiedRoomNumber);
      }
      if (currentOccupiedRoom_ != null) {
        output.WriteRawTag(146, 1);
        output.WriteMessage(CurrentOccupiedRoom);
      }
      if (TerminalOccupiedRoomNumber.Length != 0) {
        output.WriteRawTag(154, 1);
        output.WriteString(TerminalOccupiedRoomNumber);
      }
      if (terminalOccupiedRoom_ != null) {
        output.WriteRawTag(162, 1);
        output.WriteMessage(TerminalOccupiedRoom);
      }
      activeTags_.WriteTo(output, _repeated_activeTags_codec);
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
      if (GuaranteeStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GuaranteeStatus);
      }
      if (unpaidGuaranteeBalance_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UnpaidGuaranteeBalance);
      }
      if (hkTimePreference_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HkTimePreference);
      }
      if (VehiclePlateInformation.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(VehiclePlateInformation);
      }
      if (CurrentOccupiedRoomNumber.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(CurrentOccupiedRoomNumber);
      }
      if (currentOccupiedRoom_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CurrentOccupiedRoom);
      }
      if (TerminalOccupiedRoomNumber.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(TerminalOccupiedRoomNumber);
      }
      if (terminalOccupiedRoom_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TerminalOccupiedRoom);
      }
      size += activeTags_.CalculateSize(_repeated_activeTags_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompleteOpenReservation other) {
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
      if (other.GuaranteeStatus != 0) {
        GuaranteeStatus = other.GuaranteeStatus;
      }
      if (other.unpaidGuaranteeBalance_ != null) {
        if (unpaidGuaranteeBalance_ == null) {
          unpaidGuaranteeBalance_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        UnpaidGuaranteeBalance.MergeFrom(other.UnpaidGuaranteeBalance);
      }
      if (other.hkTimePreference_ != null) {
        if (hkTimePreference_ == null) {
          hkTimePreference_ = new global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime();
        }
        HkTimePreference.MergeFrom(other.HkTimePreference);
      }
      if (other.VehiclePlateInformation.Length != 0) {
        VehiclePlateInformation = other.VehiclePlateInformation;
      }
      if (other.CurrentOccupiedRoomNumber.Length != 0) {
        CurrentOccupiedRoomNumber = other.CurrentOccupiedRoomNumber;
      }
      if (other.currentOccupiedRoom_ != null) {
        if (currentOccupiedRoom_ == null) {
          currentOccupiedRoom_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
        }
        CurrentOccupiedRoom.MergeFrom(other.CurrentOccupiedRoom);
      }
      if (other.TerminalOccupiedRoomNumber.Length != 0) {
        TerminalOccupiedRoomNumber = other.TerminalOccupiedRoomNumber;
      }
      if (other.terminalOccupiedRoom_ != null) {
        if (terminalOccupiedRoom_ == null) {
          terminalOccupiedRoom_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
        }
        TerminalOccupiedRoom.MergeFrom(other.TerminalOccupiedRoom);
      }
      activeTags_.Add(other.activeTags_);
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
          case 96: {
            guaranteeStatus_ = (global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatus) input.ReadEnum();
            break;
          }
          case 106: {
            if (unpaidGuaranteeBalance_ == null) {
              unpaidGuaranteeBalance_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(unpaidGuaranteeBalance_);
            break;
          }
          case 122: {
            if (hkTimePreference_ == null) {
              hkTimePreference_ = new global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime();
            }
            input.ReadMessage(hkTimePreference_);
            break;
          }
          case 130: {
            VehiclePlateInformation = input.ReadString();
            break;
          }
          case 138: {
            CurrentOccupiedRoomNumber = input.ReadString();
            break;
          }
          case 146: {
            if (currentOccupiedRoom_ == null) {
              currentOccupiedRoom_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(currentOccupiedRoom_);
            break;
          }
          case 154: {
            TerminalOccupiedRoomNumber = input.ReadString();
            break;
          }
          case 162: {
            if (terminalOccupiedRoom_ == null) {
              terminalOccupiedRoom_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(terminalOccupiedRoom_);
            break;
          }
          case 170: {
            activeTags_.AddEntriesFrom(input, _repeated_activeTags_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/reservations/reservation_summary.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Reservations {

  /// <summary>Holder for reflection information generated from booking/reservations/reservation_summary.proto</summary>
  public static partial class ReservationSummaryReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/reservations/reservation_summary.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationSummaryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5ib29raW5nL3Jlc2VydmF0aW9ucy9yZXNlcnZhdGlvbl9zdW1tYXJ5LnBy",
            "b3RvEiBob2xtcy50eXBlcy5ib29raW5nLnJlc2VydmF0aW9ucxoeYm9va2lu",
            "Zy9jaGFubmVscy9jaGFubmVsLnByb3RvGjdib29raW5nL3Jlc2VydmF0aW9u",
            "cy9yZXNlcnZhdGlvbl9ndWFyYW50ZWVfc3RhdHVzLnByb3RvGi5ib29raW5n",
            "L2luZGljYXRvcnMvcmVzZXJ2YXRpb25faW5kaWNhdG9yLnByb3RvGixib29r",
            "aW5nL3Jlc2VydmF0aW9ucy9yZXNlcnZhdGlvbl9zdGF0ZS5wcm90bxoWY3Jt",
            "L2d1ZXN0cy9ndWVzdC5wcm90bxoqcHJpbWl0aXZlL3BiX2luY2x1c2l2ZV9v",
            "cHNkYXRlX3JhbmdlLnByb3RvGiFzdXBwbHkvcm9vbV90eXBlcy9yb29tX3R5",
            "cGUucHJvdG8aG2lhbS90ZW5hbmN5X2luZGljYXRvci5wcm90bxoydGVuYW5j",
            "eV9jb25maWcvaW5kaWNhdG9ycy9wcm9wZXJ0eV9pbmRpY2F0b3IucHJvdG8a",
            "NmJvb2tpbmcvaW5kaWNhdG9ycy9jYW5jZWxsYXRpb25fcG9saWN5X2luZGlj",
            "YXRvci5wcm90bxovb3BlcmF0aW9ucy9ob3VzZWtlZXBpbmcvaG91c2VrZWVw",
            "aW5nX3RpbWUucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJv",
            "dG8aJW9wZXJhdGlvbnMvcm9vbXMvcm9vbV9pbmRpY2F0b3IucHJvdG8imAoK",
            "ElJlc2VydmF0aW9uU3VtbWFyeRJHCgllbnRpdHlfaWQYASABKAsyNC5ob2xt",
            "cy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuUmVzZXJ2YXRpb25JbmRpY2F0",
            "b3ISEgoKYm9va2luZ19pZBgCIAEoCRJBCgVzdGF0ZRgDIAEoDjIyLmhvbG1z",
            "LnR5cGVzLmJvb2tpbmcucmVzZXJ2YXRpb25zLlJlc2VydmF0aW9uU3RhdGUS",
            "LAoFZ3Vlc3QYBCABKAsyHS5ob2xtcy50eXBlcy5jcm0uZ3Vlc3RzLkd1ZXN0",
            "EkIKCmRhdGVfcmFuZ2UYBSABKAsyLi5ob2xtcy50eXBlcy5wcmltaXRpdmUu",
            "UGJJbmNsdXNpdmVPcHNkYXRlUmFuZ2USOgoJcm9vbV90eXBlGAYgASgLMicu",
            "aG9sbXMudHlwZXMuc3VwcGx5LnJvb21fdHlwZXMuUm9vbVR5cGUSVgoQZ3Vh",
            "cmFudGVlX3N0YXR1cxgHIAEoDjI8LmhvbG1zLnR5cGVzLmJvb2tpbmcucmVz",
            "ZXJ2YXRpb25zLlJlc2VydmF0aW9uR3VhcmFudGVlU3RhdHVzEjIKB3RlbmFu",
            "Y3kYCCABKAsyIS5ob2xtcy50eXBlcy5pYW0uVGVuYW5jeUluZGljYXRvchJK",
            "Cghwcm9wZXJ0eRgJIAEoCzI4LmhvbG1zLnR5cGVzLnRlbmFuY3lfY29uZmln",
            "LmluZGljYXRvcnMuUHJvcGVydHlJbmRpY2F0b3ISNgoHY2hhbm5lbBgKIAEo",
            "DjIlLmhvbG1zLnR5cGVzLmJvb2tpbmcuY2hhbm5lbHMuQ2hhbm5lbBIhChl2",
            "ZWhpY2xlX3BsYXRlX2luZm9ybWF0aW9uGAsgASgJEiQKHGN1cnJlbnRfb2Nj",
            "dXBpZWRfcm9vbV9udW1iZXIYDCABKAkSSgoVY3VycmVudF9vY2N1cGllZF9y",
            "b29tGA0gASgLMisuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5yb29tcy5Sb29t",
            "SW5kaWNhdG9yEiUKHXRlcm1pbmFsX29jY3VwaWVkX3Jvb21fbnVtYmVyGA4g",
            "ASgJEksKFnRlcm1pbmFsX29jY3VwaWVkX3Jvb20YDyABKAsyKy5ob2xtcy50",
            "eXBlcy5vcGVyYXRpb25zLnJvb21zLlJvb21JbmRpY2F0b3ISFQoNbnVtYmVy",
            "X2FkdWx0cxgQIAEoBRIXCg9udW1iZXJfY2hpbGRyZW4YESABKAUSEwoLYWN0",
            "aXZlX3RhZ3MYEiADKAkSGgoSY2hhbm5lbF9tYW5hZ2VyX2lkGBMgASgJEhkK",
            "EXNvdXJjZV9jaGFubmVsX2lkGBQgASgJElgKE2NhbmNlbGxhdGlvbl9wb2xp",
            "Y3kYFSABKAsyOy5ob2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuQ2Fu",
            "Y2VsbGF0aW9uUG9saWN5SW5kaWNhdG9yElEKEmhrX3RpbWVfcHJlZmVyZW5j",
            "ZRgWIAEoCzI1LmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMuaG91c2VrZWVwaW5n",
            "LkhvdXNla2VlcGluZ1RpbWUSLgoKY3JlYXRlZF9hdBgXIAEoCzIaLmdvb2ds",
            "ZS5wcm90b2J1Zi5UaW1lc3RhbXASJAocb3V0c3RhbmRpbmdfaXNzdWVkX3Jv",
            "b21fa2V5cxgYIAEoBRIcChRvcHRhX3Jvb21fc3RheV9pbmRleBgZIAEoBUI5",
            "WhRib29raW5nL3Jlc2VydmF0aW9uc6oCIEhPTE1TLlR5cGVzLkJvb2tpbmcu",
            "UmVzZXJ2YXRpb25zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Channels.ChannelReflection.Descriptor, global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatusReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Reservations.ReservationStateReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeReflection.Descriptor, global::HOLMS.Types.IAM.TenancyIndicatorReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicatorReflection.Descriptor, global::HOLMS.Types.Operations.Housekeeping.HousekeepingTimeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Reservations.ReservationSummary), global::HOLMS.Types.Booking.Reservations.ReservationSummary.Parser, new[]{ "EntityId", "BookingId", "State", "Guest", "DateRange", "RoomType", "GuaranteeStatus", "Tenancy", "Property", "Channel", "VehiclePlateInformation", "CurrentOccupiedRoomNumber", "CurrentOccupiedRoom", "TerminalOccupiedRoomNumber", "TerminalOccupiedRoom", "NumberAdults", "NumberChildren", "ActiveTags", "ChannelManagerId", "SourceChannelId", "CancellationPolicy", "HkTimePreference", "CreatedAt", "OutstandingIssuedRoomKeys", "OptaRoomStayIndex" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationSummary : pb::IMessage<ReservationSummary> {
    private static readonly pb::MessageParser<ReservationSummary> _parser = new pb::MessageParser<ReservationSummary>(() => new ReservationSummary());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationSummary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Reservations.ReservationSummaryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationSummary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationSummary(ReservationSummary other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      bookingId_ = other.bookingId_;
      state_ = other.state_;
      Guest = other.guest_ != null ? other.Guest.Clone() : null;
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
      RoomType = other.roomType_ != null ? other.RoomType.Clone() : null;
      guaranteeStatus_ = other.guaranteeStatus_;
      Tenancy = other.tenancy_ != null ? other.Tenancy.Clone() : null;
      Property = other.property_ != null ? other.Property.Clone() : null;
      channel_ = other.channel_;
      vehiclePlateInformation_ = other.vehiclePlateInformation_;
      currentOccupiedRoomNumber_ = other.currentOccupiedRoomNumber_;
      CurrentOccupiedRoom = other.currentOccupiedRoom_ != null ? other.CurrentOccupiedRoom.Clone() : null;
      terminalOccupiedRoomNumber_ = other.terminalOccupiedRoomNumber_;
      TerminalOccupiedRoom = other.terminalOccupiedRoom_ != null ? other.TerminalOccupiedRoom.Clone() : null;
      numberAdults_ = other.numberAdults_;
      numberChildren_ = other.numberChildren_;
      activeTags_ = other.activeTags_.Clone();
      channelManagerId_ = other.channelManagerId_;
      sourceChannelId_ = other.sourceChannelId_;
      CancellationPolicy = other.cancellationPolicy_ != null ? other.CancellationPolicy.Clone() : null;
      HkTimePreference = other.hkTimePreference_ != null ? other.HkTimePreference.Clone() : null;
      CreatedAt = other.createdAt_ != null ? other.CreatedAt.Clone() : null;
      outstandingIssuedRoomKeys_ = other.outstandingIssuedRoomKeys_;
      optaRoomStayIndex_ = other.optaRoomStayIndex_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationSummary Clone() {
      return new ReservationSummary(this);
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

    /// <summary>Field number for the "room_type" field.</summary>
    public const int RoomTypeFieldNumber = 6;
    private global::HOLMS.Types.Supply.RoomTypes.RoomType roomType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RoomTypes.RoomType RoomType {
      get { return roomType_; }
      set {
        roomType_ = value;
      }
    }

    /// <summary>Field number for the "guarantee_status" field.</summary>
    public const int GuaranteeStatusFieldNumber = 7;
    private global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatus guaranteeStatus_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatus GuaranteeStatus {
      get { return guaranteeStatus_; }
      set {
        guaranteeStatus_ = value;
      }
    }

    /// <summary>Field number for the "tenancy" field.</summary>
    public const int TenancyFieldNumber = 8;
    private global::HOLMS.Types.IAM.TenancyIndicator tenancy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.TenancyIndicator Tenancy {
      get { return tenancy_; }
      set {
        tenancy_ = value;
      }
    }

    /// <summary>Field number for the "property" field.</summary>
    public const int PropertyFieldNumber = 9;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator property_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator Property {
      get { return property_; }
      set {
        property_ = value;
      }
    }

    /// <summary>Field number for the "channel" field.</summary>
    public const int ChannelFieldNumber = 10;
    private global::HOLMS.Types.Booking.Channels.Channel channel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Channels.Channel Channel {
      get { return channel_; }
      set {
        channel_ = value;
      }
    }

    /// <summary>Field number for the "vehicle_plate_information" field.</summary>
    public const int VehiclePlateInformationFieldNumber = 11;
    private string vehiclePlateInformation_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VehiclePlateInformation {
      get { return vehiclePlateInformation_; }
      set {
        vehiclePlateInformation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "current_occupied_room_number" field.</summary>
    public const int CurrentOccupiedRoomNumberFieldNumber = 12;
    private string currentOccupiedRoomNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrentOccupiedRoomNumber {
      get { return currentOccupiedRoomNumber_; }
      set {
        currentOccupiedRoomNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "current_occupied_room" field.</summary>
    public const int CurrentOccupiedRoomFieldNumber = 13;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator currentOccupiedRoom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator CurrentOccupiedRoom {
      get { return currentOccupiedRoom_; }
      set {
        currentOccupiedRoom_ = value;
      }
    }

    /// <summary>Field number for the "terminal_occupied_room_number" field.</summary>
    public const int TerminalOccupiedRoomNumberFieldNumber = 14;
    private string terminalOccupiedRoomNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TerminalOccupiedRoomNumber {
      get { return terminalOccupiedRoomNumber_; }
      set {
        terminalOccupiedRoomNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "terminal_occupied_room" field.</summary>
    public const int TerminalOccupiedRoomFieldNumber = 15;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator terminalOccupiedRoom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator TerminalOccupiedRoom {
      get { return terminalOccupiedRoom_; }
      set {
        terminalOccupiedRoom_ = value;
      }
    }

    /// <summary>Field number for the "number_adults" field.</summary>
    public const int NumberAdultsFieldNumber = 16;
    private int numberAdults_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumberAdults {
      get { return numberAdults_; }
      set {
        numberAdults_ = value;
      }
    }

    /// <summary>Field number for the "number_children" field.</summary>
    public const int NumberChildrenFieldNumber = 17;
    private int numberChildren_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumberChildren {
      get { return numberChildren_; }
      set {
        numberChildren_ = value;
      }
    }

    /// <summary>Field number for the "active_tags" field.</summary>
    public const int ActiveTagsFieldNumber = 18;
    private static readonly pb::FieldCodec<string> _repeated_activeTags_codec
        = pb::FieldCodec.ForString(146);
    private readonly pbc::RepeatedField<string> activeTags_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ActiveTags {
      get { return activeTags_; }
    }

    /// <summary>Field number for the "channel_manager_id" field.</summary>
    public const int ChannelManagerIdFieldNumber = 19;
    private string channelManagerId_ = "";
    /// <summary>
    ///  deprecated
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ChannelManagerId {
      get { return channelManagerId_; }
      set {
        channelManagerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source_channel_id" field.</summary>
    public const int SourceChannelIdFieldNumber = 20;
    private string sourceChannelId_ = "";
    /// <summary>
    ///  deprecated
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceChannelId {
      get { return sourceChannelId_; }
      set {
        sourceChannelId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cancellation_policy" field.</summary>
    public const int CancellationPolicyFieldNumber = 21;
    private global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator cancellationPolicy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator CancellationPolicy {
      get { return cancellationPolicy_; }
      set {
        cancellationPolicy_ = value;
      }
    }

    /// <summary>Field number for the "hk_time_preference" field.</summary>
    public const int HkTimePreferenceFieldNumber = 22;
    private global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime hkTimePreference_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime HkTimePreference {
      get { return hkTimePreference_; }
      set {
        hkTimePreference_ = value;
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 23;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    /// <summary>Field number for the "outstanding_issued_room_keys" field.</summary>
    public const int OutstandingIssuedRoomKeysFieldNumber = 24;
    private int outstandingIssuedRoomKeys_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int OutstandingIssuedRoomKeys {
      get { return outstandingIssuedRoomKeys_; }
      set {
        outstandingIssuedRoomKeys_ = value;
      }
    }

    /// <summary>Field number for the "opta_room_stay_index" field.</summary>
    public const int OptaRoomStayIndexFieldNumber = 25;
    private int optaRoomStayIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int OptaRoomStayIndex {
      get { return optaRoomStayIndex_; }
      set {
        optaRoomStayIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationSummary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationSummary other) {
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
      if (!object.Equals(RoomType, other.RoomType)) return false;
      if (GuaranteeStatus != other.GuaranteeStatus) return false;
      if (!object.Equals(Tenancy, other.Tenancy)) return false;
      if (!object.Equals(Property, other.Property)) return false;
      if (Channel != other.Channel) return false;
      if (VehiclePlateInformation != other.VehiclePlateInformation) return false;
      if (CurrentOccupiedRoomNumber != other.CurrentOccupiedRoomNumber) return false;
      if (!object.Equals(CurrentOccupiedRoom, other.CurrentOccupiedRoom)) return false;
      if (TerminalOccupiedRoomNumber != other.TerminalOccupiedRoomNumber) return false;
      if (!object.Equals(TerminalOccupiedRoom, other.TerminalOccupiedRoom)) return false;
      if (NumberAdults != other.NumberAdults) return false;
      if (NumberChildren != other.NumberChildren) return false;
      if(!activeTags_.Equals(other.activeTags_)) return false;
      if (ChannelManagerId != other.ChannelManagerId) return false;
      if (SourceChannelId != other.SourceChannelId) return false;
      if (!object.Equals(CancellationPolicy, other.CancellationPolicy)) return false;
      if (!object.Equals(HkTimePreference, other.HkTimePreference)) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if (OutstandingIssuedRoomKeys != other.OutstandingIssuedRoomKeys) return false;
      if (OptaRoomStayIndex != other.OptaRoomStayIndex) return false;
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
      if (roomType_ != null) hash ^= RoomType.GetHashCode();
      if (GuaranteeStatus != 0) hash ^= GuaranteeStatus.GetHashCode();
      if (tenancy_ != null) hash ^= Tenancy.GetHashCode();
      if (property_ != null) hash ^= Property.GetHashCode();
      if (Channel != 0) hash ^= Channel.GetHashCode();
      if (VehiclePlateInformation.Length != 0) hash ^= VehiclePlateInformation.GetHashCode();
      if (CurrentOccupiedRoomNumber.Length != 0) hash ^= CurrentOccupiedRoomNumber.GetHashCode();
      if (currentOccupiedRoom_ != null) hash ^= CurrentOccupiedRoom.GetHashCode();
      if (TerminalOccupiedRoomNumber.Length != 0) hash ^= TerminalOccupiedRoomNumber.GetHashCode();
      if (terminalOccupiedRoom_ != null) hash ^= TerminalOccupiedRoom.GetHashCode();
      if (NumberAdults != 0) hash ^= NumberAdults.GetHashCode();
      if (NumberChildren != 0) hash ^= NumberChildren.GetHashCode();
      hash ^= activeTags_.GetHashCode();
      if (ChannelManagerId.Length != 0) hash ^= ChannelManagerId.GetHashCode();
      if (SourceChannelId.Length != 0) hash ^= SourceChannelId.GetHashCode();
      if (cancellationPolicy_ != null) hash ^= CancellationPolicy.GetHashCode();
      if (hkTimePreference_ != null) hash ^= HkTimePreference.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      if (OutstandingIssuedRoomKeys != 0) hash ^= OutstandingIssuedRoomKeys.GetHashCode();
      if (OptaRoomStayIndex != 0) hash ^= OptaRoomStayIndex.GetHashCode();
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
      if (roomType_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RoomType);
      }
      if (GuaranteeStatus != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) GuaranteeStatus);
      }
      if (tenancy_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Tenancy);
      }
      if (property_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Property);
      }
      if (Channel != 0) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Channel);
      }
      if (VehiclePlateInformation.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(VehiclePlateInformation);
      }
      if (CurrentOccupiedRoomNumber.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(CurrentOccupiedRoomNumber);
      }
      if (currentOccupiedRoom_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(CurrentOccupiedRoom);
      }
      if (TerminalOccupiedRoomNumber.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(TerminalOccupiedRoomNumber);
      }
      if (terminalOccupiedRoom_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(TerminalOccupiedRoom);
      }
      if (NumberAdults != 0) {
        output.WriteRawTag(128, 1);
        output.WriteInt32(NumberAdults);
      }
      if (NumberChildren != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(NumberChildren);
      }
      activeTags_.WriteTo(output, _repeated_activeTags_codec);
      if (ChannelManagerId.Length != 0) {
        output.WriteRawTag(154, 1);
        output.WriteString(ChannelManagerId);
      }
      if (SourceChannelId.Length != 0) {
        output.WriteRawTag(162, 1);
        output.WriteString(SourceChannelId);
      }
      if (cancellationPolicy_ != null) {
        output.WriteRawTag(170, 1);
        output.WriteMessage(CancellationPolicy);
      }
      if (hkTimePreference_ != null) {
        output.WriteRawTag(178, 1);
        output.WriteMessage(HkTimePreference);
      }
      if (createdAt_ != null) {
        output.WriteRawTag(186, 1);
        output.WriteMessage(CreatedAt);
      }
      if (OutstandingIssuedRoomKeys != 0) {
        output.WriteRawTag(192, 1);
        output.WriteInt32(OutstandingIssuedRoomKeys);
      }
      if (OptaRoomStayIndex != 0) {
        output.WriteRawTag(200, 1);
        output.WriteInt32(OptaRoomStayIndex);
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
      if (roomType_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoomType);
      }
      if (GuaranteeStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GuaranteeStatus);
      }
      if (tenancy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Tenancy);
      }
      if (property_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Property);
      }
      if (Channel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Channel);
      }
      if (VehiclePlateInformation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VehiclePlateInformation);
      }
      if (CurrentOccupiedRoomNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrentOccupiedRoomNumber);
      }
      if (currentOccupiedRoom_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrentOccupiedRoom);
      }
      if (TerminalOccupiedRoomNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TerminalOccupiedRoomNumber);
      }
      if (terminalOccupiedRoom_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TerminalOccupiedRoom);
      }
      if (NumberAdults != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(NumberAdults);
      }
      if (NumberChildren != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(NumberChildren);
      }
      size += activeTags_.CalculateSize(_repeated_activeTags_codec);
      if (ChannelManagerId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ChannelManagerId);
      }
      if (SourceChannelId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(SourceChannelId);
      }
      if (cancellationPolicy_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CancellationPolicy);
      }
      if (hkTimePreference_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(HkTimePreference);
      }
      if (createdAt_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (OutstandingIssuedRoomKeys != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(OutstandingIssuedRoomKeys);
      }
      if (OptaRoomStayIndex != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(OptaRoomStayIndex);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationSummary other) {
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
      if (other.roomType_ != null) {
        if (roomType_ == null) {
          roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomType();
        }
        RoomType.MergeFrom(other.RoomType);
      }
      if (other.GuaranteeStatus != 0) {
        GuaranteeStatus = other.GuaranteeStatus;
      }
      if (other.tenancy_ != null) {
        if (tenancy_ == null) {
          tenancy_ = new global::HOLMS.Types.IAM.TenancyIndicator();
        }
        Tenancy.MergeFrom(other.Tenancy);
      }
      if (other.property_ != null) {
        if (property_ == null) {
          property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        Property.MergeFrom(other.Property);
      }
      if (other.Channel != 0) {
        Channel = other.Channel;
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
      if (other.NumberAdults != 0) {
        NumberAdults = other.NumberAdults;
      }
      if (other.NumberChildren != 0) {
        NumberChildren = other.NumberChildren;
      }
      activeTags_.Add(other.activeTags_);
      if (other.ChannelManagerId.Length != 0) {
        ChannelManagerId = other.ChannelManagerId;
      }
      if (other.SourceChannelId.Length != 0) {
        SourceChannelId = other.SourceChannelId;
      }
      if (other.cancellationPolicy_ != null) {
        if (cancellationPolicy_ == null) {
          cancellationPolicy_ = new global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator();
        }
        CancellationPolicy.MergeFrom(other.CancellationPolicy);
      }
      if (other.hkTimePreference_ != null) {
        if (hkTimePreference_ == null) {
          hkTimePreference_ = new global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime();
        }
        HkTimePreference.MergeFrom(other.HkTimePreference);
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          createdAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
      }
      if (other.OutstandingIssuedRoomKeys != 0) {
        OutstandingIssuedRoomKeys = other.OutstandingIssuedRoomKeys;
      }
      if (other.OptaRoomStayIndex != 0) {
        OptaRoomStayIndex = other.OptaRoomStayIndex;
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
          case 50: {
            if (roomType_ == null) {
              roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomType();
            }
            input.ReadMessage(roomType_);
            break;
          }
          case 56: {
            guaranteeStatus_ = (global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatus) input.ReadEnum();
            break;
          }
          case 66: {
            if (tenancy_ == null) {
              tenancy_ = new global::HOLMS.Types.IAM.TenancyIndicator();
            }
            input.ReadMessage(tenancy_);
            break;
          }
          case 74: {
            if (property_ == null) {
              property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(property_);
            break;
          }
          case 80: {
            channel_ = (global::HOLMS.Types.Booking.Channels.Channel) input.ReadEnum();
            break;
          }
          case 90: {
            VehiclePlateInformation = input.ReadString();
            break;
          }
          case 98: {
            CurrentOccupiedRoomNumber = input.ReadString();
            break;
          }
          case 106: {
            if (currentOccupiedRoom_ == null) {
              currentOccupiedRoom_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(currentOccupiedRoom_);
            break;
          }
          case 114: {
            TerminalOccupiedRoomNumber = input.ReadString();
            break;
          }
          case 122: {
            if (terminalOccupiedRoom_ == null) {
              terminalOccupiedRoom_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(terminalOccupiedRoom_);
            break;
          }
          case 128: {
            NumberAdults = input.ReadInt32();
            break;
          }
          case 136: {
            NumberChildren = input.ReadInt32();
            break;
          }
          case 146: {
            activeTags_.AddEntriesFrom(input, _repeated_activeTags_codec);
            break;
          }
          case 154: {
            ChannelManagerId = input.ReadString();
            break;
          }
          case 162: {
            SourceChannelId = input.ReadString();
            break;
          }
          case 170: {
            if (cancellationPolicy_ == null) {
              cancellationPolicy_ = new global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator();
            }
            input.ReadMessage(cancellationPolicy_);
            break;
          }
          case 178: {
            if (hkTimePreference_ == null) {
              hkTimePreference_ = new global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime();
            }
            input.ReadMessage(hkTimePreference_);
            break;
          }
          case 186: {
            if (createdAt_ == null) {
              createdAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(createdAt_);
            break;
          }
          case 192: {
            OutstandingIssuedRoomKeys = input.ReadInt32();
            break;
          }
          case 200: {
            OptaRoomStayIndex = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

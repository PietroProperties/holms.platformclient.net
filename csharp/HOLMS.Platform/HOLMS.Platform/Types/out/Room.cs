// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rooms/room.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.Rooms {

  /// <summary>Holder for reflection information generated from operations/rooms/room.proto</summary>
  public static partial class RoomReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/rooms/room.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtvcGVyYXRpb25zL3Jvb21zL3Jvb20ucHJvdG8SHGhvbG1zLnR5cGVzLm9w",
            "ZXJhdGlvbnMucm9vbXMaLmJvb2tpbmcvaW5kaWNhdG9ycy9yZXNlcnZhdGlv",
            "bl9pbmRpY2F0b3IucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAu",
            "cHJvdG8aKW9wZXJhdGlvbnMvcm9vbV9tYWludGVuYW5jZV9yZXF1ZXN0LnBy",
            "b3RvGidvcGVyYXRpb25zL3Jvb21fbWFpbnRlbmFuY2Vfc3RhdGUucHJvdG8a",
            "JW9wZXJhdGlvbnMvcm9vbV9vY2N1cGFuY3lfc3RhdGUucHJvdG8aJW9wZXJh",
            "dGlvbnMvcm9vbXMvcm9vbV9pbmRpY2F0b3IucHJvdG8aK3N1cHBseS9yb29t",
            "X3R5cGVzL3Jvb21fdHlwZV9pbmRpY2F0b3IucHJvdG8aIHRlbmFuY3lfY29u",
            "ZmlnL3Jvb21fc3RhdHVzLnByb3RvIr0GCgRSb29tEj4KCWVudGl0eV9pZBgB",
            "IAEoCzIrLmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMucm9vbXMuUm9vbUluZGlj",
            "YXRvchITCgtyb29tX251bWJlchgCIAEoCRITCgtkZXNjcmlwdGlvbhgDIAEo",
            "CRIeChZhZGRpdGlvbmFsX2Rlc2NyaXB0aW9uGAQgASgJEh8KF25pZ2h0c19v",
            "Y2N1cGllZF9jb3VudGVyGAUgASgFEjMKD2xhc3RfY2xlYW5lZF9hdBgGIAEo",
            "CzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASQwoPb2NjdXBhbmN5X3N0",
            "YXRlGAcgASgOMiouaG9sbXMudHlwZXMub3BlcmF0aW9ucy5Sb29tT2NjdXBh",
            "bmN5U3RhdGUSRwoRbWFpbnRlbmFuY2Vfc3RhdGUYCCABKA4yLC5ob2xtcy50",
            "eXBlcy5vcGVyYXRpb25zLlJvb21NYWludGVuYW5jZVN0YXRlEksKE21haW50",
            "ZW5hbmNlX3JlcXVlc3QYCSABKA4yLi5ob2xtcy50eXBlcy5vcGVyYXRpb25z",
            "LlJvb21NYWludGVuYW5jZVJlcXVlc3QSRgoMcm9vbV90eXBlX2lkGAogASgL",
            "MjAuaG9sbXMudHlwZXMuc3VwcGx5LnJvb21fdHlwZXMuUm9vbVR5cGVJbmRp",
            "Y2F0b3ISFgoOcm9vbV90eXBlX25hbWUYCyABKAkSQwoOY29ubmVjdGVkX3Jv",
            "b20YDCABKAsyKy5ob2xtcy50eXBlcy5vcGVyYXRpb25zLnJvb21zLlJvb21J",
            "bmRpY2F0b3ISEAoIdHJ1bmtfaWQYDSABKAkSUwoVb2NjdXB5aW5nX3Jlc2Vy",
            "dmF0aW9uGA4gASgLMjQuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3Jz",
            "LlJlc2VydmF0aW9uSW5kaWNhdG9yEhcKD2tjcl9yb29tX251bWJlchgPIAEo",
            "CRIYChByb29tX3N0YXR1c19jb2RlGBAgASgJEjsKC3Jvb21fc3RhdHVzGBEg",
            "ASgLMiYuaG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcuUm9vbVN0YXR1c0If",
            "qgIcSE9MTVMuVHlwZXMuT3BlcmF0aW9ucy5Sb29tc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Operations.RoomMaintenanceRequestReflection.Descriptor, global::HOLMS.Types.Operations.RoomMaintenanceStateReflection.Descriptor, global::HOLMS.Types.Operations.RoomOccupancyStateReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicatorReflection.Descriptor, global::HOLMS.Types.TenancyConfig.RoomStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.Rooms.Room), global::HOLMS.Types.Operations.Rooms.Room.Parser, new[]{ "EntityId", "RoomNumber", "Description", "AdditionalDescription", "NightsOccupiedCounter", "LastCleanedAt", "OccupancyState", "MaintenanceState", "MaintenanceRequest", "RoomTypeId", "RoomTypeName", "ConnectedRoom", "TrunkId", "OccupyingReservation", "KcrRoomNumber", "RoomStatusCode", "RoomStatus" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Room : pb::IMessage<Room> {
    private static readonly pb::MessageParser<Room> _parser = new pb::MessageParser<Room>(() => new Room());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Room> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.Rooms.RoomReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Room() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Room(Room other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      roomNumber_ = other.roomNumber_;
      description_ = other.description_;
      additionalDescription_ = other.additionalDescription_;
      nightsOccupiedCounter_ = other.nightsOccupiedCounter_;
      LastCleanedAt = other.lastCleanedAt_ != null ? other.LastCleanedAt.Clone() : null;
      occupancyState_ = other.occupancyState_;
      maintenanceState_ = other.maintenanceState_;
      maintenanceRequest_ = other.maintenanceRequest_;
      RoomTypeId = other.roomTypeId_ != null ? other.RoomTypeId.Clone() : null;
      roomTypeName_ = other.roomTypeName_;
      ConnectedRoom = other.connectedRoom_ != null ? other.ConnectedRoom.Clone() : null;
      trunkId_ = other.trunkId_;
      OccupyingReservation = other.occupyingReservation_ != null ? other.OccupyingReservation.Clone() : null;
      kcrRoomNumber_ = other.kcrRoomNumber_;
      roomStatusCode_ = other.roomStatusCode_;
      RoomStatus = other.roomStatus_ != null ? other.RoomStatus.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Room Clone() {
      return new Room(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "room_number" field.</summary>
    public const int RoomNumberFieldNumber = 2;
    private string roomNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomNumber {
      get { return roomNumber_; }
      set {
        roomNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "additional_description" field.</summary>
    public const int AdditionalDescriptionFieldNumber = 4;
    private string additionalDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdditionalDescription {
      get { return additionalDescription_; }
      set {
        additionalDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nights_occupied_counter" field.</summary>
    public const int NightsOccupiedCounterFieldNumber = 5;
    private int nightsOccupiedCounter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NightsOccupiedCounter {
      get { return nightsOccupiedCounter_; }
      set {
        nightsOccupiedCounter_ = value;
      }
    }

    /// <summary>Field number for the "last_cleaned_at" field.</summary>
    public const int LastCleanedAtFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastCleanedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastCleanedAt {
      get { return lastCleanedAt_; }
      set {
        lastCleanedAt_ = value;
      }
    }

    /// <summary>Field number for the "occupancy_state" field.</summary>
    public const int OccupancyStateFieldNumber = 7;
    private global::HOLMS.Types.Operations.RoomOccupancyState occupancyState_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.RoomOccupancyState OccupancyState {
      get { return occupancyState_; }
      set {
        occupancyState_ = value;
      }
    }

    /// <summary>Field number for the "maintenance_state" field.</summary>
    public const int MaintenanceStateFieldNumber = 8;
    private global::HOLMS.Types.Operations.RoomMaintenanceState maintenanceState_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.RoomMaintenanceState MaintenanceState {
      get { return maintenanceState_; }
      set {
        maintenanceState_ = value;
      }
    }

    /// <summary>Field number for the "maintenance_request" field.</summary>
    public const int MaintenanceRequestFieldNumber = 9;
    private global::HOLMS.Types.Operations.RoomMaintenanceRequest maintenanceRequest_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.RoomMaintenanceRequest MaintenanceRequest {
      get { return maintenanceRequest_; }
      set {
        maintenanceRequest_ = value;
      }
    }

    /// <summary>Field number for the "room_type_id" field.</summary>
    public const int RoomTypeIdFieldNumber = 10;
    private global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator roomTypeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator RoomTypeId {
      get { return roomTypeId_; }
      set {
        roomTypeId_ = value;
      }
    }

    /// <summary>Field number for the "room_type_name" field.</summary>
    public const int RoomTypeNameFieldNumber = 11;
    private string roomTypeName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomTypeName {
      get { return roomTypeName_; }
      set {
        roomTypeName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "connected_room" field.</summary>
    public const int ConnectedRoomFieldNumber = 12;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator connectedRoom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator ConnectedRoom {
      get { return connectedRoom_; }
      set {
        connectedRoom_ = value;
      }
    }

    /// <summary>Field number for the "trunk_id" field.</summary>
    public const int TrunkIdFieldNumber = 13;
    private string trunkId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TrunkId {
      get { return trunkId_; }
      set {
        trunkId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "occupying_reservation" field.</summary>
    public const int OccupyingReservationFieldNumber = 14;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator occupyingReservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator OccupyingReservation {
      get { return occupyingReservation_; }
      set {
        occupyingReservation_ = value;
      }
    }

    /// <summary>Field number for the "kcr_room_number" field.</summary>
    public const int KcrRoomNumberFieldNumber = 15;
    private string kcrRoomNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KcrRoomNumber {
      get { return kcrRoomNumber_; }
      set {
        kcrRoomNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "room_status_code" field.</summary>
    public const int RoomStatusCodeFieldNumber = 16;
    private string roomStatusCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomStatusCode {
      get { return roomStatusCode_; }
      set {
        roomStatusCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "room_status" field.</summary>
    public const int RoomStatusFieldNumber = 17;
    private global::HOLMS.Types.TenancyConfig.RoomStatus roomStatus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.RoomStatus RoomStatus {
      get { return roomStatus_; }
      set {
        roomStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Room);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Room other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (RoomNumber != other.RoomNumber) return false;
      if (Description != other.Description) return false;
      if (AdditionalDescription != other.AdditionalDescription) return false;
      if (NightsOccupiedCounter != other.NightsOccupiedCounter) return false;
      if (!object.Equals(LastCleanedAt, other.LastCleanedAt)) return false;
      if (OccupancyState != other.OccupancyState) return false;
      if (MaintenanceState != other.MaintenanceState) return false;
      if (MaintenanceRequest != other.MaintenanceRequest) return false;
      if (!object.Equals(RoomTypeId, other.RoomTypeId)) return false;
      if (RoomTypeName != other.RoomTypeName) return false;
      if (!object.Equals(ConnectedRoom, other.ConnectedRoom)) return false;
      if (TrunkId != other.TrunkId) return false;
      if (!object.Equals(OccupyingReservation, other.OccupyingReservation)) return false;
      if (KcrRoomNumber != other.KcrRoomNumber) return false;
      if (RoomStatusCode != other.RoomStatusCode) return false;
      if (!object.Equals(RoomStatus, other.RoomStatus)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (RoomNumber.Length != 0) hash ^= RoomNumber.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (AdditionalDescription.Length != 0) hash ^= AdditionalDescription.GetHashCode();
      if (NightsOccupiedCounter != 0) hash ^= NightsOccupiedCounter.GetHashCode();
      if (lastCleanedAt_ != null) hash ^= LastCleanedAt.GetHashCode();
      if (OccupancyState != 0) hash ^= OccupancyState.GetHashCode();
      if (MaintenanceState != 0) hash ^= MaintenanceState.GetHashCode();
      if (MaintenanceRequest != 0) hash ^= MaintenanceRequest.GetHashCode();
      if (roomTypeId_ != null) hash ^= RoomTypeId.GetHashCode();
      if (RoomTypeName.Length != 0) hash ^= RoomTypeName.GetHashCode();
      if (connectedRoom_ != null) hash ^= ConnectedRoom.GetHashCode();
      if (TrunkId.Length != 0) hash ^= TrunkId.GetHashCode();
      if (occupyingReservation_ != null) hash ^= OccupyingReservation.GetHashCode();
      if (KcrRoomNumber.Length != 0) hash ^= KcrRoomNumber.GetHashCode();
      if (RoomStatusCode.Length != 0) hash ^= RoomStatusCode.GetHashCode();
      if (roomStatus_ != null) hash ^= RoomStatus.GetHashCode();
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
      if (RoomNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RoomNumber);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (AdditionalDescription.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AdditionalDescription);
      }
      if (NightsOccupiedCounter != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(NightsOccupiedCounter);
      }
      if (lastCleanedAt_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(LastCleanedAt);
      }
      if (OccupancyState != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) OccupancyState);
      }
      if (MaintenanceState != 0) {
        output.WriteRawTag(64);
        output.WriteEnum((int) MaintenanceState);
      }
      if (MaintenanceRequest != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) MaintenanceRequest);
      }
      if (roomTypeId_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RoomTypeId);
      }
      if (RoomTypeName.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(RoomTypeName);
      }
      if (connectedRoom_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ConnectedRoom);
      }
      if (TrunkId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(TrunkId);
      }
      if (occupyingReservation_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(OccupyingReservation);
      }
      if (KcrRoomNumber.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(KcrRoomNumber);
      }
      if (RoomStatusCode.Length != 0) {
        output.WriteRawTag(130, 1);
        output.WriteString(RoomStatusCode);
      }
      if (roomStatus_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(RoomStatus);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (RoomNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomNumber);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (AdditionalDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdditionalDescription);
      }
      if (NightsOccupiedCounter != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NightsOccupiedCounter);
      }
      if (lastCleanedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastCleanedAt);
      }
      if (OccupancyState != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OccupancyState);
      }
      if (MaintenanceState != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MaintenanceState);
      }
      if (MaintenanceRequest != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MaintenanceRequest);
      }
      if (roomTypeId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoomTypeId);
      }
      if (RoomTypeName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomTypeName);
      }
      if (connectedRoom_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConnectedRoom);
      }
      if (TrunkId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TrunkId);
      }
      if (occupyingReservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OccupyingReservation);
      }
      if (KcrRoomNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KcrRoomNumber);
      }
      if (RoomStatusCode.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(RoomStatusCode);
      }
      if (roomStatus_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RoomStatus);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Room other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.RoomNumber.Length != 0) {
        RoomNumber = other.RoomNumber;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.AdditionalDescription.Length != 0) {
        AdditionalDescription = other.AdditionalDescription;
      }
      if (other.NightsOccupiedCounter != 0) {
        NightsOccupiedCounter = other.NightsOccupiedCounter;
      }
      if (other.lastCleanedAt_ != null) {
        if (lastCleanedAt_ == null) {
          lastCleanedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastCleanedAt.MergeFrom(other.LastCleanedAt);
      }
      if (other.OccupancyState != 0) {
        OccupancyState = other.OccupancyState;
      }
      if (other.MaintenanceState != 0) {
        MaintenanceState = other.MaintenanceState;
      }
      if (other.MaintenanceRequest != 0) {
        MaintenanceRequest = other.MaintenanceRequest;
      }
      if (other.roomTypeId_ != null) {
        if (roomTypeId_ == null) {
          roomTypeId_ = new global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator();
        }
        RoomTypeId.MergeFrom(other.RoomTypeId);
      }
      if (other.RoomTypeName.Length != 0) {
        RoomTypeName = other.RoomTypeName;
      }
      if (other.connectedRoom_ != null) {
        if (connectedRoom_ == null) {
          connectedRoom_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
        }
        ConnectedRoom.MergeFrom(other.ConnectedRoom);
      }
      if (other.TrunkId.Length != 0) {
        TrunkId = other.TrunkId;
      }
      if (other.occupyingReservation_ != null) {
        if (occupyingReservation_ == null) {
          occupyingReservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        OccupyingReservation.MergeFrom(other.OccupyingReservation);
      }
      if (other.KcrRoomNumber.Length != 0) {
        KcrRoomNumber = other.KcrRoomNumber;
      }
      if (other.RoomStatusCode.Length != 0) {
        RoomStatusCode = other.RoomStatusCode;
      }
      if (other.roomStatus_ != null) {
        if (roomStatus_ == null) {
          roomStatus_ = new global::HOLMS.Types.TenancyConfig.RoomStatus();
        }
        RoomStatus.MergeFrom(other.RoomStatus);
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
              entityId_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            RoomNumber = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 34: {
            AdditionalDescription = input.ReadString();
            break;
          }
          case 40: {
            NightsOccupiedCounter = input.ReadInt32();
            break;
          }
          case 50: {
            if (lastCleanedAt_ == null) {
              lastCleanedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(lastCleanedAt_);
            break;
          }
          case 56: {
            occupancyState_ = (global::HOLMS.Types.Operations.RoomOccupancyState) input.ReadEnum();
            break;
          }
          case 64: {
            maintenanceState_ = (global::HOLMS.Types.Operations.RoomMaintenanceState) input.ReadEnum();
            break;
          }
          case 72: {
            maintenanceRequest_ = (global::HOLMS.Types.Operations.RoomMaintenanceRequest) input.ReadEnum();
            break;
          }
          case 82: {
            if (roomTypeId_ == null) {
              roomTypeId_ = new global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator();
            }
            input.ReadMessage(roomTypeId_);
            break;
          }
          case 90: {
            RoomTypeName = input.ReadString();
            break;
          }
          case 98: {
            if (connectedRoom_ == null) {
              connectedRoom_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(connectedRoom_);
            break;
          }
          case 106: {
            TrunkId = input.ReadString();
            break;
          }
          case 114: {
            if (occupyingReservation_ == null) {
              occupyingReservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(occupyingReservation_);
            break;
          }
          case 122: {
            KcrRoomNumber = input.ReadString();
            break;
          }
          case 130: {
            RoomStatusCode = input.ReadString();
            break;
          }
          case 138: {
            if (roomStatus_ == null) {
              roomStatus_ = new global::HOLMS.Types.TenancyConfig.RoomStatus();
            }
            input.ReadMessage(roomStatus_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

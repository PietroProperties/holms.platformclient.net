// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rooms/room_occupancy_changed_notification.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.Rooms {

  /// <summary>Holder for reflection information generated from operations/rooms/room_occupancy_changed_notification.proto</summary>
  public static partial class RoomOccupancyChangedNotificationReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/rooms/room_occupancy_changed_notification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomOccupancyChangedNotificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjpvcGVyYXRpb25zL3Jvb21zL3Jvb21fb2NjdXBhbmN5X2NoYW5nZWRfbm90",
            "aWZpY2F0aW9uLnByb3RvEhxob2xtcy50eXBlcy5vcGVyYXRpb25zLnJvb21z",
            "Gi5ib29raW5nL2luZGljYXRvcnMvcmVzZXJ2YXRpb25faW5kaWNhdG9yLnBy",
            "b3RvGiVvcGVyYXRpb25zL3Jvb21zL3Jvb21faW5kaWNhdG9yLnByb3RvIu0B",
            "CiBSb29tT2NjdXBhbmN5Q2hhbmdlZE5vdGlmaWNhdGlvbhIRCglqX3dfdG9r",
            "ZW4YASABKAkSOQoEcm9vbRgCIAEoCzIrLmhvbG1zLnR5cGVzLm9wZXJhdGlv",
            "bnMucm9vbXMuUm9vbUluZGljYXRvchJJCgtyZXNlcnZhdGlvbhgDIAEoCzI0",
            "LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5SZXNlcnZhdGlvbklu",
            "ZGljYXRvchIwCihvY2N1cGFuY3lfcHJlbWF0ZXJpYWxpemVkX29uX3Jlc2Vy",
            "dmF0aW9uGAQgASgIIuEBChlSb29tS2V5SXNzdWVkTm90aWZpY2F0aW9uEhEK",
            "CWpfd190b2tlbhgBIAEoCRI5CgRyb29tGAIgASgLMisuaG9sbXMudHlwZXMu",
            "b3BlcmF0aW9ucy5yb29tcy5Sb29tSW5kaWNhdG9yEkkKC3Jlc2VydmF0aW9u",
            "GAMgASgLMjQuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3JzLlJlc2Vy",
            "dmF0aW9uSW5kaWNhdG9yEhIKCmlzX25ld19rZXkYBCABKAgSFwoPcXVhbnRp",
            "dHlfaXNzdWVkGAUgASgNQh+qAhxIT0xNUy5UeXBlcy5PcGVyYXRpb25zLlJv",
            "b21zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.Rooms.RoomOccupancyChangedNotification), global::HOLMS.Types.Operations.Rooms.RoomOccupancyChangedNotification.Parser, new[]{ "JWToken", "Room", "Reservation", "OccupancyPrematerializedOnReservation" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.Rooms.RoomKeyIssuedNotification), global::HOLMS.Types.Operations.Rooms.RoomKeyIssuedNotification.Parser, new[]{ "JWToken", "Room", "Reservation", "IsNewKey", "QuantityIssued" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoomOccupancyChangedNotification : pb::IMessage<RoomOccupancyChangedNotification> {
    private static readonly pb::MessageParser<RoomOccupancyChangedNotification> _parser = new pb::MessageParser<RoomOccupancyChangedNotification>(() => new RoomOccupancyChangedNotification());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomOccupancyChangedNotification> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.Rooms.RoomOccupancyChangedNotificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomOccupancyChangedNotification() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomOccupancyChangedNotification(RoomOccupancyChangedNotification other) : this() {
      jWToken_ = other.jWToken_;
      Room = other.room_ != null ? other.Room.Clone() : null;
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      occupancyPrematerializedOnReservation_ = other.occupancyPrematerializedOnReservation_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomOccupancyChangedNotification Clone() {
      return new RoomOccupancyChangedNotification(this);
    }

    /// <summary>Field number for the "j_w_token" field.</summary>
    public const int JWTokenFieldNumber = 1;
    private string jWToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JWToken {
      get { return jWToken_; }
      set {
        jWToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 2;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 3;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    /// <summary>Field number for the "occupancy_prematerialized_on_reservation" field.</summary>
    public const int OccupancyPrematerializedOnReservationFieldNumber = 4;
    private bool occupancyPrematerializedOnReservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool OccupancyPrematerializedOnReservation {
      get { return occupancyPrematerializedOnReservation_; }
      set {
        occupancyPrematerializedOnReservation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomOccupancyChangedNotification);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomOccupancyChangedNotification other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JWToken != other.JWToken) return false;
      if (!object.Equals(Room, other.Room)) return false;
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (OccupancyPrematerializedOnReservation != other.OccupancyPrematerializedOnReservation) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (JWToken.Length != 0) hash ^= JWToken.GetHashCode();
      if (room_ != null) hash ^= Room.GetHashCode();
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (OccupancyPrematerializedOnReservation != false) hash ^= OccupancyPrematerializedOnReservation.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (JWToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JWToken);
      }
      if (room_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Room);
      }
      if (reservation_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Reservation);
      }
      if (OccupancyPrematerializedOnReservation != false) {
        output.WriteRawTag(32);
        output.WriteBool(OccupancyPrematerializedOnReservation);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (JWToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JWToken);
      }
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      if (OccupancyPrematerializedOnReservation != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomOccupancyChangedNotification other) {
      if (other == null) {
        return;
      }
      if (other.JWToken.Length != 0) {
        JWToken = other.JWToken;
      }
      if (other.room_ != null) {
        if (room_ == null) {
          room_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
        }
        Room.MergeFrom(other.Room);
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      if (other.OccupancyPrematerializedOnReservation != false) {
        OccupancyPrematerializedOnReservation = other.OccupancyPrematerializedOnReservation;
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
            JWToken = input.ReadString();
            break;
          }
          case 18: {
            if (room_ == null) {
              room_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(room_);
            break;
          }
          case 26: {
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
          case 32: {
            OccupancyPrematerializedOnReservation = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomKeyIssuedNotification : pb::IMessage<RoomKeyIssuedNotification> {
    private static readonly pb::MessageParser<RoomKeyIssuedNotification> _parser = new pb::MessageParser<RoomKeyIssuedNotification>(() => new RoomKeyIssuedNotification());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomKeyIssuedNotification> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.Rooms.RoomOccupancyChangedNotificationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomKeyIssuedNotification() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomKeyIssuedNotification(RoomKeyIssuedNotification other) : this() {
      jWToken_ = other.jWToken_;
      Room = other.room_ != null ? other.Room.Clone() : null;
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      isNewKey_ = other.isNewKey_;
      quantityIssued_ = other.quantityIssued_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomKeyIssuedNotification Clone() {
      return new RoomKeyIssuedNotification(this);
    }

    /// <summary>Field number for the "j_w_token" field.</summary>
    public const int JWTokenFieldNumber = 1;
    private string jWToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JWToken {
      get { return jWToken_; }
      set {
        jWToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 2;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 3;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    /// <summary>Field number for the "is_new_key" field.</summary>
    public const int IsNewKeyFieldNumber = 4;
    private bool isNewKey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsNewKey {
      get { return isNewKey_; }
      set {
        isNewKey_ = value;
      }
    }

    /// <summary>Field number for the "quantity_issued" field.</summary>
    public const int QuantityIssuedFieldNumber = 5;
    private uint quantityIssued_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint QuantityIssued {
      get { return quantityIssued_; }
      set {
        quantityIssued_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomKeyIssuedNotification);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomKeyIssuedNotification other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JWToken != other.JWToken) return false;
      if (!object.Equals(Room, other.Room)) return false;
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (IsNewKey != other.IsNewKey) return false;
      if (QuantityIssued != other.QuantityIssued) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (JWToken.Length != 0) hash ^= JWToken.GetHashCode();
      if (room_ != null) hash ^= Room.GetHashCode();
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (IsNewKey != false) hash ^= IsNewKey.GetHashCode();
      if (QuantityIssued != 0) hash ^= QuantityIssued.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (JWToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JWToken);
      }
      if (room_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Room);
      }
      if (reservation_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Reservation);
      }
      if (IsNewKey != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsNewKey);
      }
      if (QuantityIssued != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(QuantityIssued);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (JWToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JWToken);
      }
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      if (IsNewKey != false) {
        size += 1 + 1;
      }
      if (QuantityIssued != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuantityIssued);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomKeyIssuedNotification other) {
      if (other == null) {
        return;
      }
      if (other.JWToken.Length != 0) {
        JWToken = other.JWToken;
      }
      if (other.room_ != null) {
        if (room_ == null) {
          room_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
        }
        Room.MergeFrom(other.Room);
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      if (other.IsNewKey != false) {
        IsNewKey = other.IsNewKey;
      }
      if (other.QuantityIssued != 0) {
        QuantityIssued = other.QuantityIssued;
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
            JWToken = input.ReadString();
            break;
          }
          case 18: {
            if (room_ == null) {
              room_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(room_);
            break;
          }
          case 26: {
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
          case 32: {
            IsNewKey = input.ReadBool();
            break;
          }
          case 40: {
            QuantityIssued = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rpc/room_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.RPC {

  /// <summary>Holder for reflection information generated from operations/rpc/room_svc.proto</summary>
  public static partial class RoomSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/rpc/room_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1vcGVyYXRpb25zL3JwYy9yb29tX3N2Yy5wcm90bxIaaG9sbXMudHlwZXMu",
            "b3BlcmF0aW9ucy5ycGMaKnByaW1pdGl2ZS9zZXJ2ZXJfYWN0aW9uX2NvbmZp",
            "cm1hdGlvbi5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGhtv",
            "cGVyYXRpb25zL3Jvb21zL3Jvb20ucHJvdG8aJW9wZXJhdGlvbnMvcm9vbXMv",
            "cm9vbV9pbmRpY2F0b3IucHJvdG8aLmJvb2tpbmcvaW5kaWNhdG9ycy9yZXNl",
            "cnZhdGlvbl9pbmRpY2F0b3IucHJvdG8aHXByaW1pdGl2ZS9wYl9sb2NhbF9k",
            "YXRlLnByb3RvIkcKElJvb21TdmNBbGxSZXNwb25zZRIxCgVyb29tcxgBIAMo",
            "CzIiLmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMucm9vbXMuUm9vbSKLAQoTUm9v",
            "bVN2Y0NSVURSZXNwb25zZRJCCgtjcnVkX3Jlc3VsdBgBIAEoDjItLmhvbG1z",
            "LnR5cGVzLm9wZXJhdGlvbnMucnBjLlJvb21TdmNDUlVEUmVzdWx0EjAKBHJv",
            "b20YAiABKAsyIi5ob2xtcy50eXBlcy5vcGVyYXRpb25zLnJvb21zLlJvb20i",
            "6gEKF1Jvb21TdmNPY2N1cGFuY3lSZXF1ZXN0EjkKBHJvb20YASABKAsyKy5o",
            "b2xtcy50eXBlcy5vcGVyYXRpb25zLnJvb21zLlJvb21JbmRpY2F0b3ISSQoL",
            "cmVzZXJ2YXRpb24YAiABKAsyNC5ob2xtcy50eXBlcy5ib29raW5nLmluZGlj",
            "YXRvcnMuUmVzZXJ2YXRpb25JbmRpY2F0b3ISSQodcmVzZXJ2YXRpb25fZGVw",
            "YXJ0dXJlX29wc2RhdGUYAyABKAsyIi5ob2xtcy50eXBlcy5wcmltaXRpdmUu",
            "UGJMb2NhbERhdGUiaAodUm9vbVN2Y0NsYWltT2NjdXBhbmN5UmVzcG9uc2US",
            "RwoGcmVzdWx0GAEgASgOMjcuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ycGMu",
            "Um9vbVN2Y09jY3VwYW5jeUNsYWltUmVzdWx0ImwKH1Jvb21TdmNSZWxlYXNl",
            "T2NjdXBhbmN5UmVzcG9uc2USSQoGcmVzdWx0GAEgASgOMjkuaG9sbXMudHlw",
            "ZXMub3BlcmF0aW9ucy5ycGMuUm9vbVN2Y09jY3VwYW5jeVJlbGVhc2VSZXN1",
            "bHQiiAEKKFJvb21TdmNHZXRCeU9jY3VweWluZ1Jlc2VydmF0aW9uUmVzcG9u",
            "c2USIgoacmVzZXJ2YXRpb25faGFzX3Jvb21fY2xhaW0YASABKAgSOAoMY2xh",
            "aW1lZF9yb29tGAIgASgLMiIuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5yb29t",
            "cy5Sb29tKlAKEVJvb21TdmNDUlVEUmVzdWx0EhAKDENSVURfU1VDQ0VTUxAA",
            "EhEKDVVOS05PV05fRVJST1IQARIWChJEVVBMSUNBVEVfVFJVTktfSUQQAiqV",
            "AQobUm9vbVN2Y09jY3VwYW5jeUNsYWltUmVzdWx0EhsKF09DQ1VQQU5DWV9D",
            "TEFJTV9TVUNDRVNTEAASHgoaRkFJTF9ST09NX0FMUkVBRFlfT0NDVVBJRUQQ",
            "ARInCiNGQUlMX1JFU0VSVkFUSU9OX0hBU19FWElTVElOR19DTEFJTRACEhAK",
            "DEZBSUxfVU5LTk9XThADKqQBCh1Sb29tU3ZjT2NjdXBhbmN5UmVsZWFzZVJl",
            "c3VsdBIdChlPQ0NVUEFOQ1lfUkVMRUFTRV9TVUNDRVNTEAASJAogRkFJTF9O",
            "T19FWElTVElOR19PQ0NVUEFOQ1lfQ0xBSU0QARItCilGQUlMX1JFU0VSVkFU",
            "SU9OX09DQ1VQWUlOR19ESUZGRVJFTlRfUk9PTRACEg8KC0ZBSUxfVU5OT1dO",
            "EAQyoQYKB1Jvb21TdmMSTQoDQWxsEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5",
            "Gi4uaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ycGMuUm9vbVN2Y0FsbFJlc3Bv",
            "bnNlEl0KBkNyZWF0ZRIiLmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMucm9vbXMu",
            "Um9vbRovLmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMucnBjLlJvb21TdmNDUlVE",
            "UmVzcG9uc2USXQoGVXBkYXRlEiIuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5y",
            "b29tcy5Sb29tGi8uaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ycGMuUm9vbVN2",
            "Y0NSVURSZXNwb25zZRJdCgZEZWxldGUSIi5ob2xtcy50eXBlcy5vcGVyYXRp",
            "b25zLnJvb21zLlJvb20aLy5ob2xtcy50eXBlcy5wcmltaXRpdmUuU2VydmVy",
            "QWN0aW9uQ29uZmlybWF0aW9uEpcBChlHZXRCeU9jY3VweWluZ1Jlc2VydmF0",
            "aW9uEjQuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3JzLlJlc2VydmF0",
            "aW9uSW5kaWNhdG9yGkQuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ycGMuUm9v",
            "bVN2Y0dldEJ5T2NjdXB5aW5nUmVzZXJ2YXRpb25SZXNwb25zZRKEAQoSQ2xh",
            "aW1Sb29tT2NjdXBhbmN5EjMuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ycGMu",
            "Um9vbVN2Y09jY3VwYW5jeVJlcXVlc3QaOS5ob2xtcy50eXBlcy5vcGVyYXRp",
            "b25zLnJwYy5Sb29tU3ZjQ2xhaW1PY2N1cGFuY3lSZXNwb25zZRKIAQoUUmVs",
            "ZWFzZVJvb21PY2N1cGFuY3kSMy5ob2xtcy50eXBlcy5vcGVyYXRpb25zLnJw",
            "Yy5Sb29tU3ZjT2NjdXBhbmN5UmVxdWVzdBo7LmhvbG1zLnR5cGVzLm9wZXJh",
            "dGlvbnMucnBjLlJvb21TdmNSZWxlYXNlT2NjdXBhbmN5UmVzcG9uc2VCLVoO",
            "b3BlcmF0aW9ucy9ycGOqAhpIT0xNUy5UeXBlcy5PcGVyYXRpb25zLlJQQ2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.ServerActionConfirmationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Operations.RPC.RoomSvcCRUDResult), typeof(global::HOLMS.Types.Operations.RPC.RoomSvcOccupancyClaimResult), typeof(global::HOLMS.Types.Operations.RPC.RoomSvcOccupancyReleaseResult), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.RoomSvcAllResponse), global::HOLMS.Types.Operations.RPC.RoomSvcAllResponse.Parser, new[]{ "Rooms" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.RoomSvcCRUDResponse), global::HOLMS.Types.Operations.RPC.RoomSvcCRUDResponse.Parser, new[]{ "CrudResult", "Room" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.RoomSvcOccupancyRequest), global::HOLMS.Types.Operations.RPC.RoomSvcOccupancyRequest.Parser, new[]{ "Room", "Reservation", "ReservationDepartureOpsdate" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.RoomSvcClaimOccupancyResponse), global::HOLMS.Types.Operations.RPC.RoomSvcClaimOccupancyResponse.Parser, new[]{ "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.RoomSvcReleaseOccupancyResponse), global::HOLMS.Types.Operations.RPC.RoomSvcReleaseOccupancyResponse.Parser, new[]{ "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.RoomSvcGetByOccupyingReservationResponse), global::HOLMS.Types.Operations.RPC.RoomSvcGetByOccupyingReservationResponse.Parser, new[]{ "ReservationHasRoomClaim", "ClaimedRoom" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum RoomSvcCRUDResult {
    [pbr::OriginalName("CRUD_SUCCESS")] CrudSuccess = 0,
    [pbr::OriginalName("UNKNOWN_ERROR")] UnknownError = 1,
    [pbr::OriginalName("DUPLICATE_TRUNK_ID")] DuplicateTrunkId = 2,
  }

  public enum RoomSvcOccupancyClaimResult {
    [pbr::OriginalName("OCCUPANCY_CLAIM_SUCCESS")] OccupancyClaimSuccess = 0,
    [pbr::OriginalName("FAIL_ROOM_ALREADY_OCCUPIED")] FailRoomAlreadyOccupied = 1,
    [pbr::OriginalName("FAIL_RESERVATION_HAS_EXISTING_CLAIM")] FailReservationHasExistingClaim = 2,
    [pbr::OriginalName("FAIL_UNKNOWN")] FailUnknown = 3,
  }

  public enum RoomSvcOccupancyReleaseResult {
    [pbr::OriginalName("OCCUPANCY_RELEASE_SUCCESS")] OccupancyReleaseSuccess = 0,
    [pbr::OriginalName("FAIL_NO_EXISTING_OCCUPANCY_CLAIM")] FailNoExistingOccupancyClaim = 1,
    [pbr::OriginalName("FAIL_RESERVATION_OCCUPYING_DIFFERENT_ROOM")] FailReservationOccupyingDifferentRoom = 2,
    [pbr::OriginalName("FAIL_UNNOWN")] FailUnnown = 4,
  }

  #endregion

  #region Messages
  public sealed partial class RoomSvcAllResponse : pb::IMessage<RoomSvcAllResponse> {
    private static readonly pb::MessageParser<RoomSvcAllResponse> _parser = new pb::MessageParser<RoomSvcAllResponse>(() => new RoomSvcAllResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomSvcAllResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.RoomSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcAllResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcAllResponse(RoomSvcAllResponse other) : this() {
      rooms_ = other.rooms_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcAllResponse Clone() {
      return new RoomSvcAllResponse(this);
    }

    /// <summary>Field number for the "rooms" field.</summary>
    public const int RoomsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Operations.Rooms.Room> _repeated_rooms_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Operations.Rooms.Room.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Operations.Rooms.Room> rooms_ = new pbc::RepeatedField<global::HOLMS.Types.Operations.Rooms.Room>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Operations.Rooms.Room> Rooms {
      get { return rooms_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomSvcAllResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomSvcAllResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!rooms_.Equals(other.rooms_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= rooms_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      rooms_.WriteTo(output, _repeated_rooms_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += rooms_.CalculateSize(_repeated_rooms_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomSvcAllResponse other) {
      if (other == null) {
        return;
      }
      rooms_.Add(other.rooms_);
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
            rooms_.AddEntriesFrom(input, _repeated_rooms_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomSvcCRUDResponse : pb::IMessage<RoomSvcCRUDResponse> {
    private static readonly pb::MessageParser<RoomSvcCRUDResponse> _parser = new pb::MessageParser<RoomSvcCRUDResponse>(() => new RoomSvcCRUDResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomSvcCRUDResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.RoomSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcCRUDResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcCRUDResponse(RoomSvcCRUDResponse other) : this() {
      crudResult_ = other.crudResult_;
      Room = other.room_ != null ? other.Room.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcCRUDResponse Clone() {
      return new RoomSvcCRUDResponse(this);
    }

    /// <summary>Field number for the "crud_result" field.</summary>
    public const int CrudResultFieldNumber = 1;
    private global::HOLMS.Types.Operations.RPC.RoomSvcCRUDResult crudResult_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.RPC.RoomSvcCRUDResult CrudResult {
      get { return crudResult_; }
      set {
        crudResult_ = value;
      }
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 2;
    private global::HOLMS.Types.Operations.Rooms.Room room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.Room Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomSvcCRUDResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomSvcCRUDResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CrudResult != other.CrudResult) return false;
      if (!object.Equals(Room, other.Room)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CrudResult != 0) hash ^= CrudResult.GetHashCode();
      if (room_ != null) hash ^= Room.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CrudResult != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) CrudResult);
      }
      if (room_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Room);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CrudResult != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CrudResult);
      }
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomSvcCRUDResponse other) {
      if (other == null) {
        return;
      }
      if (other.CrudResult != 0) {
        CrudResult = other.CrudResult;
      }
      if (other.room_ != null) {
        if (room_ == null) {
          room_ = new global::HOLMS.Types.Operations.Rooms.Room();
        }
        Room.MergeFrom(other.Room);
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
            crudResult_ = (global::HOLMS.Types.Operations.RPC.RoomSvcCRUDResult) input.ReadEnum();
            break;
          }
          case 18: {
            if (room_ == null) {
              room_ = new global::HOLMS.Types.Operations.Rooms.Room();
            }
            input.ReadMessage(room_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomSvcOccupancyRequest : pb::IMessage<RoomSvcOccupancyRequest> {
    private static readonly pb::MessageParser<RoomSvcOccupancyRequest> _parser = new pb::MessageParser<RoomSvcOccupancyRequest>(() => new RoomSvcOccupancyRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomSvcOccupancyRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.RoomSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcOccupancyRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcOccupancyRequest(RoomSvcOccupancyRequest other) : this() {
      Room = other.room_ != null ? other.Room.Clone() : null;
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      ReservationDepartureOpsdate = other.reservationDepartureOpsdate_ != null ? other.ReservationDepartureOpsdate.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcOccupancyRequest Clone() {
      return new RoomSvcOccupancyRequest(this);
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 1;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator Room {
      get { return room_; }
      set {
        room_ = value;
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

    /// <summary>Field number for the "reservation_departure_opsdate" field.</summary>
    public const int ReservationDepartureOpsdateFieldNumber = 3;
    private global::HOLMS.Types.Primitive.PbLocalDate reservationDepartureOpsdate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate ReservationDepartureOpsdate {
      get { return reservationDepartureOpsdate_; }
      set {
        reservationDepartureOpsdate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomSvcOccupancyRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomSvcOccupancyRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Room, other.Room)) return false;
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (!object.Equals(ReservationDepartureOpsdate, other.ReservationDepartureOpsdate)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (room_ != null) hash ^= Room.GetHashCode();
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (reservationDepartureOpsdate_ != null) hash ^= ReservationDepartureOpsdate.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (room_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Room);
      }
      if (reservation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Reservation);
      }
      if (reservationDepartureOpsdate_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ReservationDepartureOpsdate);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      if (reservationDepartureOpsdate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReservationDepartureOpsdate);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomSvcOccupancyRequest other) {
      if (other == null) {
        return;
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
      if (other.reservationDepartureOpsdate_ != null) {
        if (reservationDepartureOpsdate_ == null) {
          reservationDepartureOpsdate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        ReservationDepartureOpsdate.MergeFrom(other.ReservationDepartureOpsdate);
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
            if (room_ == null) {
              room_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(room_);
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
            if (reservationDepartureOpsdate_ == null) {
              reservationDepartureOpsdate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(reservationDepartureOpsdate_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomSvcClaimOccupancyResponse : pb::IMessage<RoomSvcClaimOccupancyResponse> {
    private static readonly pb::MessageParser<RoomSvcClaimOccupancyResponse> _parser = new pb::MessageParser<RoomSvcClaimOccupancyResponse>(() => new RoomSvcClaimOccupancyResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomSvcClaimOccupancyResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.RoomSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcClaimOccupancyResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcClaimOccupancyResponse(RoomSvcClaimOccupancyResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcClaimOccupancyResponse Clone() {
      return new RoomSvcClaimOccupancyResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Operations.RPC.RoomSvcOccupancyClaimResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.RPC.RoomSvcOccupancyClaimResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomSvcClaimOccupancyResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomSvcClaimOccupancyResponse other) {
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
    public void MergeFrom(RoomSvcClaimOccupancyResponse other) {
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
            result_ = (global::HOLMS.Types.Operations.RPC.RoomSvcOccupancyClaimResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomSvcReleaseOccupancyResponse : pb::IMessage<RoomSvcReleaseOccupancyResponse> {
    private static readonly pb::MessageParser<RoomSvcReleaseOccupancyResponse> _parser = new pb::MessageParser<RoomSvcReleaseOccupancyResponse>(() => new RoomSvcReleaseOccupancyResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomSvcReleaseOccupancyResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.RoomSvcReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcReleaseOccupancyResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcReleaseOccupancyResponse(RoomSvcReleaseOccupancyResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcReleaseOccupancyResponse Clone() {
      return new RoomSvcReleaseOccupancyResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Operations.RPC.RoomSvcOccupancyReleaseResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.RPC.RoomSvcOccupancyReleaseResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomSvcReleaseOccupancyResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomSvcReleaseOccupancyResponse other) {
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
    public void MergeFrom(RoomSvcReleaseOccupancyResponse other) {
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
            result_ = (global::HOLMS.Types.Operations.RPC.RoomSvcOccupancyReleaseResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomSvcGetByOccupyingReservationResponse : pb::IMessage<RoomSvcGetByOccupyingReservationResponse> {
    private static readonly pb::MessageParser<RoomSvcGetByOccupyingReservationResponse> _parser = new pb::MessageParser<RoomSvcGetByOccupyingReservationResponse>(() => new RoomSvcGetByOccupyingReservationResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomSvcGetByOccupyingReservationResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.RoomSvcReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcGetByOccupyingReservationResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcGetByOccupyingReservationResponse(RoomSvcGetByOccupyingReservationResponse other) : this() {
      reservationHasRoomClaim_ = other.reservationHasRoomClaim_;
      ClaimedRoom = other.claimedRoom_ != null ? other.ClaimedRoom.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomSvcGetByOccupyingReservationResponse Clone() {
      return new RoomSvcGetByOccupyingReservationResponse(this);
    }

    /// <summary>Field number for the "reservation_has_room_claim" field.</summary>
    public const int ReservationHasRoomClaimFieldNumber = 1;
    private bool reservationHasRoomClaim_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ReservationHasRoomClaim {
      get { return reservationHasRoomClaim_; }
      set {
        reservationHasRoomClaim_ = value;
      }
    }

    /// <summary>Field number for the "claimed_room" field.</summary>
    public const int ClaimedRoomFieldNumber = 2;
    private global::HOLMS.Types.Operations.Rooms.Room claimedRoom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.Room ClaimedRoom {
      get { return claimedRoom_; }
      set {
        claimedRoom_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomSvcGetByOccupyingReservationResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomSvcGetByOccupyingReservationResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReservationHasRoomClaim != other.ReservationHasRoomClaim) return false;
      if (!object.Equals(ClaimedRoom, other.ClaimedRoom)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ReservationHasRoomClaim != false) hash ^= ReservationHasRoomClaim.GetHashCode();
      if (claimedRoom_ != null) hash ^= ClaimedRoom.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ReservationHasRoomClaim != false) {
        output.WriteRawTag(8);
        output.WriteBool(ReservationHasRoomClaim);
      }
      if (claimedRoom_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ClaimedRoom);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ReservationHasRoomClaim != false) {
        size += 1 + 1;
      }
      if (claimedRoom_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClaimedRoom);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomSvcGetByOccupyingReservationResponse other) {
      if (other == null) {
        return;
      }
      if (other.ReservationHasRoomClaim != false) {
        ReservationHasRoomClaim = other.ReservationHasRoomClaim;
      }
      if (other.claimedRoom_ != null) {
        if (claimedRoom_ == null) {
          claimedRoom_ = new global::HOLMS.Types.Operations.Rooms.Room();
        }
        ClaimedRoom.MergeFrom(other.ClaimedRoom);
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
            ReservationHasRoomClaim = input.ReadBool();
            break;
          }
          case 18: {
            if (claimedRoom_ == null) {
              claimedRoom_ = new global::HOLMS.Types.Operations.Rooms.Room();
            }
            input.ReadMessage(claimedRoom_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

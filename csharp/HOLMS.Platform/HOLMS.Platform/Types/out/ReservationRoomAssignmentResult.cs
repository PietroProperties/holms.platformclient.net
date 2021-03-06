// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/room_claims/reservation_room_assignment_result.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.RoomClaims {

  /// <summary>Holder for reflection information generated from operations/room_claims/reservation_room_assignment_result.proto</summary>
  public static partial class ReservationRoomAssignmentResultReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/room_claims/reservation_room_assignment_result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationRoomAssignmentResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9vcGVyYXRpb25zL3Jvb21fY2xhaW1zL3Jlc2VydmF0aW9uX3Jvb21fYXNz",
            "aWdubWVudF9yZXN1bHQucHJvdG8SImhvbG1zLnR5cGVzLm9wZXJhdGlvbnMu",
            "cm9vbV9jbGFpbXMqjAMKH1Jlc2VydmF0aW9uUm9vbUFzc2lnbm1lbnRSZXN1",
            "bHQSGwoXUk9PTV9BU1NJR05NRU5UX1NVQ0NFU1MQABIoCiRST09NX0FTU0lH",
            "Tk1FTlRfTUFJTlRFTkFOQ0VfQ09ORkxJQ1QQARIoCiRST09NX0FTU0lHTk1F",
            "TlRfUkVTRVJWQVRJT05fQ09ORkxJQ1QQAhI5CjVST09NX0FTU0lHTk1FTlRf",
            "SU5WQUxJRF9SRVFVRVNUX1JFU0VSVkFUSU9OX05PVF9GT1VORBADEjIKLlJP",
            "T01fQVNTSUdOTUVOVF9JTlZBTElEX1JFUVVFU1RfUk9PTV9OT1RfRk9VTkQQ",
            "BBJCCj5ST09NX0FTU0lHTk1FTlRfSU5WQUxJRF9SRVFVRVNUX01VTFRJUExF",
            "X1JFUVVFU1RTX0ZPUl9TQU1FX0RBWRAFEkUKQVJPT01fQVNTSUdOTUVOVF9J",
            "TlZBTElEX1JFUVVFU1RfUkVRVUVTRURfREFURV9PVVRTSURFX1JFU0VSVkFU",
            "SU9OEAZCO1oVb3BlcmF0aW9ucy9yb29tY2xhaW1zqgIhSE9MTVMuVHlwZXMu",
            "T3BlcmF0aW9ucy5Sb29tQ2xhaW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Operations.RoomClaims.ReservationRoomAssignmentResult), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ReservationRoomAssignmentResult {
    [pbr::OriginalName("ROOM_ASSIGNMENT_SUCCESS")] RoomAssignmentSuccess = 0,
    [pbr::OriginalName("ROOM_ASSIGNMENT_MAINTENANCE_CONFLICT")] RoomAssignmentMaintenanceConflict = 1,
    [pbr::OriginalName("ROOM_ASSIGNMENT_RESERVATION_CONFLICT")] RoomAssignmentReservationConflict = 2,
    [pbr::OriginalName("ROOM_ASSIGNMENT_INVALID_REQUEST_RESERVATION_NOT_FOUND")] RoomAssignmentInvalidRequestReservationNotFound = 3,
    [pbr::OriginalName("ROOM_ASSIGNMENT_INVALID_REQUEST_ROOM_NOT_FOUND")] RoomAssignmentInvalidRequestRoomNotFound = 4,
    [pbr::OriginalName("ROOM_ASSIGNMENT_INVALID_REQUEST_MULTIPLE_REQUESTS_FOR_SAME_DAY")] RoomAssignmentInvalidRequestMultipleRequestsForSameDay = 5,
    [pbr::OriginalName("ROOM_ASSIGNMENT_INVALID_REQUEST_REQUESED_DATE_OUTSIDE_RESERVATION")] RoomAssignmentInvalidRequestRequesedDateOutsideReservation = 6,
  }

  #endregion

}

#endregion Designer generated code

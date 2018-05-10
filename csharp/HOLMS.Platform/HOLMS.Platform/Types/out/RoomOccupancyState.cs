// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/room_occupancy_state.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations {

  /// <summary>Holder for reflection information generated from operations/room_occupancy_state.proto</summary>
  public static partial class RoomOccupancyStateReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/room_occupancy_state.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomOccupancyStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVvcGVyYXRpb25zL3Jvb21fb2NjdXBhbmN5X3N0YXRlLnByb3RvEhZob2xt",
            "cy50eXBlcy5vcGVyYXRpb25zKnwKElJvb21PY2N1cGFuY3lTdGF0ZRIaChZP",
            "Q0NVUEFOQ1lfU1RBVEVfVkFDQU5UEAASKAokT0NDVVBBTkNZX1NUQVRFX1JF",
            "U0VSVkFUSU9OX09DQ1VQSUVEEAESIAocT0NDVVBBTkNZX1NUQVRFX09VVF9P",
            "Rl9PUkRFUhACQhmqAhZIT0xNUy5UeXBlcy5PcGVyYXRpb25zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Operations.RoomOccupancyState), }, null));
    }
    #endregion

  }
  #region Enums
  public enum RoomOccupancyState {
    [pbr::OriginalName("OCCUPANCY_STATE_VACANT")] OccupancyStateVacant = 0,
    [pbr::OriginalName("OCCUPANCY_STATE_RESERVATION_OCCUPIED")] OccupancyStateReservationOccupied = 1,
    [pbr::OriginalName("OCCUPANCY_STATE_OUT_OF_ORDER")] OccupancyStateOutOfOrder = 2,
  }

  #endregion

}

#endregion Designer generated code

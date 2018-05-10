using System;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Types.Operations;
using HOLMS.Types.Operations.Rooms;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Platform.Support.DTOBuilders.Operations {
    public class RoomBuilder {
        public RoomIndicator Ind;
        public string Description;
        public string RoomNumber;
        public string AdditionalDescription;
        public int NightsOccupiedCounter;
        public DateTime LastCleanedAt;
        public RoomOccupancyState OccupancyState;
        public RoomMaintenanceState MaintenanceState;
        public RoomMaintenanceRequest MaintenanceRequest;
        public Guid RoomTypeId;
        public string RoomTypeName;
        public RoomIndicator ConnectedRoomInd;
        public string PhoneTrunkID;

        public Room Build() {
            var r = new Room {
                EntityId = Ind,
                Description = Description,
                RoomNumber = RoomNumber,
                OccupancyState = OccupancyState,
                AdditionalDescription = AdditionalDescription,
                NightsOccupiedCounter = NightsOccupiedCounter,
                LastCleanedAt = LastCleanedAt.ToTS(),
                MaintenanceState = MaintenanceState,
                MaintenanceRequest = MaintenanceRequest,
                RoomTypeId = new RoomTypeIndicator(RoomTypeId),
                RoomTypeName = RoomTypeName,
                TrunkId = PhoneTrunkID ?? string.Empty
            };

            if (ConnectedRoomInd != null) {
                r.ConnectedRoom = ConnectedRoomInd;
            }

            return r;
        }

        public RoomBuilder SetConnectedRoom(Guid? connectedRoomId) {
            if (connectedRoomId.HasValue) {
                ConnectedRoomInd = new RoomIndicator(connectedRoomId.Value);
            }
            return this;
        }

        public RoomBuilder SetConnectedRoom(RoomIndicator connectedRoomInd) {
            if (connectedRoomInd != null) {
                ConnectedRoomInd = connectedRoomInd;
            }
            return this;
        }
    }
}

using System;
using HOLMS.Support.Conversions;
using HOLMS.Types.Operations;
using HOLMS.Types.Operations.Rooms;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Support.DTOBuilders.Premises {
    public class RoomBuilder {
        public RoomIndicator Ind;
        public string Description;
        public string RoomNumber;
        public string AdditionalDescription;
        public int NightsOccupiedCounter;
        public DateTime LastCleanedAt;
        public RoomMaintenanceState MaintenanceState;
        public Guid RoomTypeId;
        public string RoomTypeName;
        public RoomIndicator ConnectedRoomInd;
        public string PhoneTrunkID;

        public Room Build() {
            var r = new Room {
                EntityId = Ind,
                Description = Description,
                RoomNumber = RoomNumber,
                AdditionalDescription = AdditionalDescription,
                NightsOccupiedCounter = NightsOccupiedCounter,
                LastCleanedAt = LastCleanedAt.ToTS(),
                MaintenanceState = MaintenanceState,
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

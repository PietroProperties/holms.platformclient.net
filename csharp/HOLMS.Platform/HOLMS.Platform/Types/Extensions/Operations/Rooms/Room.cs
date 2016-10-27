using HOLMS.Types.Extensions;

namespace HOLMS.Types.Operations.Rooms {
    public partial class Room : EntityDTO<RoomIndicator> {
        public override RoomIndicator GetIndicator() {
            return EntityId;
        }
    }
}

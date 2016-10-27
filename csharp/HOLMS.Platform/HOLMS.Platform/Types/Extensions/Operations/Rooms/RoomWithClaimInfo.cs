using HOLMS.Types.Extensions;

namespace HOLMS.Types.Operations.Rooms {
    public partial class RoomWithClaimInfo : EntityDTO<RoomIndicator> {
        public override RoomIndicator GetIndicator() {
            return Room;
        }
    }
}

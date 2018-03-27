using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Supply.RoomTypes {
    public partial class RoomType : EntityDTO<RoomTypeIndicator> {
        public override RoomTypeIndicator GetIndicator() {
            return EntityId;
        }
    }
}

using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Operations.RoomClaims {
    public partial class ContinuousRoomClaim : IBoundByDateRangeMarker {
        public PbInclusiveOpsdateRange PBDateRange => DateRange;
    }
}

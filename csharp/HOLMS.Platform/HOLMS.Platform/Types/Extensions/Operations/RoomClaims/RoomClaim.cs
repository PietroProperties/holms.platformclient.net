using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Operations.RoomClaims {
    public partial class RoomClaim : IBoundByDateRangeMarker {
        public PbInclusiveOpsdateRange PBDateRange => DateRange;
    }
}

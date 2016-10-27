using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Supply {
    public partial class Qualification : IBoundByDateRangeMarker {
        public PbInclusiveOpsdateRange PBDateRange => DateRange;
    }
}

using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking.Pricing {
    public partial class GenesisPriceEstimateRequestDTO : IBoundByDateRangeMarker {
        public PbInclusiveOpsdateRange PBDateRange {
            get {
                return DateRange;
            }
        }
    }
}

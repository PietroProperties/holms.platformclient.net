using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking.Reservations {
    public partial class BookGenesisReservationRequest : IBoundByDateRangeMarker {
        public PbInclusiveOpsdateRange PBDateRange {
            get {
                return DateRange;
            }
        }
    }
}

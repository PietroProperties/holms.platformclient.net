using HOLMS.Platform.Types;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking.IncidentalReservations {
    public partial class IncidentalItemReservation : EntityDTO<IncidentalItemReservationIndicator>, IBoundByDateRangeMarker {
        public PbInclusiveOpsdateRange PBDateRange => DateRange;

        public override IncidentalItemReservationIndicator GetIndicator() => EntityId;
    }
}

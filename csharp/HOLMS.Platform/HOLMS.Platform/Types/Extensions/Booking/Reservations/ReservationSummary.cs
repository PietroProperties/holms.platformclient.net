using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Booking.Reservations {
    public partial class ReservationSummary : EntityDTO<ReservationIndicator> {
        public override ReservationIndicator GetIndicator() {
            return EntityId;
        }
    }
}

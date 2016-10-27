using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Booking.Reservations {
    public partial class CompleteOpenReservation : EntityDTO<ReservationIndicator> {
        public override ReservationIndicator GetIndicator() {
            return EntityId;
        }
    }
}

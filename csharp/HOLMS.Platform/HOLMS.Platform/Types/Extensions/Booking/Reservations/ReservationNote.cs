using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Booking.Reservations {
    public partial class ReservationNote : EntityDTO<ReservationNoteIndicator> {
        public override ReservationNoteIndicator GetIndicator() {
            return EntityId;
        }
    }
}

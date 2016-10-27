using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Booking.Reservations {
    public partial class ReservationContactPerson : EntityDTO<ReservationContactPersonIndicator> {
        public override ReservationContactPersonIndicator GetIndicator() {
            return EntityId;
        }
    }
}

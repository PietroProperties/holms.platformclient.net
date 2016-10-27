using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking.Indicators {
    public partial class ReservationContactPersonIndicator : EntityIndicator<ReservationContactPersonIndicator> {
        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

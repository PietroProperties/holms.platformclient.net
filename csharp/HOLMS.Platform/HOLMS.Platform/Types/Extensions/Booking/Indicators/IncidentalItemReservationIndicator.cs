using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking.Indicators {
    public partial class IncidentalItemReservationIndicator : EntityIndicator<IncidentalItemReservationIndicator> {
        public override Uuid GetUuidID() => Id;
    }
}

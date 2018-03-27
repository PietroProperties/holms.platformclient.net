using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;
using System;
using HOLMS.Platform.Types;

namespace HOLMS.Types.Booking.Indicators {
    public partial class ReservationIndicator : EntityIndicator<ReservationIndicator> {
        public ReservationIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

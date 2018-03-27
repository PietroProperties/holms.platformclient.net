using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Supply {
    public partial class ReservationBookingHoldIndicator : EntityIndicator<ReservationBookingHoldIndicator> {
        public override Uuid GetUuidID() => Id;

        public ReservationBookingHoldIndicator(Guid id) {
            Id = id.ToUUID();
        }
    }
}

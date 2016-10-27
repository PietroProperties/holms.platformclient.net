using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking.Indicators {
    public partial class TravelAgentIndicator : EntityIndicator<TravelAgentIndicator> {
        public TravelAgentIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Booking.Channels {
    public partial class TravelAgent : EntityDTO<TravelAgentIndicator> {
        public override TravelAgentIndicator GetIndicator() => EntityId;
    }
}

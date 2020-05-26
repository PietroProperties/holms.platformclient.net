using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Booking.Channels {
    public partial class OTAProviderRoomTypes : EntityDTO<OTAProviderRoomTypeIndicator> {
        public override OTAProviderRoomTypeIndicator GetIndicator() {
            return EntityId;
        }
    }
}

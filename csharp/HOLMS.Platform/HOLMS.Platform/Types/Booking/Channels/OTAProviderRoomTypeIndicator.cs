using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking.Channels {
    public partial class OTAProviderRoomTypeIndicator : EntityIndicator<OTAProviderRoomTypeIndicator> {
        public OTAProviderRoomTypeIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

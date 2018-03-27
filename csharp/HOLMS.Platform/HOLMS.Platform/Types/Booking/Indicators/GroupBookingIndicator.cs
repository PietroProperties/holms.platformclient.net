using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking.Indicators {
    public partial class GroupBookingIndicator : EntityIndicator<GroupBookingIndicator> {
        public GroupBookingIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

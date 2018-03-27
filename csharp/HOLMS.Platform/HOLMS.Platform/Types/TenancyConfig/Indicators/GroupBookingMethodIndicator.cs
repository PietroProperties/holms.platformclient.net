using HOLMS.Types.Extensions;
using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.TenancyConfig.Indicators {
    public partial class GroupBookingMethodIndicator : EntityIndicator<GroupBookingMethodIndicator> {
        public GroupBookingMethodIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

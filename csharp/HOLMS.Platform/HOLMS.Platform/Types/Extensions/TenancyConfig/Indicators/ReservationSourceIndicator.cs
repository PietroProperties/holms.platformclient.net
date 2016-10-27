using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.TenancyConfig.Indicators {
    public partial class ReservationSourceIndicator : EntityIndicator<ReservationSourceIndicator> {
        public ReservationSourceIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

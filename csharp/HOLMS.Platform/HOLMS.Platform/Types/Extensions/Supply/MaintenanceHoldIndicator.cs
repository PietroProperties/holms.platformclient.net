using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Supply {
    public partial class MaintenanceHoldIndicator : EntityIndicator<MaintenanceHoldIndicator> {
        public override Uuid GetUuidID() => Id;

        public MaintenanceHoldIndicator(Guid id) {
            Id = id.ToUUID();
        }
    }
}

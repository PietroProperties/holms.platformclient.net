using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.IAM {
    public partial class StaffMemberIndicator : EntityIndicator<StaffMemberIndicator> {
        public StaffMemberIndicator(Guid g) {
            Id = g.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

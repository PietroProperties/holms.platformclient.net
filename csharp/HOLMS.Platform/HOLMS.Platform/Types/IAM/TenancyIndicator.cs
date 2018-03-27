using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;
using System;
using HOLMS.Platform.Types;

namespace HOLMS.Types.IAM {
    public partial class TenancyIndicator : EntityIndicator<TenancyIndicator> {
        public TenancyIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;
using System;
using HOLMS.Platform.Types;

namespace HOLMS.Types.TenancyConfig.Indicators {
    public partial class PropertyIndicator : EntityIndicator<PropertyIndicator> {
        public PropertyIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

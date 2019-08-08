using HOLMS.Types.Extensions;
using System;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Platform.Types;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.TenancyConfig.Indicators {
    public partial class DefaultSettingsIndicator : EntityIndicator<DefaultSettingsIndicator> {
        public DefaultSettingsIndicator(Guid id) : base() {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

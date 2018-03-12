using System;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Supply.Packages {
    public partial class LodgingPackageIndicator : EntityIndicator<LodgingPackageIndicator> {
        public override Uuid GetUuidID() => Id;

        public LodgingPackageIndicator(Guid id) {
            Id = id.ToUUID();
        }
    }
}

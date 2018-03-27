using System;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Operations.PBXEvents {
    public partial class PbxEventIndicator : EntityIndicator<PbxEventIndicator> {
        public PbxEventIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

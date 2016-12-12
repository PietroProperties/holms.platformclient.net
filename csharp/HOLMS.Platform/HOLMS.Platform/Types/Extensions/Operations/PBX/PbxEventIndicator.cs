using System;
using HOLMS.Support.Conversions;
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

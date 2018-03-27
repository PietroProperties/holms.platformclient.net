using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Primitive;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;

namespace HOLMS.Types.Operations.Attractions {
    public partial class AttractionIndicator : EntityIndicator<AttractionIndicator> {
        public AttractionIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

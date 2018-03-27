using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Operations.Attractions {
    public partial class AttractionCategoryIndicator : EntityIndicator<AttractionCategoryIndicator> {
        public AttractionCategoryIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

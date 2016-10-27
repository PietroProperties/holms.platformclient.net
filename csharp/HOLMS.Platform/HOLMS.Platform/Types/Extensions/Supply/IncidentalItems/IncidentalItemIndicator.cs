using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Supply.IncidentalItems {
    public partial class IncidentalItemIndicator : EntityIndicator<IncidentalItemIndicator> {
        public IncidentalItemIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

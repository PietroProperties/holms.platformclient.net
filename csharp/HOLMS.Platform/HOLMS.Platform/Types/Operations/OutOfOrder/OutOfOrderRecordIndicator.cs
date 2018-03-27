using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Operations.OutOfOrder {
    public partial class OutOfOrderRecordIndicator : EntityIndicator<OutOfOrderRecordIndicator> {
        public OutOfOrderRecordIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

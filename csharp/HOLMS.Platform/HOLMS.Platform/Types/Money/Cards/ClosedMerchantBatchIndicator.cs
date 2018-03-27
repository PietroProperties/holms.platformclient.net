using HOLMS.Types.Extensions;
using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Money.Cards.Transactions {
    public partial class ClosedMerchantBatchIndicator : EntityIndicator<ClosedMerchantBatchIndicator> {
        public ClosedMerchantBatchIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

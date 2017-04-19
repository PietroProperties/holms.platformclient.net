using HOLMS.Types.Extensions;
using System;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Money.Cards.Transactions {
    public partial class MerchantBatchIndicator : EntityIndicator<MerchantBatchIndicator> {
        public MerchantBatchIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

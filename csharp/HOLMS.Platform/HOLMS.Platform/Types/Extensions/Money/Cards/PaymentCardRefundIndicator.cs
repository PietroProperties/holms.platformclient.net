using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Money.Cards.Transactions {
    public partial class PaymentCardRefundIndicator : EntityIndicator<PaymentCardRefundIndicator> {
        public PaymentCardRefundIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

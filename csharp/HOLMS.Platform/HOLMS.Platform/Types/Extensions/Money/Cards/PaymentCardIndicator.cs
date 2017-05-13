using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Money.Cards {
    public partial class PaymentCardIndicator : EntityIndicator<PaymentCardIndicator> {
        public PaymentCardIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Money.Cards.Transactions {
    public partial class PaymentCardAuthorizationCaptureIndicator : EntityIndicator<PaymentCardAuthorizationCaptureIndicator> {
        public PaymentCardAuthorizationCaptureIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

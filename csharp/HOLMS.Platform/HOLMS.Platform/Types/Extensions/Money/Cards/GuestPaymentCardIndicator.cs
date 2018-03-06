using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Money.Cards {
    public partial class CustomerPaymentCardIndicator : EntityIndicator<CustomerPaymentCardIndicator> {
        public CustomerPaymentCardIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

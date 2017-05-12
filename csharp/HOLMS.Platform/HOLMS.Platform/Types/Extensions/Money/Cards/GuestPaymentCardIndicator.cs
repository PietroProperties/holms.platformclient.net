using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Money.Cards {
    public partial class GuestPaymentCardIndicator : EntityIndicator<GuestPaymentCardIndicator> {
        public GuestPaymentCardIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

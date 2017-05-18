using HOLMS.Types.Extensions;

namespace HOLMS.Types.Money.Cards {
    public partial class GuestPaymentCard : EntityDTO<GuestPaymentCardIndicator> {
        public override GuestPaymentCardIndicator GetIndicator() {
            return Id;
        }
    }
}

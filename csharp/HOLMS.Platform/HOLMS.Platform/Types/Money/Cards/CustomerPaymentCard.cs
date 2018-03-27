using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Money.Cards {
    public partial class CustomerPaymentCard : EntityDTO<CustomerPaymentCardIndicator> {
        public override CustomerPaymentCardIndicator GetIndicator() {
            return Id;
        }
    }
}

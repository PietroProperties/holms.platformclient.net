using HOLMS.Types.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Types.Money.Cards {
    public partial class TokenizedPaymentCard : EntityDTO<PaymentCardIndicator> {
        public override PaymentCardIndicator GetIndicator() {
            return EntityId;
        }
    }
}

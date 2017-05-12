using HOLMS.Types.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Types.Money.Cards {
    [Obsolete("Convert to guest payment card")]
    public partial class TokenizedPaymentCard : EntityDTO<RawPaymentCardIndicator> {
        public override RawPaymentCardIndicator GetIndicator() {
            return EntityId;
        }
    }
}

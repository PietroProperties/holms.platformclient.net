using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Money.Cards {
    public partial class CardMerchant : EntityDTO<CardMerchantIndicator> {
        public override CardMerchantIndicator GetIndicator() {
            return EntityId;
        }
    }
}

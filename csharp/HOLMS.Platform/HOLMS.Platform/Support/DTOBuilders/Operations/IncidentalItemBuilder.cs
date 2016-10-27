using HOLMS.Support.Conversions;
using HOLMS.Types.Money.Accounting;
using HOLMS.Types.Supply.IncidentalItems;

namespace HOLMS.Support.DTOBuilders.Operations {
    public class IncidentalItemBuilder {
        private readonly IncidentalItemIndicator _entityId;
        private readonly string _itemName;
        private readonly int _quantityOwned;
        private readonly decimal _price;
        private readonly bool _incursTaxes;
        private readonly bool _incursFees;
        private readonly ItemChargeFrequency _itemChargeFrequency;
        private readonly AccountIndicator _revenueAccount;

        public IncidentalItemBuilder(IncidentalItemIndicator ind, string itemName, int quantityOwned,
            decimal price, bool incursTaxes, bool incursFees, ItemChargeFrequency chargeFrequency,
            AccountIndicator revenueAccount) {
            _entityId = ind;
            _itemName = itemName;
            _quantityOwned = quantityOwned;
            _price = price;
            _incursTaxes = incursTaxes;
            _incursFees = incursFees;
            _itemChargeFrequency = chargeFrequency;
            _revenueAccount = revenueAccount;
        }

        public IncidentalItem Build() {
            var item = new IncidentalItem {
                EntityId = _entityId,
                Description = _itemName ?? string.Empty,
                QuanityOwned = (uint) _quantityOwned,
                Price = _price.ToMoney(),
                IncursTaxes = _incursTaxes,
                IncursFees = _incursFees,
                ChargeFrequency = _itemChargeFrequency
            };

            if (_revenueAccount != null) {
                item.RevenueAccount = _revenueAccount;
            }

            return item;
        }
    }
}

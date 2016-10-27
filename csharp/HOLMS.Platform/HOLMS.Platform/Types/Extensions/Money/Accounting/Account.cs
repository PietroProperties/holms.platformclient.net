using HOLMS.Types.Extensions;

namespace HOLMS.Types.Money.Accounting {
    public partial class Account : EntityDTO<AccountIndicator>{
        public override AccountIndicator GetIndicator() {
            return EntityId;
        }
    }
}

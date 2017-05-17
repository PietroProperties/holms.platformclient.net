using HOLMS.Types.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Types.Money.Accounting {
    public partial class AccountingTransactionLine : EntityDTO<AccountingTransactionLineIndicator> {
        public override AccountingTransactionLineIndicator GetIndicator() {
            return EntityId;
        }
    }
}

using HOLMS.Types.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOLMS.Types.Primitive;
using HOLMS.Support.Conversions;

namespace HOLMS.Types.Money.Accounting {
    public partial class AccountingTransactionLineIndicator : EntityIndicator<AccountingTransactionLineIndicator> {
        public AccountingTransactionLineIndicator(Guid id) {
            Id = id.ToUUID();
        }
        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

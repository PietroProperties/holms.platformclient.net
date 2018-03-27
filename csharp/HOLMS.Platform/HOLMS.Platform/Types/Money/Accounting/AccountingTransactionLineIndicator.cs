using HOLMS.Types.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Platform.Types;
using HOLMS.Types.Primitive;

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

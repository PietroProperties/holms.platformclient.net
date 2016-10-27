using HOLMS.Types.Extensions;
using System;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Money.Accounting {
    public partial class TaxFeeIndicator : EntityIndicator<TaxFeeIndicator> {
        public TaxFeeIndicator(Guid id) {
            Id = id.ToUUID();
        }


        public override Uuid GetUuidID() => Id;
    }
}

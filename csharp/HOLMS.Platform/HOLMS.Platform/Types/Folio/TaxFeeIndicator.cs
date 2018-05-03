using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Folio {
    public partial class TaxFeeIndicator : EntityIndicator<TaxFeeIndicator> {
        public TaxFeeIndicator(Guid id) {
            Id = id.ToUUID();
        }


        public override Uuid GetUuidID() => Id;
    }
}

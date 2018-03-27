using HOLMS.Types.Extensions;
using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;
using HOLMS.Types.Folio;

namespace HOLMS.Types.Folio {
    public partial class TaxFeeIndicator : EntityIndicator<TaxFeeIndicator> {
        public TaxFeeIndicator(Guid id) {
            Id = id.ToUUID();
        }


        public override Uuid GetUuidID() => Id;
    }
}

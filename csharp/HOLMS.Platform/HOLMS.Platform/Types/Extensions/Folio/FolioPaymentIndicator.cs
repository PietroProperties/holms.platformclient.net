using System;
using HOLMS.Support.Conversions;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Folio {
    public partial class FolioPaymentIndicator : EntityIndicator<FolioPaymentIndicator> {
        public FolioPaymentIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

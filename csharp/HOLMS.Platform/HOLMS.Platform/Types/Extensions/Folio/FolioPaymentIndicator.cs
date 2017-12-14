using System;
using HOLMS.Support.Conversions;

namespace HOLMS.Types.Folio {
    public partial class FolioPaymentIndicator {
        public FolioPaymentIndicator(Guid id) {
            Id = id.ToUUID();
        }
    }
}

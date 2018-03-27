using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Text;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Platform.Types;

namespace HOLMS.Types.Folio {
    public partial class FolioCheckCashPaymentIndicator : EntityIndicator<FolioCheckCashPaymentIndicator> {
        public FolioCheckCashPaymentIndicator(Guid id) {
            Id = id.ToUUID();
        }
        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

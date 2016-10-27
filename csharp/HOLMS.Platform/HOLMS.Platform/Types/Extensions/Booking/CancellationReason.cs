using System;
using HOLMS.Types.Extensions.Support;

namespace HOLMS.Types.Booking {
    public partial class CancellationReason {
        public CancellationReason(Guid id, string reason) {
            EntityId = id.ToUUID();
            ReasonText = reason;
        }
    }
}

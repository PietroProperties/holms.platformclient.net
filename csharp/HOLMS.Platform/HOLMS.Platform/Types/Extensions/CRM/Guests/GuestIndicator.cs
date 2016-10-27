using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;
using System;

namespace HOLMS.Types.CRM.Guests {
    public partial class GuestIndicator : EntityIndicator<GuestIndicator> {
        public override Uuid GetUuidID() {
            return Id;
        }

        public GuestIndicator(Guid id) {
            Id = id.ToUUID();
        }
    }
}

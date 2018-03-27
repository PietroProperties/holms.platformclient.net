using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Operations.RoomClaims {
    public partial class RoomClaimIndicator : EntityIndicator<RoomClaim> {
        public override Uuid GetUuidID() => Id;

        public RoomClaimIndicator(Guid id) {
            Id = id.ToUUID();
        }
    }
}

using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;
using System;
using HOLMS.Platform.Types;

namespace HOLMS.Types.Operations.Rooms {
    public partial class RoomIndicator : EntityIndicator<RoomIndicator> {
        public RoomIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

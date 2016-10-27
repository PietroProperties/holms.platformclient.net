using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using System;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Supply.RoomTypes {
    public partial class RoomTypeIndicator : EntityIndicator<RoomTypeIndicator> {
        public override Uuid GetUuidID() {
            return Id;
        }
        public RoomTypeIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public static RoomTypeIndicator NullIndicator =>
            new RoomTypeIndicator(new Guid());
    }
}

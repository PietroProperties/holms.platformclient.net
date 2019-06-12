using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Operations.NoteRequestsRoomTypes {
    public partial class NoteRequestRoomTypeIndicator : EntityIndicator<NoteRequestRoomTypeIndicator> {
        public NoteRequestRoomTypeIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

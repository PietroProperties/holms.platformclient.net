using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Operations.NoteRequestsRoomTypes {
    public partial class NoteRequestRoomTypes : EntityDTO<NoteRequestRoomTypeIndicator> {
        public override NoteRequestRoomTypeIndicator GetIndicator() {
            return EntityId;
        }
    }
}

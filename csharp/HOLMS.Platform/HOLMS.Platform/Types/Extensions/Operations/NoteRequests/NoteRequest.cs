using HOLMS.Types.Extensions;

namespace HOLMS.Types.Operations.NoteRequests {
    public partial class NoteRequest : EntityDTO<NoteRequestIndicator> {
        public override NoteRequestIndicator GetIndicator() {
            return EntityId;
        }
    }
}

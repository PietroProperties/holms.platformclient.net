using HOLMS.Types.Extensions;

namespace HOLMS.Types.Supply.IncidentalItems {
    public partial class IncidentalItem : EntityDTO<IncidentalItemIndicator> {
        public override IncidentalItemIndicator GetIndicator() => EntityId;
    }
}

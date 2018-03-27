using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Supply {
    public partial class RateSchedule : EntityDTO<RateScheduleIndicator> {
        public override RateScheduleIndicator GetIndicator() {
            return Id;
        }
    }
}

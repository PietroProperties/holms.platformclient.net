using HOLMS.Types.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOLMS.Platform.Types;

namespace HOLMS.Types.Operations.Housekeeping {
    public partial class HousekeepingTime : EntityDTO<HousekeepingTimeIndicator> {
        public override HousekeepingTimeIndicator GetIndicator() {
            return EntityId;
        }
    }
}

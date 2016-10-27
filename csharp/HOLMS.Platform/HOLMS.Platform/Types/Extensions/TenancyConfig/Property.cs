using HOLMS.Types.Extensions;
using HOLMS.Types.TenancyConfig.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Types.TenancyConfig {
    public partial class Property : EntityDTO<PropertyIndicator> {
        public override PropertyIndicator GetIndicator() {
            return EntityId;
        }
    }
}

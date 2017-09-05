using HOLMS.Types.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.TenancyConfig.Indicators {
    public partial class TaxExemptCategoryIndicator : EntityIndicator<TaxExemptCategoryIndicator> {
        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

using HOLMS.Support.Conversions;
using HOLMS.Types.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.TenancyConfig.Indicators {
    public partial class ForeignPropertyIndicator : EntityIndicator<ForeignPropertyIndicator> {
        public ForeignPropertyIndicator(Guid id) : base() {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

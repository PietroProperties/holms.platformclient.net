using HOLMS.Types.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Types.Booking.Channels {
    public partial class OTAChannelProvider : EntityDTO<OTAChannelProviderIndicator> {
        public override OTAChannelProviderIndicator GetIndicator() {
            return EntityId;
        }
    }
}

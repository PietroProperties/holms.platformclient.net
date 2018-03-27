using HOLMS.Types.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOLMS.Platform.Types;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking.Channels {
    public partial class OTAChannelProviderIndicator : EntityIndicator<OTAChannelProviderIndicator> {
        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

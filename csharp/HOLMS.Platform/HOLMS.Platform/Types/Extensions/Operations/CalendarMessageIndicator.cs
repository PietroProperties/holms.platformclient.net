using System;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Operations {
    public partial class CalendarMessageIndicator : EntityIndicator<CalendarMessageIndicator> {
        public CalendarMessageIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;
using System;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Platform.Types;

namespace HOLMS.Types.CRM.Guests {
    public partial class ReservationNoteTemplateIndicator : EntityIndicator<ReservationNoteTemplateIndicator> {
        public ReservationNoteTemplateIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() {
            return Id;
        }
    }
}

using HOLMS.Support.Conversions;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Text;

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

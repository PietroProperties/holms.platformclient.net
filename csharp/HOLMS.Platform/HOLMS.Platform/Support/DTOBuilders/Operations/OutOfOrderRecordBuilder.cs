using System;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Platform.Support.Time;
using HOLMS.Types.IAM;
using HOLMS.Types.Operations.OutOfOrder;
using HOLMS.Types.Operations.Rooms;

namespace HOLMS.Platform.Support.DTOBuilders.Operations {
    public class OutOfOrderRecordBuilder {
        private readonly OutOfOrderRecordIndicator _id;
        private readonly string _reason;
        private readonly InclusiveOpsdateRange _dr;
        private readonly StaffMember _enteredBy;
        private readonly StaffMember _updatedBy;
        private readonly DateTime _updatedAt;
        private readonly Room _room;

        public OutOfOrderRecordBuilder(OutOfOrderRecordIndicator id, string reason, InclusiveOpsdateRange dr,
            StaffMember enteredBy, StaffMember updatedBy, DateTime updatedAt, Room room) {
            _id = id;
            _reason = reason;
            _dr = dr;
            _enteredBy = enteredBy;
            _updatedBy = updatedBy;
            _updatedAt = updatedAt;
            _room = room;
        }

        public OutOfOrderRecord Build() {
            var ooo = new OutOfOrderRecord {
                EntityId = _id,
                Reason = _reason ?? string.Empty,
                DateRange = _dr.ToPB,
                UpdatedAt = _updatedAt.ToTS(),
                Room = _room
            };

            if (_updatedBy != null) {
                ooo.UpdatedBy = _updatedBy;
            }

            if (_enteredBy != null) {
                ooo.EnteredBy = _enteredBy;
            }

            return ooo;
        }
    }
}

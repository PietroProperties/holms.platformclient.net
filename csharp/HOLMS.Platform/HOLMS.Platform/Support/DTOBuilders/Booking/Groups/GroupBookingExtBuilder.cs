using System.Collections.Generic;
using HOLMS.Types.Booking.Groups;
using HOLMS.Types.CRM.Groups;
using HOLMS.Types.TenancyConfig.Indicators;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.Groups {
    public class GroupBookingExtBuilder {
        private readonly GroupBooking _gb;
        private readonly string _groupName;
        private readonly string _groupNumber;
        private readonly string _groupContactName;
        private readonly GroupType _groupType;
        private readonly PropertyIndicator _property;
        private readonly IEnumerable<GroupBookingRoomTypeQuantity> _quantities;

        public GroupBookingExtBuilder(GroupBooking gb, string groupName,
            string groupNumber, string groupContactName, GroupType groupType,
            PropertyIndicator property, IEnumerable<GroupBookingRoomTypeQuantity> qty) {
            _gb = gb;
            _groupName = groupName;
            _groupNumber = groupNumber;
            _groupContactName = groupContactName;
            _groupType = groupType;
            _property = property;
            _quantities = qty;
        }

        public GroupBookingExt Build() {
            var gbex = new GroupBookingExt {
                Booking = _gb,
                GroupType = _groupType,
                GroupContactName = _groupContactName ?? string.Empty,
                GroupName = _groupName ?? string.Empty,
                GroupNumber = _groupNumber ?? string.Empty,
                GroupProperty = _property
            };

            if (_quantities != null) {
                gbex.Quantities.Add(_quantities);
            }

            return gbex;
        }
    }
}

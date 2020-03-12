using System;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Platform.Support.Time;
using HOLMS.Types.Booking.Groups;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.CRM.Groups;
using HOLMS.Types.Supply;
using HOLMS.Types.TenancyConfig.Indicators;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.Groups {
    public class GroupBookingBuilder {
        // Bookings always have these things
        private readonly GroupBookingIndicator _gbi;
        private readonly GroupBookingStatus _gbs;
        private readonly bool _taxExempt;
        private readonly string _taxId;
        private readonly bool _groupPaysLodging;
        private readonly bool _groupPaysIncidentals;
        private readonly string _additionalNotes;
        private readonly string _customerBookingId;
        private readonly RateScheduleIndicator _rateSchedule;
        private readonly GroupIndicator _group;
        private string _groupName;
        private readonly PropertyIndicator _property;

        // Everything below here is nullable
        private readonly InclusiveOpsdateRange _bookingDates;
        private readonly Guid? _groupBookingMethodId;
        private readonly Guid? _reservationSourceId;
        private readonly Guid? _travelAgent;
        private readonly Guid? _cancellationPolicy;
        private readonly bool _surpressratecheck;
        private readonly string _taxCategory;

        public GroupBookingBuilder(GroupBookingIndicator id, GroupBookingStatus status,
            bool taxExempt, string taxId, bool groupPaysLodging, bool groupPaysIncidentals,
            string additionalNotes, string customerBookingId, InclusiveOpsdateRange bookingDates,
            RateScheduleIndicator rs, GroupIndicator g, Guid? groupBookingMethodId,
            Guid? reservationSourceId, Guid? travelAgentId, Guid? cancellationPolicy,
            string groupName, bool surpressratecheck, string taxCatgeory, PropertyIndicator property) {
            _gbi = id;
            _gbs = status;
            _taxExempt = taxExempt;
            _taxId = taxId;
            _taxCategory = taxCatgeory;
            _groupPaysLodging = groupPaysLodging;
            _groupPaysIncidentals = groupPaysIncidentals;
            _additionalNotes = additionalNotes;
            _customerBookingId = customerBookingId;
            _rateSchedule = rs;
            _group = g;
            _property = property;

            // Nullables
            _bookingDates = bookingDates;
            _groupBookingMethodId = groupBookingMethodId;
            _reservationSourceId = reservationSourceId;
            _travelAgent = travelAgentId;
            _cancellationPolicy = cancellationPolicy;
            _groupName = groupName;
            _surpressratecheck = surpressratecheck;
        }

        public GroupBooking Build() {
            var gb = new GroupBooking {
                EntityId = _gbi,
                Status = _gbs,
                TaxExempt = _taxExempt,
                TaxId = _taxId,
                GroupPaysLodging = _groupPaysLodging,
                GroupPaysIncidentals = _groupPaysIncidentals,
                AdditionalNotes = _additionalNotes ?? string.Empty,
                CustomerBookingId = _customerBookingId ?? string.Empty,
                RateSchedule = _rateSchedule,
                Group = _group,
                GroupName = _groupName,
                SurpressRateInfo = _surpressratecheck,
                TaxCategory = _taxCategory,
                BookingProperty = _property
            };

            if (_bookingDates != null) {
                gb.DateRange = _bookingDates.ToPB;
            }

            if (_groupBookingMethodId.HasValue) {
                gb.BookingMethod = new GroupBookingMethodIndicator(_groupBookingMethodId.Value);
            }

            if (_reservationSourceId.HasValue) {
                gb.ReservationSourceId = _reservationSourceId.Value.ToUUID();
            }

            if (_travelAgent != null) {
                gb.TravelAgent = new TravelAgentIndicator(_travelAgent.Value);
            }

            if (_cancellationPolicy != null) {
                gb.CancellationPolicy = new CancellationPolicyIndicator(_cancellationPolicy.Value);
            }

            return gb;
        }
    }
}

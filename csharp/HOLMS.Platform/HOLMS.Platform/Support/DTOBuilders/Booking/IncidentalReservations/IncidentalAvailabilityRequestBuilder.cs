using HOLMS.Platform.Support.Time;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Supply.IncidentalItems;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.IncidentalReservations {
    public class IncidentalAvailabilityRequestBuilder {
        public IncidentalItemIndicator IncidentalItem;
        public bool IsForAmendment;
        public IncidentalItemReservationIndicator IncidentalResBeingAmended;
        public InclusiveOpsdateRange DateRange;

        public IncidentalItemAvailabilityQuery Build() {
            if (IsForAmendment) {
                return new IncidentalItemAvailabilityQuery() {
                    DateRange = DateRange.ToPB,
                    EntityId = IncidentalResBeingAmended,
                    IsForExistingIiReservation = true,
                    ReservedItem = IncidentalItem,
                };
            } else {
                return new IncidentalItemAvailabilityQuery() {
                    DateRange = DateRange.ToPB,
                    IsForExistingIiReservation = false,
                    ReservedItem = IncidentalItem,
                };
            }
        }
    }
}

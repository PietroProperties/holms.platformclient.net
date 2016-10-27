using HOLMS.Support.Time;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Supply.IncidentalItems;

namespace HOLMS.Support.DTOBuilders.Booking.IncidentalReservations {
    public class IncidentalAvailabilityRequestBuilder {
        public IncidentalItemIndicator InventoryItem;
        public bool IsForAmendment;
        public IncidentalItemReservationIndicator InvResBeingAmended;
        public InclusiveOpsdateRange DateRange;

        public IncidentalItemAvailabilityQuery Build() {
            if (IsForAmendment) {
                return new IncidentalItemAvailabilityQuery() {
                    DateRange = DateRange.ToPB,
                    EntityId = InvResBeingAmended,
                    IsForExistingIiReservation = true,
                    ReservedItem = InventoryItem
                };
            } else {
                return new IncidentalItemAvailabilityQuery() {
                    DateRange = DateRange.ToPB,
                    IsForExistingIiReservation = false,
                    ReservedItem = InventoryItem
                };
            }
        }
    }
}

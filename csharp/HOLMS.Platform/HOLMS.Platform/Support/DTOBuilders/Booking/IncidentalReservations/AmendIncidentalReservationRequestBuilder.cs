using System;
using HOLMS.Platform.Support.Time;
using HOLMS.Types.Booking.IncidentalReservations;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Supply.IncidentalItems;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.IncidentalReservations {
    public class AmendIncidentalReservationRequestBuilder {
        public IncidentalItemReservationIndicator PriorInvReservation;
        public InclusiveOpsdateRange DateRange;
        public ReservationIndicator LodgingReservation;
        public IncidentalItemIndicator ReservedItem;
        public int QuantityRequested;

        public IncidentalItemReservation Build() {
            return new IncidentalItemReservation {
                EntityId = PriorInvReservation,
                DateRange = DateRange.ToPB,
                AmountReserved = Convert.ToUInt32(QuantityRequested),
                ReservedItem = ReservedItem,
                Reservation = LodgingReservation
            };
        }
    }
}

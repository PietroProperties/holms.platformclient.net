using System;
using HOLMS.Support.Time;
using HOLMS.Types.Booking.IncidentalReservations;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Supply.IncidentalItems;

namespace HOLMS.Support.DTOBuilders.Booking.IncidentalReservations {
    public class NewIncidentalReservationRequestBuilder {
        public InclusiveOpsdateRange DateRange;
        public ReservationIndicator LodgingReservation;
        public IncidentalItemIndicator ReservedItem;
        public int QuantityRequested;

        public IncidentalItemReservation Build() {
            return new IncidentalItemReservation() {
                DateRange = DateRange.ToPB,
                AmountReserved = Convert.ToUInt32(QuantityRequested),
                ReservedItem = ReservedItem,
                Reservation = LodgingReservation
            };
        }
    }
}

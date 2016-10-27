using HOLMS.Support.Time;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Booking.Reservations;
using HOLMS.Types.Supply;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Support.DTOBuilders.Booking.Reservations {
    public class ReservationFRPAmendmentRequestBuilder {
        public ReservationFRPAmendmentRequestBuilder(
                InclusiveOpsdateRange dr,
                RoomTypeIndicator rt,
                QualificationIndicator qual,
                ReservationIndicator ri,
                int adults,
                int children,
                bool taxExempt) {
            DateRange = dr;
            RoomType = rt;
            Qualification = qual;
            Reservation = ri;
            NumberAdults = adults;
            NumberChildren = children;
            TaxExempt = taxExempt;
        }

        public InclusiveOpsdateRange DateRange;
        public RoomTypeIndicator RoomType;
        public QualificationIndicator Qualification;
        public ReservationIndicator Reservation;
        public int NumberAdults;
        public int NumberChildren;
        public bool TaxExempt;

        public ReservationFRPAmendmentRequest Build() {
            var request = new ReservationFRPAmendmentRequest() {
                Reservation = Reservation,
                RoomType = RoomType,
                DateRange = DateRange.ToPB,
                AdultGuestCount = NumberAdults,
                ChildGuestCount = NumberChildren,
                TaxExempt = TaxExempt
            };
            if (Qualification != null) {
                request.Q = Qualification;
            }
            return request;
        }
    }
}

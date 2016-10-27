using HOLMS.Support.Time;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Booking.Pricing;
using HOLMS.Types.Supply;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Support.DTOBuilders.Booking.Pricing {
    public class OpenPriceEstimateRequestBuilder {
        public ReservationIndicator Reservation;
        public QualificationIndicator Qualification;
        public RoomTypeIndicator RoomType;
        public InclusiveOpsdateRange DateRange;
        public int NumberAdults;
        public bool TaxExempt;

        public OpenPriceEstimateRequest Build() {
            var request = new OpenPriceEstimateRequest() {
                Reservation = Reservation,
                DateRange = DateRange.ToPB,
                TaxExempt = TaxExempt,
                AdultGuestCount = NumberAdults,
                RoomType = RoomType
            };
            if(Qualification != null) {
                request.Q = Qualification;
            }

            return request;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using HOLMS.Platform.Support.ReservationTags;
using HOLMS.Support.Time;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Booking.Pricing;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.Pricing {
    public class OpenPriceEstimateRequestBuilder {
        public ReservationIndicator Reservation;
        public List<ReservationTagBase> Tags;
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

            if (Tags != null) {
                request.ReservationTags.Add(Tags.Select(x => x.ToString()));
            }

            return request;
        }
    }
}

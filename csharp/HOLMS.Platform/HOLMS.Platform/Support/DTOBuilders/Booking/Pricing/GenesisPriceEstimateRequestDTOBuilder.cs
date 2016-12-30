using System.Collections.Generic;
using System.Linq;
using HOLMS.Platform.Support.ReservationTags;
using HOLMS.Support.Time;
using HOLMS.Types.Booking.Pricing;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.Pricing {
    public class GenesisPriceEstimateRequestDTOBuilder {
        public InclusiveOpsdateRange DateRange;
        public RoomTypeIndicator RoomType;
        public List<ReservationTagBase> Tags;
        public int NumberAdultGuests;

        public GenesisPriceEstimateRequestDTO Build() {
            var dto = new GenesisPriceEstimateRequestDTO();
            dto.DateRange = DateRange.ToPB;
            dto.RoomType = RoomType;
            dto.NumberAdultGuests = NumberAdultGuests;

            if (Tags != null) {
                dto.ReservationTags.Add(Tags.Select(x => x.ToString()));
            }
            
            return dto;
        }
    }
}

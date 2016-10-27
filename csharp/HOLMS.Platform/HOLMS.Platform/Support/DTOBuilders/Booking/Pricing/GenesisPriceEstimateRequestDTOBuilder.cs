using HOLMS.Support.Time;
using HOLMS.Types.Booking.Pricing;
using HOLMS.Types.Supply;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Support.DTOBuilders.Booking.Pricing {
    public class GenesisPriceEstimateRequestDTOBuilder {
        public InclusiveOpsdateRange DateRange;
        public RoomTypeIndicator RoomType;
        public QualificationIndicator Qualification;
        public int NumberAdultGuests;

        public GenesisPriceEstimateRequestDTO Build() {
            var dto = new GenesisPriceEstimateRequestDTO();
            dto.DateRange = DateRange.ToPB;
            dto.RoomType = RoomType;
            if(!ReferenceEquals(Qualification, null)) {
                dto.Qualification = Qualification;
            }
            dto.NumberAdultGuests = NumberAdultGuests;
            return dto;
        }
    }
}

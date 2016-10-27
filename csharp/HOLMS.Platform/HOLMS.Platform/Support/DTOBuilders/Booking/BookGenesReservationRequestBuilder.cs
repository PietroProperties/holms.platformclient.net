using HOLMS.Support.Time;
using HOLMS.Types.Booking.Reservations;
using HOLMS.Types.CRM.Guests;
using HOLMS.Types.Supply;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Support.DTOBuilders.Booking {
    public class BookGenesisReservationRequestBuilder {
        public RoomTypeIndicator RoomType;
        public QualificationIndicator Qualification;
        public InclusiveOpsdateRange DateRange;
        public GuestIndicator Guest;
        public int NumberAdults;
        public int NumberChildren;

        public BookGenesisReservationRequest Build() {
            var request = new BookGenesisReservationRequest() {
                RoomType = RoomType,
                DateRange = DateRange.ToPB,
                Guest = Guest,
                NumberAdults = NumberAdults,
                NumberChildren = NumberChildren
            };
            if (Qualification != null) {
                request.Qualification = Qualification;
            }
            return request;
        }
    }
}

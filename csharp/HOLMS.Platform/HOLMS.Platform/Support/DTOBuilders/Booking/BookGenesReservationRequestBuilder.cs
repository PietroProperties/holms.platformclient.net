using System.Collections.Generic;
using System.Linq;
using HOLMS.Platform.Support.ReservationTags;
using HOLMS.Support.Time;
using HOLMS.Types.Booking.Channels;
using HOLMS.Types.Booking.Reservations;
using HOLMS.Types.CRM.Guests;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Platform.Support.DTOBuilders.Booking {
    public class BookGenesisReservationRequestBuilder {
        public Channel SourceChannel;
        public RoomTypeIndicator RoomType;
        public List<ReservationTagBase> Tags;
        public InclusiveOpsdateRange DateRange;
        public GuestIndicator Guest;
        public int NumberAdults;
        public int NumberChildren;

        public BookGenesisReservationRequest Build() {
            var request = new BookGenesisReservationRequest {
                RoomType = RoomType,
                DateRange = DateRange.ToPB,
                Guest = Guest,
                NumberAdults = NumberAdults,
                NumberChildren = NumberChildren,
                SourceChannel = SourceChannel,
            };

            if (Tags != null) {
                request.ReservationTags.Add(Tags.Select(t => t.ToString()));
            }

            return request;
        }
    }
}

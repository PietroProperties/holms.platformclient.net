using System.Collections.Generic;
using System.Linq;
using HOLMS.Platform.Support.ReservationTags;
using HOLMS.Platform.Support.Time;
using HOLMS.Types.Booking.Channels;
using HOLMS.Types.Booking.Reservations;
using HOLMS.Types.CRM.Guests;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.Genesis {
    public class ChannelRushReservationRequestBuilder {
        public string ChannelRushId;
        public string ChannelReservationId;
        public string RoomStayIndex;
        public string SourceChannel;

        public RoomTypeIndicator RoomType;
        public List<ReservationTagBase> Tags;
        public InclusiveOpsdateRange DateRange;
        public GuestIndicator Guest;
        public int NumberAdults;
        public int NumberChildren;

        public BookGenesisReservationRequest Build() {
            var ci = new ChannelInfo {
                Channel = Channel.Channelrush,
            };

            ci.SupplementalInfo.Add(new Dictionary<string, string> {
                {"chid", SourceChannel},
                {"chresid", ChannelReservationId},
                {"crresid", ChannelRushId},
                {"rsi", RoomStayIndex},
            });

            var request = new BookGenesisReservationRequest {
                RoomType = RoomType,
                DateRange = DateRange.ToPB,
                Guest = Guest,
                NumberAdults = NumberAdults,
                NumberChildren = NumberChildren,
                SourceChannelInfo = ci,
            };

            if (Tags != null) {
                request.ReservationTags.Add(Tags.Select(t => t.ToString()));
            }

            return request;
        }
    }
}

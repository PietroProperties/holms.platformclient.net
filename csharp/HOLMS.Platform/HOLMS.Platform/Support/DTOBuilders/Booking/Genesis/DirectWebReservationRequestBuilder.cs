using System.Collections.Generic;
using HOLMS.Platform.Support.Time;
using HOLMS.Types.Booking.Channels;
using HOLMS.Types.Booking.Reservations;
using HOLMS.Types.CRM.Guests;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.Genesis {
    public class DirectWebReservationRequestBuilder {
        public string ReservingParty;
        public RoomTypeIndicator RoomType;
        public InclusiveOpsdateRange DateRange;
        public GuestIndicator Guest;
        public int NumberAdults;
        public int NumberChildren;

        public BookGenesisReservationRequest Build() {
            var ci = new ChannelInfo {
                Channel = Channel.DirectWeb,
            };

            var si = new Dictionary<string, string>();
            if (ReservingParty != null) {
                si["rp"] = ReservingParty;
            }

            ci.SupplementalInfo.Add(si);

            return new BookGenesisReservationRequest {
                RoomType = RoomType,
                DateRange = DateRange.ToPB,
                Guest = Guest,
                NumberAdults = NumberAdults,
                NumberChildren = NumberChildren,
                SourceChannelInfo = ci,
            };
        }
    }
}

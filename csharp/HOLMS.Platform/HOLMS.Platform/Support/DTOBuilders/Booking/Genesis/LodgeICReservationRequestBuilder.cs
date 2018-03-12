using System.Collections.Generic;
using System.Linq;
using HOLMS.Platform.Support.ReservationTags;
using HOLMS.Platform.Support.Time;
using HOLMS.Types.Booking.Channels;
using HOLMS.Types.Booking.Reservations;
using HOLMS.Types.CRM.Guests;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.Genesis {
    public class LodgeICReservationRequestBuilder {
        public string ReservingParty;
        public RoomTypeIndicator RoomType;
        public List<ReservationTagBase> Tags;
        public InclusiveOpsdateRange DateRange;
        public GuestIndicator Guest;
        public int NumberAdults;
        public int NumberChildren;

        public BookGenesisReservationRequest Build() {
            var ci = new ChannelInfo {
                Channel = Channel.Lodgeic,
            };

            var si = new Dictionary<string, string>();
            if (ReservingParty != null) {
                si["rp"] = ReservingParty;
            }

            // TODO(DA) Eventually add "Received Via" (walk-up, phone, email) here?

            ci.SupplementalInfo.Add(si);

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

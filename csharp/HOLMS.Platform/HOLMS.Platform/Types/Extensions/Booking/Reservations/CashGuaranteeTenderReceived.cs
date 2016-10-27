using Google.Protobuf.WellKnownTypes;
using HOLMS.Types.Extensions.Booking.Reservations;

namespace HOLMS.Types.Booking.Reservations {
    public partial class CashGuaranteeTenderReceived : IGuaranteeTenderReceivedEvent {
        public Timestamp CreatedAt => CreatedAt;
        public GuaranteeType Type => GuaranteeType.Cash;
    }
}

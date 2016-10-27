using Google.Protobuf.WellKnownTypes;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Extensions.Booking.Reservations {
    public interface IGuaranteeTenderReceivedEvent {
        MonetaryAmount Amount { get; }
        Timestamp CreatedAt { get; }
        GuaranteeType Type { get; }
        bool Equals(object other);
    }
}

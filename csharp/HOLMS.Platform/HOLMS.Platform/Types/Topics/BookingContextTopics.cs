namespace HOLMS.Messaging.Topics {
    public class BookingContextTopics {
        public const string GroupBookingQuantities = "bookings.groups.quantities";

        public const string ReservationCancellation = "bookings.reservations.cancellations";
        public const string ReservationCheckInTopic = "booking.reservations.checkins";
        public const string ReservationCheckOutTopic = "booking.reservations.checkouts";
        public const string ReservationFRPAmendment = "bookings.reservations.frp_amendment";
        public const string ReservationBooked = "bookings.reservations.reservation_booked";
        public const string ReservationGuaranteeOccurred = "bookings.reservations.guarantees.any";
    }
}

namespace HOLMS.Platform.Types.Topics {
    public class BookingContextTopics {
        public const string GroupBookingSaved = "booking.groups.bookings.saved";
        public const string GroupBookingQuantitiesSaved = "booking.groups.bookings.quantities.saved";

        public const string ReservationCancellation = "booking.reservations.cancellations";
        public const string ReservationCheckInTopic = "booking.reservations.checkins";
        public const string ReservationCheckOutTopic = "booking.reservations.checkouts";
        public const string ReservationFRPAmendment = "booking.reservations.frp_amendment";
        public const string ReservationBooked = "booking.reservations.reservation_booked";
        public const string ReservationGuaranteeOccurred = "booking.reservations.guarantees.any";
    }
}

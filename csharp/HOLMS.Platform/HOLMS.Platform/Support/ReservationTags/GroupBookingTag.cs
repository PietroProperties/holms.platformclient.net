using System;
using HOLMS.Types.Booking.Indicators;

namespace HOLMS.Platform.Support.ReservationTags {
    public class GroupBookingTag : ReservationTagBase {
        public GroupBookingIndicator Booking { get; protected set; }

        public override bool IsPermanent {
            get {
                return false;
            }
        }

        public GroupBookingTag(string[] tokens) {
            Booking = new GroupBookingIndicator(Guid.Parse(tokens[1]));
        }

        public GroupBookingTag(GroupBookingIndicator gbi) {
            Booking = gbi;
        }

        protected override string[] GetDescriptorPartsAfterCategory() =>
            new[] {Booking.GuidID.ToString()};

        protected override string GetCategoryDescriptor() {
            return GroupBookingCategory;
        }
    }
}

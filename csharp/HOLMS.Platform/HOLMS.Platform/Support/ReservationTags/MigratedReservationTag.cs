namespace HOLMS.Platform.Support.ReservationTags {
    public class MigratedReservationTag : ReservationTagBase {
        protected override string[] GetDescriptorPartsAfterCategory() =>
            new string[] { };

        protected override string GetCategoryDescriptor() => MigratedBookingCategory;

        public override bool IsPermanent => true;
    }
}

namespace HOLMS.Platform.Support.ReservationTags {
    public class CompStayTag : ReservationTagBase {
        public CompStayTag() { }

        public CompStayTag(string[] tokens) { }

        protected override string[] GetDescriptorPartsAfterCategory() {
            return new string[] { };
        }
    }
}

using System;

namespace HOLMS.Platform.Support.ReservationTags {
    public class CompStayTag : ReservationTagBase {
        public CompStayTag() { }

        public CompStayTag(string[] tokens) { }

        public override bool IsPermanent {
            get {
                return false;
            }
        }

        protected override string GetCategoryDescriptor() {
            return CompStayCategory;
        }

        protected override string[] GetDescriptorPartsAfterCategory() {
            return new string[] { };
        }
    }
}

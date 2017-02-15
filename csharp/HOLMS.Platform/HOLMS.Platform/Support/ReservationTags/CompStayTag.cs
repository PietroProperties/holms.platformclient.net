using System;

namespace HOLMS.Platform.Support.ReservationTags {
    public class CompStayTag : ReservationTagBase {
        public override bool IsPermanent => false;

        protected override string GetCategoryDescriptor() => CompStayCategory;

        protected override string[] GetDescriptorPartsAfterCategory() {
            return new string[] { };
        }
    }
}

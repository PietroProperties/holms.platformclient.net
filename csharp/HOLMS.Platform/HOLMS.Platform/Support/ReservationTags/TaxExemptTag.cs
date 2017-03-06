using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Platform.Support.ReservationTags {
    public class TaxExemptTag : ReservationTagBase {
        public override bool IsPermanent {
            get {
                return false;
            }
        }

        protected override string GetCategoryDescriptor() {
            return TaxExemptCategory;
        }

        protected override string[] GetDescriptorPartsAfterCategory() {
            return new string[] { };
        }
    }
}

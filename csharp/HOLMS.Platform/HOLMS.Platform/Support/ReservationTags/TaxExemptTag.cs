using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Platform.Support.ReservationTags {
    public class TaxExemptTag : ReservationTagBase {
        private string _taxExemptCategory;
        private string _taxExemptID;

        public TaxExemptTag(string [] tokens) {
            // Token 0 is the primary descriptor tokens 1, 2 are optional tax exempt category
            // and tax exempt ID. These fields are optional to be compatible with legacy tax exempt tags
            // that are described by "te:"
            if(tokens.Length == 3) {
                _taxExemptCategory = tokens[1];
                _taxExemptID = tokens[2];
            }
        }

        public TaxExemptTag(string taxExemptCategory, string taxExemptID) {
            //Clean delimiter characters
            _taxExemptCategory = taxExemptCategory.Replace(":", string.Empty);
            _taxExemptID = taxExemptID.Replace(":", string.Empty);
        }
        
        public override bool IsPermanent {
            get {
                return false;
            }
        }

        protected override string GetCategoryDescriptor() {
            return TaxExemptCategory;
        }

        public string TaxExemptCategoryDescription {
            get {
                return _taxExemptCategory;
            }
        }

        public string TaxExemptID {
            get {
                return _taxExemptID;
            }
        }

        protected override string[] GetDescriptorPartsAfterCategory() {
            return new string[] { _taxExemptCategory, _taxExemptID };
        }
    }
}

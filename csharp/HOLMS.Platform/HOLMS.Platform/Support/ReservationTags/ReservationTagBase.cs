using System;
using System.Collections.Generic;
using System.Linq;

namespace HOLMS.Platform.Support.ReservationTags {
    public abstract class ReservationTagBase {
        // NOTE(DA) These feel like they belong on the children, but I couldn't find
        // a good way to put them there without splitting responsibility for the
        // string<->type mapping.
        protected const string CompStayCategory = "comp";
        protected const string GroupBookingCategory = "gb";
        protected const string MigratedBookingCategory = "migrated";
        protected const string OTABookingCategory = "ob";
        protected const string TaxExemptCategory = "te";

        protected abstract string[] GetDescriptorPartsAfterCategory();
        protected abstract string GetCategoryDescriptor();

        /// <summary>
        /// Permanent tags are not allowed to be added/removed by amendment.
        /// </summary>
        public abstract bool IsPermanent { get; }

        public override string ToString() {
            var dp = GetDescriptorPartsAfterCategory();
            return string.Join(":", new List<string> { GetCategoryDescriptor() }.Concat(dp));
        }

        public string[] ToDescriptorArray() {
            return ToString().Split(':');
        }

        public static ReservationTagBase CreateFromDescriptor(string descriptor) {
            // NOTE(DA) Was going to do some complicated reflection thing here
            // but decided against it for now.
            var descriptorTokens = descriptor.Split(':');

            switch (descriptorTokens.First()) {
                case CompStayCategory:
                    return new CompStayTag();
                case GroupBookingCategory:
                    return new GroupBookingTag(descriptorTokens);
                case MigratedBookingCategory:
                    return new MigratedReservationTag();
                case OTABookingCategory:
                    return new OTABookingTag(descriptorTokens);
                case TaxExemptCategory:
                    return new TaxExemptTag();
                default:
                    throw new NotImplementedException();
            }
        }

        public override bool Equals(object obj) {
            var tag = obj as ReservationTagBase;
            if (tag == null) {
                return false;
            }

            return tag.ToString() == ToString();
        }

        public override int GetHashCode() {
            return ToString().GetHashCode();
        }
    }
}

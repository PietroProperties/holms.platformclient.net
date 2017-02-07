using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Platform.Support.ReservationTags {
    public class OTABookingTag : ReservationTagBase {
        private string[] descriptorTokens;

        public OTABookingTag(string[] descriptorTokens) {
            OTASourceName = descriptorTokens[1];
            ChannelManagerBookingID = descriptorTokens[2];
            SourceBookingID = descriptorTokens[3];
            StayNightIndex = descriptorTokens[4];
        }

        /// <summary>
        /// Name of the OTA channel that is the source of the reservation
        /// </summary>
        public string OTASourceName { get; private set; }

        /// <summary>
        /// ID value that the channel manager maintains for this booking
        /// </summary>
        public string ChannelManagerBookingID { get; private set; }

        /// <summary>
        /// ID value that the OTA channel uses for this booking
        /// </summary>
        public string SourceBookingID { get; private set; }

        /// <summary>
        /// The index used to identify this reservation in a multi-room booking
        /// </summary>
        public string StayNightIndex { get; private set; }

        public override bool IsPermanent {
            get {
                return true;
            }
        }

        protected override string[] GetDescriptorPartsAfterCategory() {
            return new string[] {
                OTASourceName,
                ChannelManagerBookingID,
                SourceBookingID,
                StayNightIndex
            };
        }

        protected override string GetCategoryDescriptor() {
            return OTABookingCategory;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HOLMS.Platform.Support.ReservationTags {
    public abstract class ReservationTagBase {
        // NOTE(DA) These feel like they belong on the children, but I couldn't find
        // a good way to put them there without splitting responsibility for the
        // string<->type mapping.
        private const string CompStayCategory = "comp";
        private const string GroupBookingCategory = "gb";
        private const string OTABookingCategory = "ob";

        protected abstract string[] GetDescriptorPartsAfterCategory();

        public override string ToString() {
            var dp = GetDescriptorPartsAfterCategory();

            if (this is CompStayTag) {
                return string.Join(":", new List<string> { CompStayCategory }.Concat(dp));
            } else if (this is GroupBookingTag) {
                return string.Join(":", new List<string> { GroupBookingCategory }.Concat(dp));
            } else if (this is OTABookingTag) {
                return string.Join(":", new List<string> { OTABookingCategory }.Concat(dp));
            } else {
                throw new NotImplementedException();
            }
        }

        public string[] ToDescriptorArray() {
            return ToString().Split(':');
        }

        /// <summary>
        /// Permanent tags are not allowed to be added/removed by amendment.
        /// </summary>
        public abstract bool IsPermanent { get; }

        public static ReservationTagBase CreateFromDescriptor(string descriptor) {
            // NOTE(DA) Was going to do some complicated reflection thing here
            // but decided against it for now.
            var descriptorTokens = descriptor.Split(':');

            switch (descriptorTokens.First()) {
                case CompStayCategory:
                    return new CompStayTag(descriptorTokens);
                case GroupBookingCategory:
                    return new GroupBookingTag(descriptorTokens);
                case OTABookingCategory:
                    return new OTABookingTag(descriptorTokens);
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

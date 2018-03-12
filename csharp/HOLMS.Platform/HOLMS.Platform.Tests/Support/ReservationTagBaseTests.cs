using System;
using NUnit.Framework;
using HOLMS.Platform.Support.ReservationTags;

namespace HOLMS.Platform.Tests.Support {
    class ReservationTagBaseTests {
        private const string GroupBookingId = "891a0b70-ae6c-435d-99e0-6834a5a6b3f6";
        [Test]
        public void UnknownDescriptorThrowsNotImplementedException() {
            Assert.Throws<NotImplementedException>(
                () => ReservationTagBase.CreateFromDescriptor("junk"));
        }

        [Test]
        public void DescriptorStartingWithGbParsedAsGroupBookingTag() {
            Assert.IsInstanceOf<GroupBookingTag>(
                ReservationTagBase.CreateFromDescriptor($"gb:{GroupBookingId}"));
        }

        [Test]
        public void GroupBookingTagWritesCorrectDescriptor() {
            var tag = new GroupBookingTag(new[] { "gb", GroupBookingId });
            Assert.AreEqual($"gb:{GroupBookingId}", tag.ToString());
        }

        [Test]
        public void DescriptorStartingWithCompParsedAsCompStayTag() {
            Assert.IsInstanceOf<CompStayTag>(ReservationTagBase.CreateFromDescriptor("comp"));
        }

        [Test]
        public void CompBookingTagWritesCorrectDescriptor() {
            var tag = new CompStayTag();
            Assert.AreEqual("comp", tag.ToString());
        }
    }
}

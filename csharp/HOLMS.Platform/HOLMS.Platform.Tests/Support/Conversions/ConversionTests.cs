using System;
using HOLMS.Platform.Support.Conversions;
using NUnit.Framework;

namespace HOLMS.Platform.Tests.Support.Conversions {
    internal class ConversionTests {
        [Test]
        public void TimespanToPbConversionRoundTripsIsomorphically() {
            var original = new TimeSpan(10, 11, 13);
            var converted = original.ToPb();
            var reverted = converted.ToTimeSpan();
            Assert.AreEqual(original, reverted);
        }
    }
}

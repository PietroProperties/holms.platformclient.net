using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOLMS.Support.Conversions;
using NUnit.Framework;

namespace HOLMS.Platform.Tests.Tests {
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

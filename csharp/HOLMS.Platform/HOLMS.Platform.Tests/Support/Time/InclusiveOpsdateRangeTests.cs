using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOLMS.Platform.Support.Time;
using NodaTime;
using NUnit.Framework;

namespace HOLMS.Platform.Tests.Support.Time {
    class InclusiveOpsdateRangeTests {
        [Test]
        public void MakeInclusiveDateRangeWithInvertedRangeThrows() {
            var newYear = new LocalDate(2000, 1, 1);
            var dayBefore = new LocalDate(1999, 12, 31);

            Assert.DoesNotThrow(() => new InclusiveOpsdateRange(dayBefore, newYear));
            Assert.Throws<ArgumentException>(() => new InclusiveOpsdateRange(newYear, dayBefore));
        }
    }
}

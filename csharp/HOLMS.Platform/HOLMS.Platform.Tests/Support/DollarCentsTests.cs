using HOLMS.Platform.Support.Currency;
using NUnit.Framework;

namespace HOLMS.Platform.Tests.Support {
    class DollarCentsTests {
        [Test]
        public void PositiveDollarCentsPrintsWithCommas() {
            var dc = new DollarCents(false, 1234, 56);
            Assert.AreEqual("$1,234.56", dc.ToString());
        }

        [Test]
        public void NegativeDollarCentsPrintsWithParenthesesAndCommas() {
            var dc = new DollarCents(true, 1234, 56);
            Assert.AreEqual("($1,234.56)", dc.ToString());
        }
    }
}

using HOLMS.Types.Money.Accounting;
using NUnit.Framework;

namespace HOLMS.Platform.Tests.Support {
    class EntityDTOTests {
        [Test]
        public void EqualsOperatorComparesEntityNotIndicatorToNull() {
            var line = new AccountingTransactionLine() { };
            var actual = line == null;
            var actualReversed = null == line;
            Assert.AreEqual(false, actual);
            Assert.AreEqual(false, actualReversed);
        }

        [Test]
        public void MutualVoidEntityComparisonReturnsTrue() {
            AccountingTransactionLine a = null;
            AccountingTransactionLine b = null;
            var actual = a == b;
            var actualReversed = b == a;
            Assert.AreEqual(true, actual);
            Assert.AreEqual(true, actualReversed);
        }

        [Test]
        public void VoidEntityVoidIndicatorComparisonReturnsTrue() {
            AccountingTransactionLine a = null;
            AccountingTransactionLineIndicator b = null;
            var actual = a == b;
            var actualReversed = b == a;
            Assert.AreEqual(true, actual);
            Assert.AreEqual(true, actualReversed);
        }
    }
}

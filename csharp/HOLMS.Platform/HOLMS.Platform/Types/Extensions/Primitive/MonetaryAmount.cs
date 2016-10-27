using System;

namespace HOLMS.Types.Primitive {
    public partial class MonetaryAmount {
        public MonetaryAmount(decimal d) {
            var absolute = Math.Abs(d);
            var wholeUnits = (int)absolute;
            var cents = Math.Round((absolute - wholeUnits) * 100);

            Dollars = (uint) wholeUnits;
            Cents = (uint) cents;
            IsNegative = d < 0;
        }
    }
}

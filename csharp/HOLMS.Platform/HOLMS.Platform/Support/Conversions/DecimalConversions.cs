using System;
using HOLMS.Types.Primitive;

namespace HOLMS.Support.Conversions {
    public static class DecimalConversions {
        public static MonetaryAmount ToMoney(this decimal d) {
            var absolute = Math.Abs(d);
            var wholeUnits = (int)absolute;
            var cents = Math.Round((absolute - wholeUnits) * 100);

            return new MonetaryAmount {
                Dollars = (uint) wholeUnits,
                Cents = (uint) cents,
                IsNegative = d < 0
            };
        }

        public static FixedPointRatio ToFPR(this decimal d) =>
            new FixedPointRatio {RatePpm = (uint) Math.Round(d * 1000000m) };
        }
}

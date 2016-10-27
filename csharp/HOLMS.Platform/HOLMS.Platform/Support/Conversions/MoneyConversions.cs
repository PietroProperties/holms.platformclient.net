using HOLMS.Types.Primitive;
using System;

namespace HOLMS.Support.Conversions {
    public static class MoneyConversions {
        public static decimal ToDecimal(this MonetaryAmount a) =>
            (a.Dollars + a.Cents / (decimal)100) * (a.IsNegative ? -1 : 1);

        public static Int32 ToCents(this decimal dollars) {
            return decimal.ToInt32(dollars * 100m);
        }

        public static decimal ToDollars(this Int32 cents) {
            return cents / 100m;
        }
    }
}

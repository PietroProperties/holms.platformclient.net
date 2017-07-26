using HOLMS.Types.Primitive;
using HOLMS.Platform.Support.Currency;

namespace HOLMS.Support.Conversions {
    public static class MoneyConversions {
        public static DecimalDollars ToDecimalDollars(this MonetaryAmount a) =>
            new DecimalDollars(a.Microdollars / 1000000m);

        public static DollarCents ToDollarCents(this MonetaryAmount a) =>
            a.ToDecimalDollars().ToDollarCents;
    }
}

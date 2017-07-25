using HOLMS.Platform.Support.Currency;

namespace HOLMS.Types.Primitive {
    public partial class MonetaryAmount {
        public DollarCents ToDC => new DollarCents(IsNegative, Dollars, Cents);
    }
}

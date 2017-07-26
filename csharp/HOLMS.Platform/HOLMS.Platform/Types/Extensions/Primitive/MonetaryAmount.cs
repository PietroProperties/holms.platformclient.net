using HOLMS.Platform.Support.Currency;

namespace HOLMS.Types.Primitive {
    public partial class MonetaryAmount {
        public DollarCents ToDC => new DollarCents(this);
        public DecimalDollars ToDD => new DecimalDollars(this);
    }
}

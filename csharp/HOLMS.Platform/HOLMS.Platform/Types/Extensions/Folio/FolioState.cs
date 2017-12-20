using System.Linq;
using HOLMS.Platform.Support.Currency;

namespace HOLMS.Types.Folio {
    public partial class FolioState {
        public DollarCents PostedChargeCredits => PostedChargeCreditsPrecise.ToDollarCents;
        public DollarCents PostedPayments => PostedPaymentsPrecise.ToDollarCents;
        public DollarCents RefundsTotal => RefundsTotalPrecise.ToDollarCents;

        private DecimalDollars PostedChargeCreditsPrecise => new DecimalDollars(
            ChargeCredits.Sum(c => c.PreTaxFeeSubtotal.ToDD.Amount +
                                   c.TaxesFees.Sum(t => t.Amount.ToDD.Amount) +
                                   c.FolioSwaps.Sum(s => s.Amount.ToDD.Amount)));
        public DecimalDollars PostedPaymentsPrecise => new DecimalDollars(
            Payments.Sum(p => p.Amount.ToDD.Amount));
        public DecimalDollars RefundsTotalPrecise => new DecimalDollars(
            Refunds.Sum(t => t.Amount.ToDD.Amount));

        public DollarCents Balance => (PostedChargeCreditsPrecise - 
            new DecimalDollars(GrossPayments) + RefundsTotalPrecise).ToDollarCents;
    }
}

namespace HOLMS.Types.Folio.FSv2 {
    public partial class FolioStatev2 {
        public DollarCents CurrentBalance => new DecimalDollars(
            CurrentNetCharges.ToDD.Amount       // includes gross charges, adjustments, taxes
            - PostedPayments.ToDD.Amount
            + PostedRefunds.ToDD.Amount).ToDollarCents;

        public DollarCents AnticipatedCheckoutBalance => new DecimalDollars(
            AnticipatedNetCharges.ToDD.Amount
            - PostedPayments.ToDD.Amount
            - UnusedPaymentAuthorizations.ToDD.Amount
            + PostedRefunds.ToDD.Amount).ToDollarCents;
    }
}

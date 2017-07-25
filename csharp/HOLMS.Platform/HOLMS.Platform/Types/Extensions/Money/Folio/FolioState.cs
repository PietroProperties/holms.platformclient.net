using System.Linq;
using HOLMS.Platform.Support.Currency;

namespace HOLMS.Types.Money.Folio {
    public partial class FolioState {
        public DollarCents PostedChargeCredits => DollarCents.FromCents(
            ChargeCredits.Sum(c => c.PreTaxFeeSubtotal.ToDC.TotalCents + 
                c.TaxesFees.Sum(t => t.Amount.ToDC.TotalCents) + 
                c.FolioSwaps.Sum(s => s.Amount.ToDC.TotalCents)));
        public DollarCents PostedPayments => DollarCents.FromCents(Payments.Sum(p => p.Amount.ToDC.TotalCents));
        public DollarCents RefundsTotal => DollarCents.FromCents(Refunds.Sum(t => t.Amount.ToDC.TotalCents));

        public DollarCents Balance => PostedChargeCredits - GrossPayments.ToDC + RefundsTotal;
    }
}

using HOLMS.Support.Conversions;
using System.Linq;

namespace HOLMS.Types.Money.Folio {
    public partial class FolioState {
        public decimal PostedChargeCredits => ChargeCredits.Sum(c => (
            c.PreTaxFeeSubtotal.ToDecimal() + 
            c.TaxesFees.Sum(t => t.Amount.ToDecimal()) + 
            c.FolioSwaps.Sum(s => s.Amount.ToDecimal())));
        public decimal PostedPayments => Payments.Sum(p => p.Amount.ToDecimal());
        public decimal RefundsTotal => Refunds.Sum(t => t.Amount.ToDecimal());

        public decimal Balance => PostedChargeCredits - GrossPayments.ToDecimal() + RefundsTotal;
    }
}

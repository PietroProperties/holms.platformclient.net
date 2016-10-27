using HOLMS.Support.Conversions;
using HOLMS.Types.Money.Folio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Support.DTOExtensions.Money {
    public static class FolioExtensions {
        public static decimal GetFolioAccountBalance(this FolioState fs) {
            return fs.ChargeCredits.Sum(cc =>
                cc.PreTaxFeeSubtotal.ToDecimal() +
                cc.TaxesFees.Sum(t => t.Amount.ToDecimal()))
                - fs.GrossPayments.ToDecimal();
        }
    }
}

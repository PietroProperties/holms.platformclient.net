using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HOLMS.Types.Folio
{
    public partial class TaxedReservationQuote
    {
        public Primitive.MonetaryAmount NetPrice {
            get {
                var total = LodgingPriceSubtotal.ToDD + IncidentalPriceSubtotal.ToDD
                    + TaxFeeTotals.Sum(t => t.QuotedTaxFeeAmount.ToDD.Amount);
                return total.ToPb;
            }
        }
    }
}

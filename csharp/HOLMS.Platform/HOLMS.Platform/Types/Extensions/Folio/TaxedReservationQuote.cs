using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HOLMS.Types.Folio {
    public partial class TaxedReservationQuote {
        public Primitive.MonetaryAmount NetPrice {
            get {
                var total = PretaxLodgingPriceSubtotal.ToDD + PretaxIncidentalPriceSubtotal.ToDD
                    + TaxFeeAssessments.Sum(t => t.QuotedTaxFeeAmount.ToDD.Amount);
                return total.ToPb;
            }
        }
    }
}

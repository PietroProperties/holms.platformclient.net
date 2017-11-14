using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HOLMS.Types.Folio {
    public partial class TaxedReservationQuote {
        public Primitive.MonetaryAmount NetPrice {
            get {
                var total = PretaxLodgingPriceSubtotal.ToDD + PretaxIncidentalPriceSubtotal.ToDD
                    + TaxAssessments.Sum(t => t.AssessedTaxAmount.ToDD.Amount);
                return total.ToPb;
            }
        }
    }
}

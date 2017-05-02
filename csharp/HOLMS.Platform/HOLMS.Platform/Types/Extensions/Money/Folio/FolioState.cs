﻿using HOLMS.Support.Conversions;
using HOLMS.Types.Extensions;
using System;
using System.Linq;

namespace HOLMS.Types.Money.Folio {
    public partial class FolioState {
        public decimal PostedChargeCredits => ChargeCredits.Sum(c => (c.PreTaxFeeSubtotal.ToDecimal() + c.TaxesFees.Sum(t => t.Amount.ToDecimal())));
        public decimal PostedPayments => Payments.Sum(p => p.Amount.ToDecimal());
        public decimal Balance => PostedChargeCredits - PostedPayments;
    }
}

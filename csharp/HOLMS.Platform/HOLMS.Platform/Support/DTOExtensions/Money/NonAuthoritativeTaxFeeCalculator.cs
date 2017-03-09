using HOLMS.Support.Conversions;
using HOLMS.Types.Money.Accounting;
using System.Collections.Generic;
using System.Linq;

namespace HOLMS.Support.DTOExtensions.Money {
    public class NonAuthoritativeTaxFeeCalculator {
        private int _stayLength;
        private bool _taxExempt;
        private IEnumerable<TaxFee> _taxFees;

        public NonAuthoritativeTaxFeeCalculator(IEnumerable<TaxFee> taxFees, bool reservationTaxExempt, int stayLength) {
            _taxFees = taxFees;
            _taxExempt = reservationTaxExempt;
            _stayLength = stayLength;
        }

        public decimal CalculateTaxes(decimal amount) {
            return _stayLength <= 30 && !_taxExempt ?
                _taxFees.Where(t => t.Category == TaxFeeCategory.Tax).Sum(t => t.TaxRate.ToDecimal() * amount) :
                0m;
        }

        public decimal CalculateFees(decimal amount) {
            return _taxFees.Where(t => t.Category == TaxFeeCategory.Fee).Sum(t => t.TaxRate.ToDecimal() * amount);
        }
    }
}

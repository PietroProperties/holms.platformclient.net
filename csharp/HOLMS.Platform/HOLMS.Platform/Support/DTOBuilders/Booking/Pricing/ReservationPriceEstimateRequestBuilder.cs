using HOLMS.Support.Time;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Booking.Pricing;
using HOLMS.Types.Primitive;
using HOLMS.Types.Supply;
using HOLMS.Types.Supply.RoomTypes;

namespace HOLMS.Support.DTOBuilders.Booking.Pricing {
    public class ReservationPriceEstimateRequestBuilder {
        private readonly bool _resExists;
        private readonly PbInclusiveOpsdateRange _dateRange;
        private readonly ReservationIndicator _res;
        private readonly RoomTypeIndicator _roomType;
        private readonly QualificationIndicator _qi;
        private readonly bool _taxExempt;
        private readonly int _numAdults;

        public ReservationPriceEstimateRequestBuilder(bool resExists,
            InclusiveOpsdateRange dateRange,
            ReservationIndicator ri, RoomTypeIndicator rt, QualificationIndicator qual,
            bool taxExempt, int numAdults) {
            _resExists = resExists;
            _dateRange = dateRange.ToPB;
            _res = ri;
            _roomType = rt;
            _qi = qual;
            _taxExempt = taxExempt;
            _numAdults = numAdults;
        }

        public ReservationPriceEstimateRequest Build() {
            var rper = new ReservationPriceEstimateRequest {
                AdultGuestCount = _numAdults,
                DateRange = _dateRange,
                TaxExempt = _taxExempt,
                ReservationExists = _resExists,
                RoomType = _roomType,
            };

            if (_res != null) {
                rper.Reservation = _res;
            }

            if (_qi != null) {
                rper.Q = _qi;
            }

            return rper;
        }
    }
}

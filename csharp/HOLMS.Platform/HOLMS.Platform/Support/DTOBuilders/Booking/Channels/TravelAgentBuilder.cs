using System;
using HOLMS.Platform.Support.Conversions;
using HOLMS.Platform.Support.Currency;
using HOLMS.Types.Booking.Channels;
using HOLMS.Types.Booking.Indicators;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.Channels {
    public class TravelAgentBuilder {
        private readonly TravelAgentIndicator _ind;
        private readonly string _iataId;
        private readonly CommissionType _t;
        private readonly decimal _commAmt;
        private readonly string _givenName;
        private readonly string _familyName;
        private readonly string _businessAddress1;
        private readonly string _businessAddress2;
        private readonly string _businessCity;
        private readonly string _businessState;
        private readonly string _businessZIP;
        private readonly string _businessNation;
        private readonly string _businessPhoneNumber;
        private readonly string _businessFAXNumber;
        private readonly string _businessEmailAddress;

        public TravelAgentBuilder(TravelAgentIndicator ind, string iataId, CommissionType t,
            decimal commissionAmount, string givenName, string familyName, string businessAddress1,
            string businessAddress2, string businessCity, string businessState, string businessZIP,
            string businessNation, string businessPhoneNumber, string businessFAXNumber,
            string businessEmailAddress) {

            _ind = ind;
            _iataId = iataId;
            _t = t;
            _commAmt = commissionAmount;
            _givenName = givenName;
            _familyName = familyName;
            _businessAddress1 = businessAddress1;
            _businessAddress2 = businessAddress2;
            _businessCity = businessCity;
            _businessState = businessState;
            _businessZIP = businessZIP;
            _businessNation = businessNation;
            _businessPhoneNumber = businessPhoneNumber;
            _businessFAXNumber = businessFAXNumber;
            _businessEmailAddress = businessEmailAddress;
        }

        public TravelAgent Build() {
            var ta = new TravelAgent {
                EntityId = _ind,
                IataId = _iataId,
                CommissionType = _t,
                GivenName = _givenName ?? string.Empty,
                FamilyName = _familyName ?? string.Empty,
                BusinessAddress1 = _businessAddress1 ?? string.Empty,
                BusinessAddress2 = _businessAddress2 ?? string.Empty,
                BusinessCity = _businessCity ?? string.Empty,
                BusinessState = _businessState ?? string.Empty,
                BusinessZip = _businessZIP ?? string.Empty,
                BusinessNation = _businessNation ?? string.Empty,
                BusinessPhoneNumber = _businessPhoneNumber ?? string.Empty,
                BusinessFaxNumber = _businessFAXNumber ?? string.Empty,
                BusinessEmailAddress = _businessEmailAddress ?? string.Empty
            };

            if (_t == CommissionType.FlatPerBooking) {
                ta.CommissionAmount = new DecimalDollars(_commAmt).ToPb;
            } else if (_t == CommissionType.PercentOfBooking) {
                ta.CommissionPercentage = _commAmt.ToFPR();
            } else {
                throw new NotImplementedException();
            }

            return ta;
        }
    }
}

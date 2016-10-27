using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking {
    public partial class CancellationPolicy : EntityDTO<CancellationPolicyIndicator> {
        public CancellationPolicy(CancellationPolicyIndicator id, string description,
            int noPenaltyDays, int forfeitDepositDays, CancellationFeeCategory c,
            decimal cancellationFeeAmount, decimal cancellationFeeRate,
            string policyText) {
            EntityId = id;
            Description = description;
            NoPenaltyDays = noPenaltyDays;
            ForfeitDepositDays = forfeitDepositDays;
            FeeCategory = c;
            CancellationFeeAmount = new MonetaryAmount(cancellationFeeAmount);
            CancellationFeeRate = new FixedPointRatio(cancellationFeeRate);
            CancellationPolicyText = policyText;
        }

        public override CancellationPolicyIndicator GetIndicator() {
            return EntityId;
        }
    }
}

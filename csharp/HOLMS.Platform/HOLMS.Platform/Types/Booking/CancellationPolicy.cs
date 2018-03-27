using HOLMS.Platform.Support.Currency;
using HOLMS.Platform.Types;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Booking {
    public partial class CancellationPolicy : EntityDTO<CancellationPolicyIndicator> {
        public CancellationPolicy(CancellationPolicyIndicator id, string description,
            int noPenaltyDays, CancellationFeeCategory c,
            DollarCents cancellationFeeAmount, decimal cancellationFeeRate,
            string policyText) {
            EntityId = id;
            Description = description;
            NoPenaltyDays = noPenaltyDays;
            FeeCategory = c;
            CancellationFeeAmount = cancellationFeeAmount.ToPb;
            CancellationFeeRate = new FixedPointRatio(cancellationFeeRate);
            CancellationPolicyText = policyText;
        }

        public override CancellationPolicyIndicator GetIndicator() {
            return EntityId;
        }
    }
}

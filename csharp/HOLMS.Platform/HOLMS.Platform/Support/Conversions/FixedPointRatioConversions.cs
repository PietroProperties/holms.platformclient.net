using System;
using HOLMS.Types.Primitive;

namespace HOLMS.Support.Conversions {
    public static class FixedPointRatioConversions {
        public static decimal ToDecimal(this FixedPointRatio fpr) =>
            Convert.ToDecimal(fpr.RatePpm/1000000m);
    }
}

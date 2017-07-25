using System;
using HOLMS.Types.Primitive;

namespace HOLMS.Support.Conversions {
    public static class DecimalConversions {
        public static FixedPointRatio ToFPR(this decimal d) =>
            new FixedPointRatio {RatePpm = (uint) Math.Round(d * 1000000m) };
    }
}

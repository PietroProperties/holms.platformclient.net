using System;

namespace HOLMS.Types.Primitive {
    public partial class FixedPointRatio {
        public FixedPointRatio(decimal r) {
            RatePpm = (uint) Math.Round(r*1000000);
        }
    }
}

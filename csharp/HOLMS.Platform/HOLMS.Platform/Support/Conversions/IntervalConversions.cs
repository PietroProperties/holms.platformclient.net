using HOLMS.Types.Primitive;
using NodaTime;

namespace HOLMS.Platform.Support.Conversions {
    public static class IntervalConversions {
        public static PbInterval ToPB(this Interval i) {
            return new PbInterval(i.Start.ToTS(), i.End.ToTS());
        }
    }
}

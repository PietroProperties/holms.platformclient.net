using Google.Protobuf.WellKnownTypes;
using HOLMS.Platform.Support.Conversions;
using NodaTime;

namespace HOLMS.Types.Primitive {
    public partial class PbInterval {
        public PbInterval(Timestamp start, Timestamp end) {
            Start = start;
            End = end;
        }

        public PbInterval(Instant start, Instant end) {
            Start = start.ToTS();
            End = end.ToTS();
        }

        public Interval ToNoda => new Interval(Start.ToInstant(), End.ToInstant());
    }
}

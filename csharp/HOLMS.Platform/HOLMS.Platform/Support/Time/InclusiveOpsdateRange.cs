using HOLMS.Platform.Support.Conversions;
using HOLMS.Types.Primitive;
using NodaTime;

namespace HOLMS.Platform.Support.Time {
    public class InclusiveOpsdateRange : InclusiveDateRange {
        public InclusiveOpsdateRange() { }
        public InclusiveOpsdateRange(LocalDate start, int daysInRange) : base(start, daysInRange) { }
        public InclusiveOpsdateRange(LocalDate start, LocalDate end) : base(start, end) { }
        public InclusiveOpsdateRange(InclusiveOpsdateRange other) : base(other) { }
        public InclusiveOpsdateRange(InclusiveDateRange other) : base (other.Start, other.End) { }
        public InclusiveOpsdateRange(PbInclusiveOpsdateRange pb)
            : base(pb.StartDate.ToLD(), pb.EndDate.ToLD()) { }

        public PbInclusiveOpsdateRange ToPB =>
            new PbInclusiveOpsdateRange {
                StartDate = Start.ToPb(),
                EndDate = End.ToPb()
            };

        public InclusiveOpsdateRange ExtendOver(InclusiveDateRange dr) {
            return new InclusiveOpsdateRange(
                Start < dr.Start ? Start : dr.Start,
                dr.End > End ? dr.End : End
            );
        }
    }
}

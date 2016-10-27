using System;
using HOLMS.Support.Conversions;
using HOLMS.Types.Primitive;
using NodaTime;

namespace HOLMS.Support.Time {
    public class InclusiveCalendarDateRange : InclusiveDateRange {
        public InclusiveCalendarDateRange() { }

        public InclusiveCalendarDateRange(InclusiveCalendarDateRange other) : base(other) { }

        public InclusiveCalendarDateRange(DateTime startdt, DateTime enddt)
            : base(new LocalDate(startdt.Year, startdt.Month, startdt.Day),
                new LocalDate(enddt.Year, enddt.Month, enddt.Day)) { }

        public InclusiveCalendarDateRange(PbInclusiveCalendarDateRange pb)
            : base(pb.StartDate.ToLD(), pb.EndDate.ToLD()) { }

        public PbInclusiveCalendarDateRange ToPB =>
            new PbInclusiveCalendarDateRange {
                StartDate = Start.ToPb(),
                EndDate = End.ToPb()
            };
    }
}

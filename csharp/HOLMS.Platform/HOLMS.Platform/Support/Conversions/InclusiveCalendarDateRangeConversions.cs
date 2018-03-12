using HOLMS.Platform.Support.Time;
using HOLMS.Types.Primitive;

namespace HOLMS.Platform.Support.Conversions {
    public static class InclusiveCalendarDateRangeConversions {
        public static InclusiveCalendarDateRange ToICDR(this PbInclusiveCalendarDateRange dto) {
            return new InclusiveCalendarDateRange(dto);
        }
    }
}

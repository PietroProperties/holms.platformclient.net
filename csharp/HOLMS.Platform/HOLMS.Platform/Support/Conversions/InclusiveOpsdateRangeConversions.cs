using HOLMS.Support.Time;
using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Support.Conversions {
    public static class InclusiveOpsdateRangeConversions {
        public static InclusiveOpsdateRange GetIODR(this IBoundByDateRangeMarker dto) {
            return new InclusiveOpsdateRange(dto.PBDateRange);
        }

        public static InclusiveOpsdateRange ToIODR(this PbInclusiveOpsdateRange dto) {
            return new InclusiveOpsdateRange(dto);
        }
    }
}

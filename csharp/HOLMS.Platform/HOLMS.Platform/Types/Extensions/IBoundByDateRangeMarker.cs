using HOLMS.Types.Primitive;

namespace HOLMS.Types.Extensions {
    public interface IBoundByDateRangeMarker {
        PbInclusiveOpsdateRange PBDateRange { get; }
    }
}

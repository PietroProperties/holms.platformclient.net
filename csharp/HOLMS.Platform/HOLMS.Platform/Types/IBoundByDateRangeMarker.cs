using HOLMS.Types.Primitive;

namespace HOLMS.Platform.Types {
    public interface IBoundByDateRangeMarker {
        PbInclusiveOpsdateRange PBDateRange { get; }
    }
}

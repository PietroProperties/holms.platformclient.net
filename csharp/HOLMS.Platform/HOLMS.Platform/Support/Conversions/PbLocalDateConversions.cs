using HOLMS.Types.Primitive;
using NodaTime;

namespace HOLMS.Support.Conversions {
    public static class PbLocalDateConversions {
        public static LocalDate ToLD(this PbLocalDate ld) {
            return new LocalDate((int)ld.Year, (int)ld.Month, (int)ld.Day);
        }
    }
}

using System;
using System.Globalization;
using HOLMS.Types.Primitive;
using NodaTime;

namespace HOLMS.Platform.Support.Conversions {
    public static class LocalDateConversions {
        public static PbLocalDate ToPb(this LocalDate d) =>
            new PbLocalDate {
                Year = (uint) d.Year,
                Month = (uint) d.Month,
                Day = (uint) d.Day
            };

        public static string ToShortDate(this LocalDate d) =>
            new DateTime(d.Year, d.Month, d.Day).ToString("d", CultureInfo.CurrentCulture);
    }
}

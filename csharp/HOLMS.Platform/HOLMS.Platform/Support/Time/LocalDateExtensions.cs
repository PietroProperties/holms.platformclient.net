using System;
using NodaTime;

namespace HOLMS.Platform.Support.Time {
    public static class LocalDateExtensions {
        public static LocalDate LocalToday {
            get {
                var now = SystemClock.Instance.GetCurrentInstant();
                var tz = DateTimeZoneProviders.Tzdb.GetSystemDefault();
                return now.InZone(tz).Date;
            }
        }

        public static DateTime ConvertLocalDateDateTime(this LocalDate ld) {
            return new DateTime(ld.Year, ld.Month, ld.Day);
        }

        public static LocalDate ConvertDateTimeLocalDate(this DateTime dt) {
            return new LocalDate(dt.Year, dt.Month, dt.Day);
        }

        public static bool IsWeekendNight(LocalDate d) {
            // NOTE(DA) So much for this program working in Israel
            return d.DayOfWeek == IsoDayOfWeek.Friday ||
                   d.DayOfWeek == IsoDayOfWeek.Saturday;
        }

        public static bool IsWeekDayNight(LocalDate d) {
            return !IsWeekendNight(d);
        }
    }
}

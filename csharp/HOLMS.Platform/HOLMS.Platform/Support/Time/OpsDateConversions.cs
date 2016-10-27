using NodaTime;
using System;

namespace HOLMS.Support.Time {
    public static class OpsDateConversions {
        public static DateTime ConvertDepartureDateOpsToHuman(this DateTime opsDate) {
            return opsDate.AddDays(1);
        }

        public static DateTime ConvertDepartureDateHumanToOpsDT(this DateTime humanDate) {
            return humanDate.AddDays(-1);
        }

        public static DateTime ConvertDepartureDateOpsToHuman(this LocalDate opsDate) {
            var d = opsDate.PlusDays(1);
            return new DateTime(d.Year, d.Month, d.Day);
        }

        public static LocalDate ConvertDepartureDateHumanToOps(this DateTime humanDate) {
            var d = new LocalDate(humanDate.Year, humanDate.Month, humanDate.Day);
            return d.PlusDays(-1);
        }
    }
}

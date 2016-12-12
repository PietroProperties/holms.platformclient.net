using HOLMS.Types.TenancyConfig;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOLMS.Support.Time;

namespace HOLMS.Platform.Support.DTOExtensions.TenancyConfig {
    public static class PropertyExtensions {
        public static LocalDate GetOpsdateForDateTime(this Property p, DateTime currentLocalTime) {
            var offset = p.CheckinTimeOfDay.ToTimeSpan();
            var opsDateTime = currentLocalTime - offset;
            return opsDateTime.Date.ConvertDateTimeLocalDate();
        }

        public static bool IsAllowedCheckinTime(this Property p, DateTime currentLocalTime, LocalDate arrivalOpsdate) {
            var offset = p.CheckinTimeOfDay.ToTimeSpan().Subtract(new TimeSpan(Convert.ToInt32(p.AllowedEarlyCheckinHours), 0, 0));
            return (currentLocalTime - offset).ConvertDateTimeLocalDate() >= arrivalOpsdate; 
        }
    }
}

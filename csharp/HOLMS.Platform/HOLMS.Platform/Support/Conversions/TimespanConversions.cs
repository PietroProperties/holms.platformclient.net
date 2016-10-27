using System;
using Google.Protobuf.WellKnownTypes;

namespace HOLMS.Support.Conversions {
    public static class TimespanConversions {
        public static Duration ToPb(this TimeSpan ts) {
            var secs = Convert.ToInt64(ts.TotalMilliseconds/1000);
            var nanos = Convert.ToInt32((ts.TotalMilliseconds - secs*1000)*100000);

            return new Duration {
                Seconds = secs,
                Nanos = nanos
            };
        }
    }
}

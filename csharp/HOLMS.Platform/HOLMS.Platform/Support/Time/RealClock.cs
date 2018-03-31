using System;
using NodaTime;

namespace HOLMS.Platform.Support.Time {
    public class RealClock : IClock {
        public Instant GetCurrentInstant() => Instant.FromDateTimeUtc(DateTime.UtcNow);
    }
}

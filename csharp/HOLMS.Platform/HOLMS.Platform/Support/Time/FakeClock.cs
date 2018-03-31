using System;
using NodaTime;

namespace HOLMS.Platform.Support.Time {
    public class FakeClock : IClock {
        private Instant? _stoppedAt;
        protected Instant ActualNow => Instant.FromDateTimeUtc(DateTime.UtcNow);

        public void Stop() => StopAt(ActualNow);

        public void StopAt(Instant i) {
            _stoppedAt = i;
        }

        public Instant GetCurrentInstant() => _stoppedAt ?? ActualNow;
    }
}

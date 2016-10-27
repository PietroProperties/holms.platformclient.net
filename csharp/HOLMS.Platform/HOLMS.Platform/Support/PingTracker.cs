using System;
using System.Collections.Generic;

namespace HOLMS.Support {
    public class PingTracker {
        private readonly Dictionary<Guid, int> _pings;

        public PingTracker() {
            _pings = new Dictionary<Guid, int>();
        }

        public void StartResponseTracking(Guid cookie) {
            lock (_pings) {
                _pings[cookie] = 0;
            }
        }

        public void PingResonseReceived(Guid cookie) {
            lock (_pings) {
                // If we're running in an environment with multiple machines,
                // we might get responses to pings we didn't send -- no big deal
                if (_pings.ContainsKey(cookie)) {
                    _pings[cookie]++;
                }
            }
        }

        public int StopResponseTracking(Guid cookie) {
            lock (_pings) {
                var responses = _pings[cookie];
                _pings.Remove(cookie);
                return responses;
            }
        }
    }
}

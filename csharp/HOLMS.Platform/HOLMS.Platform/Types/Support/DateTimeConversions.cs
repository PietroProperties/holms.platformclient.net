using System;
using Google.Protobuf.WellKnownTypes;

namespace HOLMS.Types.Extensions.Support {
    public static class DateTimeConversions {
        public static Timestamp ToTS(this DateTime dt) =>
            Timestamp.FromDateTime(dt.ToUniversalTime());
    }
}

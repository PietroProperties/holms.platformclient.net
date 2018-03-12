using System;
using Google.Protobuf.WellKnownTypes;
using NodaTime;

namespace HOLMS.Platform.Support.Conversions {
    public static class DateTimeConversions {
        public static Timestamp ToTS(this DateTime dt) =>
            Timestamp.FromDateTime(dt.ToUniversalTime());

        public static LocalDate ToLD(this Timestamp ts) {
            var dt = ts.ToDateTime();
            return new LocalDate(dt.Year, dt.Month, dt.Day);
        }

        public static Instant ToInstant(this Timestamp ts) {
            return Instant.FromDateTimeUtc(ts.ToDateTime().ToUniversalTime());
        }

        public static Timestamp ToTS(this Instant ins) {
            return ins.ToDateTimeUtc().ToTS();
        }
    }
}

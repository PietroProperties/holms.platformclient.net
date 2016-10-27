using System;
using Google.Protobuf.WellKnownTypes;
using NodaTime;

namespace HOLMS.Support.Conversions {
    public static class DateTimeConversions {
        public static Timestamp ToTS(this DateTime dt) =>
            Timestamp.FromDateTime(dt.ToUniversalTime());

        public static LocalDate ToLD(this Timestamp ts) {
            var dt = ts.ToDateTime();
            return new LocalDate(dt.Year, dt.Month, dt.Day);
        }
    }
}

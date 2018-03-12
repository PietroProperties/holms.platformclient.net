using System;

namespace HOLMS.Platform.Support {
    /// <summary>
    /// Cron-style job scheduler.
    /// </summary>
    public class RecurrenceDescriptor {
        // Idea: implement a subset of UNIX's cron scheduling.
        // We don't need all the capabilities of this thing, flesh it out as we go.
        public SecondsDescriptorPart Seconds { get; }
        public MinutesDescriptorPart Minutes { get; }
        public HoursDescriptorPart Hours { get; }
        public DayOfMonthDescriptorPart DaysOfMonth { get; }
        public MonthDescriptorPart Months { get; }
        public DayOfWeekDescriptorPart DaysOfWeek { get; }
        public YearDescriptorPart Years { get; }

        public RecurrenceDescriptor() {
            Seconds = new SecondsDescriptorPart("*");
            Minutes = new MinutesDescriptorPart("*");
            Hours = new HoursDescriptorPart("*");
            DaysOfMonth = new DayOfMonthDescriptorPart("*");
            Months = new MonthDescriptorPart("*");
            DaysOfWeek = new DayOfWeekDescriptorPart("*");
            Years = new YearDescriptorPart("*");
        }

        public RecurrenceDescriptor(string rd) {
            var parts = rd.Split();
            if (parts.Length != 7) {
                throw new Exception("Invalid recurrence descriptor format");
            }

            Seconds = new SecondsDescriptorPart(parts[0]);
            Minutes = new MinutesDescriptorPart(parts[1]);
            Hours = new HoursDescriptorPart(parts[2]);
            DaysOfMonth = new DayOfMonthDescriptorPart(parts[3]);
            Months = new MonthDescriptorPart(parts[4]);
            DaysOfWeek = new DayOfWeekDescriptorPart(parts[5]);
            Years = new YearDescriptorPart(parts[6]);
        }

        public RecurrenceDescriptor(string seconds, string minutes, string hours,
                string daysOfMonth, string months, string daysOfWeek, string years) {
            Seconds = new SecondsDescriptorPart(seconds);
            Minutes = new MinutesDescriptorPart(minutes);
            Hours = new HoursDescriptorPart(hours);
            DaysOfMonth = new DayOfMonthDescriptorPart(daysOfMonth);
            Months = new MonthDescriptorPart(months);
            DaysOfWeek = new DayOfWeekDescriptorPart(daysOfWeek);
            Years = new YearDescriptorPart(years);
        }

        public override string ToString() {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}", Seconds, Minutes, Hours,
                DaysOfMonth, Months, DaysOfWeek, Years);
        }

        public DayOfWeek? GetDayOfWeek() {
            return DaysOfWeek.DescriptorPartString == "*"
                ? (DayOfWeek?)null
                : (DayOfWeek)(int.Parse(DaysOfWeek.DescriptorPartString) - 1);
        }

        public IIFExportFrequency GetFrequency() {
            if (DaysOfMonth.DescriptorPartString != "*") {
                return IIFExportFrequency.Monthly;
            } else if (DaysOfWeek.DescriptorPartString != "*") {
                return IIFExportFrequency.Weekly;
            } else {
                return IIFExportFrequency.Daily;
            }
        }

        public int? GetDayOfMonth() {
            return DaysOfMonth.DescriptorPartString == "*"
                ? (int?)null : int.Parse(DaysOfMonth.DescriptorPartString);
        }
    }
}

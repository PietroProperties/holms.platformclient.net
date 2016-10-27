// http://www.quartz-scheduler.org/documentation/quartz-1.x/tutorials/crontrigger
// A "recurrence descriptor" describes the schedule of a repeating task
// (without allowing for exceptions). We've used the UNIX cron format to
// stringify how we represent recurrences.

namespace HOLMS.Support {
    public abstract class RecurrenceDescriptorPart {
        // No wildcards yet
        public string DescriptorPartString { get; }

        protected RecurrenceDescriptorPart(string d) {
            DescriptorPartString = d;
        }

        public override string ToString() {
            return DescriptorPartString;
        }
    }

    public class SecondsDescriptorPart : RecurrenceDescriptorPart {
        public SecondsDescriptorPart(string s) : base(s) { }
    }

    public class MinutesDescriptorPart : RecurrenceDescriptorPart {
        public MinutesDescriptorPart(string s) : base(s) { }
    }

    public class HoursDescriptorPart : RecurrenceDescriptorPart {
        public HoursDescriptorPart(string s) : base(s) { }
    }

    public class DayOfMonthDescriptorPart : RecurrenceDescriptorPart {
        public DayOfMonthDescriptorPart(string s) : base(s) { }
    }

    public class MonthDescriptorPart : RecurrenceDescriptorPart {
        public MonthDescriptorPart(string s) : base(s) { }
    }

    public class DayOfWeekDescriptorPart : RecurrenceDescriptorPart {
        public DayOfWeekDescriptorPart(string s) : base(s) { }
    }

    public class YearDescriptorPart : RecurrenceDescriptorPart {
        public YearDescriptorPart(string s) : base(s) { }
    }
}

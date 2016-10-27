using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NodaTime;

namespace HOLMS.Support.Time {
    public abstract class InclusiveDateRange : IEnumerable<LocalDate> {
        private readonly int _hashCode;
        public LocalDate Start;
        public LocalDate End;

        protected InclusiveDateRange() {
            var now = DateTime.Now;
            Start = new LocalDate(now.Year, now.Month, now.Day);
            End = Start.PlusDays(1);
            _hashCode = $"{Start}-{End}".GetHashCode();
        }

        protected InclusiveDateRange(LocalDate start, LocalDate end) {
            Start = start;
            End = end;
        }

        protected InclusiveDateRange(LocalDate start, int daysInRange) {
            Start = start;
            End = start.PlusDays(daysInRange - 1);
        }

        protected InclusiveDateRange(InclusiveDateRange other) {
            Start = other.Start;
            End = other.End;
        }

        public DateTime StartDateTime {
            get { return new DateTime(Start.Year, Start.Month, Start.Day); }
            set { Start = new LocalDate(value.Year, value.Month, value.Day); }
        }

        public DateTime EndDateTime {
            get { return new DateTime(End.Year, End.Month, End.Day); }
            set { End = new LocalDate(value.Year, value.Month, value.Day); }
        }

        public long DaysInRange {
            get { return Period.Between(Start, End, PeriodUnits.Days).Days + 1; }
        }

        public bool Contains(LocalDate ld) {
            return (Start <= ld) && (ld <= End);
        }

        public IEnumerable<DateTime> GetDateTimeEnumerable() {
            return this.Select(d => new DateTime(d.Year, d.Month, d.Day));
        }

        // TODO(DA) Clean up this duplication somehow?
        IEnumerator<LocalDate> IEnumerable<LocalDate>.GetEnumerator() {
            for (var onDay = Start; onDay <= End; onDay = onDay.PlusDays(1)) {
                yield return onDay;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            for (var onDay = Start; onDay <= End; onDay = onDay.PlusDays(1)) {
                yield return onDay;
            }
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(obj, this)) {
                return true;
            }

            if (!(obj is InclusiveDateRange)) {
                return false;
            }

            var other_idr = (InclusiveDateRange)obj;
            return other_idr.Start == Start && other_idr.End == End;
        }

        public static bool operator ==(InclusiveDateRange a, InclusiveDateRange b) {
            if ((object)a == null ^ (object)b == null) {
                return false;
            } else if ((object)a == null) {
                return true;
            } else {
                return a.Equals(b);
            }
        }

        public static bool operator !=(InclusiveDateRange a, InclusiveDateRange b) {
            return !(a == b);
        }

        public LocalDate this[int index] => Start.PlusDays(index);

        public override int GetHashCode() => _hashCode;
    }
}

// DateMap.cs
// Maps a (potentially infinite) range of dates to a value

using System.Collections;
using System.Collections.Generic;
using HOLMS.Support.Time;
using NodaTime;

namespace HOLMS.Support {
    public class DateMap<T> : IEnumerable<T> {
        private readonly Dictionary<LocalDate, T> _dict;
        private readonly T _default;

        public DateMap(T defaultValue) {
            _dict = new Dictionary<LocalDate, T>();
            _default = defaultValue;
        }

        public T this[LocalDate d] {
            get { return _dict.ContainsKey(d) ? _dict[d] : _default; }
            set { _dict[d] = value; }
        }

        public void Clear() {
            _dict.Clear();
        }

        public bool ContainsKey(LocalDate d) {
            return _dict.ContainsKey(d);
        }

        public int Count {
            get { return _dict.Count; }
        }

        public void IncrementRange(InclusiveDateRange r, T incrementAmount) {
            foreach (var day in r) {
                _dict[day] = Add(incrementAmount, _dict.ContainsKey(day) ? _dict[day] : _default);
            }
        }

        public ISet<LocalDate> DaysWithSetValue {
            get { return new HashSet<LocalDate>(_dict.Keys); }
        }

        public IEnumerator<T> GetEnumerator() {
            return _dict.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return _dict.Values.GetEnumerator();
        }

        private static T Add(T number1, T number2) {
            dynamic a = number1;
            dynamic b = number2;
            return a + b;
        }
    }
}

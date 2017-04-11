using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HOLMS.Platform.Support.ReservationTags {
    public class ImmutableTagSet : IEnumerable<ReservationTagBase>, IEquatable<ImmutableTagSet> {
        private readonly HashSet<ReservationTagBase> _tags;

        public bool IsEmpty => _tags.Count == 0;
        public int Count => _tags.Count;

        public ImmutableTagSet() {
            _tags = new HashSet<ReservationTagBase>();
        }

        public ImmutableTagSet(IEnumerable<string> tagDescriptors) : this() {
            if (tagDescriptors == null) {
                // This is used to parse proto messages a lot, so this was added
                // to avoid requiring a tedious null check every time
                return;
            }

            foreach (var t in tagDescriptors) {
                _tags.Add(ReservationTagBase.CreateFromDescriptor(t));
            }
        }

        public ImmutableTagSet(IEnumerable<ReservationTagBase> tags) : this() {
            if (tags == null) {
                return;
            }

            foreach (var tag in tags) {
                _tags.Add(tag);
            }
        }

        public ImmutableTagSet(ReservationTagBase tag) : this() {
            _tags.Add(tag);
        }

        public T FirstOfTypeOrDefault<T>() => _tags.OfType<T>().SingleOrDefault();

        public List<string> GetDescriptors() =>
            _tags.Select(t => t.ToString()).ToList();

        public bool IsSubsetOf(ImmutableTagSet other) => _tags.IsSubsetOf(other._tags);

        public bool Equals(ImmutableTagSet other) =>
            _tags.SetEquals(other._tags);

        public IEnumerator<ReservationTagBase> GetEnumerator() => _tags.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _tags.GetEnumerator();

        public static ImmutableTagSet Empty => new ImmutableTagSet();
    }
}

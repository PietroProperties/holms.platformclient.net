using System;

namespace HOLMS.Types.Extensions {
    public abstract class EntityDTO<T> : IEquatable<T> where T : EntityIndicator<T> {
        public abstract T GetIndicator();

        public Guid GuidID {
            get { return GetIndicator().GuidID; }
        }

        public static implicit operator T(EntityDTO<T> info) {
            return info?.GetIndicator() ?? null as T;
        }

        public bool Equals(T other) {
            return GetIndicator() == other;
        }

        public static bool operator ==(EntityDTO<T> x, EntityDTO<T> y) {
            if (ReferenceEquals(x, null) ^ ReferenceEquals(y, null)) {
                return false;
            }
            return ReferenceEquals(x, null) ? true : x.Equals(y);
        }

        public static bool operator !=(EntityDTO<T> x, EntityDTO<T> y) {
            return !(x == y);
        }

        public abstract override bool Equals(object obj);

        public abstract override int GetHashCode();
    }
}

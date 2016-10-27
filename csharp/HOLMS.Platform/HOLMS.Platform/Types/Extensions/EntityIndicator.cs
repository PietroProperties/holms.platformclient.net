using HOLMS.Types.Primitive;
using System;

namespace HOLMS.Types.Extensions {
    public abstract class EntityIndicator<T> {
        public static bool operator ==(EntityIndicator<T> self, EntityIndicator<T> other) {
            if (ReferenceEquals(self, null)) {
                return ReferenceEquals(other, null);
            } else {
                return self.Equals(other);
            }
        }

        public abstract Uuid GetUuidID();

        public Guid GuidID {
            get {
                return new Guid(GetUuidID().Value.ToByteArray());
            }
        }

        public static bool operator !=(EntityIndicator<T> self, EntityIndicator<T> other) {
            return !(self == other);
        }

        public abstract override bool Equals(object obj);

        public abstract override int GetHashCode();
    }
}

namespace HOLMS.Types.Supply {
    public partial class QualificationIndicator {
        public static bool operator ==(QualificationIndicator x, QualificationIndicator y) {
            if(ReferenceEquals(x, null)) {
                return (ReferenceEquals(y, null));
            }
            return x.Equals(y);
        }

        public static bool operator !=(QualificationIndicator x, QualificationIndicator y) {
            return !(x == y);
        }

        public QualificationIndicator(string ind) {
            Id = ind;
        }
    }
}

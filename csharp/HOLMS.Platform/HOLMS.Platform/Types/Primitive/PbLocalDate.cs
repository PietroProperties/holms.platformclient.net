using System;

namespace HOLMS.Types.Primitive {
    public partial class PbLocalDate : IComparable {
        public int CompareTo(object obj) {
            var pbld = obj as PbLocalDate;
            if (pbld == null) {
                return 1;
            }

            if (pbld.Year != Year) {
                return Year.CompareTo(pbld.Year);
            }

            if (pbld.Month != Month) {
                return Month.CompareTo(pbld.Month);
            }

            if (pbld.Day != Day) {
                return Day.CompareTo(pbld.Day);
            }

            return 0;
        }
    }
}

using System;
using HOLMS.Types.Primitive;

namespace HOLMS.Platform.Support.Currency {
    public struct DollarCents : IComparable<DollarCents>, IEquatable<DollarCents> {
        private const uint OneMillion = 1000000;
        public readonly bool IsNegative;
        public readonly uint Dollars;
        public readonly uint Cents;

        public DollarCents(bool isNegative, uint dollars, uint cents) {
            IsNegative = isNegative;
            Dollars = dollars;
            Cents = cents;
        }

        public DollarCents(MonetaryAmount amt) {
            var dc = FromCents((int) Math.Round(amt.Microdollars / (decimal) OneMillion, MidpointRounding.ToEven));

            IsNegative = dc.IsNegative;
            Dollars = dc.Dollars;
            Cents = dc.Cents;
        }

        public static DollarCents FromCents(int cents) {
            var isneg = cents < 0;

            var posCents = Math.Abs(cents);
            var wholeDollars = (uint)posCents / 100;
            var centsLeft = (uint)(posCents - wholeDollars * 100);

            return new DollarCents(isneg, wholeDollars, centsLeft);
        }

        public static DollarCents Zero => new DollarCents(false, 0, 0);

        public int TotalCents => (int)Math.Abs(Dollars * 100 + Cents);
        public decimal AsDecimal => TotalCents / 100m;

        public MonetaryAmount ToPb => new MonetaryAmount {
            Microdollars = TotalCents * OneMillion
        };

        private static int CompareTo(DollarCents x, DollarCents y) {
            var isNegativeComparison = x.IsNegative.CompareTo(y.IsNegative);
            if (isNegativeComparison != 0) {
                return isNegativeComparison;
            }

            var dollarsComparison = x.Dollars.CompareTo(y.Dollars);
            if (dollarsComparison != 0) {
                return dollarsComparison;
            }

            return x.Cents.CompareTo(y.Cents);
        }

        // h/t https://stackoverflow.com/questions/20593755/why-do-i-have-to-overload-operators-when-implementing-compareto
        public int CompareTo(DollarCents x) { return CompareTo(this, x); }
        public bool Equals(DollarCents x) { return CompareTo(this, x) == 0; }
        public static bool operator <(DollarCents x, DollarCents y) { return CompareTo(x, y) < 0; }
        public static bool operator >(DollarCents x, DollarCents y) { return CompareTo(x, y) > 0; }
        public static bool operator <=(DollarCents x, DollarCents y) { return CompareTo(x, y) <= 0; }
        public static bool operator >=(DollarCents x, DollarCents y) { return CompareTo(x, y) >= 0; }
        public static bool operator ==(DollarCents x, DollarCents y) { return CompareTo(x, y) == 0; }
        public static bool operator !=(DollarCents x, DollarCents y) { return CompareTo(x, y) != 0; }

        public static DollarCents operator +(DollarCents a, DollarCents b) => FromCents(a.TotalCents + b.TotalCents);
        public static DollarCents operator -(DollarCents a, DollarCents b) => FromCents(a.TotalCents - b.TotalCents);

        public override bool Equals(object obj) {
            return (obj is DollarCents) && (CompareTo(this, (DollarCents)obj) == 0);
        }

        public override int GetHashCode() {
            unchecked {
                var hashCode = IsNegative.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)Dollars;
                hashCode = (hashCode * 397) ^ (int)Cents;
                return hashCode;
            }
        }

        public override string ToString() {
            // This is tricky. Force $ irrespective of locale, because we really are dealing with dollars.

            if (IsNegative) {
                return $"(${Dollars}.{Cents:00})";
            } else {
                return $"${Dollars}.{Cents:00}";
            }
        }
    }
}

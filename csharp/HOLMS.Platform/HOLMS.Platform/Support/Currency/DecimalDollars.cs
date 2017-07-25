using System;
using HOLMS.Types.Primitive;

namespace HOLMS.Platform.Support.Currency {
    /// <summary>
    /// DecimalDollars does high-precision monetary arithmetic, backed by the
    /// CLR's System.Decimal. Internal calculations and db-backed model objects
    /// should use this class.
    /// </summary>
    public struct DecimalDollars : IEquatable<DecimalDollars> {
        // TODO(DA) Make this private. Try not to access it directly
        public readonly decimal Amount;

        public int TotalCents => (int)Math.Round(Amount * 100, MidpointRounding.ToEven);

        private decimal NonNegativeAmount => (Amount < 0 ? -1 : 1) * Amount;
        private uint NonNegativeDollars => (uint)NonNegativeAmount;
        private uint RoundedCents => (uint)Math.Round(((NonNegativeAmount - NonNegativeDollars) * 100),
            MidpointRounding.ToEven);

        /// <summary>
        /// Standard constructor, creates from decimal
        /// </summary>
        /// <param name="amt"></param>
        public DecimalDollars(decimal amt) {
            Amount = amt;
        }

        /// <summary>
        /// Create a high-precision DecimalDollars object from a low-precision
        /// MonetaryAmount.
        /// </summary>
        /// <param name="amt"></param>
        public DecimalDollars(MonetaryAmount amt) {
            Amount = (amt.IsNegative ? -1 : 1) * (amt.Dollars + amt.Cents / 100m);
        }

        public static DecimalDollars? FromNullable(decimal? amt) {
            if (!amt.HasValue) {
                return null;
            }

            return new DecimalDollars(amt.Value);
        }

        public static DecimalDollars Zero => new DecimalDollars(0m);

        public static DecimalDollars FromCents(int totalCents) {
            return new DecimalDollars(totalCents / 100m);
        }

        public DollarCents ToDollarCents => new DollarCents(Amount < 0, NonNegativeDollars, RoundedCents);

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            return obj is DecimalDollars && Equals((DecimalDollars)obj);
        }

        public override int GetHashCode() => Amount.GetHashCode();

        public bool Equals(DecimalDollars other) => Amount == other.Amount;

        public static DecimalDollars operator +(DecimalDollars a, DecimalDollars b) =>
            new DecimalDollars(a.Amount + b.Amount);

        public static DecimalDollars operator +(DecimalDollars a, decimal b) =>
            new DecimalDollars(a.Amount + b);

        public static DecimalDollars operator +(decimal a, DecimalDollars b) => b + a;

        public static DecimalDollars operator -(DecimalDollars a, DecimalDollars b) =>
            new DecimalDollars(a.Amount - b.Amount);

        public static bool operator ==(DecimalDollars a, DecimalDollars b) => a.Equals(b);

        public static bool operator !=(DecimalDollars a, DecimalDollars b) => !(a == b);

        public static bool operator <(DecimalDollars a, DecimalDollars b) => a.Amount < b.Amount;

        public static bool operator >(DecimalDollars a, DecimalDollars b) => a.Amount > b.Amount;

        public static bool operator >=(DecimalDollars a, DecimalDollars b) => a.Amount >= b.Amount;

        public static bool operator <=(DecimalDollars a, DecimalDollars b) => a.Amount <= b.Amount;

        public static DecimalDollars operator *(DecimalDollars a, decimal b) => new DecimalDollars(a.Amount * b);

        public static DecimalDollars operator *(decimal a, DecimalDollars b) => b * a;
    }
}

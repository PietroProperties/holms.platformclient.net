using System;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using HOLMS.Types.Primitive;

namespace HOLMS.Platform.Support.Currency {
    /// <summary>
    /// DecimalDollars does high-precision monetary arithmetic, backed by the
    /// CLR's System.Decimal. Internal calculations and db-backed model objects
    /// should use this class.
    /// </summary>
    public struct DecimalDollars : IComparable<DecimalDollars>, IEquatable<DecimalDollars> {
        private const uint OneMillion = 1000000;
        // TODO(DA) Make this private. Try not to access it directly
        public readonly decimal Amount;

        public int TotalCents => (int)Math.Round(Amount * 100, MidpointRounding.ToEven);

        private decimal NonNegativeAmount => Math.Abs(Amount);
        private uint NonNegativeDollars => (uint)NonNegativeAmount;
        private uint RoundedCents => (uint)Math.Round((NonNegativeAmount - NonNegativeDollars) * 100,
            MidpointRounding.ToEven);

        /// <summary>
        /// Standard constructor, creates from decimal
        /// </summary>
        /// <param name="amt"></param>
        public DecimalDollars(decimal amt) {
            Amount = amt;
        }

        public DecimalDollars(MonetaryAmount amt) {
            Amount = amt.Microdollars / (decimal) OneMillion;
        }

        public MonetaryAmount ToPb => new MonetaryAmount {
            Microdollars = (long) Math.Round(Amount * OneMillion, MidpointRounding.ToEven)
        };

        public static DecimalDollars? FromNullable(decimal? amt) {
            if (!amt.HasValue) {
                return null;
            }

            return new DecimalDollars(amt.Value);
        }

        public static DecimalDollars Zero => new DecimalDollars(0m);

        public static DecimalDollars FromCents(int totalCents) {
            return new DecimalDollars(Math.Round(totalCents / 100m, MidpointRounding.ToEven));
        }

        public DollarCents ToDollarCents => new DollarCents(Amount < 0, NonNegativeDollars, RoundedCents);

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            return obj is DecimalDollars && Equals((DecimalDollars)obj);
        }

        public override int GetHashCode() => Amount.GetHashCode();

        public bool Equals(DecimalDollars other) => Amount == other.Amount;

        public static DecimalDollars operator- (DecimalDollars a) => 
            new DecimalDollars(-a.Amount);
        
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

        public int CompareTo(DecimalDollars other) {
            return Amount.CompareTo(other.Amount);
        }
    }
}

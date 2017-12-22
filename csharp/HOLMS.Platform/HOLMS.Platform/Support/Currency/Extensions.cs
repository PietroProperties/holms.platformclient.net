using System;
using System.Collections.Generic;
using System.Linq;

namespace HOLMS.Platform.Support.Currency {
    public static class Extensions {
        public static DollarCents SumDC(this IEnumerable<DollarCents> l) {
            return l.SumDC(d => d);
        }

        public static DollarCents SumDC<T>(this IEnumerable<T> l, Func<T, DollarCents> f) {
            return l.Aggregate(DollarCents.Zero, (a, b) => a + f.Invoke(b));
        }

        public static DecimalDollars SumDD(this IEnumerable<DecimalDollars> l) {
            return l.SumDD(d => d);
        }

        public static DecimalDollars SumDD<T>(this IEnumerable<T> l, Func<T, DecimalDollars> f) {
            return l.Aggregate(DecimalDollars.Zero, (a, b) => a + f.Invoke(b));
        }
    }
}

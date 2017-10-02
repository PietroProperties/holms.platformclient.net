using System;

namespace HOLMS.Platform.Tests.Support {
    internal class SeedGuidFactory {
        public static Guid Get(string lastChar) {
            return new Guid(String.Format("00000000-0000-0000-0000-00000000000{0}", lastChar));
        }
    }
}

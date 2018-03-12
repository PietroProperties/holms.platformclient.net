using System;

namespace HOLMS.Platform.Tests.TestSupport {
    internal class SeedGuidFactory {
        public static Guid Get(string lastChar) {
            return new Guid($"00000000-0000-0000-0000-00000000000{lastChar}");
        }
    }
}

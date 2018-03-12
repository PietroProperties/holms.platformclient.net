using System;
using System.Collections.Generic;
using System.Linq;
using HOLMS.Types.Primitive;

namespace HOLMS.Platform.Tests.TestSupport {
    internal static class SecurityActionFactory {
        public static List<SecurityAction> GetAll() {
            return Enum.GetValues(typeof(SecurityAction))
                .Cast<SecurityAction>()
                .ToList();
        }
    }
}

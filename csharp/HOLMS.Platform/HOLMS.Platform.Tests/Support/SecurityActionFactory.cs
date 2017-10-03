using HOLMS.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Platform.Tests.Support {
    internal static class SecurityActionFactory {
        public static List<SecurityAction> GetAll() {
            return Enum.GetValues(typeof(SecurityAction))
                .Cast<SecurityAction>()
                .ToList();
        }
    }
}

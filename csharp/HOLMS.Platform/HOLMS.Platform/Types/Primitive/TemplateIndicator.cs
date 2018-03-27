using System;
using HOLMS.Types.Extensions.Support;

namespace HOLMS.Types.Primitive {
    public partial class TemplateIndicator {
        public TemplateIndicator(Guid g) {
            Id = g.ToUUID();
        }
    }
}

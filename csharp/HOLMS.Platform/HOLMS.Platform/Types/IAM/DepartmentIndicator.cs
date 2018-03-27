using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.IAM {
    public partial class DepartmentIndicator : EntityIndicator<DepartmentIndicator> {
        public DepartmentIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

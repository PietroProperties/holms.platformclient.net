using HOLMS.Types.Primitive;
using System.Collections.Generic;

namespace HOLMS.Types.IAM {
    public partial class Department {
        public Department(DepartmentIndicator id, string name, bool isHousekeeper, ISet<SecurityAction> actions, bool iscashDropInclude) {
            EntityId = id;
            Name = name;
            IsHousekeeper = isHousekeeper;
            IsCashDropInclude = iscashDropInclude;
            Actions.AddRange(actions);
        }
    }
}

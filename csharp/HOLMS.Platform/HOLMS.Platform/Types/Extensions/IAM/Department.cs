using HOLMS.Types.Primitive;
using System.Collections.Generic;

namespace HOLMS.Types.IAM {
    public partial class Department {
        public Department(DepartmentIndicator id, string name, bool isHousekeeper, ISet<SecurityAction> actions) {
            EntityId = id;
            Name = name;
            IsHousekeeper = isHousekeeper;
            Actions.AddRange(actions);
        }
    }
}

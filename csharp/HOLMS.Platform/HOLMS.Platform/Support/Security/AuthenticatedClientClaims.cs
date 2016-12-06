using HOLMS.Types.IAM;
using HOLMS.Types.Primitive;
using System.Collections.Generic;

namespace HOLMS.Platform.Support.Security {
    public class AuthenticatedClientClaims {
        public ClientInstanceIndicator Client {get;set;}
        public TenancyIndicator Tenancy { get; set; }
        public StaffMemberIndicator User { get; set; }
        public ISet<SecurityAction> SecurityActions { get; set; }

        public AuthenticatedClientClaims() {
            SecurityActions = new HashSet<SecurityAction>();
        }
    }
}

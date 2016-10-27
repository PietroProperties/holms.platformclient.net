using System;
using HOLMS.Types.Primitive;

namespace HOLMS.Application.Client {
    public class SessionService {
        public SessionService(SessionContext sc) {
            SessionContext = sc;
        }
        
        public SessionContext SessionContext { get; protected set; }
        public string SessionUsername => SessionContext.UserName;

        public bool SessionCan(AuthrnCapability c) {
            if (SessionContext.User == null) {
                return false;
            }

            switch (c) {
                case AuthrnCapability.CreditCardSetup:
                    return SessionContext.Capabilities.Contains(Capability.CreditCardSetup);
                case AuthrnCapability.GroupManagement:
                    return SessionContext.Capabilities.Contains(Capability.GroupManagement);
                case AuthrnCapability.HousekeepingManagement:
                    return SessionContext.Capabilities.Contains(Capability.HousekeepingManagement);
                case AuthrnCapability.StaffManagement:
                    return SessionContext.Capabilities.Contains(Capability.StaffManagement);
                case AuthrnCapability.SystemSettings:
                    return SessionContext.Capabilities.Contains(Capability.SystemSettings);
                case AuthrnCapability.YieldManagement:
                    return SessionContext.Capabilities.Contains(Capability.YieldManagement);
                case AuthrnCapability.OverrideRates:
                    return SessionContext.Capabilities.Contains(Capability.RateOverride);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

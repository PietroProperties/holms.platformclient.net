using HOLMS.Types.Primitive;

namespace HOLMS.Application.Client {
    public class SessionService {
        public SessionService(SessionContext sc) {
            SessionContext = sc;
        }
        
        public SessionContext SessionContext { get; protected set; }
        public string SessionUsername => SessionContext.UserName;

        public bool VerifyUserEntitlement(UserEntitlements e) {
            if (SessionContext.User == null) {
                return false;
            }

            switch (e) {
                case UserEntitlements.AdjustFolio:
                    return false;
                case UserEntitlements.ChangeSystemSettings:
                    return false;
                case UserEntitlements.GetRoomTypes:
                    return false;
                case UserEntitlements.GetSupplySnapshot:
                    return false;
                case UserEntitlements.ManageGroups:
                    return false;
                case UserEntitlements.ManageGuests:
                    return false;
                case UserEntitlements.ManageHousekeeping:
                    return false;
                case UserEntitlements.ManageIncidentalReservation:
                    return false;
                case UserEntitlements.ManageMoney:
                    return false;
                case UserEntitlements.ManagePricing:
                    return false;
                case UserEntitlements.ManageReservation:
                    return false;
                case UserEntitlements.ManageSupply:
                    return false;
                case UserEntitlements.ManageUsers:
                    return false;
                case UserEntitlements.PerformBackgroundJob:
                    return false;
                case UserEntitlements.ReadUsers:
                    return false;
                default:
                    return false;
            }
        }
    }
}

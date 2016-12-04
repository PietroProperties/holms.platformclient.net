using HOLMS.Types.Primitive;

namespace HOLMS.Application.Client {
    public class SessionService {
        public SessionService(SessionContext sc) {
            SessionContext = sc;
        }
        
        public SessionContext SessionContext { get; protected set; }
        public string SessionUsername => SessionContext.UserName;

        public bool IsTokenAuthorized(SecurityAction e) {
            if (SessionContext.User == null) {
                return false;
            }

            switch (e) {
                case SecurityAction.AdjustFolio:
                    return false;
                case SecurityAction.ChangeSystemSettings:
                    return false;
                case SecurityAction.GetRoomTypes:
                    return false;
                case SecurityAction.GetSupplySnapshot:
                    return false;
                case SecurityAction.ManageGroups:
                    return false;
                case SecurityAction.ManageGuests:
                    return false;
                case SecurityAction.ManageHousekeeping:
                    return false;
                case SecurityAction.ManageIncidentalReservation:
                    return false;
                case SecurityAction.ManageMoney:
                    return false;
                case SecurityAction.ManagePricing:
                    return false;
                case SecurityAction.ManageReservation:
                    return false;
                case SecurityAction.ManageSupply:
                    return false;
                case SecurityAction.ManageUsers:
                    return false;
                case SecurityAction.PerformBackgroundJob:
                    return false;
                case SecurityAction.ReadUsers:
                    return false;
                default:
                    return false;
            }
        }
    }
}

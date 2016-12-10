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
            return SessionContext.SecurityActions.Contains(e);
        }
    }
}

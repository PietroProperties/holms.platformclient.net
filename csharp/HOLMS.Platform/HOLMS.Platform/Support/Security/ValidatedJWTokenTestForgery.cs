using HOLMS.Types.IAM;
using System;

namespace HOLMS.Support.Security {
    public class ValidatedJWTokenTestForgery : ValidatedJWToken {
        public ValidatedJWTokenTestForgery(StaffMemberIndicator user, string userEntitlements, TenancyIndicator tenancy, ClientInstanceIndicator clientInstance, bool hasExpiration) {
            var sskf = new StubSecurityKeyFactory("SecretKeySecretKeySecretKeySecretKeySecretKeySecretKeySecretKeySecretKey");
            ACC = new AuthenticatedClientClaims {
                Tenancy = tenancy,
                User = user,
            };

            RawTokenData = new JWToken(clientInstance, user, userEntitlements, tenancy, DateTime.Now, hasExpiration,
                sskf.SigningCredentials).SignedToken;
        }
    }
}

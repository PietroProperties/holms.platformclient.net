using HOLMS.Platform.Support.Security;
using HOLMS.Types.IAM;
using HOLMS.Types.Primitive;
using System;
using System.Collections.Generic;

namespace HOLMS.Support.Security {
    public class ValidatedJWTokenTestForgery : ValidatedJWToken {
        public ValidatedJWTokenTestForgery(StaffMemberIndicator user, IEnumerable<SecurityAction> securityActions, 
                TenancyIndicator tenancy, ClientInstanceIndicator clientInstance, DateTime requestTime, bool hasExpiration) {
            var sskf = new StubSecurityKeyFactory("SecretKeySecretKeySecretKeySecretKeySecretKeySecretKeySecretKeySecretKey");
            ACC = new AuthenticatedClientClaims {
                Tenancy = tenancy,
                User = user,
                Client = clientInstance,
            };
            ACC.SecurityActions.UnionWith(securityActions);

            RawTokenData = new JWToken(clientInstance, user, securityActions, tenancy, requestTime, hasExpiration,
                sskf.SigningCredentials).SignedToken;
        }
    }
}

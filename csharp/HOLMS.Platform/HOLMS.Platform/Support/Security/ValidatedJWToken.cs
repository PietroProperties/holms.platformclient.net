using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security;
using HOLMS.Types.IAM;
using Microsoft.IdentityModel.Tokens;

namespace HOLMS.Support.Security {
    public class ValidatedJWToken {
        public string RawTokenData { get; protected set; }
        public AuthenticatedClientClaims ACC { get; protected set; }

        protected ValidatedJWToken() { }

        private ValidatedJWToken(JwtSecurityToken t) {
            RawTokenData = t.RawData;
            var claims = t.Claims.ToDictionary(x => x.Type);
            if (!claims.ContainsKey(JWToken.ClientIdKey) || !claims.ContainsKey(JWToken.TenancyIdKey) ||
                !claims.ContainsKey(JWToken.UserIdKey)) {
                throw new Exception("Missing keys in token");
            }

            ACC = new AuthenticatedClientClaims {
                Client = new ClientInstanceIndicator(Guid.Parse(claims[JWToken.ClientIdKey].Value)),
                Tenancy = new TenancyIndicator(Guid.Parse(claims[JWToken.TenancyIdKey].Value)),
                User = new StaffMemberIndicator(Guid.Parse(claims[JWToken.UserIdKey].Value)),
            };
        }

        public static ValidatedJWToken CreateWithValidation(string rawData, SecurityKey key) {
            var tokenValidationParameters = new TokenValidationParameters() {
                ValidAudiences = new [] { JWToken.Audience },
                ValidIssuers = new [] { JWToken.Issuer },
                IssuerSigningKey = key,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken validatedToken;
            tokenHandler.ValidateToken(rawData, tokenValidationParameters, out validatedToken);

            var tok = tokenHandler.ReadToken(rawData) as JwtSecurityToken;

            var expirationClaim = tok.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp);
            if (expirationClaim != null) {
                if (tok.ValidTo < DateTime.Now) {
                    throw new SecurityException("Presented token is expired");
                }
            }

            return new ValidatedJWToken(tok);
        }
    }
}

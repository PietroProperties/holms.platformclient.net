using HOLMS.Types.IAM;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace HOLMS.Support.Security {
    public sealed class JWToken {
        public const int AccessTokenExpirationMinutes = 60;
        public const string ClientIdKey = "client_id";
        public const string TenancyIdKey = "tenancy_id";
        public const string UserIdKey = JwtRegisteredClaimNames.Sub;
        public const string Audience = "private.shortbar.com";
        public const string Issuer = "private.shortbar.com";

        public string SignedToken { get; private set; }

        public JWToken(ClientInstanceIndicator client, StaffMemberIndicator user,
            TenancyIndicator tenancy, DateTime requestTime, bool hasExpiration, SigningCredentials creds) {
            CreateToken(client, user, tenancy, requestTime, hasExpiration, creds);
        }

        private void CreateToken(ClientInstanceIndicator client, StaffMemberIndicator user,
            TenancyIndicator tenancy, DateTime requestTime, bool hasExpiration, SigningCredentials creds) {
            var claims = new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(UserIdKey, user.GuidID.ToString()),
                new Claim(TenancyIdKey, tenancy.GuidID.ToString()),
                new Claim(ClientIdKey, client.GuidID.ToString())
            };

            var expiry = hasExpiration
                ? requestTime.ToUniversalTime().AddMinutes(AccessTokenExpirationMinutes)
                : (DateTime?) null;

            var tok = new JwtSecurityToken(Issuer, Audience, claims, null, expiry, creds);
            SignedToken = new JwtSecurityTokenHandler().WriteToken(tok);
        }
    }
}

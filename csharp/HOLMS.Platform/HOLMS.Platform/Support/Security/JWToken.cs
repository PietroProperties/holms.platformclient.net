using HOLMS.Types.IAM;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace HOLMS.Support.Security {
    public sealed class JWToken {
        public const int AcessTokenExpirationMinutes = 60;
        public const string ClientIdKey = "ClientId";
        public const string TenancyIdKey = "TenancyId";
        public const string UserIdKey = "UserId";
        public const string Audience = "private.shortbar.com";
        public const string Issuer = "private.shortbar.com";

        public string SignedToken { get; private set; }

        public JWToken(ClientInstanceIndicator client, StaffMemberIndicator user, TenancyIndicator tenancy, DateTime requestTime, bool hasExpiration) {
            CreateToken(client, user, tenancy, requestTime, hasExpiration);
        }

        private void CreateToken(ClientInstanceIndicator client, StaffMemberIndicator user, TenancyIndicator tenancy, DateTime requestTime, bool hasExpiration) {
            var claimsIdentity =
                    new ClaimsIdentity(new List<Claim>() {
                                            new Claim(UserIdKey, user.GuidID.ToString()),
                                            new Claim(TenancyIdKey, tenancy.GuidID.ToString()),
                                            new Claim(ClientIdKey, client.GuidID.ToString())
                    }, "Custom");
            var securityTokenDescriptor = new SecurityTokenDescriptor() {
                Audience = Audience,
                Issuer = Issuer,
                Subject = claimsIdentity,
                SigningCredentials = StubSecurityKeyFactory.SigningCredentials,
            };
            if (hasExpiration) {
                securityTokenDescriptor.Expires = requestTime.ToUniversalTime()
                    .AddMinutes(AcessTokenExpirationMinutes);
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var plainToken = tokenHandler.CreateToken(securityTokenDescriptor);
            SignedToken = tokenHandler.WriteToken(plainToken);
        }
    }
}

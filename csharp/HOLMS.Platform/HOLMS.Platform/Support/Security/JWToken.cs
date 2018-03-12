using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using HOLMS.Types.IAM;
using HOLMS.Types.Primitive;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace HOLMS.Platform.Support.Security {
    public sealed class JWToken {
        public const int AccessTokenExpirationMinutes = 60;
        public const string ClientIdKey = "client_id";
        public const string TenancyIdKey = "tenancy_id";
        public const string GrantsDocumentKey = "user_entitlements";
        public const string UserIdKey = JwtRegisteredClaimNames.Sub;
        public const string Audience = "private.shortbar.com";
        public const string Issuer = "private.shortbar.com";

        public string SignedToken { get; private set; }
        public Guid Id { get; }

        public JWToken(ClientInstanceIndicator client, StaffMemberIndicator user, IEnumerable<SecurityAction> securityActions,
            TenancyIndicator tenancy, DateTime requestTime, bool hasExpiration, SigningCredentials creds) {
            Id = Guid.NewGuid();
            CreateToken(client, user, securityActions, tenancy, requestTime, hasExpiration, creds);
        }

        private void CreateToken(ClientInstanceIndicator client, StaffMemberIndicator user, IEnumerable<SecurityAction> securityActions,
            TenancyIndicator tenancy, DateTime requestTime, bool hasExpiration, SigningCredentials creds) {
            var claims = new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Jti, Id.ToString()),
                new Claim(UserIdKey, user.GuidID.ToString()),
                new Claim(TenancyIdKey, tenancy.GuidID.ToString()),
                new Claim(ClientIdKey, client.GuidID.ToString()),
                new Claim(GrantsDocumentKey, JsonConvert.SerializeObject(securityActions.Select(x => x.ToString()).ToList())),
            };

            var expiry = hasExpiration
                ? requestTime.ToUniversalTime().AddMinutes(AccessTokenExpirationMinutes)
                : (DateTime?) null;

            var tok = new JwtSecurityToken(Issuer, Audience, claims, null, expiry, creds);
            SignedToken = new JwtSecurityTokenHandler().WriteToken(tok);
        }
    }
}

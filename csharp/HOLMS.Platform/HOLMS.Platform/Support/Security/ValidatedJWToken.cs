﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using HOLMS.Types.IAM;
using HOLMS.Types.Primitive;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace HOLMS.Platform.Support.Security {
    public class ValidatedJWToken {
        public string RawTokenData { get; protected set; }
        public AuthenticatedClientClaims ACC { get; protected set; }

        protected ValidatedJWToken() { }

        private ValidatedJWToken(JwtSecurityToken t) {
            RawTokenData = t.RawData;
            var claims = t.Claims.ToDictionary(x => x.Type);
            if (!claims.ContainsKey(JWToken.ClientIdKey) || !claims.ContainsKey(JWToken.TenancyIdKey) ||
                !claims.ContainsKey(JWToken.UserIdKey)   || !claims.ContainsKey(JWToken.GrantsDocumentKey)) {
                throw new Exception("Missing keys in token");
            }

            var securityActionStrings = JsonConvert.DeserializeObject<IEnumerable<string>>(claims[JWToken.GrantsDocumentKey].Value);
            var securityActionEnums = new HashSet<SecurityAction>();
            foreach (var s in securityActionStrings) {
                SecurityAction action;
                if (Enum.TryParse(s, true, out action)) {
                    securityActionEnums.Add(action);
                }
            }

            ACC = new AuthenticatedClientClaims {
                Client = new ClientInstanceIndicator(Guid.Parse(claims[JWToken.ClientIdKey].Value)),
                Tenancy = new TenancyIndicator(Guid.Parse(claims[JWToken.TenancyIdKey].Value)),
                User = new StaffMemberIndicator(Guid.Parse(claims[JWToken.UserIdKey].Value)), 
                SecurityActions = securityActionEnums,
            };
        }

        public static ValidatedJWToken CreateWithValidation(string rawData, SecurityKey key) {
            var tokenValidationParameters = new TokenValidationParameters() {
                ValidAudiences = new [] { JWToken.Audience },
                ValidIssuers = new [] { JWToken.Issuer },
                IssuerSigningKey = key,
                ValidateLifetime = false,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken validatedToken;
            tokenHandler.ValidateToken(rawData, tokenValidationParameters, out validatedToken);

            var tok = tokenHandler.ReadToken(rawData) as JwtSecurityToken;

            var expirationClaim = tok.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp);
            if (expirationClaim != null) {
                if (tok.ValidTo < DateTime.UtcNow) {
                    throw new SecurityTokenExpiredException("Presented token is expired");
                }
            }

            return new ValidatedJWToken(tok);
        }
    }
}

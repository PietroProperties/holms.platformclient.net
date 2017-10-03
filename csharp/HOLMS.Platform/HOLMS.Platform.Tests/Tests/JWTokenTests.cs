using HOLMS.Platform.Tests.Support;
using HOLMS.Support.Security;
using HOLMS.Types.IAM;
using Microsoft.IdentityModel.Tokens;
using NUnit.Framework;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security;

namespace HOLMS.Platform.Tests {
    internal class JWTokenTests {
        private ClientInstanceIndicator _cii;
        private SecurityKey _secKey;
        private StaffMemberIndicator _sm;
        private TenancyIndicator _ti;

        [SetUp]
        public void Init() {
            _sm = new StaffMemberIndicator(SeedGuidFactory.Get("1"));
            _ti = new TenancyIndicator(SeedGuidFactory.Get("1"));
            _cii = new ClientInstanceIndicator(SeedGuidFactory.Get("1"));
            _secKey = new StubSecurityKeyFactory("SecretKeySecretKeySecretKeySecretKeySecretKeySecretKeySecretKeySecretKey").SecurityKey;
        }

        [Test]
        public void ValidateTokenThrowsOnExpiredTokenInUTCTime() {
            var oldToken = new ValidatedJWTokenTestForgery(
                _sm, 
                SecurityActionFactory.GetAll(), 
                _ti, 
                _cii, 
                DateTime.UtcNow.AddMinutes((JWToken.AccessTokenExpirationMinutes + 1) * -1), 
                true);
            var rawData = oldToken.RawTokenData;
            Assert.Throws<SecurityTokenExpiredException>(() => ValidatedJWToken.CreateWithValidation(rawData, _secKey));
        }

        [Test]
        public void CreateTokenSetsExpirationInUTCTime() {
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            var utcNow = DateTime.UtcNow;
            // Strip fractional seconds off utcNow
            utcNow = utcNow.AddTicks(-(utcNow.Ticks % TimeSpan.TicksPerSecond));
            var tokenHandler = new JwtSecurityTokenHandler();
            var localTZ = TimeZoneInfo.Local;
            var localtimeNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, localTZ);
            var token = new ValidatedJWTokenTestForgery(_sm,
                SecurityActionFactory.GetAll(),
                _ti,
                _cii,
                localtimeNow,
                true);
            var expClaim = (tokenHandler.ReadToken(token.RawTokenData) as JwtSecurityToken);
            Assert.AreEqual(utcNow.AddMinutes(JWToken.AccessTokenExpirationMinutes), 
                expClaim.ValidTo, $"Create JWToken failed to render timezone into UTC time");
            Assert.AreEqual(DateTimeKind.Utc, expClaim.ValidTo.Kind);
        }
    }
}

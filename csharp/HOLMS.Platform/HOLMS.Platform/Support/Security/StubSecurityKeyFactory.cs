using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace HOLMS.Platform.Support.Security {
    public class StubSecurityKeyFactory {
        public SecurityKey SecurityKey { get; }
        public SigningCredentials SigningCredentials { get; }
        
        public StubSecurityKeyFactory(string key) {
            SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            SigningCredentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);
        }
    }
}

using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace HOLMS.Support.Security {
    public class StubSecurityKeyFactory {
        //NOTE (DL): This is a necessary evil. To avoid File IO everytime a client makes a request, we load the key into memory at server startup.
        //However, the maintain the extreme convenience of the SCC#ToSC method, as well as this method, this variable exists.
        //This variable will be set by HOLMS.Application.ConsoleRunner before the gRPC server is started and may NOT be altered after that.
        public static string SECURITY_KEY { get; protected set; }

        public StubSecurityKeyFactory(string key) {
            SECURITY_KEY = key;
        }

        public static SigningCredentials SigningCredentials =>    
            new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);

        public static SecurityKey SecurityKey =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECURITY_KEY));
    }
}

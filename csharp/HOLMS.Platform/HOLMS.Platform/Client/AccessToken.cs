using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using HOLMS.Types.Primitive;

namespace HOLMS.Platform.Client {
    class AccessToken : ITokenAccess {
        private readonly string _token;

        public AccessToken(SessionContext sc)
            : this(sc.AccessToken) { }

        public static AccessToken NullToken =>
            new AccessToken(string.Empty);

        public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = new CancellationToken()) =>
            Task.Run(() => _token);

        private AccessToken(string token) {
            _token = token;
        }
    }
}

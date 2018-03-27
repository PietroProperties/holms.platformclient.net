using System;

namespace HOLMS.Platform.Client {
    public interface IApplicationClientConfig {
        string AppSvcHostname { get; }
        ushort AppSvcPort { get; }
        Guid ClientInstanceId { get; }
    }
}

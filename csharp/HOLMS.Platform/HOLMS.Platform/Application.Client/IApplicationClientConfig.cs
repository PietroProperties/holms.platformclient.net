using System;

namespace HOLMS.Application.Client {
    public interface IApplicationClientConfig {
        string AppSvcHostname { get; }
        ushort AppSvcPort { get; }
        Guid ClientInstanceId { get; }
    }
}

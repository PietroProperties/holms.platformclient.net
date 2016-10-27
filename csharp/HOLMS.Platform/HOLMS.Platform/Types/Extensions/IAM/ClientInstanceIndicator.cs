using HOLMS.Types.Extensions;
using System;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.IAM {
    public partial class ClientInstanceIndicator : EntityIndicator<ClientInstanceIndicator> {
        public ClientInstanceIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

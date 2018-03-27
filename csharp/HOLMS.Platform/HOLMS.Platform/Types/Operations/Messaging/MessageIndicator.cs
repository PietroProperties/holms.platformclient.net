using System;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Operations.Messaging {
    public partial class MailboxEntryIndicator : EntityIndicator<MailboxEntryIndicator> {
        public MailboxEntryIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

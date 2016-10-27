using HOLMS.Types.Extensions;
using System;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.Money.Cards {
    public partial class CardTerminalIndicator : EntityIndicator<CardTerminalIndicator> {
        public CardTerminalIndicator(Guid id) {
            Id = id.ToUUID();
        }

        public override Uuid GetUuidID() => Id;
    }
}

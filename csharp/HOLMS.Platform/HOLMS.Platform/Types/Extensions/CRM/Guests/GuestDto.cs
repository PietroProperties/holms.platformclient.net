using HOLMS.Types.Extensions;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.CRM.Guests {
    public partial class Guest : EntityDTO<GuestIndicator> {
        public override GuestIndicator GetIndicator() {
            return EntityId;
        }

        public Guest(GuestIndicator gi, ContactInformation ci) {
            EntityId = new GuestIndicator(gi);
            ContactInfo = new ContactInformation(ci);
        }
    }
}

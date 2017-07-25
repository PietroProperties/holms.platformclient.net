using HOLMS.Platform.Support.Currency;
using HOLMS.Types.Primitive;
using HOLMS.Types.TenancyConfig.Indicators;

namespace HOLMS.Types.CRM.Groups {
    public partial class Group {
        public Group(GroupIndicator g, string name, GroupType gt, string number, 
            DollarCents creditLimit, bool active, ContactInformation contactInfo,
            PropertyIndicator p) {
            EntityId = g;
            Name = name;
            GroupType = gt;
            GroupNumber = number;
            CreditLimit = creditLimit.ToPb;
            Active = active;
            ContactInfo = new ContactInformation(contactInfo);
            Property = p;
        }
    }
}

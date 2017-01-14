using HOLMS.Types.Supply.RoomTypes;
using HOLMS.Types.TenancyConfig.Indicators;

namespace HOLMS.Support.DTOBuilders.Premises {
    public class RoomTypeBuilder {
        public RoomTypeIndicator Id;
        public string Name;
        public string Description;
        public string WebDescription;
        public int NormalOccupancy;
        public int MaxOccupancy;
        public int CleaningTimeDustMins;
        public int CleaningTimeStayoverMins;
        public int CleaningTimeCheckoutMins;
        public int CleaningTimeDeepMins;
        public int BaseManagementHolds;
        public int AdditionalWebHolds;
        public bool AvailableOnWebsite;
        public PropertyIndicator PropertyId;
        public string PropertyName;

        public RoomType Build() {
            var rt = new RoomType {
                EntityId = Id,
                Name = Name,
                Description = Description,
                NormalOccupancy = NormalOccupancy,
                MaxOccupancy = MaxOccupancy,
                CleaningTimeDustMins = CleaningTimeDustMins,
                CleaningTimeStayoverMins = CleaningTimeStayoverMins,
                CleaningTimeCheckoutMins = CleaningTimeCheckoutMins,
                CleaningTimeDeepMins = CleaningTimeDeepMins,
                BaseManagementHolds = BaseManagementHolds,
                AdditionalWebHolds = AdditionalWebHolds,
            };

            if (PropertyId != null) {
                rt.PropertyId = PropertyId;
            }

            if (PropertyName != null) {
                rt.PropertyName = PropertyName;
            }

            return rt;
        }
    }
}

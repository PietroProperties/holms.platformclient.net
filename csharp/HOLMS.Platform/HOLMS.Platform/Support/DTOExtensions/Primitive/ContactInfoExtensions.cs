using HOLMS.Types.Primitive;

namespace HOLMS.Support.DTOExtensions.Primitive {
    public static class ContactInfoExtensions {
        public static string GetNameFamilyGiven(this ContactInformation ci) {
            return $"{ci.FamilyName}, {ci.GivenName}";
        }

        public static string GetNameGivenFamily(this ContactInformation ci) {
            return $"{ci.GivenName} {ci.FamilyName}";
        }

        public static string GetAnyPhoneHomeFirst(this ContactInformation ci) {
            if (!string.IsNullOrWhiteSpace(ci.HomePhone)) {
                return ci.HomePhone;
            } 
            if (!string.IsNullOrWhiteSpace(ci.MobilePhone)) {
                return ci.MobilePhone;
            }
            if (!string.IsNullOrWhiteSpace(ci.OfficePhone)) {
                return ci.OfficePhone;
            }
            return string.Empty;
        }

        public static string GetHomeCityState(this ContactInformation ci) {
            if(!string.IsNullOrWhiteSpace(ci.HomeCity) && !string.IsNullOrWhiteSpace(ci.HomeState)) {
                return $"{ci.HomeCity}, {ci.HomeState}";
            }
            if (!string.IsNullOrWhiteSpace(ci.HomeCity) && !string.IsNullOrWhiteSpace(ci.HomeNation)) {
                return $"{ci.HomeCity}, {ci.HomeNation}";
            }
            return ci.HomeCity;
        }
    }
}

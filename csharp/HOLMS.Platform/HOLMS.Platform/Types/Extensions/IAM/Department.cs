namespace HOLMS.Types.IAM {
    public partial class Department {
        public Department(DepartmentIndicator id, string name, bool isHousekeeper, bool capGetSupplySnapshot, bool capGetRoomTypes,
            bool capChangeSystemSettings, bool capPerformBackgroundJob, bool capManagePricing,
            bool capReadUsers, bool capManageUsers, bool capManageSupply,
            bool capManageReservation, bool capManageIncidentalReservation, bool capAdjustFolio,
            bool capManageMoney, bool capManageGroups, bool capManageHousekeeping, bool capManageGuests) {
            EntityId = id;
            Name = name;
            IsHousekeeper = isHousekeeper;

            CapGetSupplySnapshot = capGetSupplySnapshot;
            CapGetRoomTypes = capGetRoomTypes;
            CapChangeSystemSettings = capChangeSystemSettings;
            CapPerformBackgroundJob = capPerformBackgroundJob;
            CapManagePricing = capManagePricing;
            CapReadUsers = capReadUsers;
            CapManageUsers = capManageUsers;
            CapManageSupply = capManageSupply;
            CapManageReservation = capManageReservation;
            CapManageIncidentalReservation = capManageIncidentalReservation;
            CapAdjustFolio = capAdjustFolio;
            CapManageMoney = capManageMoney;
            CapManageGroups = capManageGroups;
            CapManageHousekeeping = capManageHousekeeping;
            CapManageGuests = capManageGuests;
        }
    }
}

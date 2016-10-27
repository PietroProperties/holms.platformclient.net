namespace HOLMS.Types.IAM {
    public partial class Department {
        public Department(DepartmentIndicator id, string name, bool isHousekeeper, bool capStaffMgmt, bool capGroupMgmt,
            bool capHousekeepingMgmt, bool capAccountingReports, bool capManagementReports,
            bool capWorkstationParameters, bool capSaveDisplaySettings, bool capLodgeicReset,
            bool capEventsWaitlistSetup, bool capSystemSettings, bool capYieldManagement,
            bool capHoldMgmt, bool capGuestBlacklistAddRemove, bool capOverbookRooms,
            bool capOverrideRates, bool capCallAccountingAdvancedSetup, bool capGiftShopsalesSetup,
            bool capCreditCardSetup, bool capCreditCardWorksheet, bool capCreditCardCaptureSettle,
            bool capCreditCardReporting, bool capExpediaQCMgmt, bool capWebSetup) {
            EntityId = id;
            Name = name;
            IsHousekeeper = isHousekeeper;

            CapStaffMgmt = capStaffMgmt;
            CapGroupMgmt = capGroupMgmt;
            CapHousekeepingMgmt = capHousekeepingMgmt;

            CapAccountingReports = capAccountingReports;
            CapManagementReports = capManagementReports;
            CapWorkstationParameters = capWorkstationParameters;
            CapSaveDisplaySettings = capSaveDisplaySettings;
            CapLodgeicReset = capLodgeicReset;

            CapEventsWaitlistSetup = capEventsWaitlistSetup;
            CapSystemSettings = capSystemSettings;
            CapYieldMgmt = capYieldManagement;
            CapHoldMgmt = capHoldMgmt;
            CapGuestBlacklistAddRemove = capGuestBlacklistAddRemove;
            CapOverbookRooms = capOverbookRooms;
            CapOverrideRates = capOverrideRates;
            CapCallAccountingAdvancedSetup = capCallAccountingAdvancedSetup;

            CapGiftShopSalesSetup = capGiftShopsalesSetup;

            CapCreditCardSetup = capCreditCardSetup;
            CapCreditCardWorksheet = capCreditCardWorksheet;
            CapCreditCardCaptureSettle = capCreditCardCaptureSettle;
            CapCreditCardReporting = capCreditCardReporting;

            CapExpediaQcMgmt = capExpediaQCMgmt;
            CapWebSetup = capWebSetup;
        }
    }
}

using System.Threading.Tasks;
using HOLMS.Types.Booking.RPC;
using HOLMS.Types.CRM.RPC;
using HOLMS.Types.IAM.RPC;
using HOLMS.Types.Money.RPC;
using HOLMS.Types.Operations.RPC;
using HOLMS.Types.Primitive;
using HOLMS.Types.Reporting.RPC;
using HOLMS.Types.Supply.RPC;
using HOLMS.Types.TenancyConfig.RPC;
using HOLMS.Types.IAM;
using Microsoft.Extensions.Logging;

namespace HOLMS.Application.Client {
    public interface IApplicationClient {
        ILogger Logger { get; }

        #region Booking
        BookingPricingSvc.BookingPricingSvcClient BkPricingSvc { get; }
        CancellationPolicySvc.CancellationPolicySvcClient CancellationPolicySvc { get; }
        CancellationReasonSvc.CancellationReasonSvcClient CancellationReasonSvc { get; }
        CheckInService.CheckInServiceClient CheckInSvc { get; }
        CheckoutSvc.CheckoutSvcClient CheckOutSvc { get; }
        GroupBookingSvc.GroupBookingSvcClient GroupBookingSvc { get; }
        GuaranteeAuthorizerService.GuaranteeAuthorizerServiceClient GuaranteeAuthorizerService { get; }
        IncidentalItemReservationSvc.IncidentalItemReservationSvcClient IncidentalResSvc { get; }
        LodgingBookingSvc.LodgingBookingSvcClient LodgingBookingSvc { get; }
        OpenLodgingReservationSvc.OpenLodgingReservationSvcClient OpenLodgingReservationSvc { get; }
        OTAChannelProviderSvc.OTAChannelProviderSvcClient OTAChannelProviderSvc { get; }
        ReservationCancellationSvc.ReservationCancellationSvcClient ResCancellationSvc { get; }
        ReservationNoteSvc.ReservationNoteSvcClient ReservationNoteSvc { get; }
        ReservationGuaranteeSvc.ReservationGuaranteeSvcClient ResGuaranteeSvc { get; }
        ReservationSearchSvc.ReservationSearchSvcClient ReservationSearchSvc { get; }
        ReservationTagsSvc.ReservationTagsSvcClient ReservationTagsSvc { get; }
        RestrictionSvc.RestrictionSvcClient RestrictionSvc { get; }
        TravelAgentSvc.TravelAgentSvcClient TravelAgentSvc { get; }
        TurnAwayReasonSvc.TurnAwayReasonSvcClient TurnAwayReasonSvc { get; }
        OTASyncSvc.OTASyncSvcClient OTASyncSvc { get; }
        #endregion

        #region CRM
        CorrespondenceSvc.CorrespondenceSvcClient CorrespondenceSvc { get; }
        GroupSvc.GroupSvcClient GroupSvc { get; }
        GuestHistorySvc.GuestHistorySvcClient GuestHistorySvc { get; }
        GuestSvc.GuestSvcClient GuestSvc { get; }
        #endregion

        #region IAM
        ClientInstanceSvc.ClientInstanceSvcClient ClientInstancesSvc { get; }
        DepartmentSvc.DepartmentSvcClient DepartmentsSvc { get; }
        StaffSvc.StaffSvcClient StaffSvc { get; }
        TenancySvc.TenancySvcClient TenancySvc { get; }
        #endregion

        #region Money
        AccountingTxnSvc.AccountingTxnSvcClient AccountingTxnSvc { get; }
        AccountSvc.AccountSvcClient AccountSvc { get; }
        CardMerchantSvc.CardMerchantSvcClient CardMerchantSvc { get; }
        CardProcessingSvc.CardProcessingSvcClient CardProcessingSvc { get; }
        CardTerminalSvc.CardTerminalSvcClient CardTerminalSvc { get; }
        GroupBookingFolioSvc.GroupBookingFolioSvcClient GroupBookingFolioSvc { get; }
        ReservationFolioSvc.ReservationFolioSvcClient ReservationFolioSvc { get; }
        TaxFeeSvc.TaxFeeSvcClient TaxFeeSvc { get; }
        FolioAuthCleanupSvc.FolioAuthCleanupSvcClient FolioAuthCleanupSvc { get; }
        MasterFolioSvc.MasterFolioSvcClient MasterFolioSvc { get; }
        #endregion

        #region Operations
        AttractionCategorySvc.AttractionCategorySvcClient AttractionCategorySvc { get; }
        CalendarMsgSvc.CalendarMsgSvcClient CalendarMsgSvc { get; }
        GuestFolioTemplateSvc.GuestFolioTemplateSvcClient GuestFolioTmplSvc { get; }
        HKDirtyTrackingSvc.HKDirtyTrackingSvcClient HKDirtyTrackingSvc { get; }
        HousekeepingManagementSvc.HousekeepingManagementSvcClient HousekeepingManagementSvc { get; }
        HousekeepingTimeSvc.HousekeepingTimeSvcClient HousekeepingTimeSvc { get; }
        NoteRequestSvc.NoteRequestSvcClient NoteRequestSvc { get; }
        OutOfOrderRecordSvc.OutOfOrderRecordSvcClient OutOfOrderRecordSvc { get; }
        PBXSvc.PBXSvcClient PBXSvc { get; }
        RoomClaimsSvc.RoomClaimsSvcClient RoomClaimsSvc { get; }
        RoomSvc.RoomSvcClient RoomSvc { get; }
        RoomUseStatusCalculatorSvc.RoomUseStatusCalculatorSvcClient RoomUseStatusCalculatorSvc { get; }
        StaffMsgSvc.StaffMsgSvcClient StaffMsgSvc { get; }
        #endregion

        #region Supply
        HoldsSvc.HoldsSvcClient HoldsSvc { get; }
        IncidentalSupplySvc.IncidentalSupplySvcClient IncidentalSupplySvc { get; }
        IncidentalItemSvc.IncidentalItemSvcClient IncidentalItemSvc { get; }
        PricingSvc.PricingSvcClient PricingSvc { get; }
        RateScheduleSvc.RateScheduleSvcClient RateScheduleSvc { get; }
        RoomTypeSvc.RoomTypeSvcClient RoomTypeSvc { get; }
        SupplySnapshotSvc.SupplySnapshotSvcClient SupplySnapshotSvc { get; }
        #endregion

        #region TenancyConfig
        AccountAssignmentsSvc.AccountAssignmentsSvcClient AccountAssignmentSvc { get; }
        ChannelManagerConfigurationSvc.ChannelManagerConfigurationSvcClient ChannelManagerConfigurationSvc { get; }
        ForeignPropertyConfigurationSvc.ForeignPropertyConfigurationSvcClient ForeignPropertyConfigurationSvc { get; }
        GroupBookingMethodSvc.GroupBookingMethodSvcClient GroupBookingMethodSvc { get; }
        KCRConfigSvc.KCRConfigSvcClient KCRConfigSvc { get; }
        HkPhoneCodeSvc.HkPhoneCodeSvcClient HkPhoneCodeSvc { get; }
        IIFExportConfigSvc.IIFExportConfigSvcClient IIFExportConfigSvc { get; }
        PhoneCodeSvc.PhoneCodeSvcClient PhoneCodeSvc { get; }
        PropertySvc.PropertySvcClient PropertySvc { get; }
        ReservationDefaultsSvc.ReservationDefaultsSvcClient ReservationDefaultsSvc { get; }
        ReservationSourceSvc.ReservationSourceSvcClient ReservationSourceSvc { get; }
        ReservationStatusColorsSvc.ReservationStatusColorsSvcClient ReservationStatusColorsSvc { get; }
        RoomCallBillingRatesSvc.RoomCallBillingRatesSvcClient RoomCallBillingRatesSvc { get; }
        RoomStatusColorsSvc.RoomStatusColorsSvcClient RoomStatusColorsSvc { get; }
        RoomStatusSettingsSvc.RoomStatusSettingsSvcClient RoomStatusSettingsSvc { get; }
        TaxExemptCategorySvc.TaxExemptCategorySvcClient TaxExemptCategorySvc { get; }
        #endregion

        #region Reporting
        CardCaptureReportingSvc.CardCaptureReportingSvcClient CardCaptureReportingSvc { get; }
        FrontDeskReportingSvc.FrontDeskReportingSvcClient FrontDeskReportingSvc { get; }
        ManagementReportingSvc.ManagementReportingSvcClient ManagementReportingSvc { get; }
        #endregion

        StaffMemberIndicator AuthenticatedUser { get; }
        SessionContext SC { get; }
        string ServerName { get; }
        SessionService SS { get; }
        string TenancyName { get; }
        string UserName { get; }
        
        Task<SessionSvcStartSessionResult> StartSession(string candidateUsername, string candidatePassword);
    }
}

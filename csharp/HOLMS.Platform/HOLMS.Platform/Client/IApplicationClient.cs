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
using HOLMS.Types.Folio.RPC;
using HOLMS.Types.Folio;

namespace HOLMS.Platform.Client {
    public interface IApplicationClient {
        ILogger Logger { get; }

        #region Booking
        BookingPricingSvc.BookingPricingSvcClient BkPricingSvc { get; }
        CancellationPolicySvc.CancellationPolicySvcClient CancellationPolicySvc { get; }
        CancellationReasonSvc.CancellationReasonSvcClient CancellationReasonSvc { get; }
        CheckInService.CheckInServiceClient CheckInSvc { get; }
        CheckoutSvc.CheckoutSvcClient CheckOutSvc { get; }
        GroupBookingSvc.GroupBookingSvcClient GroupBookingSvc { get; }
        GroupBookingSearchSvc.GroupBookingSearchSvcClient GroupBookingSearchSvc { get; }
        GuaranteeAuthorizerService.GuaranteeAuthorizerServiceClient GuaranteeAuthorizerService { get; }
        IncidentalItemReservationSvc.IncidentalItemReservationSvcClient IncidentalResSvc { get; }
        LodgingBookingSvc.LodgingBookingSvcClient LodgingBookingSvc { get; }
        OpenLodgingReservationSvc.OpenLodgingReservationSvcClient OpenLodgingReservationSvc { get; }
        OTAChannelProviderSvc.OTAChannelProviderSvcClient OTAChannelProviderSvc { get; }
        ReservationCancellationSvc.ReservationCancellationSvcClient ResCancellationSvc { get; }
        ReservationNoteSvc.ReservationNoteSvcClient ReservationNoteSvc { get; }
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

        #region Folio
        FolioAuthCleanupSvc.FolioAuthCleanupSvcClient FolioAuthCleanupSvc { get; }
        GroupBookingFolioSvc.GroupBookingFolioSvcClient GroupBookingFolioSvc { get; }
        MasterFolioSvc.MasterFolioSvcClient MasterFolioSvc { get; }
        ReservationFolioSvc.ReservationFolioSvcClient ReservationFolioSvc { get; }
        ReservationGuaranteeSvc.ReservationGuaranteeSvcClient ResGuaranteeSvc { get; }
        TaxAssessmentSvc.TaxAssessmentSvcClient TaxAssessmentSvc { get; }
        TaxFeeSvc.TaxFeeSvcClient TaxFeeSvc { get; }
        #endregion

        #region IAM
        ClientInstanceSvc.ClientInstanceSvcClient ClientInstancesSvc { get; }
        DepartmentSvc.DepartmentSvcClient DepartmentsSvc { get; }
        StaffSvc.StaffSvcClient StaffSvc { get; }
        TenancySvc.TenancySvcClient TenancySvc { get; }
        #endregion

        #region Money
        AccountAssignmentsSvc.AccountAssignmentsSvcClient AccountAssignmentSvc { get; }
        AccountSvc.AccountSvcClient AccountSvc { get; }
        AccountingTxnSvc.AccountingTxnSvcClient AccountingTxnSvc { get; }
        CardMerchantSvc.CardMerchantSvcClient CardMerchantSvc { get; }
        CardProcessingSvc.CardProcessingSvcClient CardProcessingSvc { get; }
        CardTerminalSvc.CardTerminalSvcClient CardTerminalSvc { get; }
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
        StaffMsgSvc.StaffMsgSvcClient StaffMsgSvc { get; }
        #endregion

        #region Supply
        HoldsSvc.HoldsSvcClient HoldsSvc { get; }
        IncidentalItemSvc.IncidentalItemSvcClient IncidentalItemSvc { get; }
        IncidentalSupplySvc.IncidentalSupplySvcClient IncidentalSupplySvc { get; }
        PricingSvc.PricingSvcClient PricingSvc { get; }
        RateScheduleSvc.RateScheduleSvcClient RateScheduleSvc { get; }
        RoomTypeSvc.RoomTypeSvcClient RoomTypeSvc { get; }
        SupplyHistorySnapshotSvc.SupplyHistorySnapshotSvcClient SupplyHistorySnapshotSvc { get; }
        SupplySnapshotSvc.SupplySnapshotSvcClient SupplySnapshotSvc { get; }
        OtaBaseSupplySvc.OtaBaseSupplySvcClient OtaBaseSupplySvc { get; }
        PricingOverrideSvc.PricingOverrideSvcClient PricingOverrideSvc { get; }
        #endregion

        #region TenancyConfig
        ChannelManagerConfigurationSvc.ChannelManagerConfigurationSvcClient ChannelManagerConfigurationSvc { get; }
        ChimeSvc.ChimeSvcClient ChimeSvcClient { get; }
        ForeignPropertyConfigurationSvc.ForeignPropertyConfigurationSvcClient ForeignPropertyConfigurationSvc { get; }
        GroupBookingMethodSvc.GroupBookingMethodSvcClient GroupBookingMethodSvc { get; }
        HkPhoneCodeSvc.HkPhoneCodeSvcClient HkPhoneCodeSvc { get; }
        KCEConfigSvc.KCEConfigSvcClient KCEConfigSvc { get; }
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
        ReportingConfigurationSvc.ReportingConfigurationSvcClient ReportingConfigurationSvc { get; }
        DefaultSettingsSvc.DefaultSettingsSvcClient DefaultSettingsSvc { get; }
        RoomStatusSvc.RoomStatusSvcClient RoomStatusSvc { get; }
        ReveneueManagementSvc.ReveneueManagementSvcClient RevManagementSvc { get; }
        #endregion

        #region Reporting
        CardCaptureReportingSvc.CardCaptureReportingSvcClient CardCaptureReportingSvc { get; }
        FoliosReportingSvc.FoliosReportingSvcClient FoliosReportingSvc { get; }
        FrontDeskReportingSvc.FrontDeskReportingSvcClient FrontDeskReportingSvc { get; }
        ManagementReportingSvc.ManagementReportingSvcClient ManagementReportingSvc { get; }
        OperationsReportingSvc.OperationsReportingSvcClient OperationsReportingSvc { get; }
        ReportingDefaultSvc.ReportingDefaultSvcClient ReportingDefaultSvc { get; }
        #endregion

        StaffMemberIndicator AuthenticatedUser { get; }
        SessionContext SC { get; }
        string ServerName { get; }
        SessionService SS { get; }
        string TenancyName { get; }
        string UserName { get; }
        
        Task<SessionSvcStartSessionResult> StartSession(string candidateUsername, string candidatePassword
                                                            , ClientInstance clientInstance);
    }
}

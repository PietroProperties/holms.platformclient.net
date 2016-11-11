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
        AccountAssignmentsSvc.AccountAssignmentsSvcClient AccountAssignmentSvc { get; }
        AccountingTxnSvc.AccountingTxnSvcClient AccountingTxnSvc { get; }
        AccountSvc.AccountSvcClient AccountSvc { get; }
        AttractionCategorySvc.AttractionCategorySvcClient AttractionCategorySvc { get; }
        StaffMemberIndicator AuthenticatedUser { get; }
        BookingPricingSvc.BookingPricingSvcClient BkPricingSvc { get; }
        CalendarMsgSvc.CalendarMsgSvcClient CalendarMsgSvc { get; }
        CancellationPolicySvc.CancellationPolicySvcClient CancellationPolicySvc { get; }
        CancellationReasonSvc.CancellationReasonSvcClient CancellationReasonSvc { get; }
        CardCaptureReportingSvc.CardCaptureReportingSvcClient CardCaptureReportingSvc { get; }
        CardMerchantSvc.CardMerchantSvcClient CardMerchantSvc { get; }
        CardProcessingSvc.CardProcessingSvcClient CardProcessingSvc { get; }
        CardTerminalSvc.CardTerminalSvcClient CardTerminalSvc { get; }
        CheckInService.CheckInServiceClient CheckInSvc { get; }
        CheckoutSvc.CheckoutSvcClient CheckOutSvc { get; }
        ClientInstanceSvc.ClientInstanceSvcClient ClientInstancesSvc { get; }
        DepartmentSvc.DepartmentSvcClient DepartmentsSvc { get; }
        FrontDeskReportingSvc.FrontDeskReportingSvcClient FrontDeskReportingSvc { get; }
        GroupBookingMethodSvc.GroupBookingMethodSvcClient GroupBookingMethodSvc { get; }
        GroupBookingSvc.GroupBookingSvcClient GroupBookingSvc { get; }
        GroupSvc.GroupSvcClient GroupSvc { get; }
        GuaranteeAuthorizerService.GuaranteeAuthorizerServiceClient GuaranteeAuthorizerService { get; }
        GuestSvc.GuestSvcClient GuestSvc { get; }
        HKDirtyTrackingSvc.HKDirtyTrackingSvcClient HKDirtyTrackingSvc { get; }
        HkPhoneCodeSvc.HkPhoneCodeSvcClient HkPhoneCodeSvc { get; }
        HoldsSvc.HoldsSvcClient HoldsSvc { get; }
        HousekeepingManagementSvc.HousekeepingManagementSvcClient HousekeepingManagementSvc { get; }
        HousekeepingTimeSvc.HousekeepingTimeSvcClient HousekeepingTimeSvc { get; }
        InventoryItemSvc.InventoryItemSvcClient InventoryItemSvc { get; }
        LodgingBookingSvc.LodgingBookingSvcClient LodgingBookingSvc { get; }
        ILogger Logger { get; }
        NoteRequestSvc.NoteRequestSvcClient NoteRequestSvc { get; }
        OpenLodgingReservationSvc.OpenLodgingReservationSvcClient OpenLodgingReservationSvc { get; }
        OutOfOrderRecordSvc.OutOfOrderRecordSvcClient OutOfOrderRecordSvc { get; }
        PBXSvc.PBXSvcClient PBXSvc { get; }
        PhoneCodeSvc.PhoneCodeSvcClient PhoneCodeSvc { get; }
        PricingSvc.PricingSvcClient PricingSvc { get; }
        PropertySvc.PropertySvcClient PropertySvc { get; }
        QualificationSvc.QualificationSvcClient QualificationSvc { get; }
        RateScheduleSvc.RateScheduleSvcClient RateScheduleSvc { get; }
        ReservationCancellationSvc.ReservationCancellationSvcClient ResCancellationSvc { get; }
        ReservationDefaultsSvc.ReservationDefaultsSvcClient ReservationDefaultsSvc { get; }
        ReservationFolioSvc.ReservationFolioSvcClient ReservationFolioSvc { get; }
        ReservationNoteSvc.ReservationNoteSvcClient ReservationNoteSvc { get; }
        ReservationSourceSvc.ReservationSourceSvcClient ReservationSourceSvc { get; }
        ReservationStatusColorsSvc.ReservationStatusColorsSvcClient ReservationStatusColorsSvc { get; }
        ReservationGuaranteeSvc.ReservationGuaranteeSvcClient ResGuaranteeSvc { get; }
        RestrictionSvc.RestrictionSvcClient RestrictionSvc { get; }
        RoomCallBillingRatesSvc.RoomCallBillingRatesSvcClient RoomCallBillingRatesSvc { get; }
        RoomClaimsSvc.RoomClaimsSvcClient RoomClaimsSvc { get; }
        RoomStatusColorsSvc.RoomStatusColorsSvcClient RoomStatusColorsSvc { get; }
        RoomStatusSettingsSvc.RoomStatusSettingsSvcClient RoomStatusSettingsSvc { get; }
        RoomSvc.RoomSvcClient RoomSvc { get; }
        RoomTypeSvc.RoomTypeSvcClient RoomTypeSvc { get; }
        RoomUseStatusCalculatorSvc.RoomUseStatusCalculatorSvcClient RoomUseStatusCalculatorSvc { get; }
        SessionContext SC { get; }
        string ServerName { get; }
        SessionService SS { get; }
        StaffMsgSvc.StaffMsgSvcClient StaffMsgSvc { get; }
        StaffSvc.StaffSvcClient StaffSvc { get; }
        SupplySnapshotSvc.SupplySnapshotSvcClient SupplySnapshotSvc { get; }
        TaxFeeSvc.TaxFeeSvcClient TaxFeeSvc { get; }
        string TenancyName { get; }
        TravelAgentSvc.TravelAgentSvcClient TravelAgentSvc { get; }
        TurnAwayReasonSvc.TurnAwayReasonSvcClient TurnAwayReasonSvc { get; }
        string UserName { get; }
        ZipCodeSvc.ZipCodeSvcClient ZipCodesService { get; }

        Task<SessionSvcStartSessionResult> StartSession(string candidateUsername, string candidatePassword);
    }
}
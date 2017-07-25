using System;
using System.Threading.Tasks;
using HOLMS.Application.Client;
using HOLMS.Types.Booking.RPC;
using HOLMS.Types.CRM.RPC;
using HOLMS.Types.IAM;
using HOLMS.Types.IAM.RPC;
using HOLMS.Types.Money.RPC;
using HOLMS.Types.Operations.RPC;
using HOLMS.Types.Primitive;
using HOLMS.Types.Reporting.RPC;
using HOLMS.Types.Supply.RPC;
using HOLMS.Types.TenancyConfig.RPC;
using Microsoft.Extensions.Logging;
using Moq;

namespace HOLMS.Platform.Application.Client {
    public class MockApplicationClient : IApplicationClient {
        public ILogger Logger { get; }
        public Mock<IncidentalItemSvc.IncidentalItemSvcClient> IncidentalItemSvcMock { get; }
        public Mock<LodgingBookingSvc.LodgingBookingSvcClient> LodgingBookingSvcMock { get; }
        public Mock<TaxFeeSvc.TaxFeeSvcClient> TaxFeeSvcMock { get; }

        public MockApplicationClient(ILogger logger) {
            Logger = logger;
            
            IncidentalItemSvcMock = new Mock<IncidentalItemSvc.IncidentalItemSvcClient>();
            LodgingBookingSvcMock = new Mock<LodgingBookingSvc.LodgingBookingSvcClient>();
            TaxFeeSvcMock = new Mock<TaxFeeSvc.TaxFeeSvcClient>();
        }

        public async Task<SessionSvcStartSessionResult> StartSession(string candidateUsername, string candidatePassword) {
            await Task.Delay(0);
            return SessionSvcStartSessionResult.Success;
        }

        public SessionContext SC {
            get {
                return new SessionContext() {
                    AccessToken = string.Empty,
                    RefreshToken = string.Empty,
                    TenancyName = string.Empty,
                    User = new StaffMemberIndicator(new Guid()),
                    UserName = string.Empty,
                };
            }
        }

        public AccountAssignmentsSvc.AccountAssignmentsSvcClient AccountAssignmentSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public TenancySvc.TenancySvcClient TenancySvc { get; }

        public AccountingTxnSvc.AccountingTxnSvcClient AccountingTxnSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public AccountSvc.AccountSvcClient AccountSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ArrivalLetterTemplateSvc.ArrivalLetterTemplateSvcClient ArrivalLetterTmplSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public AttractionCategorySvc.AttractionCategorySvcClient AttractionCategorySvc {
            get {
                throw new NotImplementedException();
            }
        }

        public StaffMemberIndicator AuthenticatedUser {
            get {
                throw new NotImplementedException();
            }
        }

        public BookingPricingSvc.BookingPricingSvcClient BkPricingSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public CalendarMsgSvc.CalendarMsgSvcClient CalendarMsgSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public CancellationReasonSvc.CancellationReasonSvcClient CancellationReasonSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public CardCaptureReportingSvc.CardCaptureReportingSvcClient CardCaptureReportingSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public CardMerchantSvc.CardMerchantSvcClient CardMerchantSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public CardProcessingSvc.CardProcessingSvcClient CardProcessingSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public CardTerminalSvc.CardTerminalSvcClient CardTerminalSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public CheckInService.CheckInServiceClient CheckInSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public CheckoutSvc.CheckoutSvcClient CheckOutSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ClientInstanceSvc.ClientInstanceSvcClient ClientInstancesSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public DefaultTemplatesSvc.DefaultTemplatesSvcClient DefaultTemplatesSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public DepartmentSvc.DepartmentSvcClient DepartmentsSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public FrontDeskReportingSvc.FrontDeskReportingSvcClient FrontDeskReportingSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public GroupBookingMethodSvc.GroupBookingMethodSvcClient GroupBookingMethodSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public GroupBookingSvc.GroupBookingSvcClient GroupBookingSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public CorrespondenceSvc.CorrespondenceSvcClient CorrespondenceSvc { get; }

        public GroupSvc.GroupSvcClient GroupSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public GuestHistorySvc.GuestHistorySvcClient GuestHistorySvc { get; }

        public GuaranteeAuthorizerService.GuaranteeAuthorizerServiceClient GuaranteeAuthorizerService {
            get {
                throw new NotImplementedException();
            }
        }

        public GuestFolioTemplateSvc.GuestFolioTemplateSvcClient GuestFolioTmplSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public GuestSvc.GuestSvcClient GuestSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public HKDirtyTrackingSvc.HKDirtyTrackingSvcClient HKDirtyTrackingSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public HkPhoneCodeSvc.HkPhoneCodeSvcClient HkPhoneCodeSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public HoldsSvc.HoldsSvcClient HoldsSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public IncidentalSupplySvc.IncidentalSupplySvcClient IncidentalSupplySvc { get; }

        public HousekeepingManagementSvc.HousekeepingManagementSvcClient HousekeepingManagementSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public HousekeepingTimeSvc.HousekeepingTimeSvcClient HousekeepingTimeSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public IncidentalItemReservationSvc.IncidentalItemReservationSvcClient IncidentalResSvc { get; }

        public IncidentalItemSvc.IncidentalItemSvcClient IncidentalItemSvc => IncidentalItemSvcMock.Object;
        public LodgingBookingSvc.LodgingBookingSvcClient LodgingBookingSvc => LodgingBookingSvcMock.Object;
        public TaxFeeSvc.TaxFeeSvcClient TaxFeeSvc => TaxFeeSvcMock.Object;

        public ManagementReportingSvc.ManagementReportingSvcClient ManagementReportingSvc {
            get { throw new NotImplementedException(); }
        }

        public NoteRequestSvc.NoteRequestSvcClient NoteRequestSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public OpenLodgingReservationSvc.OpenLodgingReservationSvcClient OpenLodgingReservationSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public OutOfOrderRecordSvc.OutOfOrderRecordSvcClient OutOfOrderRecordSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public PBXSvc.PBXSvcClient PBXSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public PhoneCodeSvc.PhoneCodeSvcClient PhoneCodeSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public PricingSvc.PricingSvcClient PricingSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public RateScheduleSvc.RateScheduleSvcClient RateScheduleSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ReservationCancellationSvc.ReservationCancellationSvcClient ResCancellationSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ReservationDefaultsSvc.ReservationDefaultsSvcClient ReservationDefaultsSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ReservationFolioSvc.ReservationFolioSvcClient ReservationFolioSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ReservationNoteSvc.ReservationNoteSvcClient ReservationNoteSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ReservationSourceSvc.ReservationSourceSvcClient ReservationSourceSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ReservationStatusColorsSvc.ReservationStatusColorsSvcClient ReservationStatusColorsSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ReservationGuaranteeSvc.ReservationGuaranteeSvcClient ResGuaranteeSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public RestrictionSvc.RestrictionSvcClient RestrictionSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public RoomCallBillingRatesSvc.RoomCallBillingRatesSvcClient RoomCallBillingRatesSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public RoomClaimsSvc.RoomClaimsSvcClient RoomClaimsSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public RoomStatusColorsSvc.RoomStatusColorsSvcClient RoomStatusColorsSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public RoomStatusSettingsSvc.RoomStatusSettingsSvcClient RoomStatusSettingsSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public RoomSvc.RoomSvcClient RoomSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public RoomTypeSvc.RoomTypeSvcClient RoomTypeSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public RoomUseStatusCalculatorSvc.RoomUseStatusCalculatorSvcClient RoomUseStatusCalculatorSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public string ServerName {
            get {
                throw new NotImplementedException();
            }
        }

        public SessionSvc.SessionSvcClient SessionSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public SessionService SS {
            get {
                throw new NotImplementedException();
            }
        }

        public StaffMsgSvc.StaffMsgSvcClient StaffMsgSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public StaffSvc.StaffSvcClient StaffSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public SupplySnapshotSvc.SupplySnapshotSvcClient SupplySnapshotSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public string TenancyName {
            get {
                throw new NotImplementedException();
            }
        }

        public TravelAgentSvc.TravelAgentSvcClient TravelAgentSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public TurnAwayReasonSvc.TurnAwayReasonSvcClient TurnAwayReasonSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public string UserName {
            get {
                throw new NotImplementedException();
            }
        }

        public ZipCodeSvc.ZipCodeSvcClient ZipCodesService {
            get {
                throw new NotImplementedException();
            }
        }

        public PropertySvc.PropertySvcClient PropertySvc {
            get {
                throw new NotImplementedException();
            }
        }

        public CancellationPolicySvc.CancellationPolicySvcClient CancellationPolicySvc {
            get {
                throw new NotImplementedException();
            }
        }

        public OTASyncSvc.OTASyncSvcClient OTASyncSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ChannelManagerConfigurationSvc.ChannelManagerConfigurationSvcClient ChannelManagerConfigurationSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public GroupBookingFolioSvc.GroupBookingFolioSvcClient GroupBookingFolioSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ReservationSearchSvc.ReservationSearchSvcClient ReservationSearchSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public ReservationTagsSvc.ReservationTagsSvcClient ReservationTagsSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public OTAChannelProviderSvc.OTAChannelProviderSvcClient OTAChannelProviderSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public FolioAuthCleanupSvc.FolioAuthCleanupSvcClient FolioAuthCleanupSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public MasterFolioSvc.MasterFolioSvcClient MasterFolioSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public IIFExportConfigSvc.IIFExportConfigSvcClient IIFExportConfigSvc {
            get {
                throw new NotImplementedException();
            }
        }

        public KCRConfigSvc.KCRConfigSvcClient KCRConfigSvc {
            get {
                throw new NotImplementedException();
            }
        }
    }
}

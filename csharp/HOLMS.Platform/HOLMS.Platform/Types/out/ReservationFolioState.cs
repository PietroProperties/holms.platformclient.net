// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/reservation_folio_state.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/reservation_folio_state.proto</summary>
  public static partial class ReservationFolioStateReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/reservation_folio_state.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationFolioStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNmb2xpby9yZXNlcnZhdGlvbl9mb2xpb19zdGF0ZS5wcm90bxIRaG9sbXMu",
            "dHlwZXMuZm9saW8aH2ZvbGlvL2ZvbGlvX2F0b21pY19jaGFyZ2UucHJvdG8a",
            "HWZvbGlvL2ZvbGlvX2NhcmRfcmVmdW5kLnByb3RvGhtmb2xpby9mb2xpb19j",
            "YXJkX3NhbGUucHJvdG8aJGZvbGlvL2ZvbGlvX2NoZWNrX2Nhc2hfcGF5bWVu",
            "dC5wcm90bxogZm9saW8vZm9saW9fdGF4X2Fzc2Vzc21lbnQucHJvdG8aJWZv",
            "bGlvL3Jlc2VydmF0aW9uX2ZvbGlvX3N1bW1hcnkucHJvdG8aH3ByaW1pdGl2",
            "ZS9tb25ldGFyeV9hbW91bnQucHJvdG8i4gsKFVJlc2VydmF0aW9uRm9saW9T",
            "dGF0ZRI/ChFlZmZlY3RpdmVfY2hhcmdlcxgBIAMoCzIkLmhvbG1zLnR5cGVz",
            "LmZvbGlvLkZvbGlvQXRvbWljQ2hhcmdlEjgKDGNhcmRfcmVmdW5kcxgDIAMo",
            "CzIiLmhvbG1zLnR5cGVzLmZvbGlvLkZvbGlvQ2FyZFJlZnVuZBI0CgpjYXJk",
            "X3NhbGVzGAQgAygLMiAuaG9sbXMudHlwZXMuZm9saW8uRm9saW9DYXJkU2Fs",
            "ZRJFChNjaGVja19jYXNoX3BheW1lbnRzGAUgAygLMiguaG9sbXMudHlwZXMu",
            "Zm9saW8uRm9saW9DaGVja0Nhc2hQYXltZW50EkYKF2N1cnJlbnRfdGF4X2Fz",
            "c2Vzc21lbnRzGAYgAygLMiUuaG9sbXMudHlwZXMuZm9saW8uRm9saW9UYXhB",
            "c3Nlc3NtZW50ElAKIWFudGljaXBhdGVkX2VuZGluZ190YXhfYXNzZXNzbWVu",
            "dBgHIAMoCzIlLmhvbG1zLnR5cGVzLmZvbGlvLkZvbGlvVGF4QXNzZXNzbWVu",
            "dBI8Cg5uYXRpdmVfY2hhcmdlcxgJIAMoCzIkLmhvbG1zLnR5cGVzLmZvbGlv",
            "LkZvbGlvQXRvbWljQ2hhcmdlEk0KH2V4cG9ydGVkX3RvX290aGVyX2ZvbGlv",
            "X2NoYXJnZXMYCiADKAsyJC5ob2xtcy50eXBlcy5mb2xpby5Gb2xpb0F0b21p",
            "Y0NoYXJnZRJPCiFpbXBvcnRlZF9mcm9tX290aGVyX2ZvbGlvX2NoYXJnZXMY",
            "CyADKAsyJC5ob2xtcy50eXBlcy5mb2xpby5Gb2xpb0F0b21pY0NoYXJnZRJC",
            "ChNjdXJyZW50X25ldF9jaGFyZ2VzGAwgASgLMiUuaG9sbXMudHlwZXMucHJp",
            "bWl0aXZlLk1vbmV0YXJ5QW1vdW50EkYKF2FudGljaXBhdGVkX25ldF9jaGFy",
            "Z2VzGA0gASgLMiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5QW1v",
            "dW50Ej4KD3Bvc3RlZF9wYXltZW50cxgOIAEoCzIlLmhvbG1zLnR5cGVzLnBy",
            "aW1pdGl2ZS5Nb25ldGFyeUFtb3VudBI9Cg5wb3N0ZWRfcmVmdW5kcxgPIAEo",
            "CzIlLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudBJMCh11",
            "bnVzZWRfcGF5bWVudF9hdXRob3JpemF0aW9ucxgQIAEoCzIlLmhvbG1zLnR5",
            "cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudBJOCh91bnVzZWRfZ3VhcmFu",
            "dGVlX2F1dGhvcml6YXRpb25zGBEgASgLMiUuaG9sbXMudHlwZXMucHJpbWl0",
            "aXZlLk1vbmV0YXJ5QW1vdW50EkUKFmN1cnJlbnRfZHVlX2Zyb21fZ3Vlc3QY",
            "EiABKAsyJS5ob2xtcy50eXBlcy5wcmltaXRpdmUuTW9uZXRhcnlBbW91bnQS",
            "UgojYW50aWNpcGF0ZWRfY2hlY2tvdXRfZHVlX2Zyb21fZ3Vlc3QYEyABKAsy",
            "JS5ob2xtcy50eXBlcy5wcmltaXRpdmUuTW9uZXRhcnlBbW91bnQSIQoZZ3Jh",
            "Y2VmdWxfY2xvc3VyZV9wb3NzaWJsZRgUIAEoCBI7CgdzdW1tYXJ5GBUgASgL",
            "MiouaG9sbXMudHlwZXMuZm9saW8uUmVzZXJ2YXRpb25Gb2xpb1N1bW1hcnkS",
            "LAokbWFzdGVyX2ZvbGlvX2FjY3J1ZXNfbG9kZ2luZ19jaGFyZ2VzGBYgASgI",
            "Ei8KJ21hc3Rlcl9mb2xpb19hY2NydWVzX2luY2lkZW50YWxfY2hhcmdlcxgX",
            "IAEoCBJWCidyZW1haW5pbmdfdGVuZGVyX3JlcXVpcmVkX2Zvcl9ndWFyYW50",
            "ZWUYGCABKAsyJS5ob2xtcy50eXBlcy5wcmltaXRpdmUuTW9uZXRhcnlBbW91",
            "bnRCFKoCEUhPTE1TLlR5cGVzLkZvbGlvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Folio.FolioAtomicChargeReflection.Descriptor, global::HOLMS.Types.Folio.FolioCardRefundReflection.Descriptor, global::HOLMS.Types.Folio.FolioCardSaleReflection.Descriptor, global::HOLMS.Types.Folio.FolioCheckCashPaymentReflection.Descriptor, global::HOLMS.Types.Folio.FolioTaxAssessmentReflection.Descriptor, global::HOLMS.Types.Folio.ReservationFolioSummaryReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.ReservationFolioState), global::HOLMS.Types.Folio.ReservationFolioState.Parser, new[]{ "EffectiveCharges", "CardRefunds", "CardSales", "CheckCashPayments", "CurrentTaxAssessments", "AnticipatedEndingTaxAssessment", "NativeCharges", "ExportedToOtherFolioCharges", "ImportedFromOtherFolioCharges", "CurrentNetCharges", "AnticipatedNetCharges", "PostedPayments", "PostedRefunds", "UnusedPaymentAuthorizations", "UnusedGuaranteeAuthorizations", "CurrentDueFromGuest", "AnticipatedCheckoutDueFromGuest", "GracefulClosurePossible", "Summary", "MasterFolioAccruesLodgingCharges", "MasterFolioAccruesIncidentalCharges", "RemainingTenderRequiredForGuarantee" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationFolioState : pb::IMessage<ReservationFolioState> {
    private static readonly pb::MessageParser<ReservationFolioState> _parser = new pb::MessageParser<ReservationFolioState>(() => new ReservationFolioState());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationFolioState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.ReservationFolioStateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFolioState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFolioState(ReservationFolioState other) : this() {
      effectiveCharges_ = other.effectiveCharges_.Clone();
      cardRefunds_ = other.cardRefunds_.Clone();
      cardSales_ = other.cardSales_.Clone();
      checkCashPayments_ = other.checkCashPayments_.Clone();
      currentTaxAssessments_ = other.currentTaxAssessments_.Clone();
      anticipatedEndingTaxAssessment_ = other.anticipatedEndingTaxAssessment_.Clone();
      nativeCharges_ = other.nativeCharges_.Clone();
      exportedToOtherFolioCharges_ = other.exportedToOtherFolioCharges_.Clone();
      importedFromOtherFolioCharges_ = other.importedFromOtherFolioCharges_.Clone();
      CurrentNetCharges = other.currentNetCharges_ != null ? other.CurrentNetCharges.Clone() : null;
      AnticipatedNetCharges = other.anticipatedNetCharges_ != null ? other.AnticipatedNetCharges.Clone() : null;
      PostedPayments = other.postedPayments_ != null ? other.PostedPayments.Clone() : null;
      PostedRefunds = other.postedRefunds_ != null ? other.PostedRefunds.Clone() : null;
      UnusedPaymentAuthorizations = other.unusedPaymentAuthorizations_ != null ? other.UnusedPaymentAuthorizations.Clone() : null;
      UnusedGuaranteeAuthorizations = other.unusedGuaranteeAuthorizations_ != null ? other.UnusedGuaranteeAuthorizations.Clone() : null;
      CurrentDueFromGuest = other.currentDueFromGuest_ != null ? other.CurrentDueFromGuest.Clone() : null;
      AnticipatedCheckoutDueFromGuest = other.anticipatedCheckoutDueFromGuest_ != null ? other.AnticipatedCheckoutDueFromGuest.Clone() : null;
      gracefulClosurePossible_ = other.gracefulClosurePossible_;
      Summary = other.summary_ != null ? other.Summary.Clone() : null;
      masterFolioAccruesLodgingCharges_ = other.masterFolioAccruesLodgingCharges_;
      masterFolioAccruesIncidentalCharges_ = other.masterFolioAccruesIncidentalCharges_;
      RemainingTenderRequiredForGuarantee = other.remainingTenderRequiredForGuarantee_ != null ? other.RemainingTenderRequiredForGuarantee.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFolioState Clone() {
      return new ReservationFolioState(this);
    }

    /// <summary>Field number for the "effective_charges" field.</summary>
    public const int EffectiveChargesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.FolioAtomicCharge> _repeated_effectiveCharges_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Folio.FolioAtomicCharge.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge> effectiveCharges_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge> EffectiveCharges {
      get { return effectiveCharges_; }
    }

    /// <summary>Field number for the "card_refunds" field.</summary>
    public const int CardRefundsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.FolioCardRefund> _repeated_cardRefunds_codec
        = pb::FieldCodec.ForMessage(26, global::HOLMS.Types.Folio.FolioCardRefund.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.FolioCardRefund> cardRefunds_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.FolioCardRefund>();
    /// <summary>
    ///  deprecated adjustments = 2
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.FolioCardRefund> CardRefunds {
      get { return cardRefunds_; }
    }

    /// <summary>Field number for the "card_sales" field.</summary>
    public const int CardSalesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.FolioCardSale> _repeated_cardSales_codec
        = pb::FieldCodec.ForMessage(34, global::HOLMS.Types.Folio.FolioCardSale.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.FolioCardSale> cardSales_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.FolioCardSale>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.FolioCardSale> CardSales {
      get { return cardSales_; }
    }

    /// <summary>Field number for the "check_cash_payments" field.</summary>
    public const int CheckCashPaymentsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.FolioCheckCashPayment> _repeated_checkCashPayments_codec
        = pb::FieldCodec.ForMessage(42, global::HOLMS.Types.Folio.FolioCheckCashPayment.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.FolioCheckCashPayment> checkCashPayments_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.FolioCheckCashPayment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.FolioCheckCashPayment> CheckCashPayments {
      get { return checkCashPayments_; }
    }

    /// <summary>Field number for the "current_tax_assessments" field.</summary>
    public const int CurrentTaxAssessmentsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.FolioTaxAssessment> _repeated_currentTaxAssessments_codec
        = pb::FieldCodec.ForMessage(50, global::HOLMS.Types.Folio.FolioTaxAssessment.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.FolioTaxAssessment> currentTaxAssessments_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.FolioTaxAssessment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.FolioTaxAssessment> CurrentTaxAssessments {
      get { return currentTaxAssessments_; }
    }

    /// <summary>Field number for the "anticipated_ending_tax_assessment" field.</summary>
    public const int AnticipatedEndingTaxAssessmentFieldNumber = 7;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.FolioTaxAssessment> _repeated_anticipatedEndingTaxAssessment_codec
        = pb::FieldCodec.ForMessage(58, global::HOLMS.Types.Folio.FolioTaxAssessment.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.FolioTaxAssessment> anticipatedEndingTaxAssessment_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.FolioTaxAssessment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.FolioTaxAssessment> AnticipatedEndingTaxAssessment {
      get { return anticipatedEndingTaxAssessment_; }
    }

    /// <summary>Field number for the "native_charges" field.</summary>
    public const int NativeChargesFieldNumber = 9;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.FolioAtomicCharge> _repeated_nativeCharges_codec
        = pb::FieldCodec.ForMessage(74, global::HOLMS.Types.Folio.FolioAtomicCharge.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge> nativeCharges_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge>();
    /// <summary>
    ///  deprecated master folio status = 8
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge> NativeCharges {
      get { return nativeCharges_; }
    }

    /// <summary>Field number for the "exported_to_other_folio_charges" field.</summary>
    public const int ExportedToOtherFolioChargesFieldNumber = 10;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.FolioAtomicCharge> _repeated_exportedToOtherFolioCharges_codec
        = pb::FieldCodec.ForMessage(82, global::HOLMS.Types.Folio.FolioAtomicCharge.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge> exportedToOtherFolioCharges_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge> ExportedToOtherFolioCharges {
      get { return exportedToOtherFolioCharges_; }
    }

    /// <summary>Field number for the "imported_from_other_folio_charges" field.</summary>
    public const int ImportedFromOtherFolioChargesFieldNumber = 11;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.FolioAtomicCharge> _repeated_importedFromOtherFolioCharges_codec
        = pb::FieldCodec.ForMessage(90, global::HOLMS.Types.Folio.FolioAtomicCharge.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge> importedFromOtherFolioCharges_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.FolioAtomicCharge> ImportedFromOtherFolioCharges {
      get { return importedFromOtherFolioCharges_; }
    }

    /// <summary>Field number for the "current_net_charges" field.</summary>
    public const int CurrentNetChargesFieldNumber = 12;
    private global::HOLMS.Types.Primitive.MonetaryAmount currentNetCharges_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount CurrentNetCharges {
      get { return currentNetCharges_; }
      set {
        currentNetCharges_ = value;
      }
    }

    /// <summary>Field number for the "anticipated_net_charges" field.</summary>
    public const int AnticipatedNetChargesFieldNumber = 13;
    private global::HOLMS.Types.Primitive.MonetaryAmount anticipatedNetCharges_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount AnticipatedNetCharges {
      get { return anticipatedNetCharges_; }
      set {
        anticipatedNetCharges_ = value;
      }
    }

    /// <summary>Field number for the "posted_payments" field.</summary>
    public const int PostedPaymentsFieldNumber = 14;
    private global::HOLMS.Types.Primitive.MonetaryAmount postedPayments_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount PostedPayments {
      get { return postedPayments_; }
      set {
        postedPayments_ = value;
      }
    }

    /// <summary>Field number for the "posted_refunds" field.</summary>
    public const int PostedRefundsFieldNumber = 15;
    private global::HOLMS.Types.Primitive.MonetaryAmount postedRefunds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount PostedRefunds {
      get { return postedRefunds_; }
      set {
        postedRefunds_ = value;
      }
    }

    /// <summary>Field number for the "unused_payment_authorizations" field.</summary>
    public const int UnusedPaymentAuthorizationsFieldNumber = 16;
    private global::HOLMS.Types.Primitive.MonetaryAmount unusedPaymentAuthorizations_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount UnusedPaymentAuthorizations {
      get { return unusedPaymentAuthorizations_; }
      set {
        unusedPaymentAuthorizations_ = value;
      }
    }

    /// <summary>Field number for the "unused_guarantee_authorizations" field.</summary>
    public const int UnusedGuaranteeAuthorizationsFieldNumber = 17;
    private global::HOLMS.Types.Primitive.MonetaryAmount unusedGuaranteeAuthorizations_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount UnusedGuaranteeAuthorizations {
      get { return unusedGuaranteeAuthorizations_; }
      set {
        unusedGuaranteeAuthorizations_ = value;
      }
    }

    /// <summary>Field number for the "current_due_from_guest" field.</summary>
    public const int CurrentDueFromGuestFieldNumber = 18;
    private global::HOLMS.Types.Primitive.MonetaryAmount currentDueFromGuest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount CurrentDueFromGuest {
      get { return currentDueFromGuest_; }
      set {
        currentDueFromGuest_ = value;
      }
    }

    /// <summary>Field number for the "anticipated_checkout_due_from_guest" field.</summary>
    public const int AnticipatedCheckoutDueFromGuestFieldNumber = 19;
    private global::HOLMS.Types.Primitive.MonetaryAmount anticipatedCheckoutDueFromGuest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount AnticipatedCheckoutDueFromGuest {
      get { return anticipatedCheckoutDueFromGuest_; }
      set {
        anticipatedCheckoutDueFromGuest_ = value;
      }
    }

    /// <summary>Field number for the "graceful_closure_possible" field.</summary>
    public const int GracefulClosurePossibleFieldNumber = 20;
    private bool gracefulClosurePossible_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool GracefulClosurePossible {
      get { return gracefulClosurePossible_; }
      set {
        gracefulClosurePossible_ = value;
      }
    }

    /// <summary>Field number for the "summary" field.</summary>
    public const int SummaryFieldNumber = 21;
    private global::HOLMS.Types.Folio.ReservationFolioSummary summary_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.ReservationFolioSummary Summary {
      get { return summary_; }
      set {
        summary_ = value;
      }
    }

    /// <summary>Field number for the "master_folio_accrues_lodging_charges" field.</summary>
    public const int MasterFolioAccruesLodgingChargesFieldNumber = 22;
    private bool masterFolioAccruesLodgingCharges_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool MasterFolioAccruesLodgingCharges {
      get { return masterFolioAccruesLodgingCharges_; }
      set {
        masterFolioAccruesLodgingCharges_ = value;
      }
    }

    /// <summary>Field number for the "master_folio_accrues_incidental_charges" field.</summary>
    public const int MasterFolioAccruesIncidentalChargesFieldNumber = 23;
    private bool masterFolioAccruesIncidentalCharges_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool MasterFolioAccruesIncidentalCharges {
      get { return masterFolioAccruesIncidentalCharges_; }
      set {
        masterFolioAccruesIncidentalCharges_ = value;
      }
    }

    /// <summary>Field number for the "remaining_tender_required_for_guarantee" field.</summary>
    public const int RemainingTenderRequiredForGuaranteeFieldNumber = 24;
    private global::HOLMS.Types.Primitive.MonetaryAmount remainingTenderRequiredForGuarantee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount RemainingTenderRequiredForGuarantee {
      get { return remainingTenderRequiredForGuarantee_; }
      set {
        remainingTenderRequiredForGuarantee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationFolioState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationFolioState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!effectiveCharges_.Equals(other.effectiveCharges_)) return false;
      if(!cardRefunds_.Equals(other.cardRefunds_)) return false;
      if(!cardSales_.Equals(other.cardSales_)) return false;
      if(!checkCashPayments_.Equals(other.checkCashPayments_)) return false;
      if(!currentTaxAssessments_.Equals(other.currentTaxAssessments_)) return false;
      if(!anticipatedEndingTaxAssessment_.Equals(other.anticipatedEndingTaxAssessment_)) return false;
      if(!nativeCharges_.Equals(other.nativeCharges_)) return false;
      if(!exportedToOtherFolioCharges_.Equals(other.exportedToOtherFolioCharges_)) return false;
      if(!importedFromOtherFolioCharges_.Equals(other.importedFromOtherFolioCharges_)) return false;
      if (!object.Equals(CurrentNetCharges, other.CurrentNetCharges)) return false;
      if (!object.Equals(AnticipatedNetCharges, other.AnticipatedNetCharges)) return false;
      if (!object.Equals(PostedPayments, other.PostedPayments)) return false;
      if (!object.Equals(PostedRefunds, other.PostedRefunds)) return false;
      if (!object.Equals(UnusedPaymentAuthorizations, other.UnusedPaymentAuthorizations)) return false;
      if (!object.Equals(UnusedGuaranteeAuthorizations, other.UnusedGuaranteeAuthorizations)) return false;
      if (!object.Equals(CurrentDueFromGuest, other.CurrentDueFromGuest)) return false;
      if (!object.Equals(AnticipatedCheckoutDueFromGuest, other.AnticipatedCheckoutDueFromGuest)) return false;
      if (GracefulClosurePossible != other.GracefulClosurePossible) return false;
      if (!object.Equals(Summary, other.Summary)) return false;
      if (MasterFolioAccruesLodgingCharges != other.MasterFolioAccruesLodgingCharges) return false;
      if (MasterFolioAccruesIncidentalCharges != other.MasterFolioAccruesIncidentalCharges) return false;
      if (!object.Equals(RemainingTenderRequiredForGuarantee, other.RemainingTenderRequiredForGuarantee)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= effectiveCharges_.GetHashCode();
      hash ^= cardRefunds_.GetHashCode();
      hash ^= cardSales_.GetHashCode();
      hash ^= checkCashPayments_.GetHashCode();
      hash ^= currentTaxAssessments_.GetHashCode();
      hash ^= anticipatedEndingTaxAssessment_.GetHashCode();
      hash ^= nativeCharges_.GetHashCode();
      hash ^= exportedToOtherFolioCharges_.GetHashCode();
      hash ^= importedFromOtherFolioCharges_.GetHashCode();
      if (currentNetCharges_ != null) hash ^= CurrentNetCharges.GetHashCode();
      if (anticipatedNetCharges_ != null) hash ^= AnticipatedNetCharges.GetHashCode();
      if (postedPayments_ != null) hash ^= PostedPayments.GetHashCode();
      if (postedRefunds_ != null) hash ^= PostedRefunds.GetHashCode();
      if (unusedPaymentAuthorizations_ != null) hash ^= UnusedPaymentAuthorizations.GetHashCode();
      if (unusedGuaranteeAuthorizations_ != null) hash ^= UnusedGuaranteeAuthorizations.GetHashCode();
      if (currentDueFromGuest_ != null) hash ^= CurrentDueFromGuest.GetHashCode();
      if (anticipatedCheckoutDueFromGuest_ != null) hash ^= AnticipatedCheckoutDueFromGuest.GetHashCode();
      if (GracefulClosurePossible != false) hash ^= GracefulClosurePossible.GetHashCode();
      if (summary_ != null) hash ^= Summary.GetHashCode();
      if (MasterFolioAccruesLodgingCharges != false) hash ^= MasterFolioAccruesLodgingCharges.GetHashCode();
      if (MasterFolioAccruesIncidentalCharges != false) hash ^= MasterFolioAccruesIncidentalCharges.GetHashCode();
      if (remainingTenderRequiredForGuarantee_ != null) hash ^= RemainingTenderRequiredForGuarantee.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      effectiveCharges_.WriteTo(output, _repeated_effectiveCharges_codec);
      cardRefunds_.WriteTo(output, _repeated_cardRefunds_codec);
      cardSales_.WriteTo(output, _repeated_cardSales_codec);
      checkCashPayments_.WriteTo(output, _repeated_checkCashPayments_codec);
      currentTaxAssessments_.WriteTo(output, _repeated_currentTaxAssessments_codec);
      anticipatedEndingTaxAssessment_.WriteTo(output, _repeated_anticipatedEndingTaxAssessment_codec);
      nativeCharges_.WriteTo(output, _repeated_nativeCharges_codec);
      exportedToOtherFolioCharges_.WriteTo(output, _repeated_exportedToOtherFolioCharges_codec);
      importedFromOtherFolioCharges_.WriteTo(output, _repeated_importedFromOtherFolioCharges_codec);
      if (currentNetCharges_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CurrentNetCharges);
      }
      if (anticipatedNetCharges_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(AnticipatedNetCharges);
      }
      if (postedPayments_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(PostedPayments);
      }
      if (postedRefunds_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(PostedRefunds);
      }
      if (unusedPaymentAuthorizations_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(UnusedPaymentAuthorizations);
      }
      if (unusedGuaranteeAuthorizations_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(UnusedGuaranteeAuthorizations);
      }
      if (currentDueFromGuest_ != null) {
        output.WriteRawTag(146, 1);
        output.WriteMessage(CurrentDueFromGuest);
      }
      if (anticipatedCheckoutDueFromGuest_ != null) {
        output.WriteRawTag(154, 1);
        output.WriteMessage(AnticipatedCheckoutDueFromGuest);
      }
      if (GracefulClosurePossible != false) {
        output.WriteRawTag(160, 1);
        output.WriteBool(GracefulClosurePossible);
      }
      if (summary_ != null) {
        output.WriteRawTag(170, 1);
        output.WriteMessage(Summary);
      }
      if (MasterFolioAccruesLodgingCharges != false) {
        output.WriteRawTag(176, 1);
        output.WriteBool(MasterFolioAccruesLodgingCharges);
      }
      if (MasterFolioAccruesIncidentalCharges != false) {
        output.WriteRawTag(184, 1);
        output.WriteBool(MasterFolioAccruesIncidentalCharges);
      }
      if (remainingTenderRequiredForGuarantee_ != null) {
        output.WriteRawTag(194, 1);
        output.WriteMessage(RemainingTenderRequiredForGuarantee);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += effectiveCharges_.CalculateSize(_repeated_effectiveCharges_codec);
      size += cardRefunds_.CalculateSize(_repeated_cardRefunds_codec);
      size += cardSales_.CalculateSize(_repeated_cardSales_codec);
      size += checkCashPayments_.CalculateSize(_repeated_checkCashPayments_codec);
      size += currentTaxAssessments_.CalculateSize(_repeated_currentTaxAssessments_codec);
      size += anticipatedEndingTaxAssessment_.CalculateSize(_repeated_anticipatedEndingTaxAssessment_codec);
      size += nativeCharges_.CalculateSize(_repeated_nativeCharges_codec);
      size += exportedToOtherFolioCharges_.CalculateSize(_repeated_exportedToOtherFolioCharges_codec);
      size += importedFromOtherFolioCharges_.CalculateSize(_repeated_importedFromOtherFolioCharges_codec);
      if (currentNetCharges_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrentNetCharges);
      }
      if (anticipatedNetCharges_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AnticipatedNetCharges);
      }
      if (postedPayments_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostedPayments);
      }
      if (postedRefunds_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostedRefunds);
      }
      if (unusedPaymentAuthorizations_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(UnusedPaymentAuthorizations);
      }
      if (unusedGuaranteeAuthorizations_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(UnusedGuaranteeAuthorizations);
      }
      if (currentDueFromGuest_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CurrentDueFromGuest);
      }
      if (anticipatedCheckoutDueFromGuest_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(AnticipatedCheckoutDueFromGuest);
      }
      if (GracefulClosurePossible != false) {
        size += 2 + 1;
      }
      if (summary_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Summary);
      }
      if (MasterFolioAccruesLodgingCharges != false) {
        size += 2 + 1;
      }
      if (MasterFolioAccruesIncidentalCharges != false) {
        size += 2 + 1;
      }
      if (remainingTenderRequiredForGuarantee_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RemainingTenderRequiredForGuarantee);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationFolioState other) {
      if (other == null) {
        return;
      }
      effectiveCharges_.Add(other.effectiveCharges_);
      cardRefunds_.Add(other.cardRefunds_);
      cardSales_.Add(other.cardSales_);
      checkCashPayments_.Add(other.checkCashPayments_);
      currentTaxAssessments_.Add(other.currentTaxAssessments_);
      anticipatedEndingTaxAssessment_.Add(other.anticipatedEndingTaxAssessment_);
      nativeCharges_.Add(other.nativeCharges_);
      exportedToOtherFolioCharges_.Add(other.exportedToOtherFolioCharges_);
      importedFromOtherFolioCharges_.Add(other.importedFromOtherFolioCharges_);
      if (other.currentNetCharges_ != null) {
        if (currentNetCharges_ == null) {
          currentNetCharges_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        CurrentNetCharges.MergeFrom(other.CurrentNetCharges);
      }
      if (other.anticipatedNetCharges_ != null) {
        if (anticipatedNetCharges_ == null) {
          anticipatedNetCharges_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        AnticipatedNetCharges.MergeFrom(other.AnticipatedNetCharges);
      }
      if (other.postedPayments_ != null) {
        if (postedPayments_ == null) {
          postedPayments_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        PostedPayments.MergeFrom(other.PostedPayments);
      }
      if (other.postedRefunds_ != null) {
        if (postedRefunds_ == null) {
          postedRefunds_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        PostedRefunds.MergeFrom(other.PostedRefunds);
      }
      if (other.unusedPaymentAuthorizations_ != null) {
        if (unusedPaymentAuthorizations_ == null) {
          unusedPaymentAuthorizations_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        UnusedPaymentAuthorizations.MergeFrom(other.UnusedPaymentAuthorizations);
      }
      if (other.unusedGuaranteeAuthorizations_ != null) {
        if (unusedGuaranteeAuthorizations_ == null) {
          unusedGuaranteeAuthorizations_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        UnusedGuaranteeAuthorizations.MergeFrom(other.UnusedGuaranteeAuthorizations);
      }
      if (other.currentDueFromGuest_ != null) {
        if (currentDueFromGuest_ == null) {
          currentDueFromGuest_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        CurrentDueFromGuest.MergeFrom(other.CurrentDueFromGuest);
      }
      if (other.anticipatedCheckoutDueFromGuest_ != null) {
        if (anticipatedCheckoutDueFromGuest_ == null) {
          anticipatedCheckoutDueFromGuest_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        AnticipatedCheckoutDueFromGuest.MergeFrom(other.AnticipatedCheckoutDueFromGuest);
      }
      if (other.GracefulClosurePossible != false) {
        GracefulClosurePossible = other.GracefulClosurePossible;
      }
      if (other.summary_ != null) {
        if (summary_ == null) {
          summary_ = new global::HOLMS.Types.Folio.ReservationFolioSummary();
        }
        Summary.MergeFrom(other.Summary);
      }
      if (other.MasterFolioAccruesLodgingCharges != false) {
        MasterFolioAccruesLodgingCharges = other.MasterFolioAccruesLodgingCharges;
      }
      if (other.MasterFolioAccruesIncidentalCharges != false) {
        MasterFolioAccruesIncidentalCharges = other.MasterFolioAccruesIncidentalCharges;
      }
      if (other.remainingTenderRequiredForGuarantee_ != null) {
        if (remainingTenderRequiredForGuarantee_ == null) {
          remainingTenderRequiredForGuarantee_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        RemainingTenderRequiredForGuarantee.MergeFrom(other.RemainingTenderRequiredForGuarantee);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            effectiveCharges_.AddEntriesFrom(input, _repeated_effectiveCharges_codec);
            break;
          }
          case 26: {
            cardRefunds_.AddEntriesFrom(input, _repeated_cardRefunds_codec);
            break;
          }
          case 34: {
            cardSales_.AddEntriesFrom(input, _repeated_cardSales_codec);
            break;
          }
          case 42: {
            checkCashPayments_.AddEntriesFrom(input, _repeated_checkCashPayments_codec);
            break;
          }
          case 50: {
            currentTaxAssessments_.AddEntriesFrom(input, _repeated_currentTaxAssessments_codec);
            break;
          }
          case 58: {
            anticipatedEndingTaxAssessment_.AddEntriesFrom(input, _repeated_anticipatedEndingTaxAssessment_codec);
            break;
          }
          case 74: {
            nativeCharges_.AddEntriesFrom(input, _repeated_nativeCharges_codec);
            break;
          }
          case 82: {
            exportedToOtherFolioCharges_.AddEntriesFrom(input, _repeated_exportedToOtherFolioCharges_codec);
            break;
          }
          case 90: {
            importedFromOtherFolioCharges_.AddEntriesFrom(input, _repeated_importedFromOtherFolioCharges_codec);
            break;
          }
          case 98: {
            if (currentNetCharges_ == null) {
              currentNetCharges_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(currentNetCharges_);
            break;
          }
          case 106: {
            if (anticipatedNetCharges_ == null) {
              anticipatedNetCharges_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(anticipatedNetCharges_);
            break;
          }
          case 114: {
            if (postedPayments_ == null) {
              postedPayments_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(postedPayments_);
            break;
          }
          case 122: {
            if (postedRefunds_ == null) {
              postedRefunds_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(postedRefunds_);
            break;
          }
          case 130: {
            if (unusedPaymentAuthorizations_ == null) {
              unusedPaymentAuthorizations_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(unusedPaymentAuthorizations_);
            break;
          }
          case 138: {
            if (unusedGuaranteeAuthorizations_ == null) {
              unusedGuaranteeAuthorizations_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(unusedGuaranteeAuthorizations_);
            break;
          }
          case 146: {
            if (currentDueFromGuest_ == null) {
              currentDueFromGuest_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(currentDueFromGuest_);
            break;
          }
          case 154: {
            if (anticipatedCheckoutDueFromGuest_ == null) {
              anticipatedCheckoutDueFromGuest_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(anticipatedCheckoutDueFromGuest_);
            break;
          }
          case 160: {
            GracefulClosurePossible = input.ReadBool();
            break;
          }
          case 170: {
            if (summary_ == null) {
              summary_ = new global::HOLMS.Types.Folio.ReservationFolioSummary();
            }
            input.ReadMessage(summary_);
            break;
          }
          case 176: {
            MasterFolioAccruesLodgingCharges = input.ReadBool();
            break;
          }
          case 184: {
            MasterFolioAccruesIncidentalCharges = input.ReadBool();
            break;
          }
          case 194: {
            if (remainingTenderRequiredForGuarantee_ == null) {
              remainingTenderRequiredForGuarantee_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(remainingTenderRequiredForGuarantee_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
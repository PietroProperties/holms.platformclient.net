// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/rpc/folios_reporting_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Reporting.RPC {

  /// <summary>Holder for reflection information generated from reporting/rpc/folios_reporting_svc.proto</summary>
  public static partial class FoliosReportingSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for reporting/rpc/folios_reporting_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoliosReportingSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihyZXBvcnRpbmcvcnBjL2ZvbGlvc19yZXBvcnRpbmdfc3ZjLnByb3RvEhlo",
            "b2xtcy50eXBlcy5yZXBvcnRpbmcucnBjGjBib29raW5nL2luZGljYXRvcnMv",
            "Z3JvdXBfYm9va2luZ19pbmRpY2F0b3IucHJvdG8aLHJlcG9ydGluZy9vdXRw",
            "dXRzL2h0bWxfcmVwb3J0X3Jlc3BvbnNlLnByb3RvGixib29raW5nL2dyb3Vw",
            "cy9ncm91cF9ib29raW5nc19pbnZvaWNlcy5wcm90bxoqcHJpbWl0aXZlL3Bi",
            "X2luY2x1c2l2ZV9vcHNkYXRlX3JhbmdlLnByb3RvGhRwcmltaXRpdmUvdXVp",
            "ZC5wcm90bxofcHJpbWl0aXZlL21vbmV0YXJ5X2Ftb3VudC5wcm90byJLCjdG",
            "b2xpb3NSZXBvcnRpbmdTdmNDYXJkQ2FwdHVyZVJlcG9ydGluZ1N2Y1JlcG9y",
            "dFJlc3BvbnNlEhAKCGRvY3VtZW50GAEgASgJIrUBChdCb29raW5nU3RhdGVt",
            "ZW50UmVxdWVzdBJWChdncm91cF9ib29raW5nX2luZGljYXRvchgBIAEoCzI1",
            "LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5Hcm91cEJvb2tpbmdJ",
            "bmRpY2F0b3ISQgoKZGF0ZV9yYW5nZRgCIAEoCzIuLmhvbG1zLnR5cGVzLnBy",
            "aW1pdGl2ZS5QYkluY2x1c2l2ZU9wc2RhdGVSYW5nZSKqAgoaRm9saW9QYXlt",
            "ZW50UmVjZWlwdFJlcXVlc3QSVgoXZ3JvdXBfYm9va2luZ19pbmRpY2F0b3IY",
            "ASABKAsyNS5ob2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuR3JvdXBC",
            "b29raW5nSW5kaWNhdG9yEi8KCnBheW1lbnRfaWQYAiABKAsyGy5ob2xtcy50",
            "eXBlcy5wcmltaXRpdmUuVXVpZBIUCgxwYXltZW50X2RhdGUYAyABKAkSGQoR",
            "cGF5bWVudF9yZWZlcmVuY2UYBCABKAkSFAoMcGF5bWVudF90eXBlGAUgASgJ",
            "EjwKDWNyZWRpdF9hbW91bnQYBiABKAsyJS5ob2xtcy50eXBlcy5wcmltaXRp",
            "dmUuTW9uZXRhcnlBbW91bnQywAcKEkZvbGlvc1JlcG9ydGluZ1N2YxKMAQog",
            "R2V0Qm9va2luZ0Fzc29jaWF0ZWRGb2xpb3NEZXRhaWwSNS5ob2xtcy50eXBl",
            "cy5ib29raW5nLmluZGljYXRvcnMuR3JvdXBCb29raW5nSW5kaWNhdG9yGjEu",
            "aG9sbXMudHlwZXMucmVwb3J0aW5nLm91dHB1dHMuSHRtbFJlcG9ydFJlc3Bv",
            "bnNlEo0BCiFHZXRCb29raW5nQXNzb2NpYXRlZEZvbGlvc1N1bW1hcnkSNS5o",
            "b2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuR3JvdXBCb29raW5nSW5k",
            "aWNhdG9yGjEuaG9sbXMudHlwZXMucmVwb3J0aW5nLm91dHB1dHMuSHRtbFJl",
            "cG9ydFJlc3BvbnNlEoYBChpHZXRSZXNlcnZhdGlvbkZvbGlvU3VtbWFyeRI1",
            "LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5Hcm91cEJvb2tpbmdJ",
            "bmRpY2F0b3IaMS5ob2xtcy50eXBlcy5yZXBvcnRpbmcub3V0cHV0cy5IdG1s",
            "UmVwb3J0UmVzcG9uc2UShQEKGUdldEJvb2tpbmdXb3Jrc2hlZXREZXRhaWwS",
            "NS5ob2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuR3JvdXBCb29raW5n",
            "SW5kaWNhdG9yGjEuaG9sbXMudHlwZXMucmVwb3J0aW5nLm91dHB1dHMuSHRt",
            "bFJlcG9ydFJlc3BvbnNlEncKCkdldEludm9pY2USNi5ob2xtcy50eXBlcy5i",
            "b29raW5nLmdyb3Vwcy5Hcm91cEJvb2tpbmdJbnZvaWNlTWFwcGluZxoxLmhv",
            "bG1zLnR5cGVzLnJlcG9ydGluZy5vdXRwdXRzLkh0bWxSZXBvcnRSZXNwb25z",
            "ZRJ8ChNHZXRCb29raW5nU3RhdGVtZW50EjIuaG9sbXMudHlwZXMucmVwb3J0",
            "aW5nLnJwYy5Cb29raW5nU3RhdGVtZW50UmVxdWVzdBoxLmhvbG1zLnR5cGVz",
            "LnJlcG9ydGluZy5vdXRwdXRzLkh0bWxSZXBvcnRSZXNwb25zZRKCAQoWR2V0",
            "Rm9saW9QYXltZW50UmVjZWlwdBI1LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5y",
            "cGMuRm9saW9QYXltZW50UmVjZWlwdFJlcXVlc3QaMS5ob2xtcy50eXBlcy5y",
            "ZXBvcnRpbmcub3V0cHV0cy5IdG1sUmVwb3J0UmVzcG9uc2VCHKoCGUhPTE1T",
            "LlR5cGVzLlJlcG9ydGluZy5SUENiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.GroupBookingIndicatorReflection.Descriptor, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponseReflection.Descriptor, global::HOLMS.Types.Booking.Groups.GroupBookingsInvoicesReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Primitive.UuidReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.FoliosReportingSvcCardCaptureReportingSvcReportResponse), global::HOLMS.Types.Reporting.RPC.FoliosReportingSvcCardCaptureReportingSvcReportResponse.Parser, new[]{ "Document" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.BookingStatementRequest), global::HOLMS.Types.Reporting.RPC.BookingStatementRequest.Parser, new[]{ "GroupBookingIndicator", "DateRange" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest), global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest.Parser, new[]{ "GroupBookingIndicator", "PaymentId", "PaymentDate", "PaymentReference", "PaymentType", "CreditAmount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FoliosReportingSvcCardCaptureReportingSvcReportResponse : pb::IMessage<FoliosReportingSvcCardCaptureReportingSvcReportResponse> {
    private static readonly pb::MessageParser<FoliosReportingSvcCardCaptureReportingSvcReportResponse> _parser = new pb::MessageParser<FoliosReportingSvcCardCaptureReportingSvcReportResponse>(() => new FoliosReportingSvcCardCaptureReportingSvcReportResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FoliosReportingSvcCardCaptureReportingSvcReportResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.FoliosReportingSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FoliosReportingSvcCardCaptureReportingSvcReportResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FoliosReportingSvcCardCaptureReportingSvcReportResponse(FoliosReportingSvcCardCaptureReportingSvcReportResponse other) : this() {
      document_ = other.document_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FoliosReportingSvcCardCaptureReportingSvcReportResponse Clone() {
      return new FoliosReportingSvcCardCaptureReportingSvcReportResponse(this);
    }

    /// <summary>Field number for the "document" field.</summary>
    public const int DocumentFieldNumber = 1;
    private string document_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Document {
      get { return document_; }
      set {
        document_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FoliosReportingSvcCardCaptureReportingSvcReportResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FoliosReportingSvcCardCaptureReportingSvcReportResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Document != other.Document) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Document.Length != 0) hash ^= Document.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Document.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Document);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Document.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Document);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FoliosReportingSvcCardCaptureReportingSvcReportResponse other) {
      if (other == null) {
        return;
      }
      if (other.Document.Length != 0) {
        Document = other.Document;
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
            Document = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BookingStatementRequest : pb::IMessage<BookingStatementRequest> {
    private static readonly pb::MessageParser<BookingStatementRequest> _parser = new pb::MessageParser<BookingStatementRequest>(() => new BookingStatementRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BookingStatementRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.FoliosReportingSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BookingStatementRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BookingStatementRequest(BookingStatementRequest other) : this() {
      GroupBookingIndicator = other.groupBookingIndicator_ != null ? other.GroupBookingIndicator.Clone() : null;
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BookingStatementRequest Clone() {
      return new BookingStatementRequest(this);
    }

    /// <summary>Field number for the "group_booking_indicator" field.</summary>
    public const int GroupBookingIndicatorFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator groupBookingIndicator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator GroupBookingIndicator {
      get { return groupBookingIndicator_; }
      set {
        groupBookingIndicator_ = value;
      }
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 2;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BookingStatementRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BookingStatementRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GroupBookingIndicator, other.GroupBookingIndicator)) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (groupBookingIndicator_ != null) hash ^= GroupBookingIndicator.GetHashCode();
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (groupBookingIndicator_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(GroupBookingIndicator);
      }
      if (dateRange_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DateRange);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (groupBookingIndicator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GroupBookingIndicator);
      }
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BookingStatementRequest other) {
      if (other == null) {
        return;
      }
      if (other.groupBookingIndicator_ != null) {
        if (groupBookingIndicator_ == null) {
          groupBookingIndicator_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
        }
        GroupBookingIndicator.MergeFrom(other.GroupBookingIndicator);
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
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
            if (groupBookingIndicator_ == null) {
              groupBookingIndicator_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
            }
            input.ReadMessage(groupBookingIndicator_);
            break;
          }
          case 18: {
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class FolioPaymentReceiptRequest : pb::IMessage<FolioPaymentReceiptRequest> {
    private static readonly pb::MessageParser<FolioPaymentReceiptRequest> _parser = new pb::MessageParser<FolioPaymentReceiptRequest>(() => new FolioPaymentReceiptRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FolioPaymentReceiptRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.FoliosReportingSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioPaymentReceiptRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioPaymentReceiptRequest(FolioPaymentReceiptRequest other) : this() {
      GroupBookingIndicator = other.groupBookingIndicator_ != null ? other.GroupBookingIndicator.Clone() : null;
      PaymentId = other.paymentId_ != null ? other.PaymentId.Clone() : null;
      paymentDate_ = other.paymentDate_;
      paymentReference_ = other.paymentReference_;
      paymentType_ = other.paymentType_;
      CreditAmount = other.creditAmount_ != null ? other.CreditAmount.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioPaymentReceiptRequest Clone() {
      return new FolioPaymentReceiptRequest(this);
    }

    /// <summary>Field number for the "group_booking_indicator" field.</summary>
    public const int GroupBookingIndicatorFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator groupBookingIndicator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator GroupBookingIndicator {
      get { return groupBookingIndicator_; }
      set {
        groupBookingIndicator_ = value;
      }
    }

    /// <summary>Field number for the "payment_id" field.</summary>
    public const int PaymentIdFieldNumber = 2;
    private global::HOLMS.Types.Primitive.Uuid paymentId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.Uuid PaymentId {
      get { return paymentId_; }
      set {
        paymentId_ = value;
      }
    }

    /// <summary>Field number for the "payment_date" field.</summary>
    public const int PaymentDateFieldNumber = 3;
    private string paymentDate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PaymentDate {
      get { return paymentDate_; }
      set {
        paymentDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payment_reference" field.</summary>
    public const int PaymentReferenceFieldNumber = 4;
    private string paymentReference_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PaymentReference {
      get { return paymentReference_; }
      set {
        paymentReference_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payment_type" field.</summary>
    public const int PaymentTypeFieldNumber = 5;
    private string paymentType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PaymentType {
      get { return paymentType_; }
      set {
        paymentType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "credit_amount" field.</summary>
    public const int CreditAmountFieldNumber = 6;
    private global::HOLMS.Types.Primitive.MonetaryAmount creditAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount CreditAmount {
      get { return creditAmount_; }
      set {
        creditAmount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FolioPaymentReceiptRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FolioPaymentReceiptRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GroupBookingIndicator, other.GroupBookingIndicator)) return false;
      if (!object.Equals(PaymentId, other.PaymentId)) return false;
      if (PaymentDate != other.PaymentDate) return false;
      if (PaymentReference != other.PaymentReference) return false;
      if (PaymentType != other.PaymentType) return false;
      if (!object.Equals(CreditAmount, other.CreditAmount)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (groupBookingIndicator_ != null) hash ^= GroupBookingIndicator.GetHashCode();
      if (paymentId_ != null) hash ^= PaymentId.GetHashCode();
      if (PaymentDate.Length != 0) hash ^= PaymentDate.GetHashCode();
      if (PaymentReference.Length != 0) hash ^= PaymentReference.GetHashCode();
      if (PaymentType.Length != 0) hash ^= PaymentType.GetHashCode();
      if (creditAmount_ != null) hash ^= CreditAmount.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (groupBookingIndicator_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(GroupBookingIndicator);
      }
      if (paymentId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PaymentId);
      }
      if (PaymentDate.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PaymentDate);
      }
      if (PaymentReference.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PaymentReference);
      }
      if (PaymentType.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PaymentType);
      }
      if (creditAmount_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreditAmount);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (groupBookingIndicator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GroupBookingIndicator);
      }
      if (paymentId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PaymentId);
      }
      if (PaymentDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PaymentDate);
      }
      if (PaymentReference.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PaymentReference);
      }
      if (PaymentType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PaymentType);
      }
      if (creditAmount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreditAmount);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FolioPaymentReceiptRequest other) {
      if (other == null) {
        return;
      }
      if (other.groupBookingIndicator_ != null) {
        if (groupBookingIndicator_ == null) {
          groupBookingIndicator_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
        }
        GroupBookingIndicator.MergeFrom(other.GroupBookingIndicator);
      }
      if (other.paymentId_ != null) {
        if (paymentId_ == null) {
          paymentId_ = new global::HOLMS.Types.Primitive.Uuid();
        }
        PaymentId.MergeFrom(other.PaymentId);
      }
      if (other.PaymentDate.Length != 0) {
        PaymentDate = other.PaymentDate;
      }
      if (other.PaymentReference.Length != 0) {
        PaymentReference = other.PaymentReference;
      }
      if (other.PaymentType.Length != 0) {
        PaymentType = other.PaymentType;
      }
      if (other.creditAmount_ != null) {
        if (creditAmount_ == null) {
          creditAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        CreditAmount.MergeFrom(other.CreditAmount);
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
            if (groupBookingIndicator_ == null) {
              groupBookingIndicator_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
            }
            input.ReadMessage(groupBookingIndicator_);
            break;
          }
          case 18: {
            if (paymentId_ == null) {
              paymentId_ = new global::HOLMS.Types.Primitive.Uuid();
            }
            input.ReadMessage(paymentId_);
            break;
          }
          case 26: {
            PaymentDate = input.ReadString();
            break;
          }
          case 34: {
            PaymentReference = input.ReadString();
            break;
          }
          case 42: {
            PaymentType = input.ReadString();
            break;
          }
          case 50: {
            if (creditAmount_ == null) {
              creditAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(creditAmount_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

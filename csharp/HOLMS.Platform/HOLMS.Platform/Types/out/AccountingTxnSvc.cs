// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/rpc/accounting_txn_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.RPC {

  /// <summary>Holder for reflection information generated from money/rpc/accounting_txn_svc.proto</summary>
  public static partial class AccountingTxnSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for money/rpc/accounting_txn_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccountingTxnSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJtb25leS9ycGMvYWNjb3VudGluZ190eG5fc3ZjLnByb3RvEhVob2xtcy50",
            "eXBlcy5tb25leS5ycGMaG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90bxof",
            "Z29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxowcHJpbWl0aXZlL3Bi",
            "X2luY2x1c2l2ZV9jYWxlbmRhcl9kYXRlX3JhbmdlLnByb3RvGiBjcm0vZ3Vl",
            "c3RzL2d1ZXN0X2luZGljYXRvci5wcm90bxo7bW9uZXkvYWNjb3VudGluZy9h",
            "Y2NvdW50aW5nX3RyYW5zYWN0aW9uX2V4cG9ydF9mb3JtYXQucHJvdG8aM21v",
            "bmV5L2FjY291bnRpbmcvYWNjb3VudGluZ190eG5fZXhwb3J0X3N0YXR1cy5w",
            "cm90bxo4bW9uZXkvYWNjb3VudGluZy9hY2NvdW50aW5nX3RyYW5zYWN0aW9u",
            "X3dpdGhfZ3Vlc3QucHJvdG8aMnRlbmFuY3lfY29uZmlnL2luZGljYXRvcnMv",
            "cHJvcGVydHlfaW5kaWNhdG9yLnByb3RvIroBChhBc3NpZ25HdWVzdE93bmVy",
            "VG9UeG5SZXESZwohYWNjb3VudGluZ190cmFuc2FjdGlvbl93aXRoX2d1ZXN0",
            "GAEgASgLMjwuaG9sbXMudHlwZXMubW9uZXkuYWNjb3VudGluZy5BY2NvdW50",
            "aW5nVHJhbnNhY3Rpb25XaXRoR3Vlc3QSNQoFZ3Vlc3QYAiABKAsyJi5ob2xt",
            "cy50eXBlcy5jcm0uZ3Vlc3RzLkd1ZXN0SW5kaWNhdG9yIqECCjlBY2NvdW50",
            "VHhuRXhwb3J0U3ZjR2V0UHJvcGVydHlUcmFuc2FjdGlvbnNJbkZvcm1hdFJl",
            "cXVlc3QSTwoGZm9ybWF0GAEgASgOMj8uaG9sbXMudHlwZXMubW9uZXkuYWNj",
            "b3VudGluZy5BY2NvdW50aW5nVHJhbnNhY3Rpb25FeHBvcnRGb3JtYXQSSgoI",
            "cHJvcGVydHkYAiABKAsyOC5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5p",
            "bmRpY2F0b3JzLlByb3BlcnR5SW5kaWNhdG9yEkcKCmRhdGVfcmFuZ2UYAyAB",
            "KAsyMy5ob2xtcy50eXBlcy5wcmltaXRpdmUuUGJJbmNsdXNpdmVDYWxlbmRh",
            "ckRhdGVSYW5nZSJbCjpBY2NvdW50VHhuRXhwb3J0U3ZjR2V0UHJvcGVydHlU",
            "cmFuc2FjdGlvbnNJbkZvcm1hdFJlc3BvbnNlEh0KFWV4cG9ydGVkX3RyYW5z",
            "YWN0aW9ucxgBIAEoDDL7AwoQQWNjb3VudGluZ1R4blN2YxJoCh1Bc3NpZ25H",
            "dWVzdE93bmVyVG9UcmFuc2FjdGlvbhIvLmhvbG1zLnR5cGVzLm1vbmV5LnJw",
            "Yy5Bc3NpZ25HdWVzdE93bmVyVG9UeG5SZXEaFi5nb29nbGUucHJvdG9idWYu",
            "RW1wdHkSZQoSR2V0RXhwb3J0Sm9iU3RhdHVzEhYuZ29vZ2xlLnByb3RvYnVm",
            "LkVtcHR5GjcuaG9sbXMudHlwZXMubW9uZXkuYWNjb3VudGluZy5BY2NvdW50",
            "aW5nVHhuRXhwb3J0U3RhdHVzEk0KF1VwZGF0ZUxhc3RFeHBvcnRSdW5UaW1l",
            "EhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBoWLmdvb2dsZS5wcm90b2J1",
            "Zi5FbXB0eRLGAQofR2V0UHJvcGVydHlUcmFuc2FjdGlvbnNJbkZvcm1hdBJQ",
            "LmhvbG1zLnR5cGVzLm1vbmV5LnJwYy5BY2NvdW50VHhuRXhwb3J0U3ZjR2V0",
            "UHJvcGVydHlUcmFuc2FjdGlvbnNJbkZvcm1hdFJlcXVlc3QaUS5ob2xtcy50",
            "eXBlcy5tb25leS5ycGMuQWNjb3VudFR4bkV4cG9ydFN2Y0dldFByb3BlcnR5",
            "VHJhbnNhY3Rpb25zSW5Gb3JtYXRSZXNwb25zZUIjWgltb25leS9ycGOqAhVI",
            "T0xNUy5UeXBlcy5Nb25leS5SUENiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRangeReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Accounting.AccountingTransactionExportFormatReflection.Descriptor, global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatusReflection.Descriptor, global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuestReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq), global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq.Parser, new[]{ "AccountingTransactionWithGuest", "Guest" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.AccountTxnExportSvcGetPropertyTransactionsInFormatRequest), global::HOLMS.Types.Money.RPC.AccountTxnExportSvcGetPropertyTransactionsInFormatRequest.Parser, new[]{ "Format", "Property", "DateRange" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.AccountTxnExportSvcGetPropertyTransactionsInFormatResponse), global::HOLMS.Types.Money.RPC.AccountTxnExportSvcGetPropertyTransactionsInFormatResponse.Parser, new[]{ "ExportedTransactions" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AssignGuestOwnerToTxnReq : pb::IMessage<AssignGuestOwnerToTxnReq> {
    private static readonly pb::MessageParser<AssignGuestOwnerToTxnReq> _parser = new pb::MessageParser<AssignGuestOwnerToTxnReq>(() => new AssignGuestOwnerToTxnReq());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AssignGuestOwnerToTxnReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.AccountingTxnSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssignGuestOwnerToTxnReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssignGuestOwnerToTxnReq(AssignGuestOwnerToTxnReq other) : this() {
      AccountingTransactionWithGuest = other.accountingTransactionWithGuest_ != null ? other.AccountingTransactionWithGuest.Clone() : null;
      Guest = other.guest_ != null ? other.Guest.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssignGuestOwnerToTxnReq Clone() {
      return new AssignGuestOwnerToTxnReq(this);
    }

    /// <summary>Field number for the "accounting_transaction_with_guest" field.</summary>
    public const int AccountingTransactionWithGuestFieldNumber = 1;
    private global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuest accountingTransactionWithGuest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuest AccountingTransactionWithGuest {
      get { return accountingTransactionWithGuest_; }
      set {
        accountingTransactionWithGuest_ = value;
      }
    }

    /// <summary>Field number for the "guest" field.</summary>
    public const int GuestFieldNumber = 2;
    private global::HOLMS.Types.CRM.Guests.GuestIndicator guest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Guests.GuestIndicator Guest {
      get { return guest_; }
      set {
        guest_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AssignGuestOwnerToTxnReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AssignGuestOwnerToTxnReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AccountingTransactionWithGuest, other.AccountingTransactionWithGuest)) return false;
      if (!object.Equals(Guest, other.Guest)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (accountingTransactionWithGuest_ != null) hash ^= AccountingTransactionWithGuest.GetHashCode();
      if (guest_ != null) hash ^= Guest.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (accountingTransactionWithGuest_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccountingTransactionWithGuest);
      }
      if (guest_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Guest);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (accountingTransactionWithGuest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccountingTransactionWithGuest);
      }
      if (guest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Guest);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AssignGuestOwnerToTxnReq other) {
      if (other == null) {
        return;
      }
      if (other.accountingTransactionWithGuest_ != null) {
        if (accountingTransactionWithGuest_ == null) {
          accountingTransactionWithGuest_ = new global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuest();
        }
        AccountingTransactionWithGuest.MergeFrom(other.AccountingTransactionWithGuest);
      }
      if (other.guest_ != null) {
        if (guest_ == null) {
          guest_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
        }
        Guest.MergeFrom(other.Guest);
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
            if (accountingTransactionWithGuest_ == null) {
              accountingTransactionWithGuest_ = new global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuest();
            }
            input.ReadMessage(accountingTransactionWithGuest_);
            break;
          }
          case 18: {
            if (guest_ == null) {
              guest_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
            }
            input.ReadMessage(guest_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class AccountTxnExportSvcGetPropertyTransactionsInFormatRequest : pb::IMessage<AccountTxnExportSvcGetPropertyTransactionsInFormatRequest> {
    private static readonly pb::MessageParser<AccountTxnExportSvcGetPropertyTransactionsInFormatRequest> _parser = new pb::MessageParser<AccountTxnExportSvcGetPropertyTransactionsInFormatRequest>(() => new AccountTxnExportSvcGetPropertyTransactionsInFormatRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AccountTxnExportSvcGetPropertyTransactionsInFormatRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.AccountingTxnSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountTxnExportSvcGetPropertyTransactionsInFormatRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountTxnExportSvcGetPropertyTransactionsInFormatRequest(AccountTxnExportSvcGetPropertyTransactionsInFormatRequest other) : this() {
      format_ = other.format_;
      Property = other.property_ != null ? other.Property.Clone() : null;
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountTxnExportSvcGetPropertyTransactionsInFormatRequest Clone() {
      return new AccountTxnExportSvcGetPropertyTransactionsInFormatRequest(this);
    }

    /// <summary>Field number for the "format" field.</summary>
    public const int FormatFieldNumber = 1;
    private global::HOLMS.Types.Money.Accounting.AccountingTransactionExportFormat format_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Accounting.AccountingTransactionExportFormat Format {
      get { return format_; }
      set {
        format_ = value;
      }
    }

    /// <summary>Field number for the "property" field.</summary>
    public const int PropertyFieldNumber = 2;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator property_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator Property {
      get { return property_; }
      set {
        property_ = value;
      }
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 3;
    private global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AccountTxnExportSvcGetPropertyTransactionsInFormatRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AccountTxnExportSvcGetPropertyTransactionsInFormatRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Format != other.Format) return false;
      if (!object.Equals(Property, other.Property)) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Format != 0) hash ^= Format.GetHashCode();
      if (property_ != null) hash ^= Property.GetHashCode();
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Format != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Format);
      }
      if (property_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Property);
      }
      if (dateRange_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DateRange);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Format != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Format);
      }
      if (property_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Property);
      }
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AccountTxnExportSvcGetPropertyTransactionsInFormatRequest other) {
      if (other == null) {
        return;
      }
      if (other.Format != 0) {
        Format = other.Format;
      }
      if (other.property_ != null) {
        if (property_ == null) {
          property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        Property.MergeFrom(other.Property);
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange();
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
          case 8: {
            format_ = (global::HOLMS.Types.Money.Accounting.AccountingTransactionExportFormat) input.ReadEnum();
            break;
          }
          case 18: {
            if (property_ == null) {
              property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(property_);
            break;
          }
          case 26: {
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class AccountTxnExportSvcGetPropertyTransactionsInFormatResponse : pb::IMessage<AccountTxnExportSvcGetPropertyTransactionsInFormatResponse> {
    private static readonly pb::MessageParser<AccountTxnExportSvcGetPropertyTransactionsInFormatResponse> _parser = new pb::MessageParser<AccountTxnExportSvcGetPropertyTransactionsInFormatResponse>(() => new AccountTxnExportSvcGetPropertyTransactionsInFormatResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AccountTxnExportSvcGetPropertyTransactionsInFormatResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.AccountingTxnSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountTxnExportSvcGetPropertyTransactionsInFormatResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountTxnExportSvcGetPropertyTransactionsInFormatResponse(AccountTxnExportSvcGetPropertyTransactionsInFormatResponse other) : this() {
      exportedTransactions_ = other.exportedTransactions_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountTxnExportSvcGetPropertyTransactionsInFormatResponse Clone() {
      return new AccountTxnExportSvcGetPropertyTransactionsInFormatResponse(this);
    }

    /// <summary>Field number for the "exported_transactions" field.</summary>
    public const int ExportedTransactionsFieldNumber = 1;
    private pb::ByteString exportedTransactions_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ExportedTransactions {
      get { return exportedTransactions_; }
      set {
        exportedTransactions_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AccountTxnExportSvcGetPropertyTransactionsInFormatResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AccountTxnExportSvcGetPropertyTransactionsInFormatResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ExportedTransactions != other.ExportedTransactions) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ExportedTransactions.Length != 0) hash ^= ExportedTransactions.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ExportedTransactions.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(ExportedTransactions);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ExportedTransactions.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ExportedTransactions);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AccountTxnExportSvcGetPropertyTransactionsInFormatResponse other) {
      if (other == null) {
        return;
      }
      if (other.ExportedTransactions.Length != 0) {
        ExportedTransactions = other.ExportedTransactions;
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
            ExportedTransactions = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

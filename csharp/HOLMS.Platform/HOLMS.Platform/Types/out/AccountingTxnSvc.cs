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
            "eXBlcy5tb25leS5ycGMaG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90bxow",
            "cHJpbWl0aXZlL3BiX2luY2x1c2l2ZV9jYWxlbmRhcl9kYXRlX3JhbmdlLnBy",
            "b3RvGiBjcm0vZ3Vlc3RzL2d1ZXN0X2luZGljYXRvci5wcm90bxo7bW9uZXkv",
            "YWNjb3VudGluZy9hY2NvdW50aW5nX3RyYW5zYWN0aW9uX2V4cG9ydF9mb3Jt",
            "YXQucHJvdG8aM21vbmV5L2FjY291bnRpbmcvYWNjb3VudGluZ190eG5fZXhw",
            "b3J0X3N0YXR1cy5wcm90bxo4bW9uZXkvYWNjb3VudGluZy9hY2NvdW50aW5n",
            "X3RyYW5zYWN0aW9uX3dpdGhfZ3Vlc3QucHJvdG8iugEKGEFzc2lnbkd1ZXN0",
            "T3duZXJUb1R4blJlcRJnCiFhY2NvdW50aW5nX3RyYW5zYWN0aW9uX3dpdGhf",
            "Z3Vlc3QYASABKAsyPC5ob2xtcy50eXBlcy5tb25leS5hY2NvdW50aW5nLkFj",
            "Y291bnRpbmdUcmFuc2FjdGlvbldpdGhHdWVzdBI1CgVndWVzdBgCIAEoCzIm",
            "LmhvbG1zLnR5cGVzLmNybS5ndWVzdHMuR3Vlc3RJbmRpY2F0b3Ii2AEKPEFj",
            "Y291bnRUeG5FeHBvcnRTdmNVcGxvYWRQcm9wZXJ0eVRyYW5zYWN0aW9uc0lu",
            "Rm9ybWF0UmVxdWVzdBJPCgZmb3JtYXQYASABKA4yPy5ob2xtcy50eXBlcy5t",
            "b25leS5hY2NvdW50aW5nLkFjY291bnRpbmdUcmFuc2FjdGlvbkV4cG9ydEZv",
            "cm1hdBJHCgpkYXRlX3JhbmdlGAMgASgLMjMuaG9sbXMudHlwZXMucHJpbWl0",
            "aXZlLlBiSW5jbHVzaXZlQ2FsZW5kYXJEYXRlUmFuZ2Uy9wIKEEFjY291bnRp",
            "bmdUeG5TdmMSaAodQXNzaWduR3Vlc3RPd25lclRvVHJhbnNhY3Rpb24SLy5o",
            "b2xtcy50eXBlcy5tb25leS5ycGMuQXNzaWduR3Vlc3RPd25lclRvVHhuUmVx",
            "GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5EmUKEkdldEV4cG9ydEpvYlN0YXR1",
            "cxIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRo3LmhvbG1zLnR5cGVzLm1vbmV5",
            "LmFjY291bnRpbmcuQWNjb3VudGluZ1R4bkV4cG9ydFN0YXR1cxKRAQoiVXBs",
            "b2FkUHJvcGVydHlUcmFuc2FjdGlvbnNJbkZvcm1hdBJTLmhvbG1zLnR5cGVz",
            "Lm1vbmV5LnJwYy5BY2NvdW50VHhuRXhwb3J0U3ZjVXBsb2FkUHJvcGVydHlU",
            "cmFuc2FjdGlvbnNJbkZvcm1hdFJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYu",
            "RW1wdHlCI1oJbW9uZXkvcnBjqgIVSE9MTVMuVHlwZXMuTW9uZXkuUlBDYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRangeReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Accounting.AccountingTransactionExportFormatReflection.Descriptor, global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatusReflection.Descriptor, global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuestReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq), global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq.Parser, new[]{ "AccountingTransactionWithGuest", "Guest" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest), global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest.Parser, new[]{ "Format", "DateRange" }, null, null, null)
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

  public sealed partial class AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest : pb::IMessage<AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest> {
    private static readonly pb::MessageParser<AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest> _parser = new pb::MessageParser<AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest>(() => new AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.AccountingTxnSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest(AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest other) : this() {
      format_ = other.format_;
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest Clone() {
      return new AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest(this);
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
      return Equals(other as AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Format != other.Format) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Format != 0) hash ^= Format.GetHashCode();
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
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest other) {
      if (other == null) {
        return;
      }
      if (other.Format != 0) {
        Format = other.Format;
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

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/rpc/card_processing_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.RPC {

  /// <summary>Holder for reflection information generated from money/rpc/card_processing_svc.proto</summary>
  public static partial class CardProcessingSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for money/rpc/card_processing_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CardProcessingSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNtb25leS9ycGMvY2FyZF9wcm9jZXNzaW5nX3N2Yy5wcm90bxIVaG9sbXMu",
            "dHlwZXMubW9uZXkucnBjGiBjcm0vZ3Vlc3RzL2d1ZXN0X2luZGljYXRvci5w",
            "cm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGiltb25leS9jYXJk",
            "cy9jYXJkX21lcmNoYW50X2luZGljYXRvci5wcm90bxoubW9uZXkvY2FyZHMv",
            "Z3Vlc3RfcGF5bWVudF9jYXJkX2luZGljYXRvci5wcm90bxoqbW9uZXkvY2Fy",
            "ZHMvbm90X3ByZXNlbnRfcGF5bWVudF9jYXJkLnByb3RvGi1tb25leS9jYXJk",
            "cy90cmFuc2FjdGlvbnMvbWVyY2hhbnRfYmF0Y2gucHJvdG8aOG1vbmV5L2Nh",
            "cmRzL3RyYW5zYWN0aW9ucy9wYXltZW50X2NhcmRfc2FsZV9jYXB0dXJlLnBy",
            "b3RvGjJtb25leS9jYXJkcy90cmFuc2FjdGlvbnMvcGF5bWVudF9jYXJkX3Jl",
            "ZnVuZC5wcm90bxpCbW9uZXkvY2FyZHMvdHJhbnNhY3Rpb25zL3BheW1lbnRf",
            "Y2FyZF9zYWxlX2NhcHR1cmVfaW5kaWNhdG9yLnByb3RvGjttb25leS9jYXJk",
            "cy90cmFuc2FjdGlvbnMvcHJvY2Vzc29yX3RyYW5zYWN0aW9uX3Jlc3VsdC5w",
            "cm90bxowcHJpbWl0aXZlL3BiX2luY2x1c2l2ZV9jYWxlbmRhcl9kYXRlX3Jh",
            "bmdlLnByb3RvGjJ0ZW5hbmN5X2NvbmZpZy9pbmRpY2F0b3JzL3Byb3BlcnR5",
            "X2luZGljYXRvci5wcm90byJ2CiRDYXJkUHJvY2Vzc2luZ1N2Y0NhcHR1cmVF",
            "bnVtUmVzcG9uc2USTgoIY2FwdHVyZXMYASADKAsyPC5ob2xtcy50eXBlcy5t",
            "b25leS5jYXJkcy50cmFuc2FjdGlvbnMuUGF5bWVudENhcmRTYWxlQ2FwdHVy",
            "ZSJvCiNDYXJkUHJvY2Vzc2luZ1N2Y1JlZnVuZEVudW1SZXNwb25zZRJICgdy",
            "ZWZ1bmRzGAEgAygLMjcuaG9sbXMudHlwZXMubW9uZXkuY2FyZHMudHJhbnNh",
            "Y3Rpb25zLlBheW1lbnRDYXJkUmVmdW5kImEKGU1lcmNoYW50QmF0Y2hFbnVt",
            "UmVzcG9uc2USRAoHYmF0Y2hlcxgBIAMoCzIzLmhvbG1zLnR5cGVzLm1vbmV5",
            "LmNhcmRzLnRyYW5zYWN0aW9ucy5NZXJjaGFudEJhdGNoIoMBCi1DYXJkUHJv",
            "Y2Vzc2luZ1N2Y0NhbmNlbFBlbmRpbmdDYXB0dXJlUmVzcG9uc2USUgoGcmVz",
            "dWx0GAEgASgOMkIuaG9sbXMudHlwZXMubW9uZXkucnBjLkNhcmRQcm9jZXNz",
            "aW5nU3ZjQ2FuY2VsUGVuZGluZ0NhcHR1cmVSZXN1bHQizgEKOENhcmRQcm9j",
            "ZXNzaW5nU3ZjVmVyaWZ5QW5kVG9rZW5pemVOb3RQcmVzZW50Q2FyZFJlc3Bv",
            "bnNlElAKBnJlc3VsdBgBIAEoDjJALmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRz",
            "LnRyYW5zYWN0aW9ucy5Qcm9jZXNzb3JUcmFuc2FjdGlvblJlc3VsdBJACgRj",
            "YXJkGAIgASgLMjIuaG9sbXMudHlwZXMubW9uZXkuY2FyZHMuR3Vlc3RQYXlt",
            "ZW50Q2FyZEluZGljYXRvciLhAQoeUGF5bWVudENhcmRWZXJpZmljYXRpb25S",
            "ZXF1ZXN0EjUKBWd1ZXN0GAEgASgLMiYuaG9sbXMudHlwZXMuY3JtLmd1ZXN0",
            "cy5HdWVzdEluZGljYXRvchJKCghwcm9wZXJ0eRgCIAEoCzI4LmhvbG1zLnR5",
            "cGVzLnRlbmFuY3lfY29uZmlnLmluZGljYXRvcnMuUHJvcGVydHlJbmRpY2F0",
            "b3ISPAoEY2FyZBgDIAEoCzIuLmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLk5v",
            "dFByZXNlbnRQYXltZW50Q2FyZCqdAgorQ2FyZFByb2Nlc3NpbmdTdmNDYW5j",
            "ZWxQZW5kaW5nQ2FwdHVyZVJlc3VsdBI2CjJDQVJEX1BST0NFU1NJTkdfU1ZD",
            "X0NBTkNFTF9QRU5ESU5HX0NBUFRVUkVfU1VDQ0VTUxAAEjgKNENBUkRfUFJP",
            "Q0VTU0lOR19TVkNfQ0FOQ0VMX1BFTkRJTkdfQ0FQVFVSRV9OT1RfRk9VTkQQ",
            "ARI+CjpDQVJEX1BST0NFU1NJTkdfU1ZDX0NBTkNFTF9QRU5ESU5HX0NBUFRV",
            "UkVfTk9UX0NBTkNFTExBQkxFEAISPAo4Q0FSRF9QUk9DRVNTSU5HX1NWQ19D",
            "QU5DRUxfUEVORElOR19DQVBUVVJFX1VOS05PV05fRVJST1IQAzLVBwoRQ2Fy",
            "ZFByb2Nlc3NpbmdTdmMSbAoVR2V0QWxsUGVuZGluZ0NhcHR1cmVzEhYuZ29v",
            "Z2xlLnByb3RvYnVmLkVtcHR5GjsuaG9sbXMudHlwZXMubW9uZXkucnBjLkNh",
            "cmRQcm9jZXNzaW5nU3ZjQ2FwdHVyZUVudW1SZXNwb25zZRJqChRHZXRBbGxQ",
            "ZW5kaW5nUmVmdW5kcxIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRo6LmhvbG1z",
            "LnR5cGVzLm1vbmV5LnJwYy5DYXJkUHJvY2Vzc2luZ1N2Y1JlZnVuZEVudW1S",
            "ZXNwb25zZRJ2Cg1HZXRBbGxCYXRjaGVzEjMuaG9sbXMudHlwZXMucHJpbWl0",
            "aXZlLlBiSW5jbHVzaXZlQ2FsZW5kYXJEYXRlUmFuZ2UaMC5ob2xtcy50eXBl",
            "cy5tb25leS5ycGMuTWVyY2hhbnRCYXRjaEVudW1SZXNwb25zZRKcAQo1T3Bl",
            "bkFuZFNldHRsZUJhdGNoRnJvbVBlbmRpbmdDYXB0dXJlc1NwZWNpZmljTWVy",
            "Y2hhbnQSLi5ob2xtcy50eXBlcy5tb25leS5jYXJkcy5DYXJkTWVyY2hhbnRJ",
            "bmRpY2F0b3IaMy5ob2xtcy50eXBlcy5tb25leS5jYXJkcy50cmFuc2FjdGlv",
            "bnMuTWVyY2hhbnRCYXRjaBJ9CjFPcGVuQW5kU2V0dGxlQmF0Y2hGcm9tUGVu",
            "ZGluZ0NhcHR1cmVzQWxsTWVyY2hhbnRzEhYuZ29vZ2xlLnByb3RvYnVmLkVt",
            "cHR5GjAuaG9sbXMudHlwZXMubW9uZXkucnBjLk1lcmNoYW50QmF0Y2hFbnVt",
            "UmVzcG9uc2USowEKFENhbmNlbFBlbmRpbmdDYXB0dXJlEkUuaG9sbXMudHlw",
            "ZXMubW9uZXkuY2FyZHMudHJhbnNhY3Rpb25zLlBheW1lbnRDYXJkU2FsZUNh",
            "cHR1cmVJbmRpY2F0b3IaRC5ob2xtcy50eXBlcy5tb25leS5ycGMuQ2FyZFBy",
            "b2Nlc3NpbmdTdmNDYW5jZWxQZW5kaW5nQ2FwdHVyZVJlc3BvbnNlEqkBCh9W",
            "ZXJpZnlBbmRUb2tlbml6ZU5vdFByZXNlbnRDYXJkEjUuaG9sbXMudHlwZXMu",
            "bW9uZXkucnBjLlBheW1lbnRDYXJkVmVyaWZpY2F0aW9uUmVxdWVzdBpPLmhv",
            "bG1zLnR5cGVzLm1vbmV5LnJwYy5DYXJkUHJvY2Vzc2luZ1N2Y1ZlcmlmeUFu",
            "ZFRva2VuaXplTm90UHJlc2VudENhcmRSZXNwb25zZUIYqgIVSE9MTVMuVHlw",
            "ZXMuTW9uZXkuUlBDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.CRM.Guests.GuestIndicatorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Money.Cards.CardMerchantIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.GuestPaymentCardIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.NotPresentPaymentCardReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.MerchantBatchReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleCaptureReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleCaptureIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResultReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveCalendarDateRangeReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResult), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse), global::HOLMS.Types.Money.RPC.CardProcessingSvcCaptureEnumResponse.Parser, new[]{ "Captures" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.CardProcessingSvcRefundEnumResponse), global::HOLMS.Types.Money.RPC.CardProcessingSvcRefundEnumResponse.Parser, new[]{ "Refunds" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse), global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse.Parser, new[]{ "Batches" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse), global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResponse.Parser, new[]{ "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse), global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse.Parser, new[]{ "Result", "Card" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.PaymentCardVerificationRequest), global::HOLMS.Types.Money.RPC.PaymentCardVerificationRequest.Parser, new[]{ "Guest", "Property", "Card" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum CardProcessingSvcCancelPendingCaptureResult {
    [pbr::OriginalName("CARD_PROCESSING_SVC_CANCEL_PENDING_CAPTURE_SUCCESS")] CardProcessingSvcCancelPendingCaptureSuccess = 0,
    [pbr::OriginalName("CARD_PROCESSING_SVC_CANCEL_PENDING_CAPTURE_NOT_FOUND")] CardProcessingSvcCancelPendingCaptureNotFound = 1,
    [pbr::OriginalName("CARD_PROCESSING_SVC_CANCEL_PENDING_CAPTURE_NOT_CANCELLABLE")] CardProcessingSvcCancelPendingCaptureNotCancellable = 2,
    [pbr::OriginalName("CARD_PROCESSING_SVC_CANCEL_PENDING_CAPTURE_UNKNOWN_ERROR")] CardProcessingSvcCancelPendingCaptureUnknownError = 3,
  }

  #endregion

  #region Messages
  public sealed partial class CardProcessingSvcCaptureEnumResponse : pb::IMessage<CardProcessingSvcCaptureEnumResponse> {
    private static readonly pb::MessageParser<CardProcessingSvcCaptureEnumResponse> _parser = new pb::MessageParser<CardProcessingSvcCaptureEnumResponse>(() => new CardProcessingSvcCaptureEnumResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardProcessingSvcCaptureEnumResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcCaptureEnumResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcCaptureEnumResponse(CardProcessingSvcCaptureEnumResponse other) : this() {
      captures_ = other.captures_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcCaptureEnumResponse Clone() {
      return new CardProcessingSvcCaptureEnumResponse(this);
    }

    /// <summary>Field number for the "captures" field.</summary>
    public const int CapturesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleCapture> _repeated_captures_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleCapture.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleCapture> captures_ = new pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleCapture>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleCapture> Captures {
      get { return captures_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardProcessingSvcCaptureEnumResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardProcessingSvcCaptureEnumResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!captures_.Equals(other.captures_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= captures_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      captures_.WriteTo(output, _repeated_captures_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += captures_.CalculateSize(_repeated_captures_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardProcessingSvcCaptureEnumResponse other) {
      if (other == null) {
        return;
      }
      captures_.Add(other.captures_);
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
            captures_.AddEntriesFrom(input, _repeated_captures_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CardProcessingSvcRefundEnumResponse : pb::IMessage<CardProcessingSvcRefundEnumResponse> {
    private static readonly pb::MessageParser<CardProcessingSvcRefundEnumResponse> _parser = new pb::MessageParser<CardProcessingSvcRefundEnumResponse>(() => new CardProcessingSvcRefundEnumResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardProcessingSvcRefundEnumResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcRefundEnumResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcRefundEnumResponse(CardProcessingSvcRefundEnumResponse other) : this() {
      refunds_ = other.refunds_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcRefundEnumResponse Clone() {
      return new CardProcessingSvcRefundEnumResponse(this);
    }

    /// <summary>Field number for the "refunds" field.</summary>
    public const int RefundsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefund> _repeated_refunds_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefund.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefund> refunds_ = new pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefund>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefund> Refunds {
      get { return refunds_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardProcessingSvcRefundEnumResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardProcessingSvcRefundEnumResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!refunds_.Equals(other.refunds_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= refunds_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      refunds_.WriteTo(output, _repeated_refunds_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += refunds_.CalculateSize(_repeated_refunds_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardProcessingSvcRefundEnumResponse other) {
      if (other == null) {
        return;
      }
      refunds_.Add(other.refunds_);
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
            refunds_.AddEntriesFrom(input, _repeated_refunds_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class MerchantBatchEnumResponse : pb::IMessage<MerchantBatchEnumResponse> {
    private static readonly pb::MessageParser<MerchantBatchEnumResponse> _parser = new pb::MessageParser<MerchantBatchEnumResponse>(() => new MerchantBatchEnumResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MerchantBatchEnumResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantBatchEnumResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantBatchEnumResponse(MerchantBatchEnumResponse other) : this() {
      batches_ = other.batches_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantBatchEnumResponse Clone() {
      return new MerchantBatchEnumResponse(this);
    }

    /// <summary>Field number for the "batches" field.</summary>
    public const int BatchesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Money.Cards.Transactions.MerchantBatch> _repeated_batches_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Money.Cards.Transactions.MerchantBatch.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.MerchantBatch> batches_ = new pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.MerchantBatch>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.MerchantBatch> Batches {
      get { return batches_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MerchantBatchEnumResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MerchantBatchEnumResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!batches_.Equals(other.batches_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= batches_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      batches_.WriteTo(output, _repeated_batches_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += batches_.CalculateSize(_repeated_batches_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MerchantBatchEnumResponse other) {
      if (other == null) {
        return;
      }
      batches_.Add(other.batches_);
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
            batches_.AddEntriesFrom(input, _repeated_batches_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CardProcessingSvcCancelPendingCaptureResponse : pb::IMessage<CardProcessingSvcCancelPendingCaptureResponse> {
    private static readonly pb::MessageParser<CardProcessingSvcCancelPendingCaptureResponse> _parser = new pb::MessageParser<CardProcessingSvcCancelPendingCaptureResponse>(() => new CardProcessingSvcCancelPendingCaptureResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardProcessingSvcCancelPendingCaptureResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcCancelPendingCaptureResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcCancelPendingCaptureResponse(CardProcessingSvcCancelPendingCaptureResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcCancelPendingCaptureResponse Clone() {
      return new CardProcessingSvcCancelPendingCaptureResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardProcessingSvcCancelPendingCaptureResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardProcessingSvcCancelPendingCaptureResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardProcessingSvcCancelPendingCaptureResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
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
            result_ = (global::HOLMS.Types.Money.RPC.CardProcessingSvcCancelPendingCaptureResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse : pb::IMessage<CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> {
    private static readonly pb::MessageParser<CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> _parser = new pb::MessageParser<CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse>(() => new CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse(CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse other) : this() {
      result_ = other.result_;
      Card = other.card_ != null ? other.Card.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse Clone() {
      return new CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 2;
    private global::HOLMS.Types.Money.Cards.GuestPaymentCardIndicator card_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.GuestPaymentCardIndicator Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(Card, other.Card)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (card_ != null) hash ^= Card.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (card_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Card);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (card_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Card);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.card_ != null) {
        if (card_ == null) {
          card_ = new global::HOLMS.Types.Money.Cards.GuestPaymentCardIndicator();
        }
        Card.MergeFrom(other.Card);
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
            result_ = (global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult) input.ReadEnum();
            break;
          }
          case 18: {
            if (card_ == null) {
              card_ = new global::HOLMS.Types.Money.Cards.GuestPaymentCardIndicator();
            }
            input.ReadMessage(card_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PaymentCardVerificationRequest : pb::IMessage<PaymentCardVerificationRequest> {
    private static readonly pb::MessageParser<PaymentCardVerificationRequest> _parser = new pb::MessageParser<PaymentCardVerificationRequest>(() => new PaymentCardVerificationRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PaymentCardVerificationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentCardVerificationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentCardVerificationRequest(PaymentCardVerificationRequest other) : this() {
      Guest = other.guest_ != null ? other.Guest.Clone() : null;
      Property = other.property_ != null ? other.Property.Clone() : null;
      Card = other.card_ != null ? other.Card.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentCardVerificationRequest Clone() {
      return new PaymentCardVerificationRequest(this);
    }

    /// <summary>Field number for the "guest" field.</summary>
    public const int GuestFieldNumber = 1;
    private global::HOLMS.Types.CRM.Guests.GuestIndicator guest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Guests.GuestIndicator Guest {
      get { return guest_; }
      set {
        guest_ = value;
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

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 3;
    private global::HOLMS.Types.Money.Cards.NotPresentPaymentCard card_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.NotPresentPaymentCard Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PaymentCardVerificationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PaymentCardVerificationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Guest, other.Guest)) return false;
      if (!object.Equals(Property, other.Property)) return false;
      if (!object.Equals(Card, other.Card)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (guest_ != null) hash ^= Guest.GetHashCode();
      if (property_ != null) hash ^= Property.GetHashCode();
      if (card_ != null) hash ^= Card.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (guest_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Guest);
      }
      if (property_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Property);
      }
      if (card_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Card);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (guest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Guest);
      }
      if (property_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Property);
      }
      if (card_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Card);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PaymentCardVerificationRequest other) {
      if (other == null) {
        return;
      }
      if (other.guest_ != null) {
        if (guest_ == null) {
          guest_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
        }
        Guest.MergeFrom(other.Guest);
      }
      if (other.property_ != null) {
        if (property_ == null) {
          property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        Property.MergeFrom(other.Property);
      }
      if (other.card_ != null) {
        if (card_ == null) {
          card_ = new global::HOLMS.Types.Money.Cards.NotPresentPaymentCard();
        }
        Card.MergeFrom(other.Card);
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
            if (guest_ == null) {
              guest_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
            }
            input.ReadMessage(guest_);
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
            if (card_ == null) {
              card_ = new global::HOLMS.Types.Money.Cards.NotPresentPaymentCard();
            }
            input.ReadMessage(card_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

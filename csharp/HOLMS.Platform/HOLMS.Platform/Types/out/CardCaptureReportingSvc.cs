// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/rpc/card_capture_reporting_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Reporting.RPC {

  /// <summary>Holder for reflection information generated from reporting/rpc/card_capture_reporting_svc.proto</summary>
  public static partial class CardCaptureReportingSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for reporting/rpc/card_capture_reporting_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CardCaptureReportingSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5yZXBvcnRpbmcvcnBjL2NhcmRfY2FwdHVyZV9yZXBvcnRpbmdfc3ZjLnBy",
            "b3RvEhlob2xtcy50eXBlcy5yZXBvcnRpbmcucnBjGiltb25leS9jYXJkcy9j",
            "YXJkX21lcmNoYW50X2luZGljYXRvci5wcm90bxo+bW9uZXkvY2FyZHMvdHJh",
            "bnNhY3Rpb25zL2Nsb3NlZF9tZXJjaGFudF9iYXRjaF9pbmRpY2F0b3IucHJv",
            "dG8aG3ByaW1pdGl2ZS9wYl9pbnRlcnZhbC5wcm90byJ9CjRDYXJkQ2FwdHVy",
            "ZVJlcG9ydGluZ1N2Y0dldFBlbmRpbmdUcmFuc2FjdGlvbnNSZXF1ZXN0EkUK",
            "DWNhcmRfbWVyY2hhbnQYASABKAsyLi5ob2xtcy50eXBlcy5tb25leS5jYXJk",
            "cy5DYXJkTWVyY2hhbnRJbmRpY2F0b3IiiAEKMUNhcmRDYXB0dXJlUmVwb3J0",
            "U3ZjR2V0U2V0dGxlZFRyYW5zYWN0aW9uc1JlcXVlc3QSUwoHYmF0Y2hlcxgB",
            "IAMoCzJCLmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLnRyYW5zYWN0aW9ucy5D",
            "bG9zZWRNZXJjaGFudEJhdGNoSW5kaWNhdG9yIjkKJUNhcmRDYXB0dXJlUmVw",
            "b3J0aW5nU3ZjUmVwb3J0UmVzcG9uc2USEAoIZG9jdW1lbnQYASABKAkizgEK",
            "N0NhcmRDYXB0dXJlUmVwb3J0aW5nU3ZjR2V0T3BlbkNsb3NlZFRyYW5zYWN0",
            "aW9uc1JlcXVlc3QSRQoNY2FyZF9tZXJjaGFudBgBIAEoCzIuLmhvbG1zLnR5",
            "cGVzLm1vbmV5LmNhcmRzLkNhcmRNZXJjaGFudEluZGljYXRvchITCgtjYXJk",
            "X251bWJlchgCIAEoCRI3CgxzZWFyY2hfcmFuZ2UYAyABKAsyIS5ob2xtcy50",
            "eXBlcy5wcmltaXRpdmUuUGJJbnRlcnZhbDK4BAoXQ2FyZENhcHR1cmVSZXBv",
            "cnRpbmdTdmMSsQEKHEdldFBlbmRpbmdUcmFuc2FjdGlvbnNSZXBvcnQSTy5o",
            "b2xtcy50eXBlcy5yZXBvcnRpbmcucnBjLkNhcmRDYXB0dXJlUmVwb3J0aW5n",
            "U3ZjR2V0UGVuZGluZ1RyYW5zYWN0aW9uc1JlcXVlc3QaQC5ob2xtcy50eXBl",
            "cy5yZXBvcnRpbmcucnBjLkNhcmRDYXB0dXJlUmVwb3J0aW5nU3ZjUmVwb3J0",
            "UmVzcG9uc2USrgEKHEdldFNldHRsZWRUcmFuc2FjdGlvbnNSZXBvcnQSTC5o",
            "b2xtcy50eXBlcy5yZXBvcnRpbmcucnBjLkNhcmRDYXB0dXJlUmVwb3J0U3Zj",
            "R2V0U2V0dGxlZFRyYW5zYWN0aW9uc1JlcXVlc3QaQC5ob2xtcy50eXBlcy5y",
            "ZXBvcnRpbmcucnBjLkNhcmRDYXB0dXJlUmVwb3J0aW5nU3ZjUmVwb3J0UmVz",
            "cG9uc2UStwEKH0dldE9wZW5DbG9zZWRUcmFuc2FjdGlvbnNSZXBvcnQSUi5o",
            "b2xtcy50eXBlcy5yZXBvcnRpbmcucnBjLkNhcmRDYXB0dXJlUmVwb3J0aW5n",
            "U3ZjR2V0T3BlbkNsb3NlZFRyYW5zYWN0aW9uc1JlcXVlc3QaQC5ob2xtcy50",
            "eXBlcy5yZXBvcnRpbmcucnBjLkNhcmRDYXB0dXJlUmVwb3J0aW5nU3ZjUmVw",
            "b3J0UmVzcG9uc2VCHKoCGUhPTE1TLlR5cGVzLlJlcG9ydGluZy5SUENiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Money.Cards.CardMerchantIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatchIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.PbIntervalReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.CardCaptureReportingSvcGetPendingTransactionsRequest), global::HOLMS.Types.Reporting.RPC.CardCaptureReportingSvcGetPendingTransactionsRequest.Parser, new[]{ "CardMerchant" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.CardCaptureReportSvcGetSettledTransactionsRequest), global::HOLMS.Types.Reporting.RPC.CardCaptureReportSvcGetSettledTransactionsRequest.Parser, new[]{ "Batches" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.CardCaptureReportingSvcReportResponse), global::HOLMS.Types.Reporting.RPC.CardCaptureReportingSvcReportResponse.Parser, new[]{ "Document" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.CardCaptureReportingSvcGetOpenClosedTransactionsRequest), global::HOLMS.Types.Reporting.RPC.CardCaptureReportingSvcGetOpenClosedTransactionsRequest.Parser, new[]{ "CardMerchant", "CardNumber", "SearchRange" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CardCaptureReportingSvcGetPendingTransactionsRequest : pb::IMessage<CardCaptureReportingSvcGetPendingTransactionsRequest> {
    private static readonly pb::MessageParser<CardCaptureReportingSvcGetPendingTransactionsRequest> _parser = new pb::MessageParser<CardCaptureReportingSvcGetPendingTransactionsRequest>(() => new CardCaptureReportingSvcGetPendingTransactionsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardCaptureReportingSvcGetPendingTransactionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.CardCaptureReportingSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportingSvcGetPendingTransactionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportingSvcGetPendingTransactionsRequest(CardCaptureReportingSvcGetPendingTransactionsRequest other) : this() {
      CardMerchant = other.cardMerchant_ != null ? other.CardMerchant.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportingSvcGetPendingTransactionsRequest Clone() {
      return new CardCaptureReportingSvcGetPendingTransactionsRequest(this);
    }

    /// <summary>Field number for the "card_merchant" field.</summary>
    public const int CardMerchantFieldNumber = 1;
    private global::HOLMS.Types.Money.Cards.CardMerchantIndicator cardMerchant_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.CardMerchantIndicator CardMerchant {
      get { return cardMerchant_; }
      set {
        cardMerchant_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardCaptureReportingSvcGetPendingTransactionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardCaptureReportingSvcGetPendingTransactionsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CardMerchant, other.CardMerchant)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (cardMerchant_ != null) hash ^= CardMerchant.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (cardMerchant_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CardMerchant);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (cardMerchant_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CardMerchant);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardCaptureReportingSvcGetPendingTransactionsRequest other) {
      if (other == null) {
        return;
      }
      if (other.cardMerchant_ != null) {
        if (cardMerchant_ == null) {
          cardMerchant_ = new global::HOLMS.Types.Money.Cards.CardMerchantIndicator();
        }
        CardMerchant.MergeFrom(other.CardMerchant);
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
            if (cardMerchant_ == null) {
              cardMerchant_ = new global::HOLMS.Types.Money.Cards.CardMerchantIndicator();
            }
            input.ReadMessage(cardMerchant_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CardCaptureReportSvcGetSettledTransactionsRequest : pb::IMessage<CardCaptureReportSvcGetSettledTransactionsRequest> {
    private static readonly pb::MessageParser<CardCaptureReportSvcGetSettledTransactionsRequest> _parser = new pb::MessageParser<CardCaptureReportSvcGetSettledTransactionsRequest>(() => new CardCaptureReportSvcGetSettledTransactionsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardCaptureReportSvcGetSettledTransactionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.CardCaptureReportingSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportSvcGetSettledTransactionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportSvcGetSettledTransactionsRequest(CardCaptureReportSvcGetSettledTransactionsRequest other) : this() {
      batches_ = other.batches_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportSvcGetSettledTransactionsRequest Clone() {
      return new CardCaptureReportSvcGetSettledTransactionsRequest(this);
    }

    /// <summary>Field number for the "batches" field.</summary>
    public const int BatchesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatchIndicator> _repeated_batches_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatchIndicator.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatchIndicator> batches_ = new pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatchIndicator>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatchIndicator> Batches {
      get { return batches_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardCaptureReportSvcGetSettledTransactionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardCaptureReportSvcGetSettledTransactionsRequest other) {
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
    public void MergeFrom(CardCaptureReportSvcGetSettledTransactionsRequest other) {
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

  public sealed partial class CardCaptureReportingSvcReportResponse : pb::IMessage<CardCaptureReportingSvcReportResponse> {
    private static readonly pb::MessageParser<CardCaptureReportingSvcReportResponse> _parser = new pb::MessageParser<CardCaptureReportingSvcReportResponse>(() => new CardCaptureReportingSvcReportResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardCaptureReportingSvcReportResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.CardCaptureReportingSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportingSvcReportResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportingSvcReportResponse(CardCaptureReportingSvcReportResponse other) : this() {
      document_ = other.document_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportingSvcReportResponse Clone() {
      return new CardCaptureReportingSvcReportResponse(this);
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
      return Equals(other as CardCaptureReportingSvcReportResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardCaptureReportingSvcReportResponse other) {
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
    public void MergeFrom(CardCaptureReportingSvcReportResponse other) {
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

  public sealed partial class CardCaptureReportingSvcGetOpenClosedTransactionsRequest : pb::IMessage<CardCaptureReportingSvcGetOpenClosedTransactionsRequest> {
    private static readonly pb::MessageParser<CardCaptureReportingSvcGetOpenClosedTransactionsRequest> _parser = new pb::MessageParser<CardCaptureReportingSvcGetOpenClosedTransactionsRequest>(() => new CardCaptureReportingSvcGetOpenClosedTransactionsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardCaptureReportingSvcGetOpenClosedTransactionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.CardCaptureReportingSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportingSvcGetOpenClosedTransactionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportingSvcGetOpenClosedTransactionsRequest(CardCaptureReportingSvcGetOpenClosedTransactionsRequest other) : this() {
      CardMerchant = other.cardMerchant_ != null ? other.CardMerchant.Clone() : null;
      cardNumber_ = other.cardNumber_;
      SearchRange = other.searchRange_ != null ? other.SearchRange.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardCaptureReportingSvcGetOpenClosedTransactionsRequest Clone() {
      return new CardCaptureReportingSvcGetOpenClosedTransactionsRequest(this);
    }

    /// <summary>Field number for the "card_merchant" field.</summary>
    public const int CardMerchantFieldNumber = 1;
    private global::HOLMS.Types.Money.Cards.CardMerchantIndicator cardMerchant_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.CardMerchantIndicator CardMerchant {
      get { return cardMerchant_; }
      set {
        cardMerchant_ = value;
      }
    }

    /// <summary>Field number for the "card_number" field.</summary>
    public const int CardNumberFieldNumber = 2;
    private string cardNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CardNumber {
      get { return cardNumber_; }
      set {
        cardNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "search_range" field.</summary>
    public const int SearchRangeFieldNumber = 3;
    private global::HOLMS.Types.Primitive.PbInterval searchRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInterval SearchRange {
      get { return searchRange_; }
      set {
        searchRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardCaptureReportingSvcGetOpenClosedTransactionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardCaptureReportingSvcGetOpenClosedTransactionsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CardMerchant, other.CardMerchant)) return false;
      if (CardNumber != other.CardNumber) return false;
      if (!object.Equals(SearchRange, other.SearchRange)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (cardMerchant_ != null) hash ^= CardMerchant.GetHashCode();
      if (CardNumber.Length != 0) hash ^= CardNumber.GetHashCode();
      if (searchRange_ != null) hash ^= SearchRange.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (cardMerchant_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CardMerchant);
      }
      if (CardNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CardNumber);
      }
      if (searchRange_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SearchRange);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (cardMerchant_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CardMerchant);
      }
      if (CardNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CardNumber);
      }
      if (searchRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SearchRange);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardCaptureReportingSvcGetOpenClosedTransactionsRequest other) {
      if (other == null) {
        return;
      }
      if (other.cardMerchant_ != null) {
        if (cardMerchant_ == null) {
          cardMerchant_ = new global::HOLMS.Types.Money.Cards.CardMerchantIndicator();
        }
        CardMerchant.MergeFrom(other.CardMerchant);
      }
      if (other.CardNumber.Length != 0) {
        CardNumber = other.CardNumber;
      }
      if (other.searchRange_ != null) {
        if (searchRange_ == null) {
          searchRange_ = new global::HOLMS.Types.Primitive.PbInterval();
        }
        SearchRange.MergeFrom(other.SearchRange);
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
            if (cardMerchant_ == null) {
              cardMerchant_ = new global::HOLMS.Types.Money.Cards.CardMerchantIndicator();
            }
            input.ReadMessage(cardMerchant_);
            break;
          }
          case 18: {
            CardNumber = input.ReadString();
            break;
          }
          case 26: {
            if (searchRange_ == null) {
              searchRange_ = new global::HOLMS.Types.Primitive.PbInterval();
            }
            input.ReadMessage(searchRange_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

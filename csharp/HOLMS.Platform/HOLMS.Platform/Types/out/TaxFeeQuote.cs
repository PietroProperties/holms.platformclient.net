// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/tax_fee_quote.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/tax_fee_quote.proto</summary>
  public static partial class TaxFeeQuoteReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/tax_fee_quote.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaxFeeQuoteReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlmb2xpby90YXhfZmVlX3F1b3RlLnByb3RvEhFob2xtcy50eXBlcy5mb2xp",
            "bxoebW9uZXkvYWNjb3VudGluZy90YXhfZmVlLnByb3RvGh9wcmltaXRpdmUv",
            "bW9uZXRhcnlfYW1vdW50LnByb3RvIo0BCgtUYXhGZWVRdW90ZRI4Cgp0YXhf",
            "b3JfZmVlGAEgASgLMiQuaG9sbXMudHlwZXMubW9uZXkuYWNjb3VudGluZy5U",
            "YXhGZWUSRAoVcXVvdGVkX3RheF9mZWVfYW1vdW50GAIgASgLMiUuaG9sbXMu",
            "dHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5QW1vdW50QhtaBWZvbGlvqgIRSE9M",
            "TVMuVHlwZXMuRm9saW9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Money.Accounting.TaxFeeReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.TaxFeeQuote), global::HOLMS.Types.Folio.TaxFeeQuote.Parser, new[]{ "TaxOrFee", "QuotedTaxFeeAmount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TaxFeeQuote : pb::IMessage<TaxFeeQuote> {
    private static readonly pb::MessageParser<TaxFeeQuote> _parser = new pb::MessageParser<TaxFeeQuote>(() => new TaxFeeQuote());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TaxFeeQuote> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.TaxFeeQuoteReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxFeeQuote() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxFeeQuote(TaxFeeQuote other) : this() {
      TaxOrFee = other.taxOrFee_ != null ? other.TaxOrFee.Clone() : null;
      QuotedTaxFeeAmount = other.quotedTaxFeeAmount_ != null ? other.QuotedTaxFeeAmount.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxFeeQuote Clone() {
      return new TaxFeeQuote(this);
    }

    /// <summary>Field number for the "tax_or_fee" field.</summary>
    public const int TaxOrFeeFieldNumber = 1;
    private global::HOLMS.Types.Money.Accounting.TaxFee taxOrFee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Accounting.TaxFee TaxOrFee {
      get { return taxOrFee_; }
      set {
        taxOrFee_ = value;
      }
    }

    /// <summary>Field number for the "quoted_tax_fee_amount" field.</summary>
    public const int QuotedTaxFeeAmountFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount quotedTaxFeeAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount QuotedTaxFeeAmount {
      get { return quotedTaxFeeAmount_; }
      set {
        quotedTaxFeeAmount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TaxFeeQuote);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TaxFeeQuote other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TaxOrFee, other.TaxOrFee)) return false;
      if (!object.Equals(QuotedTaxFeeAmount, other.QuotedTaxFeeAmount)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (taxOrFee_ != null) hash ^= TaxOrFee.GetHashCode();
      if (quotedTaxFeeAmount_ != null) hash ^= QuotedTaxFeeAmount.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (taxOrFee_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TaxOrFee);
      }
      if (quotedTaxFeeAmount_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(QuotedTaxFeeAmount);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (taxOrFee_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TaxOrFee);
      }
      if (quotedTaxFeeAmount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QuotedTaxFeeAmount);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TaxFeeQuote other) {
      if (other == null) {
        return;
      }
      if (other.taxOrFee_ != null) {
        if (taxOrFee_ == null) {
          taxOrFee_ = new global::HOLMS.Types.Money.Accounting.TaxFee();
        }
        TaxOrFee.MergeFrom(other.TaxOrFee);
      }
      if (other.quotedTaxFeeAmount_ != null) {
        if (quotedTaxFeeAmount_ == null) {
          quotedTaxFeeAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        QuotedTaxFeeAmount.MergeFrom(other.QuotedTaxFeeAmount);
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
            if (taxOrFee_ == null) {
              taxOrFee_ = new global::HOLMS.Types.Money.Accounting.TaxFee();
            }
            input.ReadMessage(taxOrFee_);
            break;
          }
          case 18: {
            if (quotedTaxFeeAmount_ == null) {
              quotedTaxFeeAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(quotedTaxFeeAmount_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

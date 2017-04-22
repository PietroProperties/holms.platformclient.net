// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/cards/transactions/payment_card_authorization_reversal.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Cards.Transactions {

  /// <summary>Holder for reflection information generated from money/cards/transactions/payment_card_authorization_reversal.proto</summary>
  public static partial class PaymentCardAuthorizationReversalReflection {

    #region Descriptor
    /// <summary>File descriptor for money/cards/transactions/payment_card_authorization_reversal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaymentCardAuthorizationReversalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJtb25leS9jYXJkcy90cmFuc2FjdGlvbnMvcGF5bWVudF9jYXJkX2F1dGhv",
            "cml6YXRpb25fcmV2ZXJzYWwucHJvdG8SJGhvbG1zLnR5cGVzLm1vbmV5LmNh",
            "cmRzLnRyYW5zYWN0aW9ucxo7bW9uZXkvY2FyZHMvdHJhbnNhY3Rpb25zL3By",
            "b2Nlc3Nvcl90cmFuc2FjdGlvbl9yZXN1bHQucHJvdG8aH3ByaW1pdGl2ZS9t",
            "b25ldGFyeV9hbW91bnQucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3Rh",
            "bXAucHJvdG8iggIKIFBheW1lbnRDYXJkQXV0aG9yaXphdGlvblJldmVyc2Fs",
            "Ej4KD3JldmVyc2FsX2Ftb3VudBgBIAEoCzIlLmhvbG1zLnR5cGVzLnByaW1p",
            "dGl2ZS5Nb25ldGFyeUFtb3VudBIdChVob3N0X3JlZmVyZW5jZV9udW1iZXIY",
            "AiABKAkSUAoGcmVzdWx0GAMgASgOMkAuaG9sbXMudHlwZXMubW9uZXkuY2Fy",
            "ZHMudHJhbnNhY3Rpb25zLlByb2Nlc3NvclRyYW5zYWN0aW9uUmVzdWx0Ei0K",
            "CXBvc3RlZF9hdBgEIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBC",
            "QVoYbW9uZXkvY2FyZHMvdHJhbnNhY3Rpb25zqgIkSE9MTVMuVHlwZXMuTW9u",
            "ZXkuQ2FyZHMuVHJhbnNhY3Rpb25zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResultReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationReversal), global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationReversal.Parser, new[]{ "ReversalAmount", "HostReferenceNumber", "Result", "PostedAt" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PaymentCardAuthorizationReversal : pb::IMessage<PaymentCardAuthorizationReversal> {
    private static readonly pb::MessageParser<PaymentCardAuthorizationReversal> _parser = new pb::MessageParser<PaymentCardAuthorizationReversal>(() => new PaymentCardAuthorizationReversal());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PaymentCardAuthorizationReversal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationReversalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentCardAuthorizationReversal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentCardAuthorizationReversal(PaymentCardAuthorizationReversal other) : this() {
      ReversalAmount = other.reversalAmount_ != null ? other.ReversalAmount.Clone() : null;
      hostReferenceNumber_ = other.hostReferenceNumber_;
      result_ = other.result_;
      PostedAt = other.postedAt_ != null ? other.PostedAt.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentCardAuthorizationReversal Clone() {
      return new PaymentCardAuthorizationReversal(this);
    }

    /// <summary>Field number for the "reversal_amount" field.</summary>
    public const int ReversalAmountFieldNumber = 1;
    private global::HOLMS.Types.Primitive.MonetaryAmount reversalAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount ReversalAmount {
      get { return reversalAmount_; }
      set {
        reversalAmount_ = value;
      }
    }

    /// <summary>Field number for the "host_reference_number" field.</summary>
    public const int HostReferenceNumberFieldNumber = 2;
    private string hostReferenceNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HostReferenceNumber {
      get { return hostReferenceNumber_; }
      set {
        hostReferenceNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 3;
    private global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "posted_at" field.</summary>
    public const int PostedAtFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp postedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp PostedAt {
      get { return postedAt_; }
      set {
        postedAt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PaymentCardAuthorizationReversal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PaymentCardAuthorizationReversal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ReversalAmount, other.ReversalAmount)) return false;
      if (HostReferenceNumber != other.HostReferenceNumber) return false;
      if (Result != other.Result) return false;
      if (!object.Equals(PostedAt, other.PostedAt)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reversalAmount_ != null) hash ^= ReversalAmount.GetHashCode();
      if (HostReferenceNumber.Length != 0) hash ^= HostReferenceNumber.GetHashCode();
      if (Result != 0) hash ^= Result.GetHashCode();
      if (postedAt_ != null) hash ^= PostedAt.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (reversalAmount_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ReversalAmount);
      }
      if (HostReferenceNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(HostReferenceNumber);
      }
      if (Result != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Result);
      }
      if (postedAt_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PostedAt);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reversalAmount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReversalAmount);
      }
      if (HostReferenceNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HostReferenceNumber);
      }
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (postedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostedAt);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PaymentCardAuthorizationReversal other) {
      if (other == null) {
        return;
      }
      if (other.reversalAmount_ != null) {
        if (reversalAmount_ == null) {
          reversalAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        ReversalAmount.MergeFrom(other.ReversalAmount);
      }
      if (other.HostReferenceNumber.Length != 0) {
        HostReferenceNumber = other.HostReferenceNumber;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.postedAt_ != null) {
        if (postedAt_ == null) {
          postedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        PostedAt.MergeFrom(other.PostedAt);
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
            if (reversalAmount_ == null) {
              reversalAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(reversalAmount_);
            break;
          }
          case 18: {
            HostReferenceNumber = input.ReadString();
            break;
          }
          case 24: {
            result_ = (global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult) input.ReadEnum();
            break;
          }
          case 34: {
            if (postedAt_ == null) {
              postedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(postedAt_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/folio_card_refund.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/folio_card_refund.proto</summary>
  public static partial class FolioCardRefundReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/folio_card_refund.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FolioCardRefundReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1mb2xpby9mb2xpb19jYXJkX3JlZnVuZC5wcm90bxIRaG9sbXMudHlwZXMu",
            "Zm9saW8aJGZvbGlvL2ZvbGlvX2d1ZXN0X3BheW1lbnRfY2FyZC5wcm90bxof",
            "Z29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxogaWFtL3N0YWZmX21l",
            "bWJlcl9pbmRpY2F0b3IucHJvdG8aMG1vbmV5L2NhcmRzL3RyYW5zYWN0aW9u",
            "cy9jYXJkX3JlZnVuZF9zdGF0ZS5wcm90bxo8bW9uZXkvY2FyZHMvdHJhbnNh",
            "Y3Rpb25zL3BheW1lbnRfY2FyZF9yZWZ1bmRfaW5kaWNhdG9yLnByb3RvGh9w",
            "cmltaXRpdmUvbW9uZXRhcnlfYW1vdW50LnByb3RvIoMDCg9Gb2xpb0NhcmRS",
            "ZWZ1bmQSNgoEY2FyZBgBIAEoCzIoLmhvbG1zLnR5cGVzLmZvbGlvLkZvbGlv",
            "R3Vlc3RQYXltZW50Q2FyZBJECgVzdGF0ZRgCIAEoDjI1LmhvbG1zLnR5cGVz",
            "Lm1vbmV5LmNhcmRzLnRyYW5zYWN0aW9ucy5DYXJkUmVmdW5kU3RhdGUSNQoG",
            "YW1vdW50GAMgASgLMiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5",
            "QW1vdW50Ei0KCXBvc3RlZF9hdBgEIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5U",
            "aW1lc3RhbXASOgoLcmVjZWl2ZWRfYnkYBSABKAsyJS5ob2xtcy50eXBlcy5p",
            "YW0uU3RhZmZNZW1iZXJJbmRpY2F0b3ISUAoGcmVmdW5kGAYgASgLMkAuaG9s",
            "bXMudHlwZXMubW9uZXkuY2FyZHMudHJhbnNhY3Rpb25zLlBheW1lbnRDYXJk",
            "UmVmdW5kSW5kaWNhdG9yQhSqAhFIT0xNUy5UeXBlcy5Gb2xpb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Folio.FolioGuestPaymentCardReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.IAM.StaffMemberIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.CardRefundStateReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.FolioCardRefund), global::HOLMS.Types.Folio.FolioCardRefund.Parser, new[]{ "Card", "State", "Amount", "PostedAt", "ReceivedBy", "Refund" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FolioCardRefund : pb::IMessage<FolioCardRefund> {
    private static readonly pb::MessageParser<FolioCardRefund> _parser = new pb::MessageParser<FolioCardRefund>(() => new FolioCardRefund());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FolioCardRefund> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.FolioCardRefundReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCardRefund() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCardRefund(FolioCardRefund other) : this() {
      Card = other.card_ != null ? other.Card.Clone() : null;
      state_ = other.state_;
      Amount = other.amount_ != null ? other.Amount.Clone() : null;
      PostedAt = other.postedAt_ != null ? other.PostedAt.Clone() : null;
      ReceivedBy = other.receivedBy_ != null ? other.ReceivedBy.Clone() : null;
      Refund = other.refund_ != null ? other.Refund.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCardRefund Clone() {
      return new FolioCardRefund(this);
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 1;
    private global::HOLMS.Types.Folio.FolioGuestPaymentCard card_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.FolioGuestPaymentCard Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 2;
    private global::HOLMS.Types.Money.Cards.Transactions.CardRefundState state_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.CardRefundState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 3;
    private global::HOLMS.Types.Primitive.MonetaryAmount amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Amount {
      get { return amount_; }
      set {
        amount_ = value;
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

    /// <summary>Field number for the "received_by" field.</summary>
    public const int ReceivedByFieldNumber = 5;
    private global::HOLMS.Types.IAM.StaffMemberIndicator receivedBy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.StaffMemberIndicator ReceivedBy {
      get { return receivedBy_; }
      set {
        receivedBy_ = value;
      }
    }

    /// <summary>Field number for the "refund" field.</summary>
    public const int RefundFieldNumber = 6;
    private global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator refund_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator Refund {
      get { return refund_; }
      set {
        refund_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FolioCardRefund);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FolioCardRefund other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Card, other.Card)) return false;
      if (State != other.State) return false;
      if (!object.Equals(Amount, other.Amount)) return false;
      if (!object.Equals(PostedAt, other.PostedAt)) return false;
      if (!object.Equals(ReceivedBy, other.ReceivedBy)) return false;
      if (!object.Equals(Refund, other.Refund)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (card_ != null) hash ^= Card.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
      if (amount_ != null) hash ^= Amount.GetHashCode();
      if (postedAt_ != null) hash ^= PostedAt.GetHashCode();
      if (receivedBy_ != null) hash ^= ReceivedBy.GetHashCode();
      if (refund_ != null) hash ^= Refund.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (card_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Card);
      }
      if (State != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (amount_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Amount);
      }
      if (postedAt_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PostedAt);
      }
      if (receivedBy_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ReceivedBy);
      }
      if (refund_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Refund);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (card_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Card);
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (amount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Amount);
      }
      if (postedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostedAt);
      }
      if (receivedBy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReceivedBy);
      }
      if (refund_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Refund);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FolioCardRefund other) {
      if (other == null) {
        return;
      }
      if (other.card_ != null) {
        if (card_ == null) {
          card_ = new global::HOLMS.Types.Folio.FolioGuestPaymentCard();
        }
        Card.MergeFrom(other.Card);
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.amount_ != null) {
        if (amount_ == null) {
          amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Amount.MergeFrom(other.Amount);
      }
      if (other.postedAt_ != null) {
        if (postedAt_ == null) {
          postedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        PostedAt.MergeFrom(other.PostedAt);
      }
      if (other.receivedBy_ != null) {
        if (receivedBy_ == null) {
          receivedBy_ = new global::HOLMS.Types.IAM.StaffMemberIndicator();
        }
        ReceivedBy.MergeFrom(other.ReceivedBy);
      }
      if (other.refund_ != null) {
        if (refund_ == null) {
          refund_ = new global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator();
        }
        Refund.MergeFrom(other.Refund);
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
            if (card_ == null) {
              card_ = new global::HOLMS.Types.Folio.FolioGuestPaymentCard();
            }
            input.ReadMessage(card_);
            break;
          }
          case 16: {
            state_ = (global::HOLMS.Types.Money.Cards.Transactions.CardRefundState) input.ReadEnum();
            break;
          }
          case 26: {
            if (amount_ == null) {
              amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(amount_);
            break;
          }
          case 34: {
            if (postedAt_ == null) {
              postedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(postedAt_);
            break;
          }
          case 42: {
            if (receivedBy_ == null) {
              receivedBy_ = new global::HOLMS.Types.IAM.StaffMemberIndicator();
            }
            input.ReadMessage(receivedBy_);
            break;
          }
          case 50: {
            if (refund_ == null) {
              refund_ = new global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator();
            }
            input.ReadMessage(refund_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

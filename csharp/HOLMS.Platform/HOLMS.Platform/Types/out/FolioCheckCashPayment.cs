// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/fsv2/folio_check_cash_payment.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio.FSv2 {

  /// <summary>Holder for reflection information generated from folio/fsv2/folio_check_cash_payment.proto</summary>
  public static partial class FolioCheckCashPaymentReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/fsv2/folio_check_cash_payment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FolioCheckCashPaymentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilmb2xpby9mc3YyL2ZvbGlvX2NoZWNrX2Nhc2hfcGF5bWVudC5wcm90bxIW",
            "aG9sbXMudHlwZXMuZm9saW8uZnN2MhoYZm9saW8vcGF5bWVudF90eXBlLnBy",
            "b3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGiBpYW0vc3Rh",
            "ZmZfbWVtYmVyX2luZGljYXRvci5wcm90bxofcHJpbWl0aXZlL21vbmV0YXJ5",
            "X2Ftb3VudC5wcm90byKEAgoVRm9saW9DaGVja0Nhc2hQYXltZW50EjUKBmFt",
            "b3VudBgBIAEoCzIlLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFt",
            "b3VudBITCgtpc19jYW5jZWxlZBgCIAEoCBI0CgxwYXltZW50X3R5cGUYAyAB",
            "KA4yHi5ob2xtcy50eXBlcy5mb2xpby5QYXltZW50VHlwZRI6CgtyZWNlaXZl",
            "ZF9ieRgEIAEoCzIlLmhvbG1zLnR5cGVzLmlhbS5TdGFmZk1lbWJlckluZGlj",
            "YXRvchItCglwb3N0ZWRfYXQYBSABKAsyGi5nb29nbGUucHJvdG9idWYuVGlt",
            "ZXN0YW1wQhmqAhZIT0xNUy5UeXBlcy5Gb2xpby5GU3YyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Folio.PaymentTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.IAM.StaffMemberIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.FSv2.FolioCheckCashPayment), global::HOLMS.Types.Folio.FSv2.FolioCheckCashPayment.Parser, new[]{ "Amount", "IsCanceled", "PaymentType", "ReceivedBy", "PostedAt" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FolioCheckCashPayment : pb::IMessage<FolioCheckCashPayment> {
    private static readonly pb::MessageParser<FolioCheckCashPayment> _parser = new pb::MessageParser<FolioCheckCashPayment>(() => new FolioCheckCashPayment());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FolioCheckCashPayment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.FSv2.FolioCheckCashPaymentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCheckCashPayment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCheckCashPayment(FolioCheckCashPayment other) : this() {
      Amount = other.amount_ != null ? other.Amount.Clone() : null;
      isCanceled_ = other.isCanceled_;
      paymentType_ = other.paymentType_;
      ReceivedBy = other.receivedBy_ != null ? other.ReceivedBy.Clone() : null;
      PostedAt = other.postedAt_ != null ? other.PostedAt.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCheckCashPayment Clone() {
      return new FolioCheckCashPayment(this);
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 1;
    private global::HOLMS.Types.Primitive.MonetaryAmount amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "is_canceled" field.</summary>
    public const int IsCanceledFieldNumber = 2;
    private bool isCanceled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsCanceled {
      get { return isCanceled_; }
      set {
        isCanceled_ = value;
      }
    }

    /// <summary>Field number for the "payment_type" field.</summary>
    public const int PaymentTypeFieldNumber = 3;
    private global::HOLMS.Types.Folio.PaymentType paymentType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.PaymentType PaymentType {
      get { return paymentType_; }
      set {
        paymentType_ = value;
      }
    }

    /// <summary>Field number for the "received_by" field.</summary>
    public const int ReceivedByFieldNumber = 4;
    private global::HOLMS.Types.IAM.StaffMemberIndicator receivedBy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.StaffMemberIndicator ReceivedBy {
      get { return receivedBy_; }
      set {
        receivedBy_ = value;
      }
    }

    /// <summary>Field number for the "posted_at" field.</summary>
    public const int PostedAtFieldNumber = 5;
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
      return Equals(other as FolioCheckCashPayment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FolioCheckCashPayment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Amount, other.Amount)) return false;
      if (IsCanceled != other.IsCanceled) return false;
      if (PaymentType != other.PaymentType) return false;
      if (!object.Equals(ReceivedBy, other.ReceivedBy)) return false;
      if (!object.Equals(PostedAt, other.PostedAt)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (amount_ != null) hash ^= Amount.GetHashCode();
      if (IsCanceled != false) hash ^= IsCanceled.GetHashCode();
      if (PaymentType != 0) hash ^= PaymentType.GetHashCode();
      if (receivedBy_ != null) hash ^= ReceivedBy.GetHashCode();
      if (postedAt_ != null) hash ^= PostedAt.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (amount_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Amount);
      }
      if (IsCanceled != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsCanceled);
      }
      if (PaymentType != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) PaymentType);
      }
      if (receivedBy_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ReceivedBy);
      }
      if (postedAt_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PostedAt);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (amount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Amount);
      }
      if (IsCanceled != false) {
        size += 1 + 1;
      }
      if (PaymentType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PaymentType);
      }
      if (receivedBy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReceivedBy);
      }
      if (postedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostedAt);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FolioCheckCashPayment other) {
      if (other == null) {
        return;
      }
      if (other.amount_ != null) {
        if (amount_ == null) {
          amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Amount.MergeFrom(other.Amount);
      }
      if (other.IsCanceled != false) {
        IsCanceled = other.IsCanceled;
      }
      if (other.PaymentType != 0) {
        PaymentType = other.PaymentType;
      }
      if (other.receivedBy_ != null) {
        if (receivedBy_ == null) {
          receivedBy_ = new global::HOLMS.Types.IAM.StaffMemberIndicator();
        }
        ReceivedBy.MergeFrom(other.ReceivedBy);
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
            if (amount_ == null) {
              amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(amount_);
            break;
          }
          case 16: {
            IsCanceled = input.ReadBool();
            break;
          }
          case 24: {
            paymentType_ = (global::HOLMS.Types.Folio.PaymentType) input.ReadEnum();
            break;
          }
          case 34: {
            if (receivedBy_ == null) {
              receivedBy_ = new global::HOLMS.Types.IAM.StaffMemberIndicator();
            }
            input.ReadMessage(receivedBy_);
            break;
          }
          case 42: {
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
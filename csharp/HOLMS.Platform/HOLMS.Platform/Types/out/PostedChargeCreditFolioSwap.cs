// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/folio/posted_charge_credit_folio_swap.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Folio {

  /// <summary>Holder for reflection information generated from money/folio/posted_charge_credit_folio_swap.proto</summary>
  public static partial class PostedChargeCreditFolioSwapReflection {

    #region Descriptor
    /// <summary>File descriptor for money/folio/posted_charge_credit_folio_swap.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PostedChargeCreditFolioSwapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFtb25leS9mb2xpby9wb3N0ZWRfY2hhcmdlX2NyZWRpdF9mb2xpb19zd2Fw",
            "LnByb3RvEhdob2xtcy50eXBlcy5tb25leS5mb2xpbxouYm9va2luZy9pbmRp",
            "Y2F0b3JzL3Jlc2VydmF0aW9uX2luZGljYXRvci5wcm90bxofcHJpbWl0aXZl",
            "L21vbmV0YXJ5X2Ftb3VudC5wcm90byK6AQobUG9zdGVkQ2hhcmdlQ3JlZGl0",
            "Rm9saW9Td2FwEhMKC2Rlc2NyaXB0aW9uGAEgASgJEjUKBmFtb3VudBgCIAEo",
            "CzIlLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudBJPChFv",
            "cmlnaW5hdGluZ19mb2xpbxgDIAEoCzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcu",
            "aW5kaWNhdG9ycy5SZXNlcnZhdGlvbkluZGljYXRvckInWgttb25leS9mb2xp",
            "b6oCF0hPTE1TLlR5cGVzLk1vbmV5LkZvbGlvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Folio.PostedChargeCreditFolioSwap), global::HOLMS.Types.Money.Folio.PostedChargeCreditFolioSwap.Parser, new[]{ "Description", "Amount", "OriginatingFolio" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PostedChargeCreditFolioSwap : pb::IMessage<PostedChargeCreditFolioSwap> {
    private static readonly pb::MessageParser<PostedChargeCreditFolioSwap> _parser = new pb::MessageParser<PostedChargeCreditFolioSwap>(() => new PostedChargeCreditFolioSwap());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostedChargeCreditFolioSwap> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Folio.PostedChargeCreditFolioSwapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedChargeCreditFolioSwap() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedChargeCreditFolioSwap(PostedChargeCreditFolioSwap other) : this() {
      description_ = other.description_;
      Amount = other.amount_ != null ? other.Amount.Clone() : null;
      OriginatingFolio = other.originatingFolio_ != null ? other.OriginatingFolio.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedChargeCreditFolioSwap Clone() {
      return new PostedChargeCreditFolioSwap(this);
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 1;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "originating_folio" field.</summary>
    public const int OriginatingFolioFieldNumber = 3;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator originatingFolio_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator OriginatingFolio {
      get { return originatingFolio_; }
      set {
        originatingFolio_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostedChargeCreditFolioSwap);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostedChargeCreditFolioSwap other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Description != other.Description) return false;
      if (!object.Equals(Amount, other.Amount)) return false;
      if (!object.Equals(OriginatingFolio, other.OriginatingFolio)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (amount_ != null) hash ^= Amount.GetHashCode();
      if (originatingFolio_ != null) hash ^= OriginatingFolio.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Description.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Description);
      }
      if (amount_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Amount);
      }
      if (originatingFolio_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OriginatingFolio);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (amount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Amount);
      }
      if (originatingFolio_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OriginatingFolio);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostedChargeCreditFolioSwap other) {
      if (other == null) {
        return;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.amount_ != null) {
        if (amount_ == null) {
          amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Amount.MergeFrom(other.Amount);
      }
      if (other.originatingFolio_ != null) {
        if (originatingFolio_ == null) {
          originatingFolio_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        OriginatingFolio.MergeFrom(other.OriginatingFolio);
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
            Description = input.ReadString();
            break;
          }
          case 18: {
            if (amount_ == null) {
              amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(amount_);
            break;
          }
          case 26: {
            if (originatingFolio_ == null) {
              originatingFolio_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(originatingFolio_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
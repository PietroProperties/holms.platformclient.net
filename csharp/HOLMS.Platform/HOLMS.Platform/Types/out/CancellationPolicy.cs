// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/cancellation_policy.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking {

  /// <summary>Holder for reflection information generated from booking/cancellation_policy.proto</summary>
  public static partial class CancellationPolicyReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/cancellation_policy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CancellationPolicyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFib29raW5nL2NhbmNlbGxhdGlvbl9wb2xpY3kucHJvdG8SE2hvbG1zLnR5",
            "cGVzLmJvb2tpbmcaNmJvb2tpbmcvaW5kaWNhdG9ycy9jYW5jZWxsYXRpb25f",
            "cG9saWN5X2luZGljYXRvci5wcm90bxonYm9va2luZy9jYW5jZWxsYXRpb25f",
            "ZmVlX2NhdGVnb3J5LnByb3RvGiFwcmltaXRpdmUvZml4ZWRfcG9pbnRfcmF0",
            "aW8ucHJvdG8aH3ByaW1pdGl2ZS9tb25ldGFyeV9hbW91bnQucHJvdG8ihwMK",
            "EkNhbmNlbGxhdGlvblBvbGljeRJOCgllbnRpdHlfaWQYASABKAsyOy5ob2xt",
            "cy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuQ2FuY2VsbGF0aW9uUG9saWN5",
            "SW5kaWNhdG9yEhMKC2Rlc2NyaXB0aW9uGAIgASgJEhcKD25vX3BlbmFsdHlf",
            "ZGF5cxgDIAEoBRJCCgxmZWVfY2F0ZWdvcnkYBCABKA4yLC5ob2xtcy50eXBl",
            "cy5ib29raW5nLkNhbmNlbGxhdGlvbkZlZUNhdGVnb3J5EkYKF2NhbmNlbGxh",
            "dGlvbl9mZWVfYW1vdW50GAUgASgLMiUuaG9sbXMudHlwZXMucHJpbWl0aXZl",
            "Lk1vbmV0YXJ5QW1vdW50EkUKFWNhbmNlbGxhdGlvbl9mZWVfcmF0ZRgGIAEo",
            "CzImLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5GaXhlZFBvaW50UmF0aW8SIAoY",
            "Y2FuY2VsbGF0aW9uX3BvbGljeV90ZXh0GAcgASgJQh9aB2Jvb2tpbmeqAhNI",
            "T0xNUy5UeXBlcy5Cb29raW5nYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.CancellationFeeCategoryReflection.Descriptor, global::HOLMS.Types.Primitive.FixedPointRatioReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.CancellationPolicy), global::HOLMS.Types.Booking.CancellationPolicy.Parser, new[]{ "EntityId", "Description", "NoPenaltyDays", "FeeCategory", "CancellationFeeAmount", "CancellationFeeRate", "CancellationPolicyText" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CancellationPolicy : pb::IMessage<CancellationPolicy> {
    private static readonly pb::MessageParser<CancellationPolicy> _parser = new pb::MessageParser<CancellationPolicy>(() => new CancellationPolicy());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CancellationPolicy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.CancellationPolicyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancellationPolicy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancellationPolicy(CancellationPolicy other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      description_ = other.description_;
      noPenaltyDays_ = other.noPenaltyDays_;
      feeCategory_ = other.feeCategory_;
      CancellationFeeAmount = other.cancellationFeeAmount_ != null ? other.CancellationFeeAmount.Clone() : null;
      CancellationFeeRate = other.cancellationFeeRate_ != null ? other.CancellationFeeRate.Clone() : null;
      cancellationPolicyText_ = other.cancellationPolicyText_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancellationPolicy Clone() {
      return new CancellationPolicy(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "no_penalty_days" field.</summary>
    public const int NoPenaltyDaysFieldNumber = 3;
    private int noPenaltyDays_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NoPenaltyDays {
      get { return noPenaltyDays_; }
      set {
        noPenaltyDays_ = value;
      }
    }

    /// <summary>Field number for the "fee_category" field.</summary>
    public const int FeeCategoryFieldNumber = 4;
    private global::HOLMS.Types.Booking.CancellationFeeCategory feeCategory_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.CancellationFeeCategory FeeCategory {
      get { return feeCategory_; }
      set {
        feeCategory_ = value;
      }
    }

    /// <summary>Field number for the "cancellation_fee_amount" field.</summary>
    public const int CancellationFeeAmountFieldNumber = 5;
    private global::HOLMS.Types.Primitive.MonetaryAmount cancellationFeeAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount CancellationFeeAmount {
      get { return cancellationFeeAmount_; }
      set {
        cancellationFeeAmount_ = value;
      }
    }

    /// <summary>Field number for the "cancellation_fee_rate" field.</summary>
    public const int CancellationFeeRateFieldNumber = 6;
    private global::HOLMS.Types.Primitive.FixedPointRatio cancellationFeeRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.FixedPointRatio CancellationFeeRate {
      get { return cancellationFeeRate_; }
      set {
        cancellationFeeRate_ = value;
      }
    }

    /// <summary>Field number for the "cancellation_policy_text" field.</summary>
    public const int CancellationPolicyTextFieldNumber = 7;
    private string cancellationPolicyText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CancellationPolicyText {
      get { return cancellationPolicyText_; }
      set {
        cancellationPolicyText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CancellationPolicy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CancellationPolicy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Description != other.Description) return false;
      if (NoPenaltyDays != other.NoPenaltyDays) return false;
      if (FeeCategory != other.FeeCategory) return false;
      if (!object.Equals(CancellationFeeAmount, other.CancellationFeeAmount)) return false;
      if (!object.Equals(CancellationFeeRate, other.CancellationFeeRate)) return false;
      if (CancellationPolicyText != other.CancellationPolicyText) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (NoPenaltyDays != 0) hash ^= NoPenaltyDays.GetHashCode();
      if (FeeCategory != 0) hash ^= FeeCategory.GetHashCode();
      if (cancellationFeeAmount_ != null) hash ^= CancellationFeeAmount.GetHashCode();
      if (cancellationFeeRate_ != null) hash ^= CancellationFeeRate.GetHashCode();
      if (CancellationPolicyText.Length != 0) hash ^= CancellationPolicyText.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (entityId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EntityId);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (NoPenaltyDays != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NoPenaltyDays);
      }
      if (FeeCategory != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) FeeCategory);
      }
      if (cancellationFeeAmount_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CancellationFeeAmount);
      }
      if (cancellationFeeRate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CancellationFeeRate);
      }
      if (CancellationPolicyText.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(CancellationPolicyText);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (NoPenaltyDays != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NoPenaltyDays);
      }
      if (FeeCategory != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FeeCategory);
      }
      if (cancellationFeeAmount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CancellationFeeAmount);
      }
      if (cancellationFeeRate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CancellationFeeRate);
      }
      if (CancellationPolicyText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CancellationPolicyText);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CancellationPolicy other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.NoPenaltyDays != 0) {
        NoPenaltyDays = other.NoPenaltyDays;
      }
      if (other.FeeCategory != 0) {
        FeeCategory = other.FeeCategory;
      }
      if (other.cancellationFeeAmount_ != null) {
        if (cancellationFeeAmount_ == null) {
          cancellationFeeAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        CancellationFeeAmount.MergeFrom(other.CancellationFeeAmount);
      }
      if (other.cancellationFeeRate_ != null) {
        if (cancellationFeeRate_ == null) {
          cancellationFeeRate_ = new global::HOLMS.Types.Primitive.FixedPointRatio();
        }
        CancellationFeeRate.MergeFrom(other.CancellationFeeRate);
      }
      if (other.CancellationPolicyText.Length != 0) {
        CancellationPolicyText = other.CancellationPolicyText;
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
            if (entityId_ == null) {
              entityId_ = new global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 24: {
            NoPenaltyDays = input.ReadInt32();
            break;
          }
          case 32: {
            feeCategory_ = (global::HOLMS.Types.Booking.CancellationFeeCategory) input.ReadEnum();
            break;
          }
          case 42: {
            if (cancellationFeeAmount_ == null) {
              cancellationFeeAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(cancellationFeeAmount_);
            break;
          }
          case 50: {
            if (cancellationFeeRate_ == null) {
              cancellationFeeRate_ = new global::HOLMS.Types.Primitive.FixedPointRatio();
            }
            input.ReadMessage(cancellationFeeRate_);
            break;
          }
          case 58: {
            CancellationPolicyText = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
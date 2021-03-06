// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/cards/card_sale_purpose.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Cards {

  /// <summary>Holder for reflection information generated from money/cards/card_sale_purpose.proto</summary>
  public static partial class CardSalePurposeReflection {

    #region Descriptor
    /// <summary>File descriptor for money/cards/card_sale_purpose.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CardSalePurposeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNtb25leS9jYXJkcy9jYXJkX3NhbGVfcHVycG9zZS5wcm90bxIXaG9sbXMu",
            "dHlwZXMubW9uZXkuY2FyZHMilQIKD0NhcmRTYWxlUHVycG9zZRIVCg1mb3Jf",
            "Z3VhcmFudGVlGAEgASgIEhkKEWZvcl9wYXltZW50X290aGVyGAIgASgIEhsK",
            "E2Zvcl9wYXltZW50X2xvZGdpbmcYAyABKAgSHgoWZm9yX3BheW1lbnRfcmVz",
            "dGF1cmFudBgEIAEoCBIdChVmb3JfcGF5bWVudF9naWZ0X3Nob3AYBSABKAgS",
            "GwoTZm9yX3BheW1lbnRfbWluaWJhchgGIAEoCBIdChVmb3JfcGF5bWVudF90",
            "ZWxlcGhvbmUYByABKAgSGwoTZm9yX3BheW1lbnRfbGF1bmRyeRgIIAEoCBIb",
            "ChNmb3JfcGF5bWVudF9wZW5hbHR5GAkgASgIQidaC21vbmV5L2NhcmRzqgIX",
            "SE9MTVMuVHlwZXMuTW9uZXkuQ2FyZHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Cards.CardSalePurpose), global::HOLMS.Types.Money.Cards.CardSalePurpose.Parser, new[]{ "ForGuarantee", "ForPaymentOther", "ForPaymentLodging", "ForPaymentRestaurant", "ForPaymentGiftShop", "ForPaymentMinibar", "ForPaymentTelephone", "ForPaymentLaundry", "ForPaymentPenalty" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CardSalePurpose : pb::IMessage<CardSalePurpose> {
    private static readonly pb::MessageParser<CardSalePurpose> _parser = new pb::MessageParser<CardSalePurpose>(() => new CardSalePurpose());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardSalePurpose> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Cards.CardSalePurposeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardSalePurpose() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardSalePurpose(CardSalePurpose other) : this() {
      forGuarantee_ = other.forGuarantee_;
      forPaymentOther_ = other.forPaymentOther_;
      forPaymentLodging_ = other.forPaymentLodging_;
      forPaymentRestaurant_ = other.forPaymentRestaurant_;
      forPaymentGiftShop_ = other.forPaymentGiftShop_;
      forPaymentMinibar_ = other.forPaymentMinibar_;
      forPaymentTelephone_ = other.forPaymentTelephone_;
      forPaymentLaundry_ = other.forPaymentLaundry_;
      forPaymentPenalty_ = other.forPaymentPenalty_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardSalePurpose Clone() {
      return new CardSalePurpose(this);
    }

    /// <summary>Field number for the "for_guarantee" field.</summary>
    public const int ForGuaranteeFieldNumber = 1;
    private bool forGuarantee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForGuarantee {
      get { return forGuarantee_; }
      set {
        forGuarantee_ = value;
      }
    }

    /// <summary>Field number for the "for_payment_other" field.</summary>
    public const int ForPaymentOtherFieldNumber = 2;
    private bool forPaymentOther_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForPaymentOther {
      get { return forPaymentOther_; }
      set {
        forPaymentOther_ = value;
      }
    }

    /// <summary>Field number for the "for_payment_lodging" field.</summary>
    public const int ForPaymentLodgingFieldNumber = 3;
    private bool forPaymentLodging_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForPaymentLodging {
      get { return forPaymentLodging_; }
      set {
        forPaymentLodging_ = value;
      }
    }

    /// <summary>Field number for the "for_payment_restaurant" field.</summary>
    public const int ForPaymentRestaurantFieldNumber = 4;
    private bool forPaymentRestaurant_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForPaymentRestaurant {
      get { return forPaymentRestaurant_; }
      set {
        forPaymentRestaurant_ = value;
      }
    }

    /// <summary>Field number for the "for_payment_gift_shop" field.</summary>
    public const int ForPaymentGiftShopFieldNumber = 5;
    private bool forPaymentGiftShop_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForPaymentGiftShop {
      get { return forPaymentGiftShop_; }
      set {
        forPaymentGiftShop_ = value;
      }
    }

    /// <summary>Field number for the "for_payment_minibar" field.</summary>
    public const int ForPaymentMinibarFieldNumber = 6;
    private bool forPaymentMinibar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForPaymentMinibar {
      get { return forPaymentMinibar_; }
      set {
        forPaymentMinibar_ = value;
      }
    }

    /// <summary>Field number for the "for_payment_telephone" field.</summary>
    public const int ForPaymentTelephoneFieldNumber = 7;
    private bool forPaymentTelephone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForPaymentTelephone {
      get { return forPaymentTelephone_; }
      set {
        forPaymentTelephone_ = value;
      }
    }

    /// <summary>Field number for the "for_payment_laundry" field.</summary>
    public const int ForPaymentLaundryFieldNumber = 8;
    private bool forPaymentLaundry_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForPaymentLaundry {
      get { return forPaymentLaundry_; }
      set {
        forPaymentLaundry_ = value;
      }
    }

    /// <summary>Field number for the "for_payment_penalty" field.</summary>
    public const int ForPaymentPenaltyFieldNumber = 9;
    private bool forPaymentPenalty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForPaymentPenalty {
      get { return forPaymentPenalty_; }
      set {
        forPaymentPenalty_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardSalePurpose);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardSalePurpose other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ForGuarantee != other.ForGuarantee) return false;
      if (ForPaymentOther != other.ForPaymentOther) return false;
      if (ForPaymentLodging != other.ForPaymentLodging) return false;
      if (ForPaymentRestaurant != other.ForPaymentRestaurant) return false;
      if (ForPaymentGiftShop != other.ForPaymentGiftShop) return false;
      if (ForPaymentMinibar != other.ForPaymentMinibar) return false;
      if (ForPaymentTelephone != other.ForPaymentTelephone) return false;
      if (ForPaymentLaundry != other.ForPaymentLaundry) return false;
      if (ForPaymentPenalty != other.ForPaymentPenalty) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ForGuarantee != false) hash ^= ForGuarantee.GetHashCode();
      if (ForPaymentOther != false) hash ^= ForPaymentOther.GetHashCode();
      if (ForPaymentLodging != false) hash ^= ForPaymentLodging.GetHashCode();
      if (ForPaymentRestaurant != false) hash ^= ForPaymentRestaurant.GetHashCode();
      if (ForPaymentGiftShop != false) hash ^= ForPaymentGiftShop.GetHashCode();
      if (ForPaymentMinibar != false) hash ^= ForPaymentMinibar.GetHashCode();
      if (ForPaymentTelephone != false) hash ^= ForPaymentTelephone.GetHashCode();
      if (ForPaymentLaundry != false) hash ^= ForPaymentLaundry.GetHashCode();
      if (ForPaymentPenalty != false) hash ^= ForPaymentPenalty.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ForGuarantee != false) {
        output.WriteRawTag(8);
        output.WriteBool(ForGuarantee);
      }
      if (ForPaymentOther != false) {
        output.WriteRawTag(16);
        output.WriteBool(ForPaymentOther);
      }
      if (ForPaymentLodging != false) {
        output.WriteRawTag(24);
        output.WriteBool(ForPaymentLodging);
      }
      if (ForPaymentRestaurant != false) {
        output.WriteRawTag(32);
        output.WriteBool(ForPaymentRestaurant);
      }
      if (ForPaymentGiftShop != false) {
        output.WriteRawTag(40);
        output.WriteBool(ForPaymentGiftShop);
      }
      if (ForPaymentMinibar != false) {
        output.WriteRawTag(48);
        output.WriteBool(ForPaymentMinibar);
      }
      if (ForPaymentTelephone != false) {
        output.WriteRawTag(56);
        output.WriteBool(ForPaymentTelephone);
      }
      if (ForPaymentLaundry != false) {
        output.WriteRawTag(64);
        output.WriteBool(ForPaymentLaundry);
      }
      if (ForPaymentPenalty != false) {
        output.WriteRawTag(72);
        output.WriteBool(ForPaymentPenalty);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ForGuarantee != false) {
        size += 1 + 1;
      }
      if (ForPaymentOther != false) {
        size += 1 + 1;
      }
      if (ForPaymentLodging != false) {
        size += 1 + 1;
      }
      if (ForPaymentRestaurant != false) {
        size += 1 + 1;
      }
      if (ForPaymentGiftShop != false) {
        size += 1 + 1;
      }
      if (ForPaymentMinibar != false) {
        size += 1 + 1;
      }
      if (ForPaymentTelephone != false) {
        size += 1 + 1;
      }
      if (ForPaymentLaundry != false) {
        size += 1 + 1;
      }
      if (ForPaymentPenalty != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardSalePurpose other) {
      if (other == null) {
        return;
      }
      if (other.ForGuarantee != false) {
        ForGuarantee = other.ForGuarantee;
      }
      if (other.ForPaymentOther != false) {
        ForPaymentOther = other.ForPaymentOther;
      }
      if (other.ForPaymentLodging != false) {
        ForPaymentLodging = other.ForPaymentLodging;
      }
      if (other.ForPaymentRestaurant != false) {
        ForPaymentRestaurant = other.ForPaymentRestaurant;
      }
      if (other.ForPaymentGiftShop != false) {
        ForPaymentGiftShop = other.ForPaymentGiftShop;
      }
      if (other.ForPaymentMinibar != false) {
        ForPaymentMinibar = other.ForPaymentMinibar;
      }
      if (other.ForPaymentTelephone != false) {
        ForPaymentTelephone = other.ForPaymentTelephone;
      }
      if (other.ForPaymentLaundry != false) {
        ForPaymentLaundry = other.ForPaymentLaundry;
      }
      if (other.ForPaymentPenalty != false) {
        ForPaymentPenalty = other.ForPaymentPenalty;
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
            ForGuarantee = input.ReadBool();
            break;
          }
          case 16: {
            ForPaymentOther = input.ReadBool();
            break;
          }
          case 24: {
            ForPaymentLodging = input.ReadBool();
            break;
          }
          case 32: {
            ForPaymentRestaurant = input.ReadBool();
            break;
          }
          case 40: {
            ForPaymentGiftShop = input.ReadBool();
            break;
          }
          case 48: {
            ForPaymentMinibar = input.ReadBool();
            break;
          }
          case 56: {
            ForPaymentTelephone = input.ReadBool();
            break;
          }
          case 64: {
            ForPaymentLaundry = input.ReadBool();
            break;
          }
          case 72: {
            ForPaymentPenalty = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

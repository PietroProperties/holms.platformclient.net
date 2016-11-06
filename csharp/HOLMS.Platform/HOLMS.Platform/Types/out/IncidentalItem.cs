// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/incidental_items/incidental_item.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.IncidentalItems {

  /// <summary>Holder for reflection information generated from supply/incidental_items/incidental_item.proto</summary>
  public static partial class IncidentalItemReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/incidental_items/incidental_item.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IncidentalItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1zdXBwbHkvaW5jaWRlbnRhbF9pdGVtcy9pbmNpZGVudGFsX2l0ZW0ucHJv",
            "dG8SI2hvbG1zLnR5cGVzLnN1cHBseS5pbmNpZGVudGFsX2l0ZW1zGh9wcmlt",
            "aXRpdmUvbW9uZXRhcnlfYW1vdW50LnByb3RvGihtb25leS9hY2NvdW50aW5n",
            "L2FjY291bnRfaW5kaWNhdG9yLnByb3RvGjdzdXBwbHkvaW5jaWRlbnRhbF9p",
            "dGVtcy9pbmNpZGVudGFsX2l0ZW1faW5kaWNhdG9yLnByb3RvGjNzdXBwbHkv",
            "aW5jaWRlbnRhbF9pdGVtcy9pdGVtX2NoYXJnZV9mcmVxdWVuY3kucHJvdG8i",
            "iwMKDkluY2lkZW50YWxJdGVtEk8KCWVudGl0eV9pZBgBIAEoCzI8LmhvbG1z",
            "LnR5cGVzLnN1cHBseS5pbmNpZGVudGFsX2l0ZW1zLkluY2lkZW50YWxJdGVt",
            "SW5kaWNhdG9yEhMKC2Rlc2NyaXB0aW9uGAIgASgJEhUKDXF1YW5pdHlfb3du",
            "ZWQYAyABKA0SNAoFcHJpY2UYBCABKAsyJS5ob2xtcy50eXBlcy5wcmltaXRp",
            "dmUuTW9uZXRhcnlBbW91bnQSFAoMaW5jdXJzX3RheGVzGAUgASgIEhMKC2lu",
            "Y3Vyc19mZWVzGAYgASgIElIKEGNoYXJnZV9mcmVxdWVuY3kYByABKA4yOC5o",
            "b2xtcy50eXBlcy5zdXBwbHkuaW5jaWRlbnRhbF9pdGVtcy5JdGVtQ2hhcmdl",
            "RnJlcXVlbmN5EkcKD3JldmVudWVfYWNjb3VudBgIIAEoCzIuLmhvbG1zLnR5",
            "cGVzLm1vbmV5LmFjY291bnRpbmcuQWNjb3VudEluZGljYXRvckI9WhZzdXBw",
            "bHkvaW5jaWRlbnRhbGl0ZW1zqgIiSE9MTVMuVHlwZXMuU3VwcGx5LkluY2lk",
            "ZW50YWxJdGVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Money.Accounting.AccountIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.IncidentalItems.ItemChargeFrequencyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.IncidentalItems.IncidentalItem), global::HOLMS.Types.Supply.IncidentalItems.IncidentalItem.Parser, new[]{ "EntityId", "Description", "QuanityOwned", "Price", "IncursTaxes", "IncursFees", "ChargeFrequency", "RevenueAccount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IncidentalItem : pb::IMessage<IncidentalItem> {
    private static readonly pb::MessageParser<IncidentalItem> _parser = new pb::MessageParser<IncidentalItem>(() => new IncidentalItem());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IncidentalItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncidentalItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncidentalItem(IncidentalItem other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      description_ = other.description_;
      quanityOwned_ = other.quanityOwned_;
      Price = other.price_ != null ? other.Price.Clone() : null;
      incursTaxes_ = other.incursTaxes_;
      incursFees_ = other.incursFees_;
      chargeFrequency_ = other.chargeFrequency_;
      RevenueAccount = other.revenueAccount_ != null ? other.RevenueAccount.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncidentalItem Clone() {
      return new IncidentalItem(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator EntityId {
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

    /// <summary>Field number for the "quanity_owned" field.</summary>
    public const int QuanityOwnedFieldNumber = 3;
    private uint quanityOwned_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint QuanityOwned {
      get { return quanityOwned_; }
      set {
        quanityOwned_ = value;
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 4;
    private global::HOLMS.Types.Primitive.MonetaryAmount price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "incurs_taxes" field.</summary>
    public const int IncursTaxesFieldNumber = 5;
    private bool incursTaxes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IncursTaxes {
      get { return incursTaxes_; }
      set {
        incursTaxes_ = value;
      }
    }

    /// <summary>Field number for the "incurs_fees" field.</summary>
    public const int IncursFeesFieldNumber = 6;
    private bool incursFees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IncursFees {
      get { return incursFees_; }
      set {
        incursFees_ = value;
      }
    }

    /// <summary>Field number for the "charge_frequency" field.</summary>
    public const int ChargeFrequencyFieldNumber = 7;
    private global::HOLMS.Types.Supply.IncidentalItems.ItemChargeFrequency chargeFrequency_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.IncidentalItems.ItemChargeFrequency ChargeFrequency {
      get { return chargeFrequency_; }
      set {
        chargeFrequency_ = value;
      }
    }

    /// <summary>Field number for the "revenue_account" field.</summary>
    public const int RevenueAccountFieldNumber = 8;
    private global::HOLMS.Types.Money.Accounting.AccountIndicator revenueAccount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Accounting.AccountIndicator RevenueAccount {
      get { return revenueAccount_; }
      set {
        revenueAccount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IncidentalItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IncidentalItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Description != other.Description) return false;
      if (QuanityOwned != other.QuanityOwned) return false;
      if (!object.Equals(Price, other.Price)) return false;
      if (IncursTaxes != other.IncursTaxes) return false;
      if (IncursFees != other.IncursFees) return false;
      if (ChargeFrequency != other.ChargeFrequency) return false;
      if (!object.Equals(RevenueAccount, other.RevenueAccount)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (QuanityOwned != 0) hash ^= QuanityOwned.GetHashCode();
      if (price_ != null) hash ^= Price.GetHashCode();
      if (IncursTaxes != false) hash ^= IncursTaxes.GetHashCode();
      if (IncursFees != false) hash ^= IncursFees.GetHashCode();
      if (ChargeFrequency != 0) hash ^= ChargeFrequency.GetHashCode();
      if (revenueAccount_ != null) hash ^= RevenueAccount.GetHashCode();
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
      if (QuanityOwned != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(QuanityOwned);
      }
      if (price_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Price);
      }
      if (IncursTaxes != false) {
        output.WriteRawTag(40);
        output.WriteBool(IncursTaxes);
      }
      if (IncursFees != false) {
        output.WriteRawTag(48);
        output.WriteBool(IncursFees);
      }
      if (ChargeFrequency != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) ChargeFrequency);
      }
      if (revenueAccount_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RevenueAccount);
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
      if (QuanityOwned != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuanityOwned);
      }
      if (price_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Price);
      }
      if (IncursTaxes != false) {
        size += 1 + 1;
      }
      if (IncursFees != false) {
        size += 1 + 1;
      }
      if (ChargeFrequency != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChargeFrequency);
      }
      if (revenueAccount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RevenueAccount);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IncidentalItem other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.QuanityOwned != 0) {
        QuanityOwned = other.QuanityOwned;
      }
      if (other.price_ != null) {
        if (price_ == null) {
          price_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Price.MergeFrom(other.Price);
      }
      if (other.IncursTaxes != false) {
        IncursTaxes = other.IncursTaxes;
      }
      if (other.IncursFees != false) {
        IncursFees = other.IncursFees;
      }
      if (other.ChargeFrequency != 0) {
        ChargeFrequency = other.ChargeFrequency;
      }
      if (other.revenueAccount_ != null) {
        if (revenueAccount_ == null) {
          revenueAccount_ = new global::HOLMS.Types.Money.Accounting.AccountIndicator();
        }
        RevenueAccount.MergeFrom(other.RevenueAccount);
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
              entityId_ = new global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 24: {
            QuanityOwned = input.ReadUInt32();
            break;
          }
          case 34: {
            if (price_ == null) {
              price_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(price_);
            break;
          }
          case 40: {
            IncursTaxes = input.ReadBool();
            break;
          }
          case 48: {
            IncursFees = input.ReadBool();
            break;
          }
          case 56: {
            chargeFrequency_ = (global::HOLMS.Types.Supply.IncidentalItems.ItemChargeFrequency) input.ReadEnum();
            break;
          }
          case 66: {
            if (revenueAccount_ == null) {
              revenueAccount_ = new global::HOLMS.Types.Money.Accounting.AccountIndicator();
            }
            input.ReadMessage(revenueAccount_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
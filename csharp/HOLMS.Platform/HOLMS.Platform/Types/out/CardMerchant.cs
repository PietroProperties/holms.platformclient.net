// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/cards/card_merchant.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Cards {

  /// <summary>Holder for reflection information generated from money/cards/card_merchant.proto</summary>
  public static partial class CardMerchantReflection {

    #region Descriptor
    /// <summary>File descriptor for money/cards/card_merchant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CardMerchantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9tb25leS9jYXJkcy9jYXJkX21lcmNoYW50LnByb3RvEhdob2xtcy50eXBl",
            "cy5tb25leS5jYXJkcxopbW9uZXkvY2FyZHMvY2FyZF9tZXJjaGFudF9pbmRp",
            "Y2F0b3IucHJvdG8aKm1vbmV5L2NhcmRzL2NhcmRfcHJvY2Vzc29yX2luZGlj",
            "YXRvci5wcm90byK6AwoMQ2FyZE1lcmNoYW50EkEKCWVudGl0eV9pZBgBIAEo",
            "CzIuLmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLkNhcmRNZXJjaGFudEluZGlj",
            "YXRvchIMCgRuYW1lGAIgASgJEkcKDmNhcmRfcHJvY2Vzc29yGAMgASgOMi8u",
            "aG9sbXMudHlwZXMubW9uZXkuY2FyZHMuQ2FyZFByb2Nlc3NvckluZGljYXRv",
            "chIWCg5jYXJkX2FncmVlbWVudBgEIAEoCRISCgpsaWNlbnNlX2lkGAUgASgF",
            "Eg8KB3NpdGVfaWQYBiABKAUSEQoJZGV2aWNlX2lkGAcgASgFEhAKCHVzZXJu",
            "YW1lGAggASgJEhAKCHBhc3N3b3JkGAkgASgJEhUKDXNlcnZpY2VfdV9yX2kY",
            "CiABKAkSHQoVZGVidWdfbG9nZ2luZ19lbmFibGVkGAsgASgIEhwKFHBvcnRp",
            "Y29fZGV2ZWxvcGVyX2lkGAwgASgJEh4KFnBvcnRpY29fdmVyc2lvbl9udW1i",
            "ZXIYDSABKAkSKAogc3VwcHJlc3NfYXV0aG9yaXphdGlvbnNfaW5fZm9saW8Y",
            "DiABKAhCJ1oLbW9uZXkvY2FyZHOqAhdIT0xNUy5UeXBlcy5Nb25leS5DYXJk",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Money.Cards.CardMerchantIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.CardProcessorIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Cards.CardMerchant), global::HOLMS.Types.Money.Cards.CardMerchant.Parser, new[]{ "EntityId", "Name", "CardProcessor", "CardAgreement", "LicenseId", "SiteId", "DeviceId", "Username", "Password", "ServiceURI", "DebugLoggingEnabled", "PorticoDeveloperId", "PorticoVersionNumber", "SuppressAuthorizationsInFolio" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CardMerchant : pb::IMessage<CardMerchant> {
    private static readonly pb::MessageParser<CardMerchant> _parser = new pb::MessageParser<CardMerchant>(() => new CardMerchant());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardMerchant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Cards.CardMerchantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardMerchant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardMerchant(CardMerchant other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      name_ = other.name_;
      cardProcessor_ = other.cardProcessor_;
      cardAgreement_ = other.cardAgreement_;
      licenseId_ = other.licenseId_;
      siteId_ = other.siteId_;
      deviceId_ = other.deviceId_;
      username_ = other.username_;
      password_ = other.password_;
      serviceURI_ = other.serviceURI_;
      debugLoggingEnabled_ = other.debugLoggingEnabled_;
      porticoDeveloperId_ = other.porticoDeveloperId_;
      porticoVersionNumber_ = other.porticoVersionNumber_;
      suppressAuthorizationsInFolio_ = other.suppressAuthorizationsInFolio_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardMerchant Clone() {
      return new CardMerchant(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Money.Cards.CardMerchantIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.CardMerchantIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "card_processor" field.</summary>
    public const int CardProcessorFieldNumber = 3;
    private global::HOLMS.Types.Money.Cards.CardProcessorIndicator cardProcessor_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.CardProcessorIndicator CardProcessor {
      get { return cardProcessor_; }
      set {
        cardProcessor_ = value;
      }
    }

    /// <summary>Field number for the "card_agreement" field.</summary>
    public const int CardAgreementFieldNumber = 4;
    private string cardAgreement_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CardAgreement {
      get { return cardAgreement_; }
      set {
        cardAgreement_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "license_id" field.</summary>
    public const int LicenseIdFieldNumber = 5;
    private int licenseId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LicenseId {
      get { return licenseId_; }
      set {
        licenseId_ = value;
      }
    }

    /// <summary>Field number for the "site_id" field.</summary>
    public const int SiteIdFieldNumber = 6;
    private int siteId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SiteId {
      get { return siteId_; }
      set {
        siteId_ = value;
      }
    }

    /// <summary>Field number for the "device_id" field.</summary>
    public const int DeviceIdFieldNumber = 7;
    private int deviceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = value;
      }
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 8;
    private string username_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 9;
    private string password_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "service_u_r_i" field.</summary>
    public const int ServiceURIFieldNumber = 10;
    private string serviceURI_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ServiceURI {
      get { return serviceURI_; }
      set {
        serviceURI_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "debug_logging_enabled" field.</summary>
    public const int DebugLoggingEnabledFieldNumber = 11;
    private bool debugLoggingEnabled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DebugLoggingEnabled {
      get { return debugLoggingEnabled_; }
      set {
        debugLoggingEnabled_ = value;
      }
    }

    /// <summary>Field number for the "portico_developer_id" field.</summary>
    public const int PorticoDeveloperIdFieldNumber = 12;
    private string porticoDeveloperId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PorticoDeveloperId {
      get { return porticoDeveloperId_; }
      set {
        porticoDeveloperId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "portico_version_number" field.</summary>
    public const int PorticoVersionNumberFieldNumber = 13;
    private string porticoVersionNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PorticoVersionNumber {
      get { return porticoVersionNumber_; }
      set {
        porticoVersionNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "suppress_authorizations_in_folio" field.</summary>
    public const int SuppressAuthorizationsInFolioFieldNumber = 14;
    private bool suppressAuthorizationsInFolio_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SuppressAuthorizationsInFolio {
      get { return suppressAuthorizationsInFolio_; }
      set {
        suppressAuthorizationsInFolio_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardMerchant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardMerchant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Name != other.Name) return false;
      if (CardProcessor != other.CardProcessor) return false;
      if (CardAgreement != other.CardAgreement) return false;
      if (LicenseId != other.LicenseId) return false;
      if (SiteId != other.SiteId) return false;
      if (DeviceId != other.DeviceId) return false;
      if (Username != other.Username) return false;
      if (Password != other.Password) return false;
      if (ServiceURI != other.ServiceURI) return false;
      if (DebugLoggingEnabled != other.DebugLoggingEnabled) return false;
      if (PorticoDeveloperId != other.PorticoDeveloperId) return false;
      if (PorticoVersionNumber != other.PorticoVersionNumber) return false;
      if (SuppressAuthorizationsInFolio != other.SuppressAuthorizationsInFolio) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (CardProcessor != 0) hash ^= CardProcessor.GetHashCode();
      if (CardAgreement.Length != 0) hash ^= CardAgreement.GetHashCode();
      if (LicenseId != 0) hash ^= LicenseId.GetHashCode();
      if (SiteId != 0) hash ^= SiteId.GetHashCode();
      if (DeviceId != 0) hash ^= DeviceId.GetHashCode();
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      if (ServiceURI.Length != 0) hash ^= ServiceURI.GetHashCode();
      if (DebugLoggingEnabled != false) hash ^= DebugLoggingEnabled.GetHashCode();
      if (PorticoDeveloperId.Length != 0) hash ^= PorticoDeveloperId.GetHashCode();
      if (PorticoVersionNumber.Length != 0) hash ^= PorticoVersionNumber.GetHashCode();
      if (SuppressAuthorizationsInFolio != false) hash ^= SuppressAuthorizationsInFolio.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (CardProcessor != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CardProcessor);
      }
      if (CardAgreement.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CardAgreement);
      }
      if (LicenseId != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(LicenseId);
      }
      if (SiteId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(SiteId);
      }
      if (DeviceId != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(DeviceId);
      }
      if (Username.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Username);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Password);
      }
      if (ServiceURI.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(ServiceURI);
      }
      if (DebugLoggingEnabled != false) {
        output.WriteRawTag(88);
        output.WriteBool(DebugLoggingEnabled);
      }
      if (PorticoDeveloperId.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(PorticoDeveloperId);
      }
      if (PorticoVersionNumber.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(PorticoVersionNumber);
      }
      if (SuppressAuthorizationsInFolio != false) {
        output.WriteRawTag(112);
        output.WriteBool(SuppressAuthorizationsInFolio);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (CardProcessor != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CardProcessor);
      }
      if (CardAgreement.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CardAgreement);
      }
      if (LicenseId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LicenseId);
      }
      if (SiteId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SiteId);
      }
      if (DeviceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DeviceId);
      }
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      if (ServiceURI.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServiceURI);
      }
      if (DebugLoggingEnabled != false) {
        size += 1 + 1;
      }
      if (PorticoDeveloperId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PorticoDeveloperId);
      }
      if (PorticoVersionNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PorticoVersionNumber);
      }
      if (SuppressAuthorizationsInFolio != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardMerchant other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Money.Cards.CardMerchantIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.CardProcessor != 0) {
        CardProcessor = other.CardProcessor;
      }
      if (other.CardAgreement.Length != 0) {
        CardAgreement = other.CardAgreement;
      }
      if (other.LicenseId != 0) {
        LicenseId = other.LicenseId;
      }
      if (other.SiteId != 0) {
        SiteId = other.SiteId;
      }
      if (other.DeviceId != 0) {
        DeviceId = other.DeviceId;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
      if (other.ServiceURI.Length != 0) {
        ServiceURI = other.ServiceURI;
      }
      if (other.DebugLoggingEnabled != false) {
        DebugLoggingEnabled = other.DebugLoggingEnabled;
      }
      if (other.PorticoDeveloperId.Length != 0) {
        PorticoDeveloperId = other.PorticoDeveloperId;
      }
      if (other.PorticoVersionNumber.Length != 0) {
        PorticoVersionNumber = other.PorticoVersionNumber;
      }
      if (other.SuppressAuthorizationsInFolio != false) {
        SuppressAuthorizationsInFolio = other.SuppressAuthorizationsInFolio;
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
              entityId_ = new global::HOLMS.Types.Money.Cards.CardMerchantIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            cardProcessor_ = (global::HOLMS.Types.Money.Cards.CardProcessorIndicator) input.ReadEnum();
            break;
          }
          case 34: {
            CardAgreement = input.ReadString();
            break;
          }
          case 40: {
            LicenseId = input.ReadInt32();
            break;
          }
          case 48: {
            SiteId = input.ReadInt32();
            break;
          }
          case 56: {
            DeviceId = input.ReadInt32();
            break;
          }
          case 66: {
            Username = input.ReadString();
            break;
          }
          case 74: {
            Password = input.ReadString();
            break;
          }
          case 82: {
            ServiceURI = input.ReadString();
            break;
          }
          case 88: {
            DebugLoggingEnabled = input.ReadBool();
            break;
          }
          case 98: {
            PorticoDeveloperId = input.ReadString();
            break;
          }
          case 106: {
            PorticoVersionNumber = input.ReadString();
            break;
          }
          case 112: {
            SuppressAuthorizationsInFolio = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/channel_manager_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/channel_manager_config.proto</summary>
  public static partial class ChannelManagerConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/channel_manager_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelManagerConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cit0ZW5hbmN5X2NvbmZpZy9jaGFubmVsX21hbmFnZXJfY29uZmlnLnByb3Rv",
            "Ehpob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZyKlAgoUQ2hhbm5lbE1hbmFn",
            "ZXJDb25maWcSFAoMcHJvdmlkZXJfaV9kGAEgASgJEhoKEnByb3ZpZGVyX3Vz",
            "ZXJfbmFtZRgCIAEoCRIZChFwcm92aWRlcl9wYXNzd29yZBgDIAEoCRIRCglo",
            "b3RlbF9pX2QYBCABKAkSKAogZGV2X2Rpc2FibGVfYm9va2luZ19jb25maXJt",
            "YXRpb24YBSABKAgSJwofZGlzYWJsZV9jaGFubmVsX3N5bmNocm9uaXphdGlv",
            "bhgGIAEoCBIcChRkaXNhYmxlX2NhbmNlbGxhdGlvbhgHIAEoCBIZChFkaXNh",
            "YmxlX2FtZW5kbWVudBgIIAEoCBIhChllbmFibGVfcHJpY2luZ19jb25uZWN0",
            "aW9uGAkgASgIQitaDXRlbmFuY3ljb25maWeqAhlIT0xNUy5UeXBlcy5UZW5h",
            "bmN5Q29uZmlnYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.ChannelManagerConfig), global::HOLMS.Types.TenancyConfig.ChannelManagerConfig.Parser, new[]{ "ProviderID", "ProviderUserName", "ProviderPassword", "HotelID", "DevDisableBookingConfirmation", "DisableChannelSynchronization", "DisableCancellation", "DisableAmendment", "EnablePricingConnection" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChannelManagerConfig : pb::IMessage<ChannelManagerConfig> {
    private static readonly pb::MessageParser<ChannelManagerConfig> _parser = new pb::MessageParser<ChannelManagerConfig>(() => new ChannelManagerConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChannelManagerConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.ChannelManagerConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChannelManagerConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChannelManagerConfig(ChannelManagerConfig other) : this() {
      providerID_ = other.providerID_;
      providerUserName_ = other.providerUserName_;
      providerPassword_ = other.providerPassword_;
      hotelID_ = other.hotelID_;
      devDisableBookingConfirmation_ = other.devDisableBookingConfirmation_;
      disableChannelSynchronization_ = other.disableChannelSynchronization_;
      disableCancellation_ = other.disableCancellation_;
      disableAmendment_ = other.disableAmendment_;
      enablePricingConnection_ = other.enablePricingConnection_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChannelManagerConfig Clone() {
      return new ChannelManagerConfig(this);
    }

    /// <summary>Field number for the "provider_i_d" field.</summary>
    public const int ProviderIDFieldNumber = 1;
    private string providerID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProviderID {
      get { return providerID_; }
      set {
        providerID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "provider_user_name" field.</summary>
    public const int ProviderUserNameFieldNumber = 2;
    private string providerUserName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProviderUserName {
      get { return providerUserName_; }
      set {
        providerUserName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "provider_password" field.</summary>
    public const int ProviderPasswordFieldNumber = 3;
    private string providerPassword_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProviderPassword {
      get { return providerPassword_; }
      set {
        providerPassword_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hotel_i_d" field.</summary>
    public const int HotelIDFieldNumber = 4;
    private string hotelID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HotelID {
      get { return hotelID_; }
      set {
        hotelID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dev_disable_booking_confirmation" field.</summary>
    public const int DevDisableBookingConfirmationFieldNumber = 5;
    private bool devDisableBookingConfirmation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DevDisableBookingConfirmation {
      get { return devDisableBookingConfirmation_; }
      set {
        devDisableBookingConfirmation_ = value;
      }
    }

    /// <summary>Field number for the "disable_channel_synchronization" field.</summary>
    public const int DisableChannelSynchronizationFieldNumber = 6;
    private bool disableChannelSynchronization_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DisableChannelSynchronization {
      get { return disableChannelSynchronization_; }
      set {
        disableChannelSynchronization_ = value;
      }
    }

    /// <summary>Field number for the "disable_cancellation" field.</summary>
    public const int DisableCancellationFieldNumber = 7;
    private bool disableCancellation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DisableCancellation {
      get { return disableCancellation_; }
      set {
        disableCancellation_ = value;
      }
    }

    /// <summary>Field number for the "disable_amendment" field.</summary>
    public const int DisableAmendmentFieldNumber = 8;
    private bool disableAmendment_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DisableAmendment {
      get { return disableAmendment_; }
      set {
        disableAmendment_ = value;
      }
    }

    /// <summary>Field number for the "enable_pricing_connection" field.</summary>
    public const int EnablePricingConnectionFieldNumber = 9;
    private bool enablePricingConnection_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnablePricingConnection {
      get { return enablePricingConnection_; }
      set {
        enablePricingConnection_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChannelManagerConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChannelManagerConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProviderID != other.ProviderID) return false;
      if (ProviderUserName != other.ProviderUserName) return false;
      if (ProviderPassword != other.ProviderPassword) return false;
      if (HotelID != other.HotelID) return false;
      if (DevDisableBookingConfirmation != other.DevDisableBookingConfirmation) return false;
      if (DisableChannelSynchronization != other.DisableChannelSynchronization) return false;
      if (DisableCancellation != other.DisableCancellation) return false;
      if (DisableAmendment != other.DisableAmendment) return false;
      if (EnablePricingConnection != other.EnablePricingConnection) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProviderID.Length != 0) hash ^= ProviderID.GetHashCode();
      if (ProviderUserName.Length != 0) hash ^= ProviderUserName.GetHashCode();
      if (ProviderPassword.Length != 0) hash ^= ProviderPassword.GetHashCode();
      if (HotelID.Length != 0) hash ^= HotelID.GetHashCode();
      if (DevDisableBookingConfirmation != false) hash ^= DevDisableBookingConfirmation.GetHashCode();
      if (DisableChannelSynchronization != false) hash ^= DisableChannelSynchronization.GetHashCode();
      if (DisableCancellation != false) hash ^= DisableCancellation.GetHashCode();
      if (DisableAmendment != false) hash ^= DisableAmendment.GetHashCode();
      if (EnablePricingConnection != false) hash ^= EnablePricingConnection.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ProviderID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProviderID);
      }
      if (ProviderUserName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProviderUserName);
      }
      if (ProviderPassword.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProviderPassword);
      }
      if (HotelID.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(HotelID);
      }
      if (DevDisableBookingConfirmation != false) {
        output.WriteRawTag(40);
        output.WriteBool(DevDisableBookingConfirmation);
      }
      if (DisableChannelSynchronization != false) {
        output.WriteRawTag(48);
        output.WriteBool(DisableChannelSynchronization);
      }
      if (DisableCancellation != false) {
        output.WriteRawTag(56);
        output.WriteBool(DisableCancellation);
      }
      if (DisableAmendment != false) {
        output.WriteRawTag(64);
        output.WriteBool(DisableAmendment);
      }
      if (EnablePricingConnection != false) {
        output.WriteRawTag(72);
        output.WriteBool(EnablePricingConnection);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProviderID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProviderID);
      }
      if (ProviderUserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProviderUserName);
      }
      if (ProviderPassword.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProviderPassword);
      }
      if (HotelID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HotelID);
      }
      if (DevDisableBookingConfirmation != false) {
        size += 1 + 1;
      }
      if (DisableChannelSynchronization != false) {
        size += 1 + 1;
      }
      if (DisableCancellation != false) {
        size += 1 + 1;
      }
      if (DisableAmendment != false) {
        size += 1 + 1;
      }
      if (EnablePricingConnection != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChannelManagerConfig other) {
      if (other == null) {
        return;
      }
      if (other.ProviderID.Length != 0) {
        ProviderID = other.ProviderID;
      }
      if (other.ProviderUserName.Length != 0) {
        ProviderUserName = other.ProviderUserName;
      }
      if (other.ProviderPassword.Length != 0) {
        ProviderPassword = other.ProviderPassword;
      }
      if (other.HotelID.Length != 0) {
        HotelID = other.HotelID;
      }
      if (other.DevDisableBookingConfirmation != false) {
        DevDisableBookingConfirmation = other.DevDisableBookingConfirmation;
      }
      if (other.DisableChannelSynchronization != false) {
        DisableChannelSynchronization = other.DisableChannelSynchronization;
      }
      if (other.DisableCancellation != false) {
        DisableCancellation = other.DisableCancellation;
      }
      if (other.DisableAmendment != false) {
        DisableAmendment = other.DisableAmendment;
      }
      if (other.EnablePricingConnection != false) {
        EnablePricingConnection = other.EnablePricingConnection;
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
            ProviderID = input.ReadString();
            break;
          }
          case 18: {
            ProviderUserName = input.ReadString();
            break;
          }
          case 26: {
            ProviderPassword = input.ReadString();
            break;
          }
          case 34: {
            HotelID = input.ReadString();
            break;
          }
          case 40: {
            DevDisableBookingConfirmation = input.ReadBool();
            break;
          }
          case 48: {
            DisableChannelSynchronization = input.ReadBool();
            break;
          }
          case 56: {
            DisableCancellation = input.ReadBool();
            break;
          }
          case 64: {
            DisableAmendment = input.ReadBool();
            break;
          }
          case 72: {
            EnablePricingConnection = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

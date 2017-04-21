// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/property_email_sender_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/property_email_sender_config.proto</summary>
  public static partial class PropertyEmailSenderConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/property_email_sender_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PropertyEmailSenderConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjF0ZW5hbmN5X2NvbmZpZy9wcm9wZXJ0eV9lbWFpbF9zZW5kZXJfY29uZmln",
            "LnByb3RvEhpob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZxoydGVuYW5jeV9j",
            "b25maWcvaW5kaWNhdG9ycy9wcm9wZXJ0eV9pbmRpY2F0b3IucHJvdG8i0gEK",
            "GVByb3BlcnR5RW1haWxTZW5kZXJDb25maWcSSgoIcHJvcGVydHkYASABKAsy",
            "OC5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5pbmRpY2F0b3JzLlByb3Bl",
            "cnR5SW5kaWNhdG9yEiUKHXBvc3RtYXJrX2VtYWlsX3NlbmRlcl9hZGRyZXNz",
            "GAIgASgJEhgKEHBvc3RtYXJrX2FwaV9rZXkYAyABKAkSKAogZGlzYWJsZV9h",
            "dXRvbWF0ZWRfY29ycmVzcG9uZGVuY2UYBCABKAhCHKoCGUhPTE1TLlR5cGVz",
            "LlRlbmFuY3lDb25maWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.PropertyEmailSenderConfig), global::HOLMS.Types.TenancyConfig.PropertyEmailSenderConfig.Parser, new[]{ "Property", "PostmarkEmailSenderAddress", "PostmarkApiKey", "DisableAutomatedCorrespondence" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PropertyEmailSenderConfig : pb::IMessage<PropertyEmailSenderConfig> {
    private static readonly pb::MessageParser<PropertyEmailSenderConfig> _parser = new pb::MessageParser<PropertyEmailSenderConfig>(() => new PropertyEmailSenderConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PropertyEmailSenderConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.PropertyEmailSenderConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyEmailSenderConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyEmailSenderConfig(PropertyEmailSenderConfig other) : this() {
      Property = other.property_ != null ? other.Property.Clone() : null;
      postmarkEmailSenderAddress_ = other.postmarkEmailSenderAddress_;
      postmarkApiKey_ = other.postmarkApiKey_;
      disableAutomatedCorrespondence_ = other.disableAutomatedCorrespondence_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyEmailSenderConfig Clone() {
      return new PropertyEmailSenderConfig(this);
    }

    /// <summary>Field number for the "property" field.</summary>
    public const int PropertyFieldNumber = 1;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator property_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator Property {
      get { return property_; }
      set {
        property_ = value;
      }
    }

    /// <summary>Field number for the "postmark_email_sender_address" field.</summary>
    public const int PostmarkEmailSenderAddressFieldNumber = 2;
    private string postmarkEmailSenderAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PostmarkEmailSenderAddress {
      get { return postmarkEmailSenderAddress_; }
      set {
        postmarkEmailSenderAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "postmark_api_key" field.</summary>
    public const int PostmarkApiKeyFieldNumber = 3;
    private string postmarkApiKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PostmarkApiKey {
      get { return postmarkApiKey_; }
      set {
        postmarkApiKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "disable_automated_correspondence" field.</summary>
    public const int DisableAutomatedCorrespondenceFieldNumber = 4;
    private bool disableAutomatedCorrespondence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DisableAutomatedCorrespondence {
      get { return disableAutomatedCorrespondence_; }
      set {
        disableAutomatedCorrespondence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PropertyEmailSenderConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PropertyEmailSenderConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Property, other.Property)) return false;
      if (PostmarkEmailSenderAddress != other.PostmarkEmailSenderAddress) return false;
      if (PostmarkApiKey != other.PostmarkApiKey) return false;
      if (DisableAutomatedCorrespondence != other.DisableAutomatedCorrespondence) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (property_ != null) hash ^= Property.GetHashCode();
      if (PostmarkEmailSenderAddress.Length != 0) hash ^= PostmarkEmailSenderAddress.GetHashCode();
      if (PostmarkApiKey.Length != 0) hash ^= PostmarkApiKey.GetHashCode();
      if (DisableAutomatedCorrespondence != false) hash ^= DisableAutomatedCorrespondence.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (property_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Property);
      }
      if (PostmarkEmailSenderAddress.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PostmarkEmailSenderAddress);
      }
      if (PostmarkApiKey.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PostmarkApiKey);
      }
      if (DisableAutomatedCorrespondence != false) {
        output.WriteRawTag(32);
        output.WriteBool(DisableAutomatedCorrespondence);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (property_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Property);
      }
      if (PostmarkEmailSenderAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PostmarkEmailSenderAddress);
      }
      if (PostmarkApiKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PostmarkApiKey);
      }
      if (DisableAutomatedCorrespondence != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PropertyEmailSenderConfig other) {
      if (other == null) {
        return;
      }
      if (other.property_ != null) {
        if (property_ == null) {
          property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        Property.MergeFrom(other.Property);
      }
      if (other.PostmarkEmailSenderAddress.Length != 0) {
        PostmarkEmailSenderAddress = other.PostmarkEmailSenderAddress;
      }
      if (other.PostmarkApiKey.Length != 0) {
        PostmarkApiKey = other.PostmarkApiKey;
      }
      if (other.DisableAutomatedCorrespondence != false) {
        DisableAutomatedCorrespondence = other.DisableAutomatedCorrespondence;
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
            if (property_ == null) {
              property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(property_);
            break;
          }
          case 18: {
            PostmarkEmailSenderAddress = input.ReadString();
            break;
          }
          case 26: {
            PostmarkApiKey = input.ReadString();
            break;
          }
          case 32: {
            DisableAutomatedCorrespondence = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

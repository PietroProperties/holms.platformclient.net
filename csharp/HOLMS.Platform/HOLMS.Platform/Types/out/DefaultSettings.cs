// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/default_settings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/default_settings.proto</summary>
  public static partial class DefaultSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/default_settings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DefaultSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiV0ZW5hbmN5X2NvbmZpZy9kZWZhdWx0X3NldHRpbmdzLnByb3RvEhpob2xt",
            "cy50eXBlcy50ZW5hbmN5X2NvbmZpZxo6dGVuYW5jeV9jb25maWcvaW5kaWNh",
            "dG9ycy9kZWZhdWx0X3NldHRpbmdzX2luZGljYXRvci5wcm90byKDAQoPRGVm",
            "YXVsdFNldHRpbmdzEksKAmlkGAEgASgLMj8uaG9sbXMudHlwZXMudGVuYW5j",
            "eV9jb25maWcuaW5kaWNhdG9ycy5EZWZhdWx0U2V0dGluZ3NJbmRpY2F0b3IS",
            "FAoMZGlzcGxheV90ZXh0GAIgASgJEg0KBXZhbHVlGAMgASgJQitaDXRlbmFu",
            "Y3ljb25maWeqAhlIT0xNUy5UeXBlcy5UZW5hbmN5Q29uZmlnYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.TenancyConfig.Indicators.DefaultSettingsIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.DefaultSettings), global::HOLMS.Types.TenancyConfig.DefaultSettings.Parser, new[]{ "Id", "DisplayText", "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DefaultSettings : pb::IMessage<DefaultSettings> {
    private static readonly pb::MessageParser<DefaultSettings> _parser = new pb::MessageParser<DefaultSettings>(() => new DefaultSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DefaultSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.DefaultSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DefaultSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DefaultSettings(DefaultSettings other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
      displayText_ = other.displayText_;
      value_ = other.value_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DefaultSettings Clone() {
      return new DefaultSettings(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::HOLMS.Types.TenancyConfig.Indicators.DefaultSettingsIndicator id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.DefaultSettingsIndicator Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "display_text" field.</summary>
    public const int DisplayTextFieldNumber = 2;
    private string displayText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayText {
      get { return displayText_; }
      set {
        displayText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 3;
    private string value_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DefaultSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DefaultSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if (DisplayText != other.DisplayText) return false;
      if (Value != other.Value) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (DisplayText.Length != 0) hash ^= DisplayText.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
      if (DisplayText.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayText);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      if (DisplayText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayText);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DefaultSettings other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::HOLMS.Types.TenancyConfig.Indicators.DefaultSettingsIndicator();
        }
        Id.MergeFrom(other.Id);
      }
      if (other.DisplayText.Length != 0) {
        DisplayText = other.DisplayText;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
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
            if (id_ == null) {
              id_ = new global::HOLMS.Types.TenancyConfig.Indicators.DefaultSettingsIndicator();
            }
            input.ReadMessage(id_);
            break;
          }
          case 18: {
            DisplayText = input.ReadString();
            break;
          }
          case 26: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

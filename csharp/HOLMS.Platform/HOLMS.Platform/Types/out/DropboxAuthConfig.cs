// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/dropbox_auth_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/dropbox_auth_config.proto</summary>
  public static partial class DropboxAuthConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/dropbox_auth_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DropboxAuthConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cih0ZW5hbmN5X2NvbmZpZy9kcm9wYm94X2F1dGhfY29uZmlnLnByb3RvEhpo",
            "b2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZyJQChREcm9wYm94Q29uZmlndXJh",
            "dGlvbhIYChBoYXNfYWNjZXNzX3Rva2VuGAEgASgIEh4KFnB1YmxpY19hcHBs",
            "aWNhdGlvbl9rZXkYAiABKAlCHKoCGUhPTE1TLlR5cGVzLlRlbmFuY3lDb25m",
            "aWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.DropboxConfiguration), global::HOLMS.Types.TenancyConfig.DropboxConfiguration.Parser, new[]{ "HasAccessToken", "PublicApplicationKey" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DropboxConfiguration : pb::IMessage<DropboxConfiguration> {
    private static readonly pb::MessageParser<DropboxConfiguration> _parser = new pb::MessageParser<DropboxConfiguration>(() => new DropboxConfiguration());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DropboxConfiguration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.DropboxAuthConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DropboxConfiguration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DropboxConfiguration(DropboxConfiguration other) : this() {
      hasAccessToken_ = other.hasAccessToken_;
      publicApplicationKey_ = other.publicApplicationKey_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DropboxConfiguration Clone() {
      return new DropboxConfiguration(this);
    }

    /// <summary>Field number for the "has_access_token" field.</summary>
    public const int HasAccessTokenFieldNumber = 1;
    private bool hasAccessToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAccessToken {
      get { return hasAccessToken_; }
      set {
        hasAccessToken_ = value;
      }
    }

    /// <summary>Field number for the "public_application_key" field.</summary>
    public const int PublicApplicationKeyFieldNumber = 2;
    private string publicApplicationKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PublicApplicationKey {
      get { return publicApplicationKey_; }
      set {
        publicApplicationKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DropboxConfiguration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DropboxConfiguration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HasAccessToken != other.HasAccessToken) return false;
      if (PublicApplicationKey != other.PublicApplicationKey) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasAccessToken != false) hash ^= HasAccessToken.GetHashCode();
      if (PublicApplicationKey.Length != 0) hash ^= PublicApplicationKey.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HasAccessToken != false) {
        output.WriteRawTag(8);
        output.WriteBool(HasAccessToken);
      }
      if (PublicApplicationKey.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PublicApplicationKey);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasAccessToken != false) {
        size += 1 + 1;
      }
      if (PublicApplicationKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PublicApplicationKey);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DropboxConfiguration other) {
      if (other == null) {
        return;
      }
      if (other.HasAccessToken != false) {
        HasAccessToken = other.HasAccessToken;
      }
      if (other.PublicApplicationKey.Length != 0) {
        PublicApplicationKey = other.PublicApplicationKey;
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
            HasAccessToken = input.ReadBool();
            break;
          }
          case 18: {
            PublicApplicationKey = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/iif_export_configuration.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/iif_export_configuration.proto</summary>
  public static partial class IifExportConfigurationReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/iif_export_configuration.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IifExportConfigurationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci10ZW5hbmN5X2NvbmZpZy9paWZfZXhwb3J0X2NvbmZpZ3VyYXRpb24ucHJv",
            "dG8SGmhvbG1zLnR5cGVzLnRlbmFuY3lfY29uZmlnIl0KFklJRkV4cG9ydENv",
            "bmZpZ3VyYXRpb24SHQoVcmVjdXJyZW5jZV9kZXNjcmlwdG9yGAEgASgJEiQK",
            "HGRpc2FibGVfYXNzZXRfYWNjb3VudF9leHBvcnQYAiABKAhCHKoCGUhPTE1T",
            "LlR5cGVzLlRlbmFuY3lDb25maWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.IIFExportConfiguration), global::HOLMS.Types.TenancyConfig.IIFExportConfiguration.Parser, new[]{ "RecurrenceDescriptor", "DisableAssetAccountExport" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IIFExportConfiguration : pb::IMessage<IIFExportConfiguration> {
    private static readonly pb::MessageParser<IIFExportConfiguration> _parser = new pb::MessageParser<IIFExportConfiguration>(() => new IIFExportConfiguration());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IIFExportConfiguration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.IifExportConfigurationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IIFExportConfiguration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IIFExportConfiguration(IIFExportConfiguration other) : this() {
      recurrenceDescriptor_ = other.recurrenceDescriptor_;
      disableAssetAccountExport_ = other.disableAssetAccountExport_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IIFExportConfiguration Clone() {
      return new IIFExportConfiguration(this);
    }

    /// <summary>Field number for the "recurrence_descriptor" field.</summary>
    public const int RecurrenceDescriptorFieldNumber = 1;
    private string recurrenceDescriptor_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RecurrenceDescriptor {
      get { return recurrenceDescriptor_; }
      set {
        recurrenceDescriptor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "disable_asset_account_export" field.</summary>
    public const int DisableAssetAccountExportFieldNumber = 2;
    private bool disableAssetAccountExport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DisableAssetAccountExport {
      get { return disableAssetAccountExport_; }
      set {
        disableAssetAccountExport_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IIFExportConfiguration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IIFExportConfiguration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RecurrenceDescriptor != other.RecurrenceDescriptor) return false;
      if (DisableAssetAccountExport != other.DisableAssetAccountExport) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RecurrenceDescriptor.Length != 0) hash ^= RecurrenceDescriptor.GetHashCode();
      if (DisableAssetAccountExport != false) hash ^= DisableAssetAccountExport.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RecurrenceDescriptor.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RecurrenceDescriptor);
      }
      if (DisableAssetAccountExport != false) {
        output.WriteRawTag(16);
        output.WriteBool(DisableAssetAccountExport);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RecurrenceDescriptor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RecurrenceDescriptor);
      }
      if (DisableAssetAccountExport != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IIFExportConfiguration other) {
      if (other == null) {
        return;
      }
      if (other.RecurrenceDescriptor.Length != 0) {
        RecurrenceDescriptor = other.RecurrenceDescriptor;
      }
      if (other.DisableAssetAccountExport != false) {
        DisableAssetAccountExport = other.DisableAssetAccountExport;
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
            RecurrenceDescriptor = input.ReadString();
            break;
          }
          case 16: {
            DisableAssetAccountExport = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

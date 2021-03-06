// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/miwa_encoder_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/miwa_encoder_config.proto</summary>
  public static partial class MiwaEncoderConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/miwa_encoder_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MiwaEncoderConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cih0ZW5hbmN5X2NvbmZpZy9taXdhX2VuY29kZXJfY29uZmlnLnByb3RvEhpo",
            "b2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZyJwChFNaXdhRW5jb2RlckNvbmZp",
            "ZxIhChlwb3N0X2NoZWNrb3V0X2dyYWNlX2hvdXJzGAEgASgNEh4KFm1pd2Ff",
            "c2VydmVyX2lwX2FkZHJlc3MYAiABKAkSGAoQbWl3YV9zZXJ2ZXJfcG9ydBgD",
            "IAEoDUIrWg10ZW5hbmN5Y29uZmlnqgIZSE9MTVMuVHlwZXMuVGVuYW5jeUNv",
            "bmZpZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.MiwaEncoderConfig), global::HOLMS.Types.TenancyConfig.MiwaEncoderConfig.Parser, new[]{ "PostCheckoutGraceHours", "MiwaServerIpAddress", "MiwaServerPort" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MiwaEncoderConfig : pb::IMessage<MiwaEncoderConfig> {
    private static readonly pb::MessageParser<MiwaEncoderConfig> _parser = new pb::MessageParser<MiwaEncoderConfig>(() => new MiwaEncoderConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MiwaEncoderConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.MiwaEncoderConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MiwaEncoderConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MiwaEncoderConfig(MiwaEncoderConfig other) : this() {
      postCheckoutGraceHours_ = other.postCheckoutGraceHours_;
      miwaServerIpAddress_ = other.miwaServerIpAddress_;
      miwaServerPort_ = other.miwaServerPort_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MiwaEncoderConfig Clone() {
      return new MiwaEncoderConfig(this);
    }

    /// <summary>Field number for the "post_checkout_grace_hours" field.</summary>
    public const int PostCheckoutGraceHoursFieldNumber = 1;
    private uint postCheckoutGraceHours_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint PostCheckoutGraceHours {
      get { return postCheckoutGraceHours_; }
      set {
        postCheckoutGraceHours_ = value;
      }
    }

    /// <summary>Field number for the "miwa_server_ip_address" field.</summary>
    public const int MiwaServerIpAddressFieldNumber = 2;
    private string miwaServerIpAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MiwaServerIpAddress {
      get { return miwaServerIpAddress_; }
      set {
        miwaServerIpAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "miwa_server_port" field.</summary>
    public const int MiwaServerPortFieldNumber = 3;
    private uint miwaServerPort_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint MiwaServerPort {
      get { return miwaServerPort_; }
      set {
        miwaServerPort_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MiwaEncoderConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MiwaEncoderConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PostCheckoutGraceHours != other.PostCheckoutGraceHours) return false;
      if (MiwaServerIpAddress != other.MiwaServerIpAddress) return false;
      if (MiwaServerPort != other.MiwaServerPort) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PostCheckoutGraceHours != 0) hash ^= PostCheckoutGraceHours.GetHashCode();
      if (MiwaServerIpAddress.Length != 0) hash ^= MiwaServerIpAddress.GetHashCode();
      if (MiwaServerPort != 0) hash ^= MiwaServerPort.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PostCheckoutGraceHours != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PostCheckoutGraceHours);
      }
      if (MiwaServerIpAddress.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MiwaServerIpAddress);
      }
      if (MiwaServerPort != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MiwaServerPort);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PostCheckoutGraceHours != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PostCheckoutGraceHours);
      }
      if (MiwaServerIpAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MiwaServerIpAddress);
      }
      if (MiwaServerPort != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MiwaServerPort);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MiwaEncoderConfig other) {
      if (other == null) {
        return;
      }
      if (other.PostCheckoutGraceHours != 0) {
        PostCheckoutGraceHours = other.PostCheckoutGraceHours;
      }
      if (other.MiwaServerIpAddress.Length != 0) {
        MiwaServerIpAddress = other.MiwaServerIpAddress;
      }
      if (other.MiwaServerPort != 0) {
        MiwaServerPort = other.MiwaServerPort;
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
            PostCheckoutGraceHours = input.ReadUInt32();
            break;
          }
          case 18: {
            MiwaServerIpAddress = input.ReadString();
            break;
          }
          case 24: {
            MiwaServerPort = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

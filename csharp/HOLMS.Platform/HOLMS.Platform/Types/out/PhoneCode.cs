// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/phone_code.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/phone_code.proto</summary>
  public static partial class PhoneCodeReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/phone_code.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PhoneCodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch90ZW5hbmN5X2NvbmZpZy9waG9uZV9jb2RlLnByb3RvEhpob2xtcy50eXBl",
            "cy50ZW5hbmN5X2NvbmZpZxoUcHJpbWl0aXZlL3V1aWQucHJvdG8iigEKCVBo",
            "b25lQ29kZRInCgJpZBgBIAEoCzIbLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5V",
            "dWlkEhQKDHBob25lX251bWJlchgCIAEoCRI+Cgh1c2VfY2FzZRgDIAEoDjIs",
            "LmhvbG1zLnR5cGVzLnRlbmFuY3lfY29uZmlnLlBob25lQ29kZVVzZUNhc2Uq",
            "RQoQUGhvbmVDb2RlVXNlQ2FzZRIXChNUT0xMX0ZSRUVfQVJFQV9DT0RFEAAS",
            "GAoURElSRUNUT1JZX0FTU0lTVEFOQ0UQAUIrWg10ZW5hbmN5Y29uZmlnqgIZ",
            "SE9MTVMuVHlwZXMuVGVuYW5jeUNvbmZpZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.UuidReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.TenancyConfig.PhoneCodeUseCase), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.PhoneCode), global::HOLMS.Types.TenancyConfig.PhoneCode.Parser, new[]{ "Id", "PhoneNumber", "UseCase" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum PhoneCodeUseCase {
    [pbr::OriginalName("TOLL_FREE_AREA_CODE")] TollFreeAreaCode = 0,
    [pbr::OriginalName("DIRECTORY_ASSISTANCE")] DirectoryAssistance = 1,
  }

  #endregion

  #region Messages
  public sealed partial class PhoneCode : pb::IMessage<PhoneCode> {
    private static readonly pb::MessageParser<PhoneCode> _parser = new pb::MessageParser<PhoneCode>(() => new PhoneCode());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PhoneCode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.PhoneCodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PhoneCode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PhoneCode(PhoneCode other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
      phoneNumber_ = other.phoneNumber_;
      useCase_ = other.useCase_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PhoneCode Clone() {
      return new PhoneCode(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::HOLMS.Types.Primitive.Uuid id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.Uuid Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "phone_number" field.</summary>
    public const int PhoneNumberFieldNumber = 2;
    private string phoneNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PhoneNumber {
      get { return phoneNumber_; }
      set {
        phoneNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "use_case" field.</summary>
    public const int UseCaseFieldNumber = 3;
    private global::HOLMS.Types.TenancyConfig.PhoneCodeUseCase useCase_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.PhoneCodeUseCase UseCase {
      get { return useCase_; }
      set {
        useCase_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PhoneCode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PhoneCode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if (PhoneNumber != other.PhoneNumber) return false;
      if (UseCase != other.UseCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (PhoneNumber.Length != 0) hash ^= PhoneNumber.GetHashCode();
      if (UseCase != 0) hash ^= UseCase.GetHashCode();
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
      if (PhoneNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PhoneNumber);
      }
      if (UseCase != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) UseCase);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      if (PhoneNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PhoneNumber);
      }
      if (UseCase != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UseCase);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PhoneCode other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::HOLMS.Types.Primitive.Uuid();
        }
        Id.MergeFrom(other.Id);
      }
      if (other.PhoneNumber.Length != 0) {
        PhoneNumber = other.PhoneNumber;
      }
      if (other.UseCase != 0) {
        UseCase = other.UseCase;
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
              id_ = new global::HOLMS.Types.Primitive.Uuid();
            }
            input.ReadMessage(id_);
            break;
          }
          case 18: {
            PhoneNumber = input.ReadString();
            break;
          }
          case 24: {
            useCase_ = (global::HOLMS.Types.TenancyConfig.PhoneCodeUseCase) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/hk_phone_codes.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/hk_phone_codes.proto</summary>
  public static partial class HkPhoneCodesReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/hk_phone_codes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HkPhoneCodesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiN0ZW5hbmN5X2NvbmZpZy9oa19waG9uZV9jb2Rlcy5wcm90bxIaaG9sbXMu",
            "dHlwZXMudGVuYW5jeV9jb25maWciiAEKDEhLUGhvbmVDb2RlcxIUCgxtYWlk",
            "X2luX3Jvb20YASABKAkSDwoHaW5zcGVjdBgCIAEoCRIgChhjbGVhbl9zaGVl",
            "dHNfbm90X2NoYW5nZWQYAyABKAkSIAoYY2xlYW5fYW5kX3NoZWV0c19jaGFu",
            "Z2VkGAQgASgJEg0KBWRpcnR5GAUgASgJQitaDXRlbmFuY3ljb25maWeqAhlI",
            "T0xNUy5UeXBlcy5UZW5hbmN5Q29uZmlnYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.HKPhoneCodes), global::HOLMS.Types.TenancyConfig.HKPhoneCodes.Parser, new[]{ "MaidInRoom", "Inspect", "CleanSheetsNotChanged", "CleanAndSheetsChanged", "Dirty" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HKPhoneCodes : pb::IMessage<HKPhoneCodes> {
    private static readonly pb::MessageParser<HKPhoneCodes> _parser = new pb::MessageParser<HKPhoneCodes>(() => new HKPhoneCodes());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HKPhoneCodes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.HkPhoneCodesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HKPhoneCodes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HKPhoneCodes(HKPhoneCodes other) : this() {
      maidInRoom_ = other.maidInRoom_;
      inspect_ = other.inspect_;
      cleanSheetsNotChanged_ = other.cleanSheetsNotChanged_;
      cleanAndSheetsChanged_ = other.cleanAndSheetsChanged_;
      dirty_ = other.dirty_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HKPhoneCodes Clone() {
      return new HKPhoneCodes(this);
    }

    /// <summary>Field number for the "maid_in_room" field.</summary>
    public const int MaidInRoomFieldNumber = 1;
    private string maidInRoom_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MaidInRoom {
      get { return maidInRoom_; }
      set {
        maidInRoom_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "inspect" field.</summary>
    public const int InspectFieldNumber = 2;
    private string inspect_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Inspect {
      get { return inspect_; }
      set {
        inspect_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "clean_sheets_not_changed" field.</summary>
    public const int CleanSheetsNotChangedFieldNumber = 3;
    private string cleanSheetsNotChanged_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CleanSheetsNotChanged {
      get { return cleanSheetsNotChanged_; }
      set {
        cleanSheetsNotChanged_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "clean_and_sheets_changed" field.</summary>
    public const int CleanAndSheetsChangedFieldNumber = 4;
    private string cleanAndSheetsChanged_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CleanAndSheetsChanged {
      get { return cleanAndSheetsChanged_; }
      set {
        cleanAndSheetsChanged_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dirty" field.</summary>
    public const int DirtyFieldNumber = 5;
    private string dirty_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Dirty {
      get { return dirty_; }
      set {
        dirty_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HKPhoneCodes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HKPhoneCodes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaidInRoom != other.MaidInRoom) return false;
      if (Inspect != other.Inspect) return false;
      if (CleanSheetsNotChanged != other.CleanSheetsNotChanged) return false;
      if (CleanAndSheetsChanged != other.CleanAndSheetsChanged) return false;
      if (Dirty != other.Dirty) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MaidInRoom.Length != 0) hash ^= MaidInRoom.GetHashCode();
      if (Inspect.Length != 0) hash ^= Inspect.GetHashCode();
      if (CleanSheetsNotChanged.Length != 0) hash ^= CleanSheetsNotChanged.GetHashCode();
      if (CleanAndSheetsChanged.Length != 0) hash ^= CleanAndSheetsChanged.GetHashCode();
      if (Dirty.Length != 0) hash ^= Dirty.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MaidInRoom.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MaidInRoom);
      }
      if (Inspect.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Inspect);
      }
      if (CleanSheetsNotChanged.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CleanSheetsNotChanged);
      }
      if (CleanAndSheetsChanged.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CleanAndSheetsChanged);
      }
      if (Dirty.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Dirty);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MaidInRoom.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MaidInRoom);
      }
      if (Inspect.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Inspect);
      }
      if (CleanSheetsNotChanged.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CleanSheetsNotChanged);
      }
      if (CleanAndSheetsChanged.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CleanAndSheetsChanged);
      }
      if (Dirty.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Dirty);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HKPhoneCodes other) {
      if (other == null) {
        return;
      }
      if (other.MaidInRoom.Length != 0) {
        MaidInRoom = other.MaidInRoom;
      }
      if (other.Inspect.Length != 0) {
        Inspect = other.Inspect;
      }
      if (other.CleanSheetsNotChanged.Length != 0) {
        CleanSheetsNotChanged = other.CleanSheetsNotChanged;
      }
      if (other.CleanAndSheetsChanged.Length != 0) {
        CleanAndSheetsChanged = other.CleanAndSheetsChanged;
      }
      if (other.Dirty.Length != 0) {
        Dirty = other.Dirty;
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
            MaidInRoom = input.ReadString();
            break;
          }
          case 18: {
            Inspect = input.ReadString();
            break;
          }
          case 26: {
            CleanSheetsNotChanged = input.ReadString();
            break;
          }
          case 34: {
            CleanAndSheetsChanged = input.ReadString();
            break;
          }
          case 42: {
            Dirty = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

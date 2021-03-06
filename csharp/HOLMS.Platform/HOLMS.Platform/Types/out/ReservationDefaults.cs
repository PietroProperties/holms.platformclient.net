// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/reservation_defaults.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/reservation_defaults.proto</summary>
  public static partial class ReservationDefaultsReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/reservation_defaults.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationDefaultsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cil0ZW5hbmN5X2NvbmZpZy9yZXNlcnZhdGlvbl9kZWZhdWx0cy5wcm90bxIa",
            "aG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcaI3ByaW1pdGl2ZS9jaGFyYWN0",
            "ZXJfY2FzZV90eXBlLnByb3RvGiRzdXBwbHkvcmF0ZV9zY2hlZHVsZV9pbmRp",
            "Y2F0b3IucHJvdG8inQIKE1Jlc2VydmF0aW9uRGVmYXVsdHMSSAoVZGVmYXVs",
            "dF9yYXRlX3NjaGVkdWxlGAEgASgLMikuaG9sbXMudHlwZXMuc3VwcGx5LlJh",
            "dGVTY2hlZHVsZUluZGljYXRvchIgChhzaG93X2NhbmNlbGxhdGlvbl9wb2xp",
            "Y3kYAiABKAgSHAoUcmVxdWlyZV9waG9uZV9udW1iZXIYAyABKAgSQAoOY2hh",
            "cmFjdGVyX2Nhc2UYBCABKA4yKC5ob2xtcy50eXBlcy5wcmltaXRpdmUuQ2hh",
            "cmFjdGVyQ2FzZVR5cGUSFwoPYmxvY2tfZHJvcF9kYXlzGAUgASgFEiEKGXZp",
            "ZXdfZm9saW9faGlnaGxpZ2h0X2RheXMYBiABKAVCK1oNdGVuYW5jeWNvbmZp",
            "Z6oCGUhPTE1TLlR5cGVzLlRlbmFuY3lDb25maWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.CharacterCaseTypeReflection.Descriptor, global::HOLMS.Types.Supply.RateScheduleIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.ReservationDefaults), global::HOLMS.Types.TenancyConfig.ReservationDefaults.Parser, new[]{ "DefaultRateSchedule", "ShowCancellationPolicy", "RequirePhoneNumber", "CharacterCase", "BlockDropDays", "ViewFolioHighlightDays" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationDefaults : pb::IMessage<ReservationDefaults> {
    private static readonly pb::MessageParser<ReservationDefaults> _parser = new pb::MessageParser<ReservationDefaults>(() => new ReservationDefaults());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationDefaults> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.ReservationDefaultsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationDefaults() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationDefaults(ReservationDefaults other) : this() {
      DefaultRateSchedule = other.defaultRateSchedule_ != null ? other.DefaultRateSchedule.Clone() : null;
      showCancellationPolicy_ = other.showCancellationPolicy_;
      requirePhoneNumber_ = other.requirePhoneNumber_;
      characterCase_ = other.characterCase_;
      blockDropDays_ = other.blockDropDays_;
      viewFolioHighlightDays_ = other.viewFolioHighlightDays_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationDefaults Clone() {
      return new ReservationDefaults(this);
    }

    /// <summary>Field number for the "default_rate_schedule" field.</summary>
    public const int DefaultRateScheduleFieldNumber = 1;
    private global::HOLMS.Types.Supply.RateScheduleIndicator defaultRateSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RateScheduleIndicator DefaultRateSchedule {
      get { return defaultRateSchedule_; }
      set {
        defaultRateSchedule_ = value;
      }
    }

    /// <summary>Field number for the "show_cancellation_policy" field.</summary>
    public const int ShowCancellationPolicyFieldNumber = 2;
    private bool showCancellationPolicy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ShowCancellationPolicy {
      get { return showCancellationPolicy_; }
      set {
        showCancellationPolicy_ = value;
      }
    }

    /// <summary>Field number for the "require_phone_number" field.</summary>
    public const int RequirePhoneNumberFieldNumber = 3;
    private bool requirePhoneNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool RequirePhoneNumber {
      get { return requirePhoneNumber_; }
      set {
        requirePhoneNumber_ = value;
      }
    }

    /// <summary>Field number for the "character_case" field.</summary>
    public const int CharacterCaseFieldNumber = 4;
    private global::HOLMS.Types.Primitive.CharacterCaseType characterCase_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.CharacterCaseType CharacterCase {
      get { return characterCase_; }
      set {
        characterCase_ = value;
      }
    }

    /// <summary>Field number for the "block_drop_days" field.</summary>
    public const int BlockDropDaysFieldNumber = 5;
    private int blockDropDays_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BlockDropDays {
      get { return blockDropDays_; }
      set {
        blockDropDays_ = value;
      }
    }

    /// <summary>Field number for the "view_folio_highlight_days" field.</summary>
    public const int ViewFolioHighlightDaysFieldNumber = 6;
    private int viewFolioHighlightDays_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ViewFolioHighlightDays {
      get { return viewFolioHighlightDays_; }
      set {
        viewFolioHighlightDays_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationDefaults);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationDefaults other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DefaultRateSchedule, other.DefaultRateSchedule)) return false;
      if (ShowCancellationPolicy != other.ShowCancellationPolicy) return false;
      if (RequirePhoneNumber != other.RequirePhoneNumber) return false;
      if (CharacterCase != other.CharacterCase) return false;
      if (BlockDropDays != other.BlockDropDays) return false;
      if (ViewFolioHighlightDays != other.ViewFolioHighlightDays) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (defaultRateSchedule_ != null) hash ^= DefaultRateSchedule.GetHashCode();
      if (ShowCancellationPolicy != false) hash ^= ShowCancellationPolicy.GetHashCode();
      if (RequirePhoneNumber != false) hash ^= RequirePhoneNumber.GetHashCode();
      if (CharacterCase != 0) hash ^= CharacterCase.GetHashCode();
      if (BlockDropDays != 0) hash ^= BlockDropDays.GetHashCode();
      if (ViewFolioHighlightDays != 0) hash ^= ViewFolioHighlightDays.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (defaultRateSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DefaultRateSchedule);
      }
      if (ShowCancellationPolicy != false) {
        output.WriteRawTag(16);
        output.WriteBool(ShowCancellationPolicy);
      }
      if (RequirePhoneNumber != false) {
        output.WriteRawTag(24);
        output.WriteBool(RequirePhoneNumber);
      }
      if (CharacterCase != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) CharacterCase);
      }
      if (BlockDropDays != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(BlockDropDays);
      }
      if (ViewFolioHighlightDays != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(ViewFolioHighlightDays);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (defaultRateSchedule_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DefaultRateSchedule);
      }
      if (ShowCancellationPolicy != false) {
        size += 1 + 1;
      }
      if (RequirePhoneNumber != false) {
        size += 1 + 1;
      }
      if (CharacterCase != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CharacterCase);
      }
      if (BlockDropDays != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BlockDropDays);
      }
      if (ViewFolioHighlightDays != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ViewFolioHighlightDays);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationDefaults other) {
      if (other == null) {
        return;
      }
      if (other.defaultRateSchedule_ != null) {
        if (defaultRateSchedule_ == null) {
          defaultRateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
        }
        DefaultRateSchedule.MergeFrom(other.DefaultRateSchedule);
      }
      if (other.ShowCancellationPolicy != false) {
        ShowCancellationPolicy = other.ShowCancellationPolicy;
      }
      if (other.RequirePhoneNumber != false) {
        RequirePhoneNumber = other.RequirePhoneNumber;
      }
      if (other.CharacterCase != 0) {
        CharacterCase = other.CharacterCase;
      }
      if (other.BlockDropDays != 0) {
        BlockDropDays = other.BlockDropDays;
      }
      if (other.ViewFolioHighlightDays != 0) {
        ViewFolioHighlightDays = other.ViewFolioHighlightDays;
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
            if (defaultRateSchedule_ == null) {
              defaultRateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
            }
            input.ReadMessage(defaultRateSchedule_);
            break;
          }
          case 16: {
            ShowCancellationPolicy = input.ReadBool();
            break;
          }
          case 24: {
            RequirePhoneNumber = input.ReadBool();
            break;
          }
          case 32: {
            characterCase_ = (global::HOLMS.Types.Primitive.CharacterCaseType) input.ReadEnum();
            break;
          }
          case 40: {
            BlockDropDays = input.ReadInt32();
            break;
          }
          case 48: {
            ViewFolioHighlightDays = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

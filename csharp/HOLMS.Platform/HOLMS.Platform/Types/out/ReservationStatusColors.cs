// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/reservation_status_colors.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/reservation_status_colors.proto</summary>
  public static partial class ReservationStatusColorsReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/reservation_status_colors.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationStatusColorsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci50ZW5hbmN5X2NvbmZpZy9yZXNlcnZhdGlvbl9zdGF0dXNfY29sb3JzLnBy",
            "b3RvEhpob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZxoccHJpbWl0aXZlL3N0",
            "YXR1c19jb2xvci5wcm90byK7DQoXUmVzZXJ2YXRpb25TdGF0dXNDb2xvcnMS",
            "SwofdW5ndWFyYW50ZWVkX25vdF9kdWVfaW5kaXZpZHVhbBgBIAEoDjIiLmhv",
            "bG1zLnR5cGVzLnByaW1pdGl2ZS5TdGF0dXNDb2xvchJGChp1bmd1YXJhbnRl",
            "ZWRfbm90X2R1ZV9ncm91cBgCIAEoDjIiLmhvbG1zLnR5cGVzLnByaW1pdGl2",
            "ZS5TdGF0dXNDb2xvchJHChtndWFyYW50ZWVkX2NvbG9yX2luZGl2aWR1YWwY",
            "AyABKA4yIi5ob2xtcy50eXBlcy5wcmltaXRpdmUuU3RhdHVzQ29sb3ISQgoW",
            "Z3VhcmFudGVlZF9jb2xvcl9ncm91cBgEIAEoDjIiLmhvbG1zLnR5cGVzLnBy",
            "aW1pdGl2ZS5TdGF0dXNDb2xvchJLCh91bmd1YXJhbnRlZWRfb3ZlcmR1ZV9p",
            "bmRpdmlkdWFsGAUgASgOMiIuaG9sbXMudHlwZXMucHJpbWl0aXZlLlN0YXR1",
            "c0NvbG9yEkYKGnVuZ3VhcmFudGVlZF9vdmVyZHVlX2dyb3VwGAYgASgOMiIu",
            "aG9sbXMudHlwZXMucHJpbWl0aXZlLlN0YXR1c0NvbG9yEkQKGGFycml2YWxf",
            "Y29sb3JfaW5kaXZpZHVhbBgHIAEoDjIiLmhvbG1zLnR5cGVzLnByaW1pdGl2",
            "ZS5TdGF0dXNDb2xvchI/ChNhcnJpdmFsX2NvbG9yX2dyb3VwGAggASgOMiIu",
            "aG9sbXMudHlwZXMucHJpbWl0aXZlLlN0YXR1c0NvbG9yEkQKGGluaG91c2Vf",
            "Y29sb3JfaW5kaXZpZHVhbBgJIAEoDjIiLmhvbG1zLnR5cGVzLnByaW1pdGl2",
            "ZS5TdGF0dXNDb2xvchI/ChNpbmhvdXNlX2NvbG9yX2dyb3VwGAogASgOMiIu",
            "aG9sbXMudHlwZXMucHJpbWl0aXZlLlN0YXR1c0NvbG9yEkYKGmRlcGFydHVy",
            "ZV9jb2xvcl9pbmRpdmlkdWFsGAsgASgOMiIuaG9sbXMudHlwZXMucHJpbWl0",
            "aXZlLlN0YXR1c0NvbG9yEkEKFWRlcGFydHVyZV9jb2xvcl9ncm91cBgMIAEo",
            "DjIiLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5TdGF0dXNDb2xvchJIChxjaGVj",
            "a2VkX291dF9jb2xvcl9pbmRpdmlkdWFsGA0gASgOMiIuaG9sbXMudHlwZXMu",
            "cHJpbWl0aXZlLlN0YXR1c0NvbG9yEkMKF2NoZWNrZWRfb3V0X2NvbG9yX2dy",
            "b3VwGA4gASgOMiIuaG9sbXMudHlwZXMucHJpbWl0aXZlLlN0YXR1c0NvbG9y",
            "EkQKGG5vX3Nob3dfY29sb3JfaW5kaXZpZHVhbBgPIAEoDjIiLmhvbG1zLnR5",
            "cGVzLnByaW1pdGl2ZS5TdGF0dXNDb2xvchI/ChNub19zaG93X2NvbG9yX2dy",
            "b3VwGBAgASgOMiIuaG9sbXMudHlwZXMucHJpbWl0aXZlLlN0YXR1c0NvbG9y",
            "EkUKGWNhbmNlbGVkX2NvbG9yX2luZGl2aWR1YWwYESABKA4yIi5ob2xtcy50",
            "eXBlcy5wcmltaXRpdmUuU3RhdHVzQ29sb3ISQAoUY2FuY2VsZWRfY29sb3Jf",
            "Z3JvdXAYEiABKA4yIi5ob2xtcy50eXBlcy5wcmltaXRpdmUuU3RhdHVzQ29s",
            "b3ISTgoiY2FuY2VsZWRfd2l0aF9mZWVfY29sb3JfaW5kaXZpZHVhbBgTIAEo",
            "DjIiLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5TdGF0dXNDb2xvchJJCh1jYW5j",
            "ZWxlZF93aXRoX2ZlZV9jb2xvcl9ncm91cBgUIAEoDjIiLmhvbG1zLnR5cGVz",
            "LnByaW1pdGl2ZS5TdGF0dXNDb2xvchJBChVvcGVuX2NvbG9yX2luZGl2aWR1",
            "YWwYFSABKA4yIi5ob2xtcy50eXBlcy5wcmltaXRpdmUuU3RhdHVzQ29sb3IS",
            "PAoQb3Blbl9jb2xvcl9ncm91cBgWIAEoDjIiLmhvbG1zLnR5cGVzLnByaW1p",
            "dGl2ZS5TdGF0dXNDb2xvchJMCiBhcnJpdmFsX292ZXJkdWVfY29sb3JfaW5k",
            "aXZpZHVhbBgXIAEoDjIiLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5TdGF0dXND",
            "b2xvchJHChthcnJpdmFsX292ZXJkdWVfY29sb3JfZ3JvdXAYGCABKA4yIi5o",
            "b2xtcy50eXBlcy5wcmltaXRpdmUuU3RhdHVzQ29sb3JCK1oNdGVuYW5jeWNv",
            "bmZpZ6oCGUhPTE1TLlR5cGVzLlRlbmFuY3lDb25maWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.StatusColorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.ReservationStatusColors), global::HOLMS.Types.TenancyConfig.ReservationStatusColors.Parser, new[]{ "UnguaranteedNotDueIndividual", "UnguaranteedNotDueGroup", "GuaranteedColorIndividual", "GuaranteedColorGroup", "UnguaranteedOverdueIndividual", "UnguaranteedOverdueGroup", "ArrivalColorIndividual", "ArrivalColorGroup", "InhouseColorIndividual", "InhouseColorGroup", "DepartureColorIndividual", "DepartureColorGroup", "CheckedOutColorIndividual", "CheckedOutColorGroup", "NoShowColorIndividual", "NoShowColorGroup", "CanceledColorIndividual", "CanceledColorGroup", "CanceledWithFeeColorIndividual", "CanceledWithFeeColorGroup", "OpenColorIndividual", "OpenColorGroup", "ArrivalOverdueColorIndividual", "ArrivalOverdueColorGroup" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationStatusColors : pb::IMessage<ReservationStatusColors> {
    private static readonly pb::MessageParser<ReservationStatusColors> _parser = new pb::MessageParser<ReservationStatusColors>(() => new ReservationStatusColors());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationStatusColors> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.ReservationStatusColorsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationStatusColors() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationStatusColors(ReservationStatusColors other) : this() {
      unguaranteedNotDueIndividual_ = other.unguaranteedNotDueIndividual_;
      unguaranteedNotDueGroup_ = other.unguaranteedNotDueGroup_;
      guaranteedColorIndividual_ = other.guaranteedColorIndividual_;
      guaranteedColorGroup_ = other.guaranteedColorGroup_;
      unguaranteedOverdueIndividual_ = other.unguaranteedOverdueIndividual_;
      unguaranteedOverdueGroup_ = other.unguaranteedOverdueGroup_;
      arrivalColorIndividual_ = other.arrivalColorIndividual_;
      arrivalColorGroup_ = other.arrivalColorGroup_;
      inhouseColorIndividual_ = other.inhouseColorIndividual_;
      inhouseColorGroup_ = other.inhouseColorGroup_;
      departureColorIndividual_ = other.departureColorIndividual_;
      departureColorGroup_ = other.departureColorGroup_;
      checkedOutColorIndividual_ = other.checkedOutColorIndividual_;
      checkedOutColorGroup_ = other.checkedOutColorGroup_;
      noShowColorIndividual_ = other.noShowColorIndividual_;
      noShowColorGroup_ = other.noShowColorGroup_;
      canceledColorIndividual_ = other.canceledColorIndividual_;
      canceledColorGroup_ = other.canceledColorGroup_;
      canceledWithFeeColorIndividual_ = other.canceledWithFeeColorIndividual_;
      canceledWithFeeColorGroup_ = other.canceledWithFeeColorGroup_;
      openColorIndividual_ = other.openColorIndividual_;
      openColorGroup_ = other.openColorGroup_;
      arrivalOverdueColorIndividual_ = other.arrivalOverdueColorIndividual_;
      arrivalOverdueColorGroup_ = other.arrivalOverdueColorGroup_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationStatusColors Clone() {
      return new ReservationStatusColors(this);
    }

    /// <summary>Field number for the "unguaranteed_not_due_individual" field.</summary>
    public const int UnguaranteedNotDueIndividualFieldNumber = 1;
    private global::HOLMS.Types.Primitive.StatusColor unguaranteedNotDueIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor UnguaranteedNotDueIndividual {
      get { return unguaranteedNotDueIndividual_; }
      set {
        unguaranteedNotDueIndividual_ = value;
      }
    }

    /// <summary>Field number for the "unguaranteed_not_due_group" field.</summary>
    public const int UnguaranteedNotDueGroupFieldNumber = 2;
    private global::HOLMS.Types.Primitive.StatusColor unguaranteedNotDueGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor UnguaranteedNotDueGroup {
      get { return unguaranteedNotDueGroup_; }
      set {
        unguaranteedNotDueGroup_ = value;
      }
    }

    /// <summary>Field number for the "guaranteed_color_individual" field.</summary>
    public const int GuaranteedColorIndividualFieldNumber = 3;
    private global::HOLMS.Types.Primitive.StatusColor guaranteedColorIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor GuaranteedColorIndividual {
      get { return guaranteedColorIndividual_; }
      set {
        guaranteedColorIndividual_ = value;
      }
    }

    /// <summary>Field number for the "guaranteed_color_group" field.</summary>
    public const int GuaranteedColorGroupFieldNumber = 4;
    private global::HOLMS.Types.Primitive.StatusColor guaranteedColorGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor GuaranteedColorGroup {
      get { return guaranteedColorGroup_; }
      set {
        guaranteedColorGroup_ = value;
      }
    }

    /// <summary>Field number for the "unguaranteed_overdue_individual" field.</summary>
    public const int UnguaranteedOverdueIndividualFieldNumber = 5;
    private global::HOLMS.Types.Primitive.StatusColor unguaranteedOverdueIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor UnguaranteedOverdueIndividual {
      get { return unguaranteedOverdueIndividual_; }
      set {
        unguaranteedOverdueIndividual_ = value;
      }
    }

    /// <summary>Field number for the "unguaranteed_overdue_group" field.</summary>
    public const int UnguaranteedOverdueGroupFieldNumber = 6;
    private global::HOLMS.Types.Primitive.StatusColor unguaranteedOverdueGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor UnguaranteedOverdueGroup {
      get { return unguaranteedOverdueGroup_; }
      set {
        unguaranteedOverdueGroup_ = value;
      }
    }

    /// <summary>Field number for the "arrival_color_individual" field.</summary>
    public const int ArrivalColorIndividualFieldNumber = 7;
    private global::HOLMS.Types.Primitive.StatusColor arrivalColorIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor ArrivalColorIndividual {
      get { return arrivalColorIndividual_; }
      set {
        arrivalColorIndividual_ = value;
      }
    }

    /// <summary>Field number for the "arrival_color_group" field.</summary>
    public const int ArrivalColorGroupFieldNumber = 8;
    private global::HOLMS.Types.Primitive.StatusColor arrivalColorGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor ArrivalColorGroup {
      get { return arrivalColorGroup_; }
      set {
        arrivalColorGroup_ = value;
      }
    }

    /// <summary>Field number for the "inhouse_color_individual" field.</summary>
    public const int InhouseColorIndividualFieldNumber = 9;
    private global::HOLMS.Types.Primitive.StatusColor inhouseColorIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor InhouseColorIndividual {
      get { return inhouseColorIndividual_; }
      set {
        inhouseColorIndividual_ = value;
      }
    }

    /// <summary>Field number for the "inhouse_color_group" field.</summary>
    public const int InhouseColorGroupFieldNumber = 10;
    private global::HOLMS.Types.Primitive.StatusColor inhouseColorGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor InhouseColorGroup {
      get { return inhouseColorGroup_; }
      set {
        inhouseColorGroup_ = value;
      }
    }

    /// <summary>Field number for the "departure_color_individual" field.</summary>
    public const int DepartureColorIndividualFieldNumber = 11;
    private global::HOLMS.Types.Primitive.StatusColor departureColorIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor DepartureColorIndividual {
      get { return departureColorIndividual_; }
      set {
        departureColorIndividual_ = value;
      }
    }

    /// <summary>Field number for the "departure_color_group" field.</summary>
    public const int DepartureColorGroupFieldNumber = 12;
    private global::HOLMS.Types.Primitive.StatusColor departureColorGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor DepartureColorGroup {
      get { return departureColorGroup_; }
      set {
        departureColorGroup_ = value;
      }
    }

    /// <summary>Field number for the "checked_out_color_individual" field.</summary>
    public const int CheckedOutColorIndividualFieldNumber = 13;
    private global::HOLMS.Types.Primitive.StatusColor checkedOutColorIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor CheckedOutColorIndividual {
      get { return checkedOutColorIndividual_; }
      set {
        checkedOutColorIndividual_ = value;
      }
    }

    /// <summary>Field number for the "checked_out_color_group" field.</summary>
    public const int CheckedOutColorGroupFieldNumber = 14;
    private global::HOLMS.Types.Primitive.StatusColor checkedOutColorGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor CheckedOutColorGroup {
      get { return checkedOutColorGroup_; }
      set {
        checkedOutColorGroup_ = value;
      }
    }

    /// <summary>Field number for the "no_show_color_individual" field.</summary>
    public const int NoShowColorIndividualFieldNumber = 15;
    private global::HOLMS.Types.Primitive.StatusColor noShowColorIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor NoShowColorIndividual {
      get { return noShowColorIndividual_; }
      set {
        noShowColorIndividual_ = value;
      }
    }

    /// <summary>Field number for the "no_show_color_group" field.</summary>
    public const int NoShowColorGroupFieldNumber = 16;
    private global::HOLMS.Types.Primitive.StatusColor noShowColorGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor NoShowColorGroup {
      get { return noShowColorGroup_; }
      set {
        noShowColorGroup_ = value;
      }
    }

    /// <summary>Field number for the "canceled_color_individual" field.</summary>
    public const int CanceledColorIndividualFieldNumber = 17;
    private global::HOLMS.Types.Primitive.StatusColor canceledColorIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor CanceledColorIndividual {
      get { return canceledColorIndividual_; }
      set {
        canceledColorIndividual_ = value;
      }
    }

    /// <summary>Field number for the "canceled_color_group" field.</summary>
    public const int CanceledColorGroupFieldNumber = 18;
    private global::HOLMS.Types.Primitive.StatusColor canceledColorGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor CanceledColorGroup {
      get { return canceledColorGroup_; }
      set {
        canceledColorGroup_ = value;
      }
    }

    /// <summary>Field number for the "canceled_with_fee_color_individual" field.</summary>
    public const int CanceledWithFeeColorIndividualFieldNumber = 19;
    private global::HOLMS.Types.Primitive.StatusColor canceledWithFeeColorIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor CanceledWithFeeColorIndividual {
      get { return canceledWithFeeColorIndividual_; }
      set {
        canceledWithFeeColorIndividual_ = value;
      }
    }

    /// <summary>Field number for the "canceled_with_fee_color_group" field.</summary>
    public const int CanceledWithFeeColorGroupFieldNumber = 20;
    private global::HOLMS.Types.Primitive.StatusColor canceledWithFeeColorGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor CanceledWithFeeColorGroup {
      get { return canceledWithFeeColorGroup_; }
      set {
        canceledWithFeeColorGroup_ = value;
      }
    }

    /// <summary>Field number for the "open_color_individual" field.</summary>
    public const int OpenColorIndividualFieldNumber = 21;
    private global::HOLMS.Types.Primitive.StatusColor openColorIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor OpenColorIndividual {
      get { return openColorIndividual_; }
      set {
        openColorIndividual_ = value;
      }
    }

    /// <summary>Field number for the "open_color_group" field.</summary>
    public const int OpenColorGroupFieldNumber = 22;
    private global::HOLMS.Types.Primitive.StatusColor openColorGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor OpenColorGroup {
      get { return openColorGroup_; }
      set {
        openColorGroup_ = value;
      }
    }

    /// <summary>Field number for the "arrival_overdue_color_individual" field.</summary>
    public const int ArrivalOverdueColorIndividualFieldNumber = 23;
    private global::HOLMS.Types.Primitive.StatusColor arrivalOverdueColorIndividual_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor ArrivalOverdueColorIndividual {
      get { return arrivalOverdueColorIndividual_; }
      set {
        arrivalOverdueColorIndividual_ = value;
      }
    }

    /// <summary>Field number for the "arrival_overdue_color_group" field.</summary>
    public const int ArrivalOverdueColorGroupFieldNumber = 24;
    private global::HOLMS.Types.Primitive.StatusColor arrivalOverdueColorGroup_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.StatusColor ArrivalOverdueColorGroup {
      get { return arrivalOverdueColorGroup_; }
      set {
        arrivalOverdueColorGroup_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationStatusColors);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationStatusColors other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnguaranteedNotDueIndividual != other.UnguaranteedNotDueIndividual) return false;
      if (UnguaranteedNotDueGroup != other.UnguaranteedNotDueGroup) return false;
      if (GuaranteedColorIndividual != other.GuaranteedColorIndividual) return false;
      if (GuaranteedColorGroup != other.GuaranteedColorGroup) return false;
      if (UnguaranteedOverdueIndividual != other.UnguaranteedOverdueIndividual) return false;
      if (UnguaranteedOverdueGroup != other.UnguaranteedOverdueGroup) return false;
      if (ArrivalColorIndividual != other.ArrivalColorIndividual) return false;
      if (ArrivalColorGroup != other.ArrivalColorGroup) return false;
      if (InhouseColorIndividual != other.InhouseColorIndividual) return false;
      if (InhouseColorGroup != other.InhouseColorGroup) return false;
      if (DepartureColorIndividual != other.DepartureColorIndividual) return false;
      if (DepartureColorGroup != other.DepartureColorGroup) return false;
      if (CheckedOutColorIndividual != other.CheckedOutColorIndividual) return false;
      if (CheckedOutColorGroup != other.CheckedOutColorGroup) return false;
      if (NoShowColorIndividual != other.NoShowColorIndividual) return false;
      if (NoShowColorGroup != other.NoShowColorGroup) return false;
      if (CanceledColorIndividual != other.CanceledColorIndividual) return false;
      if (CanceledColorGroup != other.CanceledColorGroup) return false;
      if (CanceledWithFeeColorIndividual != other.CanceledWithFeeColorIndividual) return false;
      if (CanceledWithFeeColorGroup != other.CanceledWithFeeColorGroup) return false;
      if (OpenColorIndividual != other.OpenColorIndividual) return false;
      if (OpenColorGroup != other.OpenColorGroup) return false;
      if (ArrivalOverdueColorIndividual != other.ArrivalOverdueColorIndividual) return false;
      if (ArrivalOverdueColorGroup != other.ArrivalOverdueColorGroup) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnguaranteedNotDueIndividual != 0) hash ^= UnguaranteedNotDueIndividual.GetHashCode();
      if (UnguaranteedNotDueGroup != 0) hash ^= UnguaranteedNotDueGroup.GetHashCode();
      if (GuaranteedColorIndividual != 0) hash ^= GuaranteedColorIndividual.GetHashCode();
      if (GuaranteedColorGroup != 0) hash ^= GuaranteedColorGroup.GetHashCode();
      if (UnguaranteedOverdueIndividual != 0) hash ^= UnguaranteedOverdueIndividual.GetHashCode();
      if (UnguaranteedOverdueGroup != 0) hash ^= UnguaranteedOverdueGroup.GetHashCode();
      if (ArrivalColorIndividual != 0) hash ^= ArrivalColorIndividual.GetHashCode();
      if (ArrivalColorGroup != 0) hash ^= ArrivalColorGroup.GetHashCode();
      if (InhouseColorIndividual != 0) hash ^= InhouseColorIndividual.GetHashCode();
      if (InhouseColorGroup != 0) hash ^= InhouseColorGroup.GetHashCode();
      if (DepartureColorIndividual != 0) hash ^= DepartureColorIndividual.GetHashCode();
      if (DepartureColorGroup != 0) hash ^= DepartureColorGroup.GetHashCode();
      if (CheckedOutColorIndividual != 0) hash ^= CheckedOutColorIndividual.GetHashCode();
      if (CheckedOutColorGroup != 0) hash ^= CheckedOutColorGroup.GetHashCode();
      if (NoShowColorIndividual != 0) hash ^= NoShowColorIndividual.GetHashCode();
      if (NoShowColorGroup != 0) hash ^= NoShowColorGroup.GetHashCode();
      if (CanceledColorIndividual != 0) hash ^= CanceledColorIndividual.GetHashCode();
      if (CanceledColorGroup != 0) hash ^= CanceledColorGroup.GetHashCode();
      if (CanceledWithFeeColorIndividual != 0) hash ^= CanceledWithFeeColorIndividual.GetHashCode();
      if (CanceledWithFeeColorGroup != 0) hash ^= CanceledWithFeeColorGroup.GetHashCode();
      if (OpenColorIndividual != 0) hash ^= OpenColorIndividual.GetHashCode();
      if (OpenColorGroup != 0) hash ^= OpenColorGroup.GetHashCode();
      if (ArrivalOverdueColorIndividual != 0) hash ^= ArrivalOverdueColorIndividual.GetHashCode();
      if (ArrivalOverdueColorGroup != 0) hash ^= ArrivalOverdueColorGroup.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnguaranteedNotDueIndividual != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) UnguaranteedNotDueIndividual);
      }
      if (UnguaranteedNotDueGroup != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) UnguaranteedNotDueGroup);
      }
      if (GuaranteedColorIndividual != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) GuaranteedColorIndividual);
      }
      if (GuaranteedColorGroup != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) GuaranteedColorGroup);
      }
      if (UnguaranteedOverdueIndividual != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) UnguaranteedOverdueIndividual);
      }
      if (UnguaranteedOverdueGroup != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) UnguaranteedOverdueGroup);
      }
      if (ArrivalColorIndividual != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) ArrivalColorIndividual);
      }
      if (ArrivalColorGroup != 0) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ArrivalColorGroup);
      }
      if (InhouseColorIndividual != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) InhouseColorIndividual);
      }
      if (InhouseColorGroup != 0) {
        output.WriteRawTag(80);
        output.WriteEnum((int) InhouseColorGroup);
      }
      if (DepartureColorIndividual != 0) {
        output.WriteRawTag(88);
        output.WriteEnum((int) DepartureColorIndividual);
      }
      if (DepartureColorGroup != 0) {
        output.WriteRawTag(96);
        output.WriteEnum((int) DepartureColorGroup);
      }
      if (CheckedOutColorIndividual != 0) {
        output.WriteRawTag(104);
        output.WriteEnum((int) CheckedOutColorIndividual);
      }
      if (CheckedOutColorGroup != 0) {
        output.WriteRawTag(112);
        output.WriteEnum((int) CheckedOutColorGroup);
      }
      if (NoShowColorIndividual != 0) {
        output.WriteRawTag(120);
        output.WriteEnum((int) NoShowColorIndividual);
      }
      if (NoShowColorGroup != 0) {
        output.WriteRawTag(128, 1);
        output.WriteEnum((int) NoShowColorGroup);
      }
      if (CanceledColorIndividual != 0) {
        output.WriteRawTag(136, 1);
        output.WriteEnum((int) CanceledColorIndividual);
      }
      if (CanceledColorGroup != 0) {
        output.WriteRawTag(144, 1);
        output.WriteEnum((int) CanceledColorGroup);
      }
      if (CanceledWithFeeColorIndividual != 0) {
        output.WriteRawTag(152, 1);
        output.WriteEnum((int) CanceledWithFeeColorIndividual);
      }
      if (CanceledWithFeeColorGroup != 0) {
        output.WriteRawTag(160, 1);
        output.WriteEnum((int) CanceledWithFeeColorGroup);
      }
      if (OpenColorIndividual != 0) {
        output.WriteRawTag(168, 1);
        output.WriteEnum((int) OpenColorIndividual);
      }
      if (OpenColorGroup != 0) {
        output.WriteRawTag(176, 1);
        output.WriteEnum((int) OpenColorGroup);
      }
      if (ArrivalOverdueColorIndividual != 0) {
        output.WriteRawTag(184, 1);
        output.WriteEnum((int) ArrivalOverdueColorIndividual);
      }
      if (ArrivalOverdueColorGroup != 0) {
        output.WriteRawTag(192, 1);
        output.WriteEnum((int) ArrivalOverdueColorGroup);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnguaranteedNotDueIndividual != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnguaranteedNotDueIndividual);
      }
      if (UnguaranteedNotDueGroup != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnguaranteedNotDueGroup);
      }
      if (GuaranteedColorIndividual != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GuaranteedColorIndividual);
      }
      if (GuaranteedColorGroup != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GuaranteedColorGroup);
      }
      if (UnguaranteedOverdueIndividual != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnguaranteedOverdueIndividual);
      }
      if (UnguaranteedOverdueGroup != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnguaranteedOverdueGroup);
      }
      if (ArrivalColorIndividual != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArrivalColorIndividual);
      }
      if (ArrivalColorGroup != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArrivalColorGroup);
      }
      if (InhouseColorIndividual != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) InhouseColorIndividual);
      }
      if (InhouseColorGroup != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) InhouseColorGroup);
      }
      if (DepartureColorIndividual != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DepartureColorIndividual);
      }
      if (DepartureColorGroup != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DepartureColorGroup);
      }
      if (CheckedOutColorIndividual != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CheckedOutColorIndividual);
      }
      if (CheckedOutColorGroup != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CheckedOutColorGroup);
      }
      if (NoShowColorIndividual != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NoShowColorIndividual);
      }
      if (NoShowColorGroup != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) NoShowColorGroup);
      }
      if (CanceledColorIndividual != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) CanceledColorIndividual);
      }
      if (CanceledColorGroup != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) CanceledColorGroup);
      }
      if (CanceledWithFeeColorIndividual != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) CanceledWithFeeColorIndividual);
      }
      if (CanceledWithFeeColorGroup != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) CanceledWithFeeColorGroup);
      }
      if (OpenColorIndividual != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) OpenColorIndividual);
      }
      if (OpenColorGroup != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) OpenColorGroup);
      }
      if (ArrivalOverdueColorIndividual != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) ArrivalOverdueColorIndividual);
      }
      if (ArrivalOverdueColorGroup != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) ArrivalOverdueColorGroup);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationStatusColors other) {
      if (other == null) {
        return;
      }
      if (other.UnguaranteedNotDueIndividual != 0) {
        UnguaranteedNotDueIndividual = other.UnguaranteedNotDueIndividual;
      }
      if (other.UnguaranteedNotDueGroup != 0) {
        UnguaranteedNotDueGroup = other.UnguaranteedNotDueGroup;
      }
      if (other.GuaranteedColorIndividual != 0) {
        GuaranteedColorIndividual = other.GuaranteedColorIndividual;
      }
      if (other.GuaranteedColorGroup != 0) {
        GuaranteedColorGroup = other.GuaranteedColorGroup;
      }
      if (other.UnguaranteedOverdueIndividual != 0) {
        UnguaranteedOverdueIndividual = other.UnguaranteedOverdueIndividual;
      }
      if (other.UnguaranteedOverdueGroup != 0) {
        UnguaranteedOverdueGroup = other.UnguaranteedOverdueGroup;
      }
      if (other.ArrivalColorIndividual != 0) {
        ArrivalColorIndividual = other.ArrivalColorIndividual;
      }
      if (other.ArrivalColorGroup != 0) {
        ArrivalColorGroup = other.ArrivalColorGroup;
      }
      if (other.InhouseColorIndividual != 0) {
        InhouseColorIndividual = other.InhouseColorIndividual;
      }
      if (other.InhouseColorGroup != 0) {
        InhouseColorGroup = other.InhouseColorGroup;
      }
      if (other.DepartureColorIndividual != 0) {
        DepartureColorIndividual = other.DepartureColorIndividual;
      }
      if (other.DepartureColorGroup != 0) {
        DepartureColorGroup = other.DepartureColorGroup;
      }
      if (other.CheckedOutColorIndividual != 0) {
        CheckedOutColorIndividual = other.CheckedOutColorIndividual;
      }
      if (other.CheckedOutColorGroup != 0) {
        CheckedOutColorGroup = other.CheckedOutColorGroup;
      }
      if (other.NoShowColorIndividual != 0) {
        NoShowColorIndividual = other.NoShowColorIndividual;
      }
      if (other.NoShowColorGroup != 0) {
        NoShowColorGroup = other.NoShowColorGroup;
      }
      if (other.CanceledColorIndividual != 0) {
        CanceledColorIndividual = other.CanceledColorIndividual;
      }
      if (other.CanceledColorGroup != 0) {
        CanceledColorGroup = other.CanceledColorGroup;
      }
      if (other.CanceledWithFeeColorIndividual != 0) {
        CanceledWithFeeColorIndividual = other.CanceledWithFeeColorIndividual;
      }
      if (other.CanceledWithFeeColorGroup != 0) {
        CanceledWithFeeColorGroup = other.CanceledWithFeeColorGroup;
      }
      if (other.OpenColorIndividual != 0) {
        OpenColorIndividual = other.OpenColorIndividual;
      }
      if (other.OpenColorGroup != 0) {
        OpenColorGroup = other.OpenColorGroup;
      }
      if (other.ArrivalOverdueColorIndividual != 0) {
        ArrivalOverdueColorIndividual = other.ArrivalOverdueColorIndividual;
      }
      if (other.ArrivalOverdueColorGroup != 0) {
        ArrivalOverdueColorGroup = other.ArrivalOverdueColorGroup;
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
            unguaranteedNotDueIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 16: {
            unguaranteedNotDueGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 24: {
            guaranteedColorIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 32: {
            guaranteedColorGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 40: {
            unguaranteedOverdueIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 48: {
            unguaranteedOverdueGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 56: {
            arrivalColorIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 64: {
            arrivalColorGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 72: {
            inhouseColorIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 80: {
            inhouseColorGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 88: {
            departureColorIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 96: {
            departureColorGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 104: {
            checkedOutColorIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 112: {
            checkedOutColorGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 120: {
            noShowColorIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 128: {
            noShowColorGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 136: {
            canceledColorIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 144: {
            canceledColorGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 152: {
            canceledWithFeeColorIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 160: {
            canceledWithFeeColorGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 168: {
            openColorIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 176: {
            openColorGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 184: {
            arrivalOverdueColorIndividual_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
          case 192: {
            arrivalOverdueColorGroup_ = (global::HOLMS.Types.Primitive.StatusColor) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

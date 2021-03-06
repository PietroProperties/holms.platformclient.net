// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rpc/housekeeping_time_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.RPC {

  /// <summary>Holder for reflection information generated from operations/rpc/housekeeping_time_svc.proto</summary>
  public static partial class HousekeepingTimeSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/rpc/housekeeping_time_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HousekeepingTimeSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipvcGVyYXRpb25zL3JwYy9ob3VzZWtlZXBpbmdfdGltZV9zdmMucHJvdG8S",
            "GmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMucnBjGipwcmltaXRpdmUvc2VydmVy",
            "X2FjdGlvbl9jb25maXJtYXRpb24ucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9l",
            "bXB0eS5wcm90bxovb3BlcmF0aW9ucy9ob3VzZWtlZXBpbmcvaG91c2VrZWVw",
            "aW5nX3RpbWUucHJvdG8aOW9wZXJhdGlvbnMvaG91c2VrZWVwaW5nL2hvdXNl",
            "a2VlcGluZ190aW1lX2luZGljYXRvci5wcm90byJnCh9Ib3VzZWtlZXBpbmdU",
            "aW1lU3ZjRW51bVJlc3BvbnNlEkQKBXRpbWVzGAEgAygLMjUuaG9sbXMudHlw",
            "ZXMub3BlcmF0aW9ucy5ob3VzZWtlZXBpbmcuSG91c2VrZWVwaW5nVGltZTLW",
            "BAoTSG91c2VrZWVwaW5nVGltZVN2YxJaCgNBbGwSFi5nb29nbGUucHJvdG9i",
            "dWYuRW1wdHkaOy5ob2xtcy50eXBlcy5vcGVyYXRpb25zLnJwYy5Ib3VzZWtl",
            "ZXBpbmdUaW1lU3ZjRW51bVJlc3BvbnNlEoABCgdHZXRCeUlkEj4uaG9sbXMu",
            "dHlwZXMub3BlcmF0aW9ucy5ob3VzZWtlZXBpbmcuSG91c2VrZWVwaW5nVGlt",
            "ZUluZGljYXRvcho1LmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMuaG91c2VrZWVw",
            "aW5nLkhvdXNla2VlcGluZ1RpbWUSdgoGQ3JlYXRlEjUuaG9sbXMudHlwZXMu",
            "b3BlcmF0aW9ucy5ob3VzZWtlZXBpbmcuSG91c2VrZWVwaW5nVGltZRo1Lmhv",
            "bG1zLnR5cGVzLm9wZXJhdGlvbnMuaG91c2VrZWVwaW5nLkhvdXNla2VlcGlu",
            "Z1RpbWUSdgoGVXBkYXRlEjUuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ob3Vz",
            "ZWtlZXBpbmcuSG91c2VrZWVwaW5nVGltZRo1LmhvbG1zLnR5cGVzLm9wZXJh",
            "dGlvbnMuaG91c2VrZWVwaW5nLkhvdXNla2VlcGluZ1RpbWUScAoGRGVsZXRl",
            "EjUuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ob3VzZWtlZXBpbmcuSG91c2Vr",
            "ZWVwaW5nVGltZRovLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5TZXJ2ZXJBY3Rp",
            "b25Db25maXJtYXRpb25CLVoOb3BlcmF0aW9ucy9ycGOqAhpIT0xNUy5UeXBl",
            "cy5PcGVyYXRpb25zLlJQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.ServerActionConfirmationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Operations.Housekeeping.HousekeepingTimeReflection.Descriptor, global::HOLMS.Types.Operations.Housekeeping.HousekeepingTimeIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.HousekeepingTimeSvcEnumResponse), global::HOLMS.Types.Operations.RPC.HousekeepingTimeSvcEnumResponse.Parser, new[]{ "Times" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HousekeepingTimeSvcEnumResponse : pb::IMessage<HousekeepingTimeSvcEnumResponse> {
    private static readonly pb::MessageParser<HousekeepingTimeSvcEnumResponse> _parser = new pb::MessageParser<HousekeepingTimeSvcEnumResponse>(() => new HousekeepingTimeSvcEnumResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HousekeepingTimeSvcEnumResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.HousekeepingTimeSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HousekeepingTimeSvcEnumResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HousekeepingTimeSvcEnumResponse(HousekeepingTimeSvcEnumResponse other) : this() {
      times_ = other.times_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HousekeepingTimeSvcEnumResponse Clone() {
      return new HousekeepingTimeSvcEnumResponse(this);
    }

    /// <summary>Field number for the "times" field.</summary>
    public const int TimesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime> _repeated_times_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime> times_ = new pbc::RepeatedField<global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Operations.Housekeeping.HousekeepingTime> Times {
      get { return times_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HousekeepingTimeSvcEnumResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HousekeepingTimeSvcEnumResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!times_.Equals(other.times_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= times_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      times_.WriteTo(output, _repeated_times_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += times_.CalculateSize(_repeated_times_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HousekeepingTimeSvcEnumResponse other) {
      if (other == null) {
        return;
      }
      times_.Add(other.times_);
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
            times_.AddEntriesFrom(input, _repeated_times_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rpc/room_use_status_calculator_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.RPC {

  /// <summary>Holder for reflection information generated from operations/rpc/room_use_status_calculator_svc.proto</summary>
  public static partial class RoomUseStatusCalculatorSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/rpc/room_use_status_calculator_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomUseStatusCalculatorSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNvcGVyYXRpb25zL3JwYy9yb29tX3VzZV9zdGF0dXNfY2FsY3VsYXRvcl9z",
            "dmMucHJvdG8SGmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMucnBjGh9nb29nbGUv",
            "cHJvdG9idWYvdGltZXN0YW1wLnByb3RvGjZvcGVyYXRpb25zL2hvdXNla2Vl",
            "cGluZy9ob3VzZWtlZXBpbmdfcm9vbV9zdGF0dXMucHJvdG8ieAonSEtBY3Rp",
            "b25DYWxjdWxhdG9yU2VydmljZU1hbnlSb29tU3RhdHVzEk0KCHN0YXR1c2Vz",
            "GAEgAygLMjsuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ob3VzZWtlZXBpbmcu",
            "SG91c2VrZWVwaW5nUm9vbVN0YXR1czKQAQoaUm9vbVVzZVN0YXR1c0NhbGN1",
            "bGF0b3JTdmMScgoPR2V0Um9vbVN0YXR1c2VzEhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcBpDLmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMucnBjLkhLQWN0",
            "aW9uQ2FsY3VsYXRvclNlcnZpY2VNYW55Um9vbVN0YXR1c0ItWg5vcGVyYXRp",
            "b25zL3JwY6oCGkhPTE1TLlR5cGVzLk9wZXJhdGlvbnMuUlBDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Operations.Housekeeping.HousekeepingRoomStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.HKActionCalculatorServiceManyRoomStatus), global::HOLMS.Types.Operations.RPC.HKActionCalculatorServiceManyRoomStatus.Parser, new[]{ "Statuses" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HKActionCalculatorServiceManyRoomStatus : pb::IMessage<HKActionCalculatorServiceManyRoomStatus> {
    private static readonly pb::MessageParser<HKActionCalculatorServiceManyRoomStatus> _parser = new pb::MessageParser<HKActionCalculatorServiceManyRoomStatus>(() => new HKActionCalculatorServiceManyRoomStatus());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HKActionCalculatorServiceManyRoomStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.RoomUseStatusCalculatorSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HKActionCalculatorServiceManyRoomStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HKActionCalculatorServiceManyRoomStatus(HKActionCalculatorServiceManyRoomStatus other) : this() {
      statuses_ = other.statuses_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HKActionCalculatorServiceManyRoomStatus Clone() {
      return new HKActionCalculatorServiceManyRoomStatus(this);
    }

    /// <summary>Field number for the "statuses" field.</summary>
    public const int StatusesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Operations.Housekeeping.HousekeepingRoomStatus> _repeated_statuses_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Operations.Housekeeping.HousekeepingRoomStatus.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Operations.Housekeeping.HousekeepingRoomStatus> statuses_ = new pbc::RepeatedField<global::HOLMS.Types.Operations.Housekeeping.HousekeepingRoomStatus>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Operations.Housekeeping.HousekeepingRoomStatus> Statuses {
      get { return statuses_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HKActionCalculatorServiceManyRoomStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HKActionCalculatorServiceManyRoomStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!statuses_.Equals(other.statuses_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= statuses_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      statuses_.WriteTo(output, _repeated_statuses_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += statuses_.CalculateSize(_repeated_statuses_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HKActionCalculatorServiceManyRoomStatus other) {
      if (other == null) {
        return;
      }
      statuses_.Add(other.statuses_);
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
            statuses_.AddEntriesFrom(input, _repeated_statuses_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
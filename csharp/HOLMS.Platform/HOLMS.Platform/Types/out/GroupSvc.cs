// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: crm/rpc/group_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.CRM.RPC {

  /// <summary>Holder for reflection information generated from crm/rpc/group_svc.proto</summary>
  public static partial class GroupSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for crm/rpc/group_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chdjcm0vcnBjL2dyb3VwX3N2Yy5wcm90bxITaG9sbXMudHlwZXMuY3JtLnJw",
            "YxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGhZjcm0vZ3JvdXBzL2dy",
            "b3VwLnByb3RvGiBjcm0vZ3JvdXBzL2dyb3VwX2luZGljYXRvci5wcm90byJE",
            "ChNHcm91cFN2Y0FsbFJlc3BvbnNlEi0KBmdyb3VwcxgBIAMoCzIdLmhvbG1z",
            "LnR5cGVzLmNybS5ncm91cHMuR3JvdXAyrgIKCEdyb3VwU3ZjEkcKA0FsbBIW",
            "Lmdvb2dsZS5wcm90b2J1Zi5FbXB0eRooLmhvbG1zLnR5cGVzLmNybS5ycGMu",
            "R3JvdXBTdmNBbGxSZXNwb25zZRI/CgZDcmVhdGUSFi5nb29nbGUucHJvdG9i",
            "dWYuRW1wdHkaHS5ob2xtcy50eXBlcy5jcm0uZ3JvdXBzLkdyb3VwEkYKBlVw",
            "ZGF0ZRIdLmhvbG1zLnR5cGVzLmNybS5ncm91cHMuR3JvdXAaHS5ob2xtcy50",
            "eXBlcy5jcm0uZ3JvdXBzLkdyb3VwElAKB0dldEJ5SWQSJi5ob2xtcy50eXBl",
            "cy5jcm0uZ3JvdXBzLkdyb3VwSW5kaWNhdG9yGh0uaG9sbXMudHlwZXMuY3Jt",
            "Lmdyb3Vwcy5Hcm91cEIfWgdjcm0vcnBjqgITSE9MTVMuVHlwZXMuQ1JNLlJQ",
            "Q2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.CRM.Groups.GroupReflection.Descriptor, global::HOLMS.Types.CRM.Groups.GroupIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.RPC.GroupSvcAllResponse), global::HOLMS.Types.CRM.RPC.GroupSvcAllResponse.Parser, new[]{ "Groups" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroupSvcAllResponse : pb::IMessage<GroupSvcAllResponse> {
    private static readonly pb::MessageParser<GroupSvcAllResponse> _parser = new pb::MessageParser<GroupSvcAllResponse>(() => new GroupSvcAllResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GroupSvcAllResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.CRM.RPC.GroupSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupSvcAllResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupSvcAllResponse(GroupSvcAllResponse other) : this() {
      groups_ = other.groups_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupSvcAllResponse Clone() {
      return new GroupSvcAllResponse(this);
    }

    /// <summary>Field number for the "groups" field.</summary>
    public const int GroupsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.CRM.Groups.Group> _repeated_groups_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.CRM.Groups.Group.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.CRM.Groups.Group> groups_ = new pbc::RepeatedField<global::HOLMS.Types.CRM.Groups.Group>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.CRM.Groups.Group> Groups {
      get { return groups_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GroupSvcAllResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GroupSvcAllResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!groups_.Equals(other.groups_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= groups_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      groups_.WriteTo(output, _repeated_groups_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += groups_.CalculateSize(_repeated_groups_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GroupSvcAllResponse other) {
      if (other == null) {
        return;
      }
      groups_.Add(other.groups_);
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
            groups_.AddEntriesFrom(input, _repeated_groups_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

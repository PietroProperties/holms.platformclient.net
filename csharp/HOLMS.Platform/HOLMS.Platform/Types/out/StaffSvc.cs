// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: iam/rpc/staff_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.IAM.RPC {

  /// <summary>Holder for reflection information generated from iam/rpc/staff_svc.proto</summary>
  public static partial class StaffSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for iam/rpc/staff_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StaffSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdpYW0vcnBjL3N0YWZmX3N2Yy5wcm90bxITaG9sbXMudHlwZXMuaWFtLnJw",
            "YxoqcHJpbWl0aXZlL3NlcnZlcl9hY3Rpb25fY29uZmlybWF0aW9uLnByb3Rv",
            "Ghtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aFmlhbS9zdGFmZl9tZW1i",
            "ZXIucHJvdG8aIGlhbS9zdGFmZl9tZW1iZXJfaW5kaWNhdG9yLnByb3RvIk0K",
            "FlN0YWZmU3ZjR2V0QWxsUmVzcG9uc2USMwoNc3RhZmZfbWVtYmVycxgBIAMo",
            "CzIcLmhvbG1zLnR5cGVzLmlhbS5TdGFmZk1lbWJlciKUAQocU3RhZmZTdmND",
            "cmVhdGVVcGRhdGVSZXNwb25zZRI/CgZyZXN1bHQYASABKA4yLy5ob2xtcy50",
            "eXBlcy5pYW0ucnBjLlN0YWZmU3ZjQ3JlYXRlVXBkYXRlUmVzdWx0EjMKDXN0",
            "YWZmX21lbWJlcnMYAiABKAsyHC5ob2xtcy50eXBlcy5pYW0uU3RhZmZNZW1i",
            "ZXIqsAEKGlN0YWZmU3ZjQ3JlYXRlVXBkYXRlUmVzdWx0EioKJlNUQUZGX1NW",
            "Q19DUkVBVEVfVVBEQVRFX1JFU1VMVF9TVUNDRVNTEAASMAosU1RBRkZfU1ZD",
            "X0NSRUFURV9VUERBVEVfUkVTVUxUX1VOS05PV05fRVJST1IQARI0CjBTVEFG",
            "Rl9TVkNfQ1JFQVRFX1VQREFURV9SRVNVTFRfVVNFUk5BTUVfQ09ORkxJQ1QQ",
            "AjKNBAoIU3RhZmZTdmMSSgoDQWxsEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5",
            "GisuaG9sbXMudHlwZXMuaWFtLnJwYy5TdGFmZlN2Y0dldEFsbFJlc3BvbnNl",
            "ElYKD0dldEhvdXNla2VlcGVycxIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRor",
            "LmhvbG1zLnR5cGVzLmlhbS5ycGMuU3RhZmZTdmNHZXRBbGxSZXNwb25zZRJO",
            "CgdHZXRCeUlkEiUuaG9sbXMudHlwZXMuaWFtLlN0YWZmTWVtYmVySW5kaWNh",
            "dG9yGhwuaG9sbXMudHlwZXMuaWFtLlN0YWZmTWVtYmVyElkKBkNyZWF0ZRIc",
            "LmhvbG1zLnR5cGVzLmlhbS5TdGFmZk1lbWJlchoxLmhvbG1zLnR5cGVzLmlh",
            "bS5ycGMuU3RhZmZTdmNDcmVhdGVVcGRhdGVSZXNwb25zZRJZCgZVcGRhdGUS",
            "HC5ob2xtcy50eXBlcy5pYW0uU3RhZmZNZW1iZXIaMS5ob2xtcy50eXBlcy5p",
            "YW0ucnBjLlN0YWZmU3ZjQ3JlYXRlVXBkYXRlUmVzcG9uc2USVwoGRGVsZXRl",
            "EhwuaG9sbXMudHlwZXMuaWFtLlN0YWZmTWVtYmVyGi8uaG9sbXMudHlwZXMu",
            "cHJpbWl0aXZlLlNlcnZlckFjdGlvbkNvbmZpcm1hdGlvbkIfWgdpYW0vcnBj",
            "qgITSE9MTVMuVHlwZXMuSUFNLlJQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.ServerActionConfirmationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.IAM.StaffMemberReflection.Descriptor, global::HOLMS.Types.IAM.StaffMemberIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResult), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse), global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse.Parser, new[]{ "StaffMembers" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse), global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse.Parser, new[]{ "Result", "StaffMembers" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum StaffSvcCreateUpdateResult {
    [pbr::OriginalName("STAFF_SVC_CREATE_UPDATE_RESULT_SUCCESS")] Success = 0,
    [pbr::OriginalName("STAFF_SVC_CREATE_UPDATE_RESULT_UNKNOWN_ERROR")] UnknownError = 1,
    [pbr::OriginalName("STAFF_SVC_CREATE_UPDATE_RESULT_USERNAME_CONFLICT")] UsernameConflict = 2,
  }

  #endregion

  #region Messages
  public sealed partial class StaffSvcGetAllResponse : pb::IMessage<StaffSvcGetAllResponse> {
    private static readonly pb::MessageParser<StaffSvcGetAllResponse> _parser = new pb::MessageParser<StaffSvcGetAllResponse>(() => new StaffSvcGetAllResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StaffSvcGetAllResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.IAM.RPC.StaffSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaffSvcGetAllResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaffSvcGetAllResponse(StaffSvcGetAllResponse other) : this() {
      staffMembers_ = other.staffMembers_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaffSvcGetAllResponse Clone() {
      return new StaffSvcGetAllResponse(this);
    }

    /// <summary>Field number for the "staff_members" field.</summary>
    public const int StaffMembersFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.IAM.StaffMember> _repeated_staffMembers_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.IAM.StaffMember.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.IAM.StaffMember> staffMembers_ = new pbc::RepeatedField<global::HOLMS.Types.IAM.StaffMember>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.IAM.StaffMember> StaffMembers {
      get { return staffMembers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StaffSvcGetAllResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StaffSvcGetAllResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!staffMembers_.Equals(other.staffMembers_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= staffMembers_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      staffMembers_.WriteTo(output, _repeated_staffMembers_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += staffMembers_.CalculateSize(_repeated_staffMembers_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StaffSvcGetAllResponse other) {
      if (other == null) {
        return;
      }
      staffMembers_.Add(other.staffMembers_);
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
            staffMembers_.AddEntriesFrom(input, _repeated_staffMembers_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class StaffSvcCreateUpdateResponse : pb::IMessage<StaffSvcCreateUpdateResponse> {
    private static readonly pb::MessageParser<StaffSvcCreateUpdateResponse> _parser = new pb::MessageParser<StaffSvcCreateUpdateResponse>(() => new StaffSvcCreateUpdateResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StaffSvcCreateUpdateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.IAM.RPC.StaffSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaffSvcCreateUpdateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaffSvcCreateUpdateResponse(StaffSvcCreateUpdateResponse other) : this() {
      result_ = other.result_;
      StaffMembers = other.staffMembers_ != null ? other.StaffMembers.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaffSvcCreateUpdateResponse Clone() {
      return new StaffSvcCreateUpdateResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "staff_members" field.</summary>
    public const int StaffMembersFieldNumber = 2;
    private global::HOLMS.Types.IAM.StaffMember staffMembers_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.StaffMember StaffMembers {
      get { return staffMembers_; }
      set {
        staffMembers_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StaffSvcCreateUpdateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StaffSvcCreateUpdateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(StaffMembers, other.StaffMembers)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (staffMembers_ != null) hash ^= StaffMembers.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (staffMembers_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StaffMembers);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (staffMembers_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StaffMembers);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StaffSvcCreateUpdateResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.staffMembers_ != null) {
        if (staffMembers_ == null) {
          staffMembers_ = new global::HOLMS.Types.IAM.StaffMember();
        }
        StaffMembers.MergeFrom(other.StaffMembers);
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
            result_ = (global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResult) input.ReadEnum();
            break;
          }
          case 18: {
            if (staffMembers_ == null) {
              staffMembers_ = new global::HOLMS.Types.IAM.StaffMember();
            }
            input.ReadMessage(staffMembers_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

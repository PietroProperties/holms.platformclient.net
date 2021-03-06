// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/rpc/folio_svc_post_card_payment_response.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio.RPC {

  /// <summary>Holder for reflection information generated from folio/rpc/folio_svc_post_card_payment_response.proto</summary>
  public static partial class FolioSvcPostCardPaymentResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/rpc/folio_svc_post_card_payment_response.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FolioSvcPostCardPaymentResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRmb2xpby9ycGMvZm9saW9fc3ZjX3Bvc3RfY2FyZF9wYXltZW50X3Jlc3Bv",
            "bnNlLnByb3RvEhVob2xtcy50eXBlcy5mb2xpby5ycGMaMmZvbGlvL3JwYy9m",
            "b2xpb19zdmNfcG9zdF9jYXJkX3BheW1lbnRfcmVzdWx0LnByb3RvImcKH0Zv",
            "bGlvU3ZjUG9zdENhcmRQYXltZW50UmVzcG9uc2USRAoGcmVzdWx0GAEgASgO",
            "MjQuaG9sbXMudHlwZXMuZm9saW8ucnBjLkZvbGlvU3ZjUG9zdENhcmRQYXlt",
            "ZW50UmVzdWx0QhiqAhVIT0xNUy5UeXBlcy5Gb2xpby5SUENiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Folio.RPC.FolioSvcPostCardPaymentResultReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.RPC.FolioSvcPostCardPaymentResponse), global::HOLMS.Types.Folio.RPC.FolioSvcPostCardPaymentResponse.Parser, new[]{ "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FolioSvcPostCardPaymentResponse : pb::IMessage<FolioSvcPostCardPaymentResponse> {
    private static readonly pb::MessageParser<FolioSvcPostCardPaymentResponse> _parser = new pb::MessageParser<FolioSvcPostCardPaymentResponse>(() => new FolioSvcPostCardPaymentResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FolioSvcPostCardPaymentResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.RPC.FolioSvcPostCardPaymentResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioSvcPostCardPaymentResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioSvcPostCardPaymentResponse(FolioSvcPostCardPaymentResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioSvcPostCardPaymentResponse Clone() {
      return new FolioSvcPostCardPaymentResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Folio.RPC.FolioSvcPostCardPaymentResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.RPC.FolioSvcPostCardPaymentResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FolioSvcPostCardPaymentResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FolioSvcPostCardPaymentResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
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
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FolioSvcPostCardPaymentResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
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
            result_ = (global::HOLMS.Types.Folio.RPC.FolioSvcPostCardPaymentResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

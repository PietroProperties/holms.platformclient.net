// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/rpc/folios_reporting_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Reporting.RPC {

  /// <summary>Holder for reflection information generated from reporting/rpc/folios_reporting_svc.proto</summary>
  public static partial class FoliosReportingSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for reporting/rpc/folios_reporting_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoliosReportingSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihyZXBvcnRpbmcvcnBjL2ZvbGlvc19yZXBvcnRpbmdfc3ZjLnByb3RvEhlo",
            "b2xtcy50eXBlcy5yZXBvcnRpbmcucnBjGjBib29raW5nL2luZGljYXRvcnMv",
            "Z3JvdXBfYm9va2luZ19pbmRpY2F0b3IucHJvdG8aLHJlcG9ydGluZy9vdXRw",
            "dXRzL2h0bWxfcmVwb3J0X3Jlc3BvbnNlLnByb3RvIksKN0ZvbGlvc1JlcG9y",
            "dGluZ1N2Y0NhcmRDYXB0dXJlUmVwb3J0aW5nU3ZjUmVwb3J0UmVzcG9uc2US",
            "EAoIZG9jdW1lbnQYASABKAkyvAMKEkZvbGlvc1JlcG9ydGluZ1N2YxKMAQog",
            "R2V0Qm9va2luZ0Fzc29jaWF0ZWRGb2xpb3NEZXRhaWwSNS5ob2xtcy50eXBl",
            "cy5ib29raW5nLmluZGljYXRvcnMuR3JvdXBCb29raW5nSW5kaWNhdG9yGjEu",
            "aG9sbXMudHlwZXMucmVwb3J0aW5nLm91dHB1dHMuSHRtbFJlcG9ydFJlc3Bv",
            "bnNlEo0BCiFHZXRCb29raW5nQXNzb2NpYXRlZEZvbGlvc1N1bW1hcnkSNS5o",
            "b2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuR3JvdXBCb29raW5nSW5k",
            "aWNhdG9yGjEuaG9sbXMudHlwZXMucmVwb3J0aW5nLm91dHB1dHMuSHRtbFJl",
            "cG9ydFJlc3BvbnNlEoYBChpHZXRSZXNlcnZhdGlvbkZvbGlvU3VtbWFyeRI1",
            "LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5Hcm91cEJvb2tpbmdJ",
            "bmRpY2F0b3IaMS5ob2xtcy50eXBlcy5yZXBvcnRpbmcub3V0cHV0cy5IdG1s",
            "UmVwb3J0UmVzcG9uc2VCHKoCGUhPTE1TLlR5cGVzLlJlcG9ydGluZy5SUENi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.GroupBookingIndicatorReflection.Descriptor, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponseReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.FoliosReportingSvcCardCaptureReportingSvcReportResponse), global::HOLMS.Types.Reporting.RPC.FoliosReportingSvcCardCaptureReportingSvcReportResponse.Parser, new[]{ "Document" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FoliosReportingSvcCardCaptureReportingSvcReportResponse : pb::IMessage<FoliosReportingSvcCardCaptureReportingSvcReportResponse> {
    private static readonly pb::MessageParser<FoliosReportingSvcCardCaptureReportingSvcReportResponse> _parser = new pb::MessageParser<FoliosReportingSvcCardCaptureReportingSvcReportResponse>(() => new FoliosReportingSvcCardCaptureReportingSvcReportResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FoliosReportingSvcCardCaptureReportingSvcReportResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.FoliosReportingSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FoliosReportingSvcCardCaptureReportingSvcReportResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FoliosReportingSvcCardCaptureReportingSvcReportResponse(FoliosReportingSvcCardCaptureReportingSvcReportResponse other) : this() {
      document_ = other.document_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FoliosReportingSvcCardCaptureReportingSvcReportResponse Clone() {
      return new FoliosReportingSvcCardCaptureReportingSvcReportResponse(this);
    }

    /// <summary>Field number for the "document" field.</summary>
    public const int DocumentFieldNumber = 1;
    private string document_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Document {
      get { return document_; }
      set {
        document_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FoliosReportingSvcCardCaptureReportingSvcReportResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FoliosReportingSvcCardCaptureReportingSvcReportResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Document != other.Document) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Document.Length != 0) hash ^= Document.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Document.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Document);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Document.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Document);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FoliosReportingSvcCardCaptureReportingSvcReportResponse other) {
      if (other == null) {
        return;
      }
      if (other.Document.Length != 0) {
        Document = other.Document;
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
            Document = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

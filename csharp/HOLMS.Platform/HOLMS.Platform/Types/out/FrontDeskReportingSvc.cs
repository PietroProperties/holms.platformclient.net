// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/rpc/front_desk_reporting_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Reporting.RPC {

  /// <summary>Holder for reflection information generated from reporting/rpc/front_desk_reporting_svc.proto</summary>
  public static partial class FrontDeskReportingSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for reporting/rpc/front_desk_reporting_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FrontDeskReportingSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixyZXBvcnRpbmcvcnBjL2Zyb250X2Rlc2tfcmVwb3J0aW5nX3N2Yy5wcm90",
            "bxIZaG9sbXMudHlwZXMucmVwb3J0aW5nLnJwYxogaWFtL3N0YWZmX21lbWJl",
            "cl9pbmRpY2F0b3IucHJvdG8aHXByaW1pdGl2ZS9wYl9sb2NhbF9kYXRlLnBy",
            "b3RvGjhyZXBvcnRpbmcvaW5wdXRfcGFyYW1zL2Zyb250X2Rlc2tfcmVwb3J0",
            "X21hbmlmZXN0cy5wcm90bxoscmVwb3J0aW5nL291dHB1dHMvaHRtbF9yZXBv",
            "cnRfcmVzcG9uc2UucHJvdG8aMnRlbmFuY3lfY29uZmlnL2luZGljYXRvcnMv",
            "cHJvcGVydHlfaW5kaWNhdG9yLnByb3RvIosDCiFGcm9udERlc2tCYXRjaFJl",
            "cG9ydGluZ1N2Y1JlcXVlc3QSTAoKcHJvcGVydGllcxgBIAMoCzI4LmhvbG1z",
            "LnR5cGVzLnRlbmFuY3lfY29uZmlnLmluZGljYXRvcnMuUHJvcGVydHlJbmRp",
            "Y2F0b3ISbgoeY2FsZW5kYXJfZGF0ZV9yZXBvcnRzX21hbmlmZXN0GAIgASgL",
            "MkYuaG9sbXMudHlwZXMucmVwb3J0aW5nLmlucHV0X3BhcmFtcy5Gcm9udERl",
            "c2tDdXJyZW50RGF0ZVJlcG9ydE1hbmlmZXN0Em8KHm9wc2RhdGVfcmFuZ2Vf",
            "cmVwb3J0c19tYW5pZmVzdBgDIAEoCzJHLmhvbG1zLnR5cGVzLnJlcG9ydGlu",
            "Zy5pbnB1dF9wYXJhbXMuRnJvbnREZXNrT3BzZGF0ZVJhbmdlUmVwb3J0TWFu",
            "aWZlc3QSGgoSaW5jbHVkZV9jaGVja2VkX2luGAQgASgIEhsKE2luY2x1ZGVf",
            "Y2hlY2tlZF9vdXQYBSABKAgirQEKKEZyb250RGVza1JlcG9ydGluZ1N2Y0hv",
            "dXNla2VlcGluZ1JlcXVlc3QSPAoNc3RhZmZfbWVtYmVycxgBIAMoCzIlLmhv",
            "bG1zLnR5cGVzLmlhbS5TdGFmZk1lbWJlckluZGljYXRvchIRCglhZGRfbm90",
            "ZXMYAiABKAkSMAoEZGF0ZRgDIAEoCzIiLmhvbG1zLnR5cGVzLnByaW1pdGl2",
            "ZS5QYkxvY2FsRGF0ZTK9AgoVRnJvbnREZXNrUmVwb3J0aW5nU3ZjEoYBChNH",
            "ZXRGcm9udERlc2tSZXBvcnRzEjwuaG9sbXMudHlwZXMucmVwb3J0aW5nLnJw",
            "Yy5Gcm9udERlc2tCYXRjaFJlcG9ydGluZ1N2Y1JlcXVlc3QaMS5ob2xtcy50",
            "eXBlcy5yZXBvcnRpbmcub3V0cHV0cy5IdG1sUmVwb3J0UmVzcG9uc2USmgEK",
            "IEdldEhvdXNla2VlcGluZ0Fzc2lnbm1lbnRzUmVwb3J0EkMuaG9sbXMudHlw",
            "ZXMucmVwb3J0aW5nLnJwYy5Gcm9udERlc2tSZXBvcnRpbmdTdmNIb3VzZWtl",
            "ZXBpbmdSZXF1ZXN0GjEuaG9sbXMudHlwZXMucmVwb3J0aW5nLm91dHB1dHMu",
            "SHRtbFJlcG9ydFJlc3BvbnNlQhyqAhlIT0xNUy5UeXBlcy5SZXBvcnRpbmcu",
            "UlBDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.IAM.StaffMemberIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, global::HOLMS.Types.Reporting.ReportParams.FrontDeskReportManifestsReflection.Descriptor, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponseReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.FrontDeskBatchReportingSvcRequest), global::HOLMS.Types.Reporting.RPC.FrontDeskBatchReportingSvcRequest.Parser, new[]{ "Properties", "CalendarDateReportsManifest", "OpsdateRangeReportsManifest", "IncludeCheckedIn", "IncludeCheckedOut" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest), global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest.Parser, new[]{ "StaffMembers", "AddNotes", "Date" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FrontDeskBatchReportingSvcRequest : pb::IMessage<FrontDeskBatchReportingSvcRequest> {
    private static readonly pb::MessageParser<FrontDeskBatchReportingSvcRequest> _parser = new pb::MessageParser<FrontDeskBatchReportingSvcRequest>(() => new FrontDeskBatchReportingSvcRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrontDeskBatchReportingSvcRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskBatchReportingSvcRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskBatchReportingSvcRequest(FrontDeskBatchReportingSvcRequest other) : this() {
      properties_ = other.properties_.Clone();
      CalendarDateReportsManifest = other.calendarDateReportsManifest_ != null ? other.CalendarDateReportsManifest.Clone() : null;
      OpsdateRangeReportsManifest = other.opsdateRangeReportsManifest_ != null ? other.OpsdateRangeReportsManifest.Clone() : null;
      includeCheckedIn_ = other.includeCheckedIn_;
      includeCheckedOut_ = other.includeCheckedOut_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskBatchReportingSvcRequest Clone() {
      return new FrontDeskBatchReportingSvcRequest(this);
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator> _repeated_properties_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator> properties_ = new pbc::RepeatedField<global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator> Properties {
      get { return properties_; }
    }

    /// <summary>Field number for the "calendar_date_reports_manifest" field.</summary>
    public const int CalendarDateReportsManifestFieldNumber = 2;
    private global::HOLMS.Types.Reporting.ReportParams.FrontDeskCurrentDateReportManifest calendarDateReportsManifest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Reporting.ReportParams.FrontDeskCurrentDateReportManifest CalendarDateReportsManifest {
      get { return calendarDateReportsManifest_; }
      set {
        calendarDateReportsManifest_ = value;
      }
    }

    /// <summary>Field number for the "opsdate_range_reports_manifest" field.</summary>
    public const int OpsdateRangeReportsManifestFieldNumber = 3;
    private global::HOLMS.Types.Reporting.ReportParams.FrontDeskOpsdateRangeReportManifest opsdateRangeReportsManifest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Reporting.ReportParams.FrontDeskOpsdateRangeReportManifest OpsdateRangeReportsManifest {
      get { return opsdateRangeReportsManifest_; }
      set {
        opsdateRangeReportsManifest_ = value;
      }
    }

    /// <summary>Field number for the "include_checked_in" field.</summary>
    public const int IncludeCheckedInFieldNumber = 4;
    private bool includeCheckedIn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IncludeCheckedIn {
      get { return includeCheckedIn_; }
      set {
        includeCheckedIn_ = value;
      }
    }

    /// <summary>Field number for the "include_checked_out" field.</summary>
    public const int IncludeCheckedOutFieldNumber = 5;
    private bool includeCheckedOut_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IncludeCheckedOut {
      get { return includeCheckedOut_; }
      set {
        includeCheckedOut_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FrontDeskBatchReportingSvcRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrontDeskBatchReportingSvcRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!properties_.Equals(other.properties_)) return false;
      if (!object.Equals(CalendarDateReportsManifest, other.CalendarDateReportsManifest)) return false;
      if (!object.Equals(OpsdateRangeReportsManifest, other.OpsdateRangeReportsManifest)) return false;
      if (IncludeCheckedIn != other.IncludeCheckedIn) return false;
      if (IncludeCheckedOut != other.IncludeCheckedOut) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= properties_.GetHashCode();
      if (calendarDateReportsManifest_ != null) hash ^= CalendarDateReportsManifest.GetHashCode();
      if (opsdateRangeReportsManifest_ != null) hash ^= OpsdateRangeReportsManifest.GetHashCode();
      if (IncludeCheckedIn != false) hash ^= IncludeCheckedIn.GetHashCode();
      if (IncludeCheckedOut != false) hash ^= IncludeCheckedOut.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      properties_.WriteTo(output, _repeated_properties_codec);
      if (calendarDateReportsManifest_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CalendarDateReportsManifest);
      }
      if (opsdateRangeReportsManifest_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OpsdateRangeReportsManifest);
      }
      if (IncludeCheckedIn != false) {
        output.WriteRawTag(32);
        output.WriteBool(IncludeCheckedIn);
      }
      if (IncludeCheckedOut != false) {
        output.WriteRawTag(40);
        output.WriteBool(IncludeCheckedOut);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += properties_.CalculateSize(_repeated_properties_codec);
      if (calendarDateReportsManifest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CalendarDateReportsManifest);
      }
      if (opsdateRangeReportsManifest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OpsdateRangeReportsManifest);
      }
      if (IncludeCheckedIn != false) {
        size += 1 + 1;
      }
      if (IncludeCheckedOut != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FrontDeskBatchReportingSvcRequest other) {
      if (other == null) {
        return;
      }
      properties_.Add(other.properties_);
      if (other.calendarDateReportsManifest_ != null) {
        if (calendarDateReportsManifest_ == null) {
          calendarDateReportsManifest_ = new global::HOLMS.Types.Reporting.ReportParams.FrontDeskCurrentDateReportManifest();
        }
        CalendarDateReportsManifest.MergeFrom(other.CalendarDateReportsManifest);
      }
      if (other.opsdateRangeReportsManifest_ != null) {
        if (opsdateRangeReportsManifest_ == null) {
          opsdateRangeReportsManifest_ = new global::HOLMS.Types.Reporting.ReportParams.FrontDeskOpsdateRangeReportManifest();
        }
        OpsdateRangeReportsManifest.MergeFrom(other.OpsdateRangeReportsManifest);
      }
      if (other.IncludeCheckedIn != false) {
        IncludeCheckedIn = other.IncludeCheckedIn;
      }
      if (other.IncludeCheckedOut != false) {
        IncludeCheckedOut = other.IncludeCheckedOut;
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
            properties_.AddEntriesFrom(input, _repeated_properties_codec);
            break;
          }
          case 18: {
            if (calendarDateReportsManifest_ == null) {
              calendarDateReportsManifest_ = new global::HOLMS.Types.Reporting.ReportParams.FrontDeskCurrentDateReportManifest();
            }
            input.ReadMessage(calendarDateReportsManifest_);
            break;
          }
          case 26: {
            if (opsdateRangeReportsManifest_ == null) {
              opsdateRangeReportsManifest_ = new global::HOLMS.Types.Reporting.ReportParams.FrontDeskOpsdateRangeReportManifest();
            }
            input.ReadMessage(opsdateRangeReportsManifest_);
            break;
          }
          case 32: {
            IncludeCheckedIn = input.ReadBool();
            break;
          }
          case 40: {
            IncludeCheckedOut = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class FrontDeskReportingSvcHousekeepingRequest : pb::IMessage<FrontDeskReportingSvcHousekeepingRequest> {
    private static readonly pb::MessageParser<FrontDeskReportingSvcHousekeepingRequest> _parser = new pb::MessageParser<FrontDeskReportingSvcHousekeepingRequest>(() => new FrontDeskReportingSvcHousekeepingRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrontDeskReportingSvcHousekeepingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcHousekeepingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcHousekeepingRequest(FrontDeskReportingSvcHousekeepingRequest other) : this() {
      staffMembers_ = other.staffMembers_.Clone();
      addNotes_ = other.addNotes_;
      Date = other.date_ != null ? other.Date.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcHousekeepingRequest Clone() {
      return new FrontDeskReportingSvcHousekeepingRequest(this);
    }

    /// <summary>Field number for the "staff_members" field.</summary>
    public const int StaffMembersFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.IAM.StaffMemberIndicator> _repeated_staffMembers_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.IAM.StaffMemberIndicator.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.IAM.StaffMemberIndicator> staffMembers_ = new pbc::RepeatedField<global::HOLMS.Types.IAM.StaffMemberIndicator>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.IAM.StaffMemberIndicator> StaffMembers {
      get { return staffMembers_; }
    }

    /// <summary>Field number for the "add_notes" field.</summary>
    public const int AddNotesFieldNumber = 2;
    private string addNotes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AddNotes {
      get { return addNotes_; }
      set {
        addNotes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 3;
    private global::HOLMS.Types.Primitive.PbLocalDate date_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate Date {
      get { return date_; }
      set {
        date_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FrontDeskReportingSvcHousekeepingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrontDeskReportingSvcHousekeepingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!staffMembers_.Equals(other.staffMembers_)) return false;
      if (AddNotes != other.AddNotes) return false;
      if (!object.Equals(Date, other.Date)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= staffMembers_.GetHashCode();
      if (AddNotes.Length != 0) hash ^= AddNotes.GetHashCode();
      if (date_ != null) hash ^= Date.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      staffMembers_.WriteTo(output, _repeated_staffMembers_codec);
      if (AddNotes.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AddNotes);
      }
      if (date_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Date);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += staffMembers_.CalculateSize(_repeated_staffMembers_codec);
      if (AddNotes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AddNotes);
      }
      if (date_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Date);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FrontDeskReportingSvcHousekeepingRequest other) {
      if (other == null) {
        return;
      }
      staffMembers_.Add(other.staffMembers_);
      if (other.AddNotes.Length != 0) {
        AddNotes = other.AddNotes;
      }
      if (other.date_ != null) {
        if (date_ == null) {
          date_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        Date.MergeFrom(other.Date);
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
            staffMembers_.AddEntriesFrom(input, _repeated_staffMembers_codec);
            break;
          }
          case 18: {
            AddNotes = input.ReadString();
            break;
          }
          case 26: {
            if (date_ == null) {
              date_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(date_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

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
            "bxIZaG9sbXMudHlwZXMucmVwb3J0aW5nLnJwYxofZ29vZ2xlL3Byb3RvYnVm",
            "L3RpbWVzdGFtcC5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3Rv",
            "GiBpYW0vc3RhZmZfbWVtYmVyX2luZGljYXRvci5wcm90bxoqcHJpbWl0aXZl",
            "L3BiX2luY2x1c2l2ZV9vcHNkYXRlX3JhbmdlLnByb3RvIkgKHEZyb250RGVz",
            "a1JlcG9ydGluZ1N2Y1JlcXVlc3QSKAoEZGF0ZRgBIAEoCzIaLmdvb2dsZS5w",
            "cm90b2J1Zi5UaW1lc3RhbXAingEKKUZyb250RGVza1JlcG9ydGluZ1N2Y0lu",
            "SG91c2VHdWVzdHNSZXF1ZXN0EigKBGRhdGUYASABKAsyGi5nb29nbGUucHJv",
            "dG9idWYuVGltZXN0YW1wEkcKCXNvcnRfdHlwZRgCIAEoDjI0LmhvbG1zLnR5",
            "cGVzLnJlcG9ydGluZy5ycGMuSW5Ib3VzZUd1ZXN0UmVwb3J0U29ydGluZyJ3",
            "CjFGcm9udERlc2tSZXBvcnRpbmdTdmNDYW5jZWxsZWRSZXNlcnZhdGlvbnNS",
            "ZXF1ZXN0EkIKCmRhdGVfcmFuZ2UYASABKAsyLi5ob2xtcy50eXBlcy5wcmlt",
            "aXRpdmUuUGJJbmNsdXNpdmVPcHNkYXRlUmFuZ2UiewooRnJvbnREZXNrUmVw",
            "b3J0aW5nU3ZjSG91c2VrZWVwaW5nUmVxdWVzdBI8Cg1zdGFmZl9tZW1iZXJz",
            "GAEgAygLMiUuaG9sbXMudHlwZXMuaWFtLlN0YWZmTWVtYmVySW5kaWNhdG9y",
            "EhEKCWFkZF9ub3RlcxgCIAEoCSI3CiNGcm9udERlc2tSZXBvcnRpbmdTdmNS",
            "ZXBvcnRSZXNwb25zZRIQCghkb2N1bWVudBgBIAEoCSpCChlJbkhvdXNlR3Vl",
            "c3RSZXBvcnRTb3J0aW5nEhEKDUJZX0dVRVNUX05BTUUQABISCg5CWV9ST09N",
            "X05VTUJFUhABMqQJChVGcm9udERlc2tSZXBvcnRpbmdTdmMSjAEKEUdldEFy",
            "cml2YWxzUmVwb3J0EjcuaG9sbXMudHlwZXMucmVwb3J0aW5nLnJwYy5Gcm9u",
            "dERlc2tSZXBvcnRpbmdTdmNSZXF1ZXN0Gj4uaG9sbXMudHlwZXMucmVwb3J0",
            "aW5nLnJwYy5Gcm9udERlc2tSZXBvcnRpbmdTdmNSZXBvcnRSZXNwb25zZRKO",
            "AQoTR2V0RGVwYXJ0dXJlc1JlcG9ydBI3LmhvbG1zLnR5cGVzLnJlcG9ydGlu",
            "Zy5ycGMuRnJvbnREZXNrUmVwb3J0aW5nU3ZjUmVxdWVzdBo+LmhvbG1zLnR5",
            "cGVzLnJlcG9ydGluZy5ycGMuRnJvbnREZXNrUmVwb3J0aW5nU3ZjUmVwb3J0",
            "UmVzcG9uc2USngEKFkdldEluSG91c2VHdWVzdHNSZXBvcnQSRC5ob2xtcy50",
            "eXBlcy5yZXBvcnRpbmcucnBjLkZyb250RGVza1JlcG9ydGluZ1N2Y0luSG91",
            "c2VHdWVzdHNSZXF1ZXN0Gj4uaG9sbXMudHlwZXMucmVwb3J0aW5nLnJwYy5G",
            "cm9udERlc2tSZXBvcnRpbmdTdmNSZXBvcnRSZXNwb25zZRKLAQoQR2V0Tm9T",
            "aG93c1JlcG9ydBI3LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5ycGMuRnJvbnRE",
            "ZXNrUmVwb3J0aW5nU3ZjUmVxdWVzdBo+LmhvbG1zLnR5cGVzLnJlcG9ydGlu",
            "Zy5ycGMuRnJvbnREZXNrUmVwb3J0aW5nU3ZjUmVwb3J0UmVzcG9uc2USpwEK",
            "IEdldEhvdXNla2VlcGluZ0Fzc2lnbm1lbnRzUmVwb3J0EkMuaG9sbXMudHlw",
            "ZXMucmVwb3J0aW5nLnJwYy5Gcm9udERlc2tSZXBvcnRpbmdTdmNIb3VzZWtl",
            "ZXBpbmdSZXF1ZXN0Gj4uaG9sbXMudHlwZXMucmVwb3J0aW5nLnJwYy5Gcm9u",
            "dERlc2tSZXBvcnRpbmdTdmNSZXBvcnRSZXNwb25zZRJ0ChpHZXRSZXNlcnZh",
            "dGlvbkNyZWRpdFJlcG9ydBIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRo+Lmhv",
            "bG1zLnR5cGVzLnJlcG9ydGluZy5ycGMuRnJvbnREZXNrUmVwb3J0aW5nU3Zj",
            "UmVwb3J0UmVzcG9uc2USawoRR2V0VmVoaWNsZXNSZXBvcnQSFi5nb29nbGUu",
            "cHJvdG9idWYuRW1wdHkaPi5ob2xtcy50eXBlcy5yZXBvcnRpbmcucnBjLkZy",
            "b250RGVza1JlcG9ydGluZ1N2Y1JlcG9ydFJlc3BvbnNlEq4BCh5HZXRDYW5j",
            "ZWxsZWRSZXNlcnZhdGlvbnNSZXBvcnQSTC5ob2xtcy50eXBlcy5yZXBvcnRp",
            "bmcucnBjLkZyb250RGVza1JlcG9ydGluZ1N2Y0NhbmNlbGxlZFJlc2VydmF0",
            "aW9uc1JlcXVlc3QaPi5ob2xtcy50eXBlcy5yZXBvcnRpbmcucnBjLkZyb250",
            "RGVza1JlcG9ydGluZ1N2Y1JlcG9ydFJlc3BvbnNlQixaDm9wZXJhdGlvbnMv",
            "cnBjqgIZSE9MTVMuVHlwZXMuUmVwb3J0aW5nLlJQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.IAM.StaffMemberIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Reporting.RPC.InHouseGuestReportSorting), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest), global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcRequest.Parser, new[]{ "Date" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest), global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcInHouseGuestsRequest.Parser, new[]{ "Date", "SortType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcCancelledReservationsRequest), global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcCancelledReservationsRequest.Parser, new[]{ "DateRange" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest), global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcHousekeepingRequest.Parser, new[]{ "StaffMembers", "AddNotes" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse), global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReportResponse.Parser, new[]{ "Document" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum InHouseGuestReportSorting {
    [pbr::OriginalName("BY_GUEST_NAME")] ByGuestName = 0,
    [pbr::OriginalName("BY_ROOM_NUMBER")] ByRoomNumber = 1,
  }

  #endregion

  #region Messages
  public sealed partial class FrontDeskReportingSvcRequest : pb::IMessage<FrontDeskReportingSvcRequest> {
    private static readonly pb::MessageParser<FrontDeskReportingSvcRequest> _parser = new pb::MessageParser<FrontDeskReportingSvcRequest>(() => new FrontDeskReportingSvcRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrontDeskReportingSvcRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcRequest(FrontDeskReportingSvcRequest other) : this() {
      Date = other.date_ != null ? other.Date.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcRequest Clone() {
      return new FrontDeskReportingSvcRequest(this);
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp date_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Date {
      get { return date_; }
      set {
        date_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FrontDeskReportingSvcRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrontDeskReportingSvcRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Date, other.Date)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (date_ != null) hash ^= Date.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (date_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Date);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (date_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Date);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FrontDeskReportingSvcRequest other) {
      if (other == null) {
        return;
      }
      if (other.date_ != null) {
        if (date_ == null) {
          date_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
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
            if (date_ == null) {
              date_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(date_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class FrontDeskReportingSvcInHouseGuestsRequest : pb::IMessage<FrontDeskReportingSvcInHouseGuestsRequest> {
    private static readonly pb::MessageParser<FrontDeskReportingSvcInHouseGuestsRequest> _parser = new pb::MessageParser<FrontDeskReportingSvcInHouseGuestsRequest>(() => new FrontDeskReportingSvcInHouseGuestsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrontDeskReportingSvcInHouseGuestsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcInHouseGuestsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcInHouseGuestsRequest(FrontDeskReportingSvcInHouseGuestsRequest other) : this() {
      Date = other.date_ != null ? other.Date.Clone() : null;
      sortType_ = other.sortType_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcInHouseGuestsRequest Clone() {
      return new FrontDeskReportingSvcInHouseGuestsRequest(this);
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp date_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Date {
      get { return date_; }
      set {
        date_ = value;
      }
    }

    /// <summary>Field number for the "sort_type" field.</summary>
    public const int SortTypeFieldNumber = 2;
    private global::HOLMS.Types.Reporting.RPC.InHouseGuestReportSorting sortType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Reporting.RPC.InHouseGuestReportSorting SortType {
      get { return sortType_; }
      set {
        sortType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FrontDeskReportingSvcInHouseGuestsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrontDeskReportingSvcInHouseGuestsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Date, other.Date)) return false;
      if (SortType != other.SortType) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (date_ != null) hash ^= Date.GetHashCode();
      if (SortType != 0) hash ^= SortType.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (date_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Date);
      }
      if (SortType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) SortType);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (date_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Date);
      }
      if (SortType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SortType);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FrontDeskReportingSvcInHouseGuestsRequest other) {
      if (other == null) {
        return;
      }
      if (other.date_ != null) {
        if (date_ == null) {
          date_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Date.MergeFrom(other.Date);
      }
      if (other.SortType != 0) {
        SortType = other.SortType;
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
            if (date_ == null) {
              date_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(date_);
            break;
          }
          case 16: {
            sortType_ = (global::HOLMS.Types.Reporting.RPC.InHouseGuestReportSorting) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class FrontDeskReportingSvcCancelledReservationsRequest : pb::IMessage<FrontDeskReportingSvcCancelledReservationsRequest> {
    private static readonly pb::MessageParser<FrontDeskReportingSvcCancelledReservationsRequest> _parser = new pb::MessageParser<FrontDeskReportingSvcCancelledReservationsRequest>(() => new FrontDeskReportingSvcCancelledReservationsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrontDeskReportingSvcCancelledReservationsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcCancelledReservationsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcCancelledReservationsRequest(FrontDeskReportingSvcCancelledReservationsRequest other) : this() {
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcCancelledReservationsRequest Clone() {
      return new FrontDeskReportingSvcCancelledReservationsRequest(this);
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 1;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FrontDeskReportingSvcCancelledReservationsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrontDeskReportingSvcCancelledReservationsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DateRange, other.DateRange)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (dateRange_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DateRange);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FrontDeskReportingSvcCancelledReservationsRequest other) {
      if (other == null) {
        return;
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
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
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
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
      get { return global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReflection.Descriptor.MessageTypes[3]; }
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
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= staffMembers_.GetHashCode();
      if (AddNotes.Length != 0) hash ^= AddNotes.GetHashCode();
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
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += staffMembers_.CalculateSize(_repeated_staffMembers_codec);
      if (AddNotes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AddNotes);
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
        }
      }
    }

  }

  public sealed partial class FrontDeskReportingSvcReportResponse : pb::IMessage<FrontDeskReportingSvcReportResponse> {
    private static readonly pb::MessageParser<FrontDeskReportingSvcReportResponse> _parser = new pb::MessageParser<FrontDeskReportingSvcReportResponse>(() => new FrontDeskReportingSvcReportResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrontDeskReportingSvcReportResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.RPC.FrontDeskReportingSvcReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcReportResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcReportResponse(FrontDeskReportingSvcReportResponse other) : this() {
      document_ = other.document_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskReportingSvcReportResponse Clone() {
      return new FrontDeskReportingSvcReportResponse(this);
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
      return Equals(other as FrontDeskReportingSvcReportResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrontDeskReportingSvcReportResponse other) {
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
    public void MergeFrom(FrontDeskReportingSvcReportResponse other) {
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

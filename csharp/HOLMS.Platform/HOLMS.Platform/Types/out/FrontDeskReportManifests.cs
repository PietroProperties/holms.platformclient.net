// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/input_params/front_desk_report_manifests.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Reporting.ReportParams {

  /// <summary>Holder for reflection information generated from reporting/input_params/front_desk_report_manifests.proto</summary>
  public static partial class FrontDeskReportManifestsReflection {

    #region Descriptor
    /// <summary>File descriptor for reporting/input_params/front_desk_report_manifests.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FrontDeskReportManifestsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhyZXBvcnRpbmcvaW5wdXRfcGFyYW1zL2Zyb250X2Rlc2tfcmVwb3J0X21h",
            "bmlmZXN0cy5wcm90bxIiaG9sbXMudHlwZXMucmVwb3J0aW5nLmlucHV0X3Bh",
            "cmFtcxoqcHJpbWl0aXZlL3BiX2luY2x1c2l2ZV9vcHNkYXRlX3JhbmdlLnBy",
            "b3RvGh1wcmltaXRpdmUvcGJfbG9jYWxfZGF0ZS5wcm90byLKBQoiRnJvbnRE",
            "ZXNrQ3VycmVudERhdGVSZXBvcnRNYW5pZmVzdBIXCg9hcnJpdmFsc19yZXBv",
            "cnQYAiABKAgSGQoRZGVwYXJ0dXJlc19yZXBvcnQYAyABKAgSHgoWaW5faG91",
            "c2VfZ3Vlc3RzX3JlcG9ydBgEIAEoCBJbChRndWVzdF9yZXBvcnRfc29ydGlu",
            "ZxgFIAEoDjI9LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5pbnB1dF9wYXJhbXMu",
            "SW5Ib3VzZUd1ZXN0UmVwb3J0U29ydGluZxIXCg92ZWhpY2xlc19yZXBvcnQY",
            "BiABKAgSFwoPbm9fc2hvd3NfcmVwb3J0GAcgASgIEh8KF3Vub2NjdXBpZWRf",
            "cm9vbXNfcmVwb3J0GAggASgIEhgKEGNhc2hfZHJvcF9yZXBvcnQYCSABKAgS",
            "EgoKc3RhcnRfdGltZRgKIAEoCRIVCg1jYXNoX2Ryb3BfZm9yGAsgASgJEhAK",
            "CGVuZF90aW1lGAwgASgJElYKDW5vdGVfY2F0ZWdvcnkYDSABKA4yPy5ob2xt",
            "cy50eXBlcy5yZXBvcnRpbmcuaW5wdXRfcGFyYW1zLkZyb250RGVza1JlcG9y",
            "dHNOb3Rlc0ZpbHRlchJcChhkZXBhcnR1cmVfcmVwb3J0X3NvcnRpbmcYDiAB",
            "KA4yOi5ob2xtcy50eXBlcy5yZXBvcnRpbmcuaW5wdXRfcGFyYW1zLkRlcGFy",
            "dHVyZVJlcG9ydFNvcnRpbmcSOQoNc2VsZWN0ZWRfZGF0ZRgPIAEoCzIiLmhv",
            "bG1zLnR5cGVzLnByaW1pdGl2ZS5QYkxvY2FsRGF0ZRJYChZhcnJpdmFsX3Jl",
            "cG9ydF9zb3J0aW5nGBAgASgOMjguaG9sbXMudHlwZXMucmVwb3J0aW5nLmlu",
            "cHV0X3BhcmFtcy5BcnJpdmFsUmVwb3J0U29ydGluZyK8AgojRnJvbnREZXNr",
            "T3BzZGF0ZVJhbmdlUmVwb3J0TWFuaWZlc3QSQgoKZGF0ZV9yYW5nZRgBIAEo",
            "CzIuLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5QYkluY2x1c2l2ZU9wc2RhdGVS",
            "YW5nZRIjChtnZW5lcmFsX2F2YWlsYWJpbGl0eV9yZXBvcnQYAiABKAgSJQod",
            "Y2FuY2VsbGVkX3Jlc2VydmF0aW9uc19yZXBvcnQYAyABKAgSYgogYXJyaXZh",
            "bF9yZXBvcnRfZGF0ZXJhbmdlX3NvcnRpbmcYBCABKA4yOC5ob2xtcy50eXBl",
            "cy5yZXBvcnRpbmcuaW5wdXRfcGFyYW1zLkFycml2YWxSZXBvcnRTb3J0aW5n",
            "EiEKGWFycml2YWxzX3JlcG9ydF9kYXRlcmFuZ2UYBSABKAgqQgoZSW5Ib3Vz",
            "ZUd1ZXN0UmVwb3J0U29ydGluZxIRCg1CWV9HVUVTVF9OQU1FEAASEgoOQllf",
            "Uk9PTV9OVU1CRVIQASo9ChZEZXBhcnR1cmVSZXBvcnRTb3J0aW5nEhYKEkJZ",
            "X0dVRVNUX05BTUVfU09SVBAAEgsKB0JZX1JPT00QASpQChRBcnJpdmFsUmVw",
            "b3J0U29ydGluZxIeChpBUlJJVkFMX0JZX0dVRVNUX05BTUVfU09SVBAAEhgK",
            "FEFSUklWQUxfQllfUk9PTV9TT1JUEAEqWAobRnJvbnREZXNrUmVwb3J0c05v",
            "dGVzRmlsdGVyEggKBE5PTkUQABINCglBTExfTk9URVMQARIOCgpGUk9OVF9E",
            "RVNLEAISEAoMSE9VU0VLRUVQSU5HEANCPVoWcmVwb3J0aW5nL2lucHV0X3Bh",
            "cmFtc6oCIkhPTE1TLlR5cGVzLlJlcG9ydGluZy5SZXBvcnRQYXJhbXNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Reporting.ReportParams.InHouseGuestReportSorting), typeof(global::HOLMS.Types.Reporting.ReportParams.DepartureReportSorting), typeof(global::HOLMS.Types.Reporting.ReportParams.ArrivalReportSorting), typeof(global::HOLMS.Types.Reporting.ReportParams.FrontDeskReportsNotesFilter), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.ReportParams.FrontDeskCurrentDateReportManifest), global::HOLMS.Types.Reporting.ReportParams.FrontDeskCurrentDateReportManifest.Parser, new[]{ "ArrivalsReport", "DeparturesReport", "InHouseGuestsReport", "GuestReportSorting", "VehiclesReport", "NoShowsReport", "UnoccupiedRoomsReport", "CashDropReport", "StartTime", "CashDropFor", "EndTime", "NoteCategory", "DepartureReportSorting", "SelectedDate", "ArrivalReportSorting" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.ReportParams.FrontDeskOpsdateRangeReportManifest), global::HOLMS.Types.Reporting.ReportParams.FrontDeskOpsdateRangeReportManifest.Parser, new[]{ "DateRange", "GeneralAvailabilityReport", "CancelledReservationsReport", "ArrivalReportDaterangeSorting", "ArrivalsReportDaterange" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum InHouseGuestReportSorting {
    [pbr::OriginalName("BY_GUEST_NAME")] ByGuestName = 0,
    [pbr::OriginalName("BY_ROOM_NUMBER")] ByRoomNumber = 1,
  }

  public enum DepartureReportSorting {
    [pbr::OriginalName("BY_GUEST_NAME_SORT")] ByGuestNameSort = 0,
    [pbr::OriginalName("BY_ROOM")] ByRoom = 1,
  }

  public enum ArrivalReportSorting {
    [pbr::OriginalName("ARRIVAL_BY_GUEST_NAME_SORT")] ArrivalByGuestNameSort = 0,
    [pbr::OriginalName("ARRIVAL_BY_ROOM_SORT")] ArrivalByRoomSort = 1,
  }

  public enum FrontDeskReportsNotesFilter {
    [pbr::OriginalName("NONE")] None = 0,
    [pbr::OriginalName("ALL_NOTES")] AllNotes = 1,
    [pbr::OriginalName("FRONT_DESK")] FrontDesk = 2,
    [pbr::OriginalName("HOUSEKEEPING")] Housekeeping = 3,
  }

  #endregion

  #region Messages
  public sealed partial class FrontDeskCurrentDateReportManifest : pb::IMessage<FrontDeskCurrentDateReportManifest> {
    private static readonly pb::MessageParser<FrontDeskCurrentDateReportManifest> _parser = new pb::MessageParser<FrontDeskCurrentDateReportManifest>(() => new FrontDeskCurrentDateReportManifest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrontDeskCurrentDateReportManifest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.ReportParams.FrontDeskReportManifestsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskCurrentDateReportManifest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskCurrentDateReportManifest(FrontDeskCurrentDateReportManifest other) : this() {
      arrivalsReport_ = other.arrivalsReport_;
      departuresReport_ = other.departuresReport_;
      inHouseGuestsReport_ = other.inHouseGuestsReport_;
      guestReportSorting_ = other.guestReportSorting_;
      vehiclesReport_ = other.vehiclesReport_;
      noShowsReport_ = other.noShowsReport_;
      unoccupiedRoomsReport_ = other.unoccupiedRoomsReport_;
      cashDropReport_ = other.cashDropReport_;
      startTime_ = other.startTime_;
      cashDropFor_ = other.cashDropFor_;
      endTime_ = other.endTime_;
      noteCategory_ = other.noteCategory_;
      departureReportSorting_ = other.departureReportSorting_;
      SelectedDate = other.selectedDate_ != null ? other.SelectedDate.Clone() : null;
      arrivalReportSorting_ = other.arrivalReportSorting_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskCurrentDateReportManifest Clone() {
      return new FrontDeskCurrentDateReportManifest(this);
    }

    /// <summary>Field number for the "arrivals_report" field.</summary>
    public const int ArrivalsReportFieldNumber = 2;
    private bool arrivalsReport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ArrivalsReport {
      get { return arrivalsReport_; }
      set {
        arrivalsReport_ = value;
      }
    }

    /// <summary>Field number for the "departures_report" field.</summary>
    public const int DeparturesReportFieldNumber = 3;
    private bool departuresReport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DeparturesReport {
      get { return departuresReport_; }
      set {
        departuresReport_ = value;
      }
    }

    /// <summary>Field number for the "in_house_guests_report" field.</summary>
    public const int InHouseGuestsReportFieldNumber = 4;
    private bool inHouseGuestsReport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool InHouseGuestsReport {
      get { return inHouseGuestsReport_; }
      set {
        inHouseGuestsReport_ = value;
      }
    }

    /// <summary>Field number for the "guest_report_sorting" field.</summary>
    public const int GuestReportSortingFieldNumber = 5;
    private global::HOLMS.Types.Reporting.ReportParams.InHouseGuestReportSorting guestReportSorting_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Reporting.ReportParams.InHouseGuestReportSorting GuestReportSorting {
      get { return guestReportSorting_; }
      set {
        guestReportSorting_ = value;
      }
    }

    /// <summary>Field number for the "vehicles_report" field.</summary>
    public const int VehiclesReportFieldNumber = 6;
    private bool vehiclesReport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool VehiclesReport {
      get { return vehiclesReport_; }
      set {
        vehiclesReport_ = value;
      }
    }

    /// <summary>Field number for the "no_shows_report" field.</summary>
    public const int NoShowsReportFieldNumber = 7;
    private bool noShowsReport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool NoShowsReport {
      get { return noShowsReport_; }
      set {
        noShowsReport_ = value;
      }
    }

    /// <summary>Field number for the "unoccupied_rooms_report" field.</summary>
    public const int UnoccupiedRoomsReportFieldNumber = 8;
    private bool unoccupiedRoomsReport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool UnoccupiedRoomsReport {
      get { return unoccupiedRoomsReport_; }
      set {
        unoccupiedRoomsReport_ = value;
      }
    }

    /// <summary>Field number for the "cash_drop_report" field.</summary>
    public const int CashDropReportFieldNumber = 9;
    private bool cashDropReport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CashDropReport {
      get { return cashDropReport_; }
      set {
        cashDropReport_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 10;
    private string startTime_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StartTime {
      get { return startTime_; }
      set {
        startTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cash_drop_for" field.</summary>
    public const int CashDropForFieldNumber = 11;
    private string cashDropFor_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CashDropFor {
      get { return cashDropFor_; }
      set {
        cashDropFor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 12;
    private string endTime_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EndTime {
      get { return endTime_; }
      set {
        endTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "note_category" field.</summary>
    public const int NoteCategoryFieldNumber = 13;
    private global::HOLMS.Types.Reporting.ReportParams.FrontDeskReportsNotesFilter noteCategory_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Reporting.ReportParams.FrontDeskReportsNotesFilter NoteCategory {
      get { return noteCategory_; }
      set {
        noteCategory_ = value;
      }
    }

    /// <summary>Field number for the "departure_report_sorting" field.</summary>
    public const int DepartureReportSortingFieldNumber = 14;
    private global::HOLMS.Types.Reporting.ReportParams.DepartureReportSorting departureReportSorting_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Reporting.ReportParams.DepartureReportSorting DepartureReportSorting {
      get { return departureReportSorting_; }
      set {
        departureReportSorting_ = value;
      }
    }

    /// <summary>Field number for the "selected_date" field.</summary>
    public const int SelectedDateFieldNumber = 15;
    private global::HOLMS.Types.Primitive.PbLocalDate selectedDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate SelectedDate {
      get { return selectedDate_; }
      set {
        selectedDate_ = value;
      }
    }

    /// <summary>Field number for the "arrival_report_sorting" field.</summary>
    public const int ArrivalReportSortingFieldNumber = 16;
    private global::HOLMS.Types.Reporting.ReportParams.ArrivalReportSorting arrivalReportSorting_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Reporting.ReportParams.ArrivalReportSorting ArrivalReportSorting {
      get { return arrivalReportSorting_; }
      set {
        arrivalReportSorting_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FrontDeskCurrentDateReportManifest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrontDeskCurrentDateReportManifest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ArrivalsReport != other.ArrivalsReport) return false;
      if (DeparturesReport != other.DeparturesReport) return false;
      if (InHouseGuestsReport != other.InHouseGuestsReport) return false;
      if (GuestReportSorting != other.GuestReportSorting) return false;
      if (VehiclesReport != other.VehiclesReport) return false;
      if (NoShowsReport != other.NoShowsReport) return false;
      if (UnoccupiedRoomsReport != other.UnoccupiedRoomsReport) return false;
      if (CashDropReport != other.CashDropReport) return false;
      if (StartTime != other.StartTime) return false;
      if (CashDropFor != other.CashDropFor) return false;
      if (EndTime != other.EndTime) return false;
      if (NoteCategory != other.NoteCategory) return false;
      if (DepartureReportSorting != other.DepartureReportSorting) return false;
      if (!object.Equals(SelectedDate, other.SelectedDate)) return false;
      if (ArrivalReportSorting != other.ArrivalReportSorting) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ArrivalsReport != false) hash ^= ArrivalsReport.GetHashCode();
      if (DeparturesReport != false) hash ^= DeparturesReport.GetHashCode();
      if (InHouseGuestsReport != false) hash ^= InHouseGuestsReport.GetHashCode();
      if (GuestReportSorting != 0) hash ^= GuestReportSorting.GetHashCode();
      if (VehiclesReport != false) hash ^= VehiclesReport.GetHashCode();
      if (NoShowsReport != false) hash ^= NoShowsReport.GetHashCode();
      if (UnoccupiedRoomsReport != false) hash ^= UnoccupiedRoomsReport.GetHashCode();
      if (CashDropReport != false) hash ^= CashDropReport.GetHashCode();
      if (StartTime.Length != 0) hash ^= StartTime.GetHashCode();
      if (CashDropFor.Length != 0) hash ^= CashDropFor.GetHashCode();
      if (EndTime.Length != 0) hash ^= EndTime.GetHashCode();
      if (NoteCategory != 0) hash ^= NoteCategory.GetHashCode();
      if (DepartureReportSorting != 0) hash ^= DepartureReportSorting.GetHashCode();
      if (selectedDate_ != null) hash ^= SelectedDate.GetHashCode();
      if (ArrivalReportSorting != 0) hash ^= ArrivalReportSorting.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ArrivalsReport != false) {
        output.WriteRawTag(16);
        output.WriteBool(ArrivalsReport);
      }
      if (DeparturesReport != false) {
        output.WriteRawTag(24);
        output.WriteBool(DeparturesReport);
      }
      if (InHouseGuestsReport != false) {
        output.WriteRawTag(32);
        output.WriteBool(InHouseGuestsReport);
      }
      if (GuestReportSorting != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) GuestReportSorting);
      }
      if (VehiclesReport != false) {
        output.WriteRawTag(48);
        output.WriteBool(VehiclesReport);
      }
      if (NoShowsReport != false) {
        output.WriteRawTag(56);
        output.WriteBool(NoShowsReport);
      }
      if (UnoccupiedRoomsReport != false) {
        output.WriteRawTag(64);
        output.WriteBool(UnoccupiedRoomsReport);
      }
      if (CashDropReport != false) {
        output.WriteRawTag(72);
        output.WriteBool(CashDropReport);
      }
      if (StartTime.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(StartTime);
      }
      if (CashDropFor.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(CashDropFor);
      }
      if (EndTime.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(EndTime);
      }
      if (NoteCategory != 0) {
        output.WriteRawTag(104);
        output.WriteEnum((int) NoteCategory);
      }
      if (DepartureReportSorting != 0) {
        output.WriteRawTag(112);
        output.WriteEnum((int) DepartureReportSorting);
      }
      if (selectedDate_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(SelectedDate);
      }
      if (ArrivalReportSorting != 0) {
        output.WriteRawTag(128, 1);
        output.WriteEnum((int) ArrivalReportSorting);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ArrivalsReport != false) {
        size += 1 + 1;
      }
      if (DeparturesReport != false) {
        size += 1 + 1;
      }
      if (InHouseGuestsReport != false) {
        size += 1 + 1;
      }
      if (GuestReportSorting != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GuestReportSorting);
      }
      if (VehiclesReport != false) {
        size += 1 + 1;
      }
      if (NoShowsReport != false) {
        size += 1 + 1;
      }
      if (UnoccupiedRoomsReport != false) {
        size += 1 + 1;
      }
      if (CashDropReport != false) {
        size += 1 + 1;
      }
      if (StartTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StartTime);
      }
      if (CashDropFor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CashDropFor);
      }
      if (EndTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EndTime);
      }
      if (NoteCategory != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NoteCategory);
      }
      if (DepartureReportSorting != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DepartureReportSorting);
      }
      if (selectedDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SelectedDate);
      }
      if (ArrivalReportSorting != 0) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) ArrivalReportSorting);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FrontDeskCurrentDateReportManifest other) {
      if (other == null) {
        return;
      }
      if (other.ArrivalsReport != false) {
        ArrivalsReport = other.ArrivalsReport;
      }
      if (other.DeparturesReport != false) {
        DeparturesReport = other.DeparturesReport;
      }
      if (other.InHouseGuestsReport != false) {
        InHouseGuestsReport = other.InHouseGuestsReport;
      }
      if (other.GuestReportSorting != 0) {
        GuestReportSorting = other.GuestReportSorting;
      }
      if (other.VehiclesReport != false) {
        VehiclesReport = other.VehiclesReport;
      }
      if (other.NoShowsReport != false) {
        NoShowsReport = other.NoShowsReport;
      }
      if (other.UnoccupiedRoomsReport != false) {
        UnoccupiedRoomsReport = other.UnoccupiedRoomsReport;
      }
      if (other.CashDropReport != false) {
        CashDropReport = other.CashDropReport;
      }
      if (other.StartTime.Length != 0) {
        StartTime = other.StartTime;
      }
      if (other.CashDropFor.Length != 0) {
        CashDropFor = other.CashDropFor;
      }
      if (other.EndTime.Length != 0) {
        EndTime = other.EndTime;
      }
      if (other.NoteCategory != 0) {
        NoteCategory = other.NoteCategory;
      }
      if (other.DepartureReportSorting != 0) {
        DepartureReportSorting = other.DepartureReportSorting;
      }
      if (other.selectedDate_ != null) {
        if (selectedDate_ == null) {
          selectedDate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        SelectedDate.MergeFrom(other.SelectedDate);
      }
      if (other.ArrivalReportSorting != 0) {
        ArrivalReportSorting = other.ArrivalReportSorting;
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
          case 16: {
            ArrivalsReport = input.ReadBool();
            break;
          }
          case 24: {
            DeparturesReport = input.ReadBool();
            break;
          }
          case 32: {
            InHouseGuestsReport = input.ReadBool();
            break;
          }
          case 40: {
            guestReportSorting_ = (global::HOLMS.Types.Reporting.ReportParams.InHouseGuestReportSorting) input.ReadEnum();
            break;
          }
          case 48: {
            VehiclesReport = input.ReadBool();
            break;
          }
          case 56: {
            NoShowsReport = input.ReadBool();
            break;
          }
          case 64: {
            UnoccupiedRoomsReport = input.ReadBool();
            break;
          }
          case 72: {
            CashDropReport = input.ReadBool();
            break;
          }
          case 82: {
            StartTime = input.ReadString();
            break;
          }
          case 90: {
            CashDropFor = input.ReadString();
            break;
          }
          case 98: {
            EndTime = input.ReadString();
            break;
          }
          case 104: {
            noteCategory_ = (global::HOLMS.Types.Reporting.ReportParams.FrontDeskReportsNotesFilter) input.ReadEnum();
            break;
          }
          case 112: {
            departureReportSorting_ = (global::HOLMS.Types.Reporting.ReportParams.DepartureReportSorting) input.ReadEnum();
            break;
          }
          case 122: {
            if (selectedDate_ == null) {
              selectedDate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(selectedDate_);
            break;
          }
          case 128: {
            arrivalReportSorting_ = (global::HOLMS.Types.Reporting.ReportParams.ArrivalReportSorting) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class FrontDeskOpsdateRangeReportManifest : pb::IMessage<FrontDeskOpsdateRangeReportManifest> {
    private static readonly pb::MessageParser<FrontDeskOpsdateRangeReportManifest> _parser = new pb::MessageParser<FrontDeskOpsdateRangeReportManifest>(() => new FrontDeskOpsdateRangeReportManifest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrontDeskOpsdateRangeReportManifest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.ReportParams.FrontDeskReportManifestsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskOpsdateRangeReportManifest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskOpsdateRangeReportManifest(FrontDeskOpsdateRangeReportManifest other) : this() {
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
      generalAvailabilityReport_ = other.generalAvailabilityReport_;
      cancelledReservationsReport_ = other.cancelledReservationsReport_;
      arrivalReportDaterangeSorting_ = other.arrivalReportDaterangeSorting_;
      arrivalsReportDaterange_ = other.arrivalsReportDaterange_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrontDeskOpsdateRangeReportManifest Clone() {
      return new FrontDeskOpsdateRangeReportManifest(this);
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

    /// <summary>Field number for the "general_availability_report" field.</summary>
    public const int GeneralAvailabilityReportFieldNumber = 2;
    private bool generalAvailabilityReport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool GeneralAvailabilityReport {
      get { return generalAvailabilityReport_; }
      set {
        generalAvailabilityReport_ = value;
      }
    }

    /// <summary>Field number for the "cancelled_reservations_report" field.</summary>
    public const int CancelledReservationsReportFieldNumber = 3;
    private bool cancelledReservationsReport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CancelledReservationsReport {
      get { return cancelledReservationsReport_; }
      set {
        cancelledReservationsReport_ = value;
      }
    }

    /// <summary>Field number for the "arrival_report_daterange_sorting" field.</summary>
    public const int ArrivalReportDaterangeSortingFieldNumber = 4;
    private global::HOLMS.Types.Reporting.ReportParams.ArrivalReportSorting arrivalReportDaterangeSorting_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Reporting.ReportParams.ArrivalReportSorting ArrivalReportDaterangeSorting {
      get { return arrivalReportDaterangeSorting_; }
      set {
        arrivalReportDaterangeSorting_ = value;
      }
    }

    /// <summary>Field number for the "arrivals_report_daterange" field.</summary>
    public const int ArrivalsReportDaterangeFieldNumber = 5;
    private bool arrivalsReportDaterange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ArrivalsReportDaterange {
      get { return arrivalsReportDaterange_; }
      set {
        arrivalsReportDaterange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FrontDeskOpsdateRangeReportManifest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrontDeskOpsdateRangeReportManifest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DateRange, other.DateRange)) return false;
      if (GeneralAvailabilityReport != other.GeneralAvailabilityReport) return false;
      if (CancelledReservationsReport != other.CancelledReservationsReport) return false;
      if (ArrivalReportDaterangeSorting != other.ArrivalReportDaterangeSorting) return false;
      if (ArrivalsReportDaterange != other.ArrivalsReportDaterange) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      if (GeneralAvailabilityReport != false) hash ^= GeneralAvailabilityReport.GetHashCode();
      if (CancelledReservationsReport != false) hash ^= CancelledReservationsReport.GetHashCode();
      if (ArrivalReportDaterangeSorting != 0) hash ^= ArrivalReportDaterangeSorting.GetHashCode();
      if (ArrivalsReportDaterange != false) hash ^= ArrivalsReportDaterange.GetHashCode();
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
      if (GeneralAvailabilityReport != false) {
        output.WriteRawTag(16);
        output.WriteBool(GeneralAvailabilityReport);
      }
      if (CancelledReservationsReport != false) {
        output.WriteRawTag(24);
        output.WriteBool(CancelledReservationsReport);
      }
      if (ArrivalReportDaterangeSorting != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ArrivalReportDaterangeSorting);
      }
      if (ArrivalsReportDaterange != false) {
        output.WriteRawTag(40);
        output.WriteBool(ArrivalsReportDaterange);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      if (GeneralAvailabilityReport != false) {
        size += 1 + 1;
      }
      if (CancelledReservationsReport != false) {
        size += 1 + 1;
      }
      if (ArrivalReportDaterangeSorting != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArrivalReportDaterangeSorting);
      }
      if (ArrivalsReportDaterange != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FrontDeskOpsdateRangeReportManifest other) {
      if (other == null) {
        return;
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
      }
      if (other.GeneralAvailabilityReport != false) {
        GeneralAvailabilityReport = other.GeneralAvailabilityReport;
      }
      if (other.CancelledReservationsReport != false) {
        CancelledReservationsReport = other.CancelledReservationsReport;
      }
      if (other.ArrivalReportDaterangeSorting != 0) {
        ArrivalReportDaterangeSorting = other.ArrivalReportDaterangeSorting;
      }
      if (other.ArrivalsReportDaterange != false) {
        ArrivalsReportDaterange = other.ArrivalsReportDaterange;
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
          case 16: {
            GeneralAvailabilityReport = input.ReadBool();
            break;
          }
          case 24: {
            CancelledReservationsReport = input.ReadBool();
            break;
          }
          case 32: {
            arrivalReportDaterangeSorting_ = (global::HOLMS.Types.Reporting.ReportParams.ArrivalReportSorting) input.ReadEnum();
            break;
          }
          case 40: {
            ArrivalsReportDaterange = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/input_params/property_clocktime_range.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Reporting.ReportParams {

  /// <summary>Holder for reflection information generated from reporting/input_params/property_clocktime_range.proto</summary>
  public static partial class PropertyClocktimeRangeReflection {

    #region Descriptor
    /// <summary>File descriptor for reporting/input_params/property_clocktime_range.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PropertyClocktimeRangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVyZXBvcnRpbmcvaW5wdXRfcGFyYW1zL3Byb3BlcnR5X2Nsb2NrdGltZV9y",
            "YW5nZS5wcm90bxIiaG9sbXMudHlwZXMucmVwb3J0aW5nLmlucHV0X3BhcmFt",
            "cxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxoydGVuYW5jeV9j",
            "b25maWcvaW5kaWNhdG9ycy9wcm9wZXJ0eV9pbmRpY2F0b3IucHJvdG8i3gEK",
            "FlByb3BlcnR5Q2xvY2tUaW1lUmFuZ2USPAoYcmVwb3J0aW5nX2ludGVydmFs",
            "X3N0YXJ0GAEgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBI6ChZy",
            "ZXBvcnRpbmdfaW50ZXJ2YWxfZW5kGAIgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcBJKCghwcm9wZXJ0eRgDIAEoCzI4LmhvbG1zLnR5cGVzLnRl",
            "bmFuY3lfY29uZmlnLmluZGljYXRvcnMuUHJvcGVydHlJbmRpY2F0b3JCPVoW",
            "cmVwb3J0aW5nL2lucHV0X3BhcmFtc6oCIkhPTE1TLlR5cGVzLlJlcG9ydGlu",
            "Zy5SZXBvcnRQYXJhbXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange), global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange.Parser, new[]{ "ReportingIntervalStart", "ReportingIntervalEnd", "Property" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PropertyClockTimeRange : pb::IMessage<PropertyClockTimeRange> {
    private static readonly pb::MessageParser<PropertyClockTimeRange> _parser = new pb::MessageParser<PropertyClockTimeRange>(() => new PropertyClockTimeRange());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PropertyClockTimeRange> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Reporting.ReportParams.PropertyClocktimeRangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyClockTimeRange() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyClockTimeRange(PropertyClockTimeRange other) : this() {
      ReportingIntervalStart = other.reportingIntervalStart_ != null ? other.ReportingIntervalStart.Clone() : null;
      ReportingIntervalEnd = other.reportingIntervalEnd_ != null ? other.ReportingIntervalEnd.Clone() : null;
      Property = other.property_ != null ? other.Property.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyClockTimeRange Clone() {
      return new PropertyClockTimeRange(this);
    }

    /// <summary>Field number for the "reporting_interval_start" field.</summary>
    public const int ReportingIntervalStartFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp reportingIntervalStart_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ReportingIntervalStart {
      get { return reportingIntervalStart_; }
      set {
        reportingIntervalStart_ = value;
      }
    }

    /// <summary>Field number for the "reporting_interval_end" field.</summary>
    public const int ReportingIntervalEndFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp reportingIntervalEnd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ReportingIntervalEnd {
      get { return reportingIntervalEnd_; }
      set {
        reportingIntervalEnd_ = value;
      }
    }

    /// <summary>Field number for the "property" field.</summary>
    public const int PropertyFieldNumber = 3;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator property_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator Property {
      get { return property_; }
      set {
        property_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PropertyClockTimeRange);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PropertyClockTimeRange other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ReportingIntervalStart, other.ReportingIntervalStart)) return false;
      if (!object.Equals(ReportingIntervalEnd, other.ReportingIntervalEnd)) return false;
      if (!object.Equals(Property, other.Property)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reportingIntervalStart_ != null) hash ^= ReportingIntervalStart.GetHashCode();
      if (reportingIntervalEnd_ != null) hash ^= ReportingIntervalEnd.GetHashCode();
      if (property_ != null) hash ^= Property.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (reportingIntervalStart_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ReportingIntervalStart);
      }
      if (reportingIntervalEnd_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ReportingIntervalEnd);
      }
      if (property_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Property);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reportingIntervalStart_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReportingIntervalStart);
      }
      if (reportingIntervalEnd_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReportingIntervalEnd);
      }
      if (property_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Property);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PropertyClockTimeRange other) {
      if (other == null) {
        return;
      }
      if (other.reportingIntervalStart_ != null) {
        if (reportingIntervalStart_ == null) {
          reportingIntervalStart_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ReportingIntervalStart.MergeFrom(other.ReportingIntervalStart);
      }
      if (other.reportingIntervalEnd_ != null) {
        if (reportingIntervalEnd_ == null) {
          reportingIntervalEnd_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ReportingIntervalEnd.MergeFrom(other.ReportingIntervalEnd);
      }
      if (other.property_ != null) {
        if (property_ == null) {
          property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        Property.MergeFrom(other.Property);
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
            if (reportingIntervalStart_ == null) {
              reportingIntervalStart_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(reportingIntervalStart_);
            break;
          }
          case 18: {
            if (reportingIntervalEnd_ == null) {
              reportingIntervalEnd_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(reportingIntervalEnd_);
            break;
          }
          case 26: {
            if (property_ == null) {
              property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(property_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
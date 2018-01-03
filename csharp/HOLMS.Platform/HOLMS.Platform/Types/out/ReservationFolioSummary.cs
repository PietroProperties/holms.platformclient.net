// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/fsv2/reservation_folio_summary.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio.FSv2 {

  /// <summary>Holder for reflection information generated from folio/fsv2/reservation_folio_summary.proto</summary>
  public static partial class ReservationFolioSummaryReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/fsv2/reservation_folio_summary.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationFolioSummaryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipmb2xpby9mc3YyL3Jlc2VydmF0aW9uX2ZvbGlvX3N1bW1hcnkucHJvdG8S",
            "FmhvbG1zLnR5cGVzLmZvbGlvLmZzdjIaLmJvb2tpbmcvaW5kaWNhdG9ycy9y",
            "ZXNlcnZhdGlvbl9pbmRpY2F0b3IucHJvdG8aN2Jvb2tpbmcvcmVzZXJ2YXRp",
            "b25zL3Jlc2VydmF0aW9uX2d1YXJhbnRlZV9zdGF0dXMucHJvdG8aIGZvbGlv",
            "L2ZzdjIvZm9saW9faW5kaWNhdG9yLnByb3RvGiRmb2xpby9mc3YyL21hc3Rl",
            "cl9mb2xpb19zdGF0dXMucHJvdG8aMnRlbmFuY3lfY29uZmlnL2luZGljYXRv",
            "cnMvcHJvcGVydHlfaW5kaWNhdG9yLnByb3RvGh1wcmltaXRpdmUvcGJfbG9j",
            "YWxfZGF0ZS5wcm90byKTBAoXUmVzZXJ2YXRpb25Gb2xpb1N1bW1hcnkSTAoO",
            "cmVzZXJ2YXRpb25faWQYASABKAsyNC5ob2xtcy50eXBlcy5ib29raW5nLmlu",
            "ZGljYXRvcnMuUmVzZXJ2YXRpb25JbmRpY2F0b3ISRgoTbWFzdGVyX2ZvbGlv",
            "X3N0YXR1cxgCIAEoDjIpLmhvbG1zLnR5cGVzLmZvbGlvLmZzdjIuTWFzdGVy",
            "Rm9saW9TdGF0dXMSPAoMbWFzdGVyX2ZvbGlvGAMgASgLMiYuaG9sbXMudHlw",
            "ZXMuZm9saW8uZnN2Mi5Gb2xpb0luZGljYXRvchI9Cg1jbGllbnRfZm9saW9z",
            "GAUgAygLMiYuaG9sbXMudHlwZXMuZm9saW8uZnN2Mi5Gb2xpb0luZGljYXRv",
            "chJWChBndWFyYW50ZWVfc3RhdHVzGAYgASgOMjwuaG9sbXMudHlwZXMuYm9v",
            "a2luZy5yZXNlcnZhdGlvbnMuUmVzZXJ2YXRpb25HdWFyYW50ZWVTdGF0dXMS",
            "PAoQZ3VhcmFudGVlX2R1ZV9vbhgHIAEoCzIiLmhvbG1zLnR5cGVzLnByaW1p",
            "dGl2ZS5QYkxvY2FsRGF0ZRJPCg1ob3N0X3Byb3BlcnR5GAggASgLMjguaG9s",
            "bXMudHlwZXMudGVuYW5jeV9jb25maWcuaW5kaWNhdG9ycy5Qcm9wZXJ0eUlu",
            "ZGljYXRvckIZqgIWSE9MTVMuVHlwZXMuRm9saW8uRlN2MmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatusReflection.Descriptor, global::HOLMS.Types.Folio.FSv2.FolioIndicatorReflection.Descriptor, global::HOLMS.Types.Folio.FSv2.MasterFolioStatusReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.FSv2.ReservationFolioSummary), global::HOLMS.Types.Folio.FSv2.ReservationFolioSummary.Parser, new[]{ "ReservationId", "MasterFolioStatus", "MasterFolio", "ClientFolios", "GuaranteeStatus", "GuaranteeDueOn", "HostProperty" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationFolioSummary : pb::IMessage<ReservationFolioSummary> {
    private static readonly pb::MessageParser<ReservationFolioSummary> _parser = new pb::MessageParser<ReservationFolioSummary>(() => new ReservationFolioSummary());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationFolioSummary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.FSv2.ReservationFolioSummaryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFolioSummary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFolioSummary(ReservationFolioSummary other) : this() {
      ReservationId = other.reservationId_ != null ? other.ReservationId.Clone() : null;
      masterFolioStatus_ = other.masterFolioStatus_;
      MasterFolio = other.masterFolio_ != null ? other.MasterFolio.Clone() : null;
      clientFolios_ = other.clientFolios_.Clone();
      guaranteeStatus_ = other.guaranteeStatus_;
      GuaranteeDueOn = other.guaranteeDueOn_ != null ? other.GuaranteeDueOn.Clone() : null;
      HostProperty = other.hostProperty_ != null ? other.HostProperty.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFolioSummary Clone() {
      return new ReservationFolioSummary(this);
    }

    /// <summary>Field number for the "reservation_id" field.</summary>
    public const int ReservationIdFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservationId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator ReservationId {
      get { return reservationId_; }
      set {
        reservationId_ = value;
      }
    }

    /// <summary>Field number for the "master_folio_status" field.</summary>
    public const int MasterFolioStatusFieldNumber = 2;
    private global::HOLMS.Types.Folio.FSv2.MasterFolioStatus masterFolioStatus_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.FSv2.MasterFolioStatus MasterFolioStatus {
      get { return masterFolioStatus_; }
      set {
        masterFolioStatus_ = value;
      }
    }

    /// <summary>Field number for the "master_folio" field.</summary>
    public const int MasterFolioFieldNumber = 3;
    private global::HOLMS.Types.Folio.FSv2.FolioIndicator masterFolio_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.FSv2.FolioIndicator MasterFolio {
      get { return masterFolio_; }
      set {
        masterFolio_ = value;
      }
    }

    /// <summary>Field number for the "client_folios" field.</summary>
    public const int ClientFoliosFieldNumber = 5;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.FSv2.FolioIndicator> _repeated_clientFolios_codec
        = pb::FieldCodec.ForMessage(42, global::HOLMS.Types.Folio.FSv2.FolioIndicator.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.FSv2.FolioIndicator> clientFolios_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.FSv2.FolioIndicator>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.FSv2.FolioIndicator> ClientFolios {
      get { return clientFolios_; }
    }

    /// <summary>Field number for the "guarantee_status" field.</summary>
    public const int GuaranteeStatusFieldNumber = 6;
    private global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatus guaranteeStatus_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatus GuaranteeStatus {
      get { return guaranteeStatus_; }
      set {
        guaranteeStatus_ = value;
      }
    }

    /// <summary>Field number for the "guarantee_due_on" field.</summary>
    public const int GuaranteeDueOnFieldNumber = 7;
    private global::HOLMS.Types.Primitive.PbLocalDate guaranteeDueOn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate GuaranteeDueOn {
      get { return guaranteeDueOn_; }
      set {
        guaranteeDueOn_ = value;
      }
    }

    /// <summary>Field number for the "host_property" field.</summary>
    public const int HostPropertyFieldNumber = 8;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator hostProperty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator HostProperty {
      get { return hostProperty_; }
      set {
        hostProperty_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationFolioSummary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationFolioSummary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ReservationId, other.ReservationId)) return false;
      if (MasterFolioStatus != other.MasterFolioStatus) return false;
      if (!object.Equals(MasterFolio, other.MasterFolio)) return false;
      if(!clientFolios_.Equals(other.clientFolios_)) return false;
      if (GuaranteeStatus != other.GuaranteeStatus) return false;
      if (!object.Equals(GuaranteeDueOn, other.GuaranteeDueOn)) return false;
      if (!object.Equals(HostProperty, other.HostProperty)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservationId_ != null) hash ^= ReservationId.GetHashCode();
      if (MasterFolioStatus != 0) hash ^= MasterFolioStatus.GetHashCode();
      if (masterFolio_ != null) hash ^= MasterFolio.GetHashCode();
      hash ^= clientFolios_.GetHashCode();
      if (GuaranteeStatus != 0) hash ^= GuaranteeStatus.GetHashCode();
      if (guaranteeDueOn_ != null) hash ^= GuaranteeDueOn.GetHashCode();
      if (hostProperty_ != null) hash ^= HostProperty.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (reservationId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ReservationId);
      }
      if (MasterFolioStatus != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) MasterFolioStatus);
      }
      if (masterFolio_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MasterFolio);
      }
      clientFolios_.WriteTo(output, _repeated_clientFolios_codec);
      if (GuaranteeStatus != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) GuaranteeStatus);
      }
      if (guaranteeDueOn_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(GuaranteeDueOn);
      }
      if (hostProperty_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(HostProperty);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservationId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReservationId);
      }
      if (MasterFolioStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MasterFolioStatus);
      }
      if (masterFolio_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MasterFolio);
      }
      size += clientFolios_.CalculateSize(_repeated_clientFolios_codec);
      if (GuaranteeStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GuaranteeStatus);
      }
      if (guaranteeDueOn_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GuaranteeDueOn);
      }
      if (hostProperty_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HostProperty);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationFolioSummary other) {
      if (other == null) {
        return;
      }
      if (other.reservationId_ != null) {
        if (reservationId_ == null) {
          reservationId_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        ReservationId.MergeFrom(other.ReservationId);
      }
      if (other.MasterFolioStatus != 0) {
        MasterFolioStatus = other.MasterFolioStatus;
      }
      if (other.masterFolio_ != null) {
        if (masterFolio_ == null) {
          masterFolio_ = new global::HOLMS.Types.Folio.FSv2.FolioIndicator();
        }
        MasterFolio.MergeFrom(other.MasterFolio);
      }
      clientFolios_.Add(other.clientFolios_);
      if (other.GuaranteeStatus != 0) {
        GuaranteeStatus = other.GuaranteeStatus;
      }
      if (other.guaranteeDueOn_ != null) {
        if (guaranteeDueOn_ == null) {
          guaranteeDueOn_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        GuaranteeDueOn.MergeFrom(other.GuaranteeDueOn);
      }
      if (other.hostProperty_ != null) {
        if (hostProperty_ == null) {
          hostProperty_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        HostProperty.MergeFrom(other.HostProperty);
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
            if (reservationId_ == null) {
              reservationId_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservationId_);
            break;
          }
          case 16: {
            masterFolioStatus_ = (global::HOLMS.Types.Folio.FSv2.MasterFolioStatus) input.ReadEnum();
            break;
          }
          case 26: {
            if (masterFolio_ == null) {
              masterFolio_ = new global::HOLMS.Types.Folio.FSv2.FolioIndicator();
            }
            input.ReadMessage(masterFolio_);
            break;
          }
          case 42: {
            clientFolios_.AddEntriesFrom(input, _repeated_clientFolios_codec);
            break;
          }
          case 48: {
            guaranteeStatus_ = (global::HOLMS.Types.Booking.Reservations.ReservationGuaranteeStatus) input.ReadEnum();
            break;
          }
          case 58: {
            if (guaranteeDueOn_ == null) {
              guaranteeDueOn_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(guaranteeDueOn_);
            break;
          }
          case 66: {
            if (hostProperty_ == null) {
              hostProperty_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(hostProperty_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/housekeeping/housekeeping_assignment.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.Housekeeping {

  /// <summary>Holder for reflection information generated from operations/housekeeping/housekeeping_assignment.proto</summary>
  public static partial class HousekeepingAssignmentReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/housekeeping/housekeeping_assignment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HousekeepingAssignmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVvcGVyYXRpb25zL2hvdXNla2VlcGluZy9ob3VzZWtlZXBpbmdfYXNzaWdu",
            "bWVudC5wcm90bxIjaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ob3VzZWtlZXBp",
            "bmcaH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aIGlhbS9zdGFm",
            "Zl9tZW1iZXJfaW5kaWNhdG9yLnByb3RvGiVvcGVyYXRpb25zL3Jvb21zL3Jv",
            "b21faW5kaWNhdG9yLnByb3RvGh1wcmltaXRpdmUvcGJfbG9jYWxfZGF0ZS5w",
            "cm90byL7AQoWSG91c2VrZWVwaW5nQXNzaWdubWVudBIuCgpjcmVhdGVkX2F0",
            "GAEgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBI6Cg5lZmZlY3Rp",
            "dmVfZGF0ZRgCIAEoCzIiLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5QYkxvY2Fs",
            "RGF0ZRI6Cgtob3VzZWtlZXBlchgDIAEoCzIlLmhvbG1zLnR5cGVzLmlhbS5T",
            "dGFmZk1lbWJlckluZGljYXRvchI5CgRyb29tGAQgASgLMisuaG9sbXMudHlw",
            "ZXMub3BlcmF0aW9ucy5yb29tcy5Sb29tSW5kaWNhdG9yQj9aF29wZXJhdGlv",
            "bnMvaG91c2VrZWVwaW5nqgIjSE9MTVMuVHlwZXMuT3BlcmF0aW9ucy5Ib3Vz",
            "ZWtlZXBpbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.IAM.StaffMemberIndicatorReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.Housekeeping.HousekeepingAssignment), global::HOLMS.Types.Operations.Housekeeping.HousekeepingAssignment.Parser, new[]{ "CreatedAt", "EffectiveDate", "Housekeeper", "Room" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HousekeepingAssignment : pb::IMessage<HousekeepingAssignment> {
    private static readonly pb::MessageParser<HousekeepingAssignment> _parser = new pb::MessageParser<HousekeepingAssignment>(() => new HousekeepingAssignment());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HousekeepingAssignment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.Housekeeping.HousekeepingAssignmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HousekeepingAssignment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HousekeepingAssignment(HousekeepingAssignment other) : this() {
      CreatedAt = other.createdAt_ != null ? other.CreatedAt.Clone() : null;
      EffectiveDate = other.effectiveDate_ != null ? other.EffectiveDate.Clone() : null;
      Housekeeper = other.housekeeper_ != null ? other.Housekeeper.Clone() : null;
      Room = other.room_ != null ? other.Room.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HousekeepingAssignment Clone() {
      return new HousekeepingAssignment(this);
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    /// <summary>Field number for the "effective_date" field.</summary>
    public const int EffectiveDateFieldNumber = 2;
    private global::HOLMS.Types.Primitive.PbLocalDate effectiveDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate EffectiveDate {
      get { return effectiveDate_; }
      set {
        effectiveDate_ = value;
      }
    }

    /// <summary>Field number for the "housekeeper" field.</summary>
    public const int HousekeeperFieldNumber = 3;
    private global::HOLMS.Types.IAM.StaffMemberIndicator housekeeper_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.StaffMemberIndicator Housekeeper {
      get { return housekeeper_; }
      set {
        housekeeper_ = value;
      }
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 4;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HousekeepingAssignment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HousekeepingAssignment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if (!object.Equals(EffectiveDate, other.EffectiveDate)) return false;
      if (!object.Equals(Housekeeper, other.Housekeeper)) return false;
      if (!object.Equals(Room, other.Room)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      if (effectiveDate_ != null) hash ^= EffectiveDate.GetHashCode();
      if (housekeeper_ != null) hash ^= Housekeeper.GetHashCode();
      if (room_ != null) hash ^= Room.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (createdAt_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreatedAt);
      }
      if (effectiveDate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EffectiveDate);
      }
      if (housekeeper_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Housekeeper);
      }
      if (room_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Room);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (effectiveDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EffectiveDate);
      }
      if (housekeeper_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Housekeeper);
      }
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HousekeepingAssignment other) {
      if (other == null) {
        return;
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          createdAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
      }
      if (other.effectiveDate_ != null) {
        if (effectiveDate_ == null) {
          effectiveDate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        EffectiveDate.MergeFrom(other.EffectiveDate);
      }
      if (other.housekeeper_ != null) {
        if (housekeeper_ == null) {
          housekeeper_ = new global::HOLMS.Types.IAM.StaffMemberIndicator();
        }
        Housekeeper.MergeFrom(other.Housekeeper);
      }
      if (other.room_ != null) {
        if (room_ == null) {
          room_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
        }
        Room.MergeFrom(other.Room);
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
            if (createdAt_ == null) {
              createdAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(createdAt_);
            break;
          }
          case 18: {
            if (effectiveDate_ == null) {
              effectiveDate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(effectiveDate_);
            break;
          }
          case 26: {
            if (housekeeper_ == null) {
              housekeeper_ = new global::HOLMS.Types.IAM.StaffMemberIndicator();
            }
            input.ReadMessage(housekeeper_);
            break;
          }
          case 34: {
            if (room_ == null) {
              room_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(room_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

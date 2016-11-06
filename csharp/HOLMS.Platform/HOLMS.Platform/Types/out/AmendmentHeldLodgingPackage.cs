// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/packages/amendment_held_lodging_package.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.Packages {

  /// <summary>Holder for reflection information generated from supply/packages/amendment_held_lodging_package.proto</summary>
  public static partial class AmendmentHeldLodgingPackageReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/packages/amendment_held_lodging_package.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AmendmentHeldLodgingPackageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRzdXBwbHkvcGFja2FnZXMvYW1lbmRtZW50X2hlbGRfbG9kZ2luZ19wYWNr",
            "YWdlLnByb3RvEhtob2xtcy50eXBlcy5zdXBwbHkucGFja2FnZXMaH2dvb2ds",
            "ZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aJXN1cHBseS9wYWNrYWdlcy9s",
            "b2RnaW5nX3BhY2thZ2UucHJvdG8aMXN1cHBseS9yZXNlcnZhdGlvbl9hbWVu",
            "ZG1lbnRfaG9sZF9pbmRpY2F0b3IucHJvdG8i2gEKG0FtZW5kbWVudEhlbGRM",
            "b2RnaW5nUGFja2FnZRJNCg5ob2xkX2luZGljYXRvchgBIAEoCzI1LmhvbG1z",
            "LnR5cGVzLnN1cHBseS5SZXNlcnZhdGlvbkFtZW5kbWVudEhvbGRJbmRpY2F0",
            "b3ISLgoKZXhwaXJlc19hdBgCIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1l",
            "c3RhbXASPAoHcGFja2FnZRgDIAEoCzIrLmhvbG1zLnR5cGVzLnN1cHBseS5w",
            "YWNrYWdlcy5Mb2RnaW5nUGFja2FnZUIvWg9zdXBwbHkvcGFja2FnZXOqAhtI",
            "T0xNUy5UeXBlcy5TdXBwbHkuUGFja2FnZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Supply.Packages.LodgingPackageReflection.Descriptor, global::HOLMS.Types.Supply.ReservationAmendmentHoldIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.Packages.AmendmentHeldLodgingPackage), global::HOLMS.Types.Supply.Packages.AmendmentHeldLodgingPackage.Parser, new[]{ "HoldIndicator", "ExpiresAt", "Package" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AmendmentHeldLodgingPackage : pb::IMessage<AmendmentHeldLodgingPackage> {
    private static readonly pb::MessageParser<AmendmentHeldLodgingPackage> _parser = new pb::MessageParser<AmendmentHeldLodgingPackage>(() => new AmendmentHeldLodgingPackage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AmendmentHeldLodgingPackage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.Packages.AmendmentHeldLodgingPackageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AmendmentHeldLodgingPackage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AmendmentHeldLodgingPackage(AmendmentHeldLodgingPackage other) : this() {
      HoldIndicator = other.holdIndicator_ != null ? other.HoldIndicator.Clone() : null;
      ExpiresAt = other.expiresAt_ != null ? other.ExpiresAt.Clone() : null;
      Package = other.package_ != null ? other.Package.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AmendmentHeldLodgingPackage Clone() {
      return new AmendmentHeldLodgingPackage(this);
    }

    /// <summary>Field number for the "hold_indicator" field.</summary>
    public const int HoldIndicatorFieldNumber = 1;
    private global::HOLMS.Types.Supply.ReservationAmendmentHoldIndicator holdIndicator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.ReservationAmendmentHoldIndicator HoldIndicator {
      get { return holdIndicator_; }
      set {
        holdIndicator_ = value;
      }
    }

    /// <summary>Field number for the "expires_at" field.</summary>
    public const int ExpiresAtFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expiresAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ExpiresAt {
      get { return expiresAt_; }
      set {
        expiresAt_ = value;
      }
    }

    /// <summary>Field number for the "package" field.</summary>
    public const int PackageFieldNumber = 3;
    private global::HOLMS.Types.Supply.Packages.LodgingPackage package_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.Packages.LodgingPackage Package {
      get { return package_; }
      set {
        package_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AmendmentHeldLodgingPackage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AmendmentHeldLodgingPackage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(HoldIndicator, other.HoldIndicator)) return false;
      if (!object.Equals(ExpiresAt, other.ExpiresAt)) return false;
      if (!object.Equals(Package, other.Package)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (holdIndicator_ != null) hash ^= HoldIndicator.GetHashCode();
      if (expiresAt_ != null) hash ^= ExpiresAt.GetHashCode();
      if (package_ != null) hash ^= Package.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (holdIndicator_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(HoldIndicator);
      }
      if (expiresAt_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ExpiresAt);
      }
      if (package_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Package);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (holdIndicator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HoldIndicator);
      }
      if (expiresAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpiresAt);
      }
      if (package_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Package);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AmendmentHeldLodgingPackage other) {
      if (other == null) {
        return;
      }
      if (other.holdIndicator_ != null) {
        if (holdIndicator_ == null) {
          holdIndicator_ = new global::HOLMS.Types.Supply.ReservationAmendmentHoldIndicator();
        }
        HoldIndicator.MergeFrom(other.HoldIndicator);
      }
      if (other.expiresAt_ != null) {
        if (expiresAt_ == null) {
          expiresAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ExpiresAt.MergeFrom(other.ExpiresAt);
      }
      if (other.package_ != null) {
        if (package_ == null) {
          package_ = new global::HOLMS.Types.Supply.Packages.LodgingPackage();
        }
        Package.MergeFrom(other.Package);
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
            if (holdIndicator_ == null) {
              holdIndicator_ = new global::HOLMS.Types.Supply.ReservationAmendmentHoldIndicator();
            }
            input.ReadMessage(holdIndicator_);
            break;
          }
          case 18: {
            if (expiresAt_ == null) {
              expiresAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(expiresAt_);
            break;
          }
          case 26: {
            if (package_ == null) {
              package_ = new global::HOLMS.Types.Supply.Packages.LodgingPackage();
            }
            input.ReadMessage(package_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
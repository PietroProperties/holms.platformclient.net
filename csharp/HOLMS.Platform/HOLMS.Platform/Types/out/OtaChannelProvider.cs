// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/channels/ota_channel_provider.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Channels {

  /// <summary>Holder for reflection information generated from booking/channels/ota_channel_provider.proto</summary>
  public static partial class OtaChannelProviderReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/channels/ota_channel_provider.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OtaChannelProviderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citib29raW5nL2NoYW5uZWxzL290YV9jaGFubmVsX3Byb3ZpZGVyLnByb3Rv",
            "Ehxob2xtcy50eXBlcy5ib29raW5nLmNoYW5uZWxzGjZib29raW5nL2luZGlj",
            "YXRvcnMvY2FuY2VsbGF0aW9uX3BvbGljeV9pbmRpY2F0b3IucHJvdG8aNWJv",
            "b2tpbmcvY2hhbm5lbHMvb3RhX2NoYW5uZWxfcHJvdmlkZXJfaW5kaWNhdG9y",
            "LnByb3RvGiFzdXBwbHkvcm9vbV90eXBlcy9yb29tX3R5cGUucHJvdG8ioAMK",
            "Ek9UQUNoYW5uZWxQcm92aWRlchJMCgllbnRpdHlfaWQYASABKAsyOS5ob2xt",
            "cy50eXBlcy5ib29raW5nLmNoYW5uZWxzLk9UQUNoYW5uZWxQcm92aWRlcklu",
            "ZGljYXRvchIVCg1wcm92aWRlcl9uYW1lGAIgASgJEhUKDXByb3ZpZGVyX2Nv",
            "ZGUYAyABKAkSJAocZGlzYWJsZV9ndWVzdF9jb3JyZXNwb25kZW5jZRgEIAEo",
            "CBIpCiFkaXNhYmxlX2NvcnJlc3BvbmRlbmNlX3JhdGVfdGFibGUYBSABKAgS",
            "WAoTY2FuY2VsbGF0aW9uX3BvbGljeRgGIAEoCzI7LmhvbG1zLnR5cGVzLmJv",
            "b2tpbmcuaW5kaWNhdG9ycy5DYW5jZWxsYXRpb25Qb2xpY3lJbmRpY2F0b3IS",
            "HwoXdmlydHVhbF9jYXJkX2lkZW50aWZpZXIYByABKAkSQgoRcmVxdWVzdF9y",
            "b29tX3R5cGUYCCADKAsyJy5ob2xtcy50eXBlcy5zdXBwbHkucm9vbV90eXBl",
            "cy5Sb29tVHlwZUIxWhBib29raW5nL2NoYW5uZWxzqgIcSE9MTVMuVHlwZXMu",
            "Qm9va2luZy5DaGFubmVsc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Channels.OtaChannelProviderIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Channels.OTAChannelProvider), global::HOLMS.Types.Booking.Channels.OTAChannelProvider.Parser, new[]{ "EntityId", "ProviderName", "ProviderCode", "DisableGuestCorrespondence", "DisableCorrespondenceRateTable", "CancellationPolicy", "VirtualCardIdentifier", "RequestRoomType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OTAChannelProvider : pb::IMessage<OTAChannelProvider> {
    private static readonly pb::MessageParser<OTAChannelProvider> _parser = new pb::MessageParser<OTAChannelProvider>(() => new OTAChannelProvider());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OTAChannelProvider> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Channels.OtaChannelProviderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OTAChannelProvider() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OTAChannelProvider(OTAChannelProvider other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      providerName_ = other.providerName_;
      providerCode_ = other.providerCode_;
      disableGuestCorrespondence_ = other.disableGuestCorrespondence_;
      disableCorrespondenceRateTable_ = other.disableCorrespondenceRateTable_;
      CancellationPolicy = other.cancellationPolicy_ != null ? other.CancellationPolicy.Clone() : null;
      virtualCardIdentifier_ = other.virtualCardIdentifier_;
      requestRoomType_ = other.requestRoomType_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OTAChannelProvider Clone() {
      return new OTAChannelProvider(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "provider_name" field.</summary>
    public const int ProviderNameFieldNumber = 2;
    private string providerName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProviderName {
      get { return providerName_; }
      set {
        providerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "provider_code" field.</summary>
    public const int ProviderCodeFieldNumber = 3;
    private string providerCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProviderCode {
      get { return providerCode_; }
      set {
        providerCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "disable_guest_correspondence" field.</summary>
    public const int DisableGuestCorrespondenceFieldNumber = 4;
    private bool disableGuestCorrespondence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DisableGuestCorrespondence {
      get { return disableGuestCorrespondence_; }
      set {
        disableGuestCorrespondence_ = value;
      }
    }

    /// <summary>Field number for the "disable_correspondence_rate_table" field.</summary>
    public const int DisableCorrespondenceRateTableFieldNumber = 5;
    private bool disableCorrespondenceRateTable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DisableCorrespondenceRateTable {
      get { return disableCorrespondenceRateTable_; }
      set {
        disableCorrespondenceRateTable_ = value;
      }
    }

    /// <summary>Field number for the "cancellation_policy" field.</summary>
    public const int CancellationPolicyFieldNumber = 6;
    private global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator cancellationPolicy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator CancellationPolicy {
      get { return cancellationPolicy_; }
      set {
        cancellationPolicy_ = value;
      }
    }

    /// <summary>Field number for the "virtual_card_identifier" field.</summary>
    public const int VirtualCardIdentifierFieldNumber = 7;
    private string virtualCardIdentifier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VirtualCardIdentifier {
      get { return virtualCardIdentifier_; }
      set {
        virtualCardIdentifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "request_room_type" field.</summary>
    public const int RequestRoomTypeFieldNumber = 8;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.RoomTypes.RoomType> _repeated_requestRoomType_codec
        = pb::FieldCodec.ForMessage(66, global::HOLMS.Types.Supply.RoomTypes.RoomType.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.RoomTypes.RoomType> requestRoomType_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.RoomTypes.RoomType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.RoomTypes.RoomType> RequestRoomType {
      get { return requestRoomType_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OTAChannelProvider);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OTAChannelProvider other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (ProviderName != other.ProviderName) return false;
      if (ProviderCode != other.ProviderCode) return false;
      if (DisableGuestCorrespondence != other.DisableGuestCorrespondence) return false;
      if (DisableCorrespondenceRateTable != other.DisableCorrespondenceRateTable) return false;
      if (!object.Equals(CancellationPolicy, other.CancellationPolicy)) return false;
      if (VirtualCardIdentifier != other.VirtualCardIdentifier) return false;
      if(!requestRoomType_.Equals(other.requestRoomType_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (ProviderName.Length != 0) hash ^= ProviderName.GetHashCode();
      if (ProviderCode.Length != 0) hash ^= ProviderCode.GetHashCode();
      if (DisableGuestCorrespondence != false) hash ^= DisableGuestCorrespondence.GetHashCode();
      if (DisableCorrespondenceRateTable != false) hash ^= DisableCorrespondenceRateTable.GetHashCode();
      if (cancellationPolicy_ != null) hash ^= CancellationPolicy.GetHashCode();
      if (VirtualCardIdentifier.Length != 0) hash ^= VirtualCardIdentifier.GetHashCode();
      hash ^= requestRoomType_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (entityId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EntityId);
      }
      if (ProviderName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProviderName);
      }
      if (ProviderCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProviderCode);
      }
      if (DisableGuestCorrespondence != false) {
        output.WriteRawTag(32);
        output.WriteBool(DisableGuestCorrespondence);
      }
      if (DisableCorrespondenceRateTable != false) {
        output.WriteRawTag(40);
        output.WriteBool(DisableCorrespondenceRateTable);
      }
      if (cancellationPolicy_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CancellationPolicy);
      }
      if (VirtualCardIdentifier.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(VirtualCardIdentifier);
      }
      requestRoomType_.WriteTo(output, _repeated_requestRoomType_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (ProviderName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProviderName);
      }
      if (ProviderCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProviderCode);
      }
      if (DisableGuestCorrespondence != false) {
        size += 1 + 1;
      }
      if (DisableCorrespondenceRateTable != false) {
        size += 1 + 1;
      }
      if (cancellationPolicy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CancellationPolicy);
      }
      if (VirtualCardIdentifier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VirtualCardIdentifier);
      }
      size += requestRoomType_.CalculateSize(_repeated_requestRoomType_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OTAChannelProvider other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.ProviderName.Length != 0) {
        ProviderName = other.ProviderName;
      }
      if (other.ProviderCode.Length != 0) {
        ProviderCode = other.ProviderCode;
      }
      if (other.DisableGuestCorrespondence != false) {
        DisableGuestCorrespondence = other.DisableGuestCorrespondence;
      }
      if (other.DisableCorrespondenceRateTable != false) {
        DisableCorrespondenceRateTable = other.DisableCorrespondenceRateTable;
      }
      if (other.cancellationPolicy_ != null) {
        if (cancellationPolicy_ == null) {
          cancellationPolicy_ = new global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator();
        }
        CancellationPolicy.MergeFrom(other.CancellationPolicy);
      }
      if (other.VirtualCardIdentifier.Length != 0) {
        VirtualCardIdentifier = other.VirtualCardIdentifier;
      }
      requestRoomType_.Add(other.requestRoomType_);
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
            if (entityId_ == null) {
              entityId_ = new global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            ProviderName = input.ReadString();
            break;
          }
          case 26: {
            ProviderCode = input.ReadString();
            break;
          }
          case 32: {
            DisableGuestCorrespondence = input.ReadBool();
            break;
          }
          case 40: {
            DisableCorrespondenceRateTable = input.ReadBool();
            break;
          }
          case 50: {
            if (cancellationPolicy_ == null) {
              cancellationPolicy_ = new global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator();
            }
            input.ReadMessage(cancellationPolicy_);
            break;
          }
          case 58: {
            VirtualCardIdentifier = input.ReadString();
            break;
          }
          case 66: {
            requestRoomType_.AddEntriesFrom(input, _repeated_requestRoomType_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

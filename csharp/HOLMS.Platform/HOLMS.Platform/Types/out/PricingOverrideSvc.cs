// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/rpc/pricing_override_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.RPC {

  /// <summary>Holder for reflection information generated from supply/rpc/pricing_override_svc.proto</summary>
  public static partial class PricingOverrideSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/rpc/pricing_override_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PricingOverrideSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVzdXBwbHkvcnBjL3ByaWNpbmdfb3ZlcnJpZGVfc3ZjLnByb3RvEhZob2xt",
            "cy50eXBlcy5zdXBwbHkucnBjGipwcmltaXRpdmUvcGJfaW5jbHVzaXZlX29w",
            "c2RhdGVfcmFuZ2UucHJvdG8aHXByaW1pdGl2ZS9wYl9sb2NhbF9kYXRlLnBy",
            "b3RvGh9wcmltaXRpdmUvbW9uZXRhcnlfYW1vdW50LnByb3RvGitzdXBwbHkv",
            "cm9vbV90eXBlcy9yb29tX3R5cGVfaW5kaWNhdG9yLnByb3RvIlsKFVByaWNp",
            "bmdEZXRhaWxzUmVxdWVzdBJCCgpkYXRlX3JhbmdlGAEgASgLMi4uaG9sbXMu",
            "dHlwZXMucHJpbWl0aXZlLlBiSW5jbHVzaXZlT3BzZGF0ZVJhbmdlIscBCg9P",
            "dmVycmlkZVByaWNpbmcSQwoJcm9vbV90eXBlGAEgASgLMjAuaG9sbXMudHlw",
            "ZXMuc3VwcGx5LnJvb21fdHlwZXMuUm9vbVR5cGVJbmRpY2F0b3ISMAoEZGF0",
            "ZRgCIAEoCzIiLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5QYkxvY2FsRGF0ZRI9",
            "Cg5vdmVycmlkZV9wcmljZRgDIAEoCzIlLmhvbG1zLnR5cGVzLnByaW1pdGl2",
            "ZS5Nb25ldGFyeUFtb3VudCJHChNSZW1vdmVPdmVycmlkZURhdGVzEjAKBGRh",
            "dGUYASABKAsyIi5ob2xtcy50eXBlcy5wcmltaXRpdmUuUGJMb2NhbERhdGUi",
            "ngEKFFByaWNpbmdVcGRhdGVSZXF1ZXN0EkEKEG92ZXJyaWRlX3ByaWNpbmcY",
            "ASADKAsyJy5ob2xtcy50eXBlcy5zdXBwbHkucnBjLk92ZXJyaWRlUHJpY2lu",
            "ZxJDCg5yZW1vdmVfcHJpY2luZxgCIAMoCzIrLmhvbG1zLnR5cGVzLnN1cHBs",
            "eS5ycGMuUmVtb3ZlT3ZlcnJpZGVEYXRlcyJrChVQcmljaW5nVXBkYXRlUmVz",
            "cG9uc2USOwoGUmVzdWx0GAEgASgOMisuaG9sbXMudHlwZXMuc3VwcGx5LnJw",
            "Yy5QcmljaW5nVXBkYXRlUmVzdWx0EhUKDUVycm9yTWVzc2FnZXMYAiADKAki",
            "WwoWUHJpY2luZ0RldGFpbHNSZXNwb25zZRJBChBvdmVycmlkZV9wcmljaW5n",
            "GAEgAygLMicuaG9sbXMudHlwZXMuc3VwcGx5LnJwYy5PdmVycmlkZVByaWNp",
            "bmcqWAoTUHJpY2luZ1VwZGF0ZVJlc3VsdBIRCg1VUERBVEVfRkFJTEVEEAAS",
            "FwoTREJfVVBEQVRFX0NSX0ZBSUxFRBABEhUKEVVQREFURV9TVUNDRVNTRlVM",
            "EAIy9wEKElByaWNpbmdPdmVycmlkZVN2YxJsCgtBbGxGb3JEYXRlcxItLmhv",
            "bG1zLnR5cGVzLnN1cHBseS5ycGMuUHJpY2luZ0RldGFpbHNSZXF1ZXN0Gi4u",
            "aG9sbXMudHlwZXMuc3VwcGx5LnJwYy5QcmljaW5nRGV0YWlsc1Jlc3BvbnNl",
            "EnMKFEluc2VydE9yVXBkYXRlUHJpY2VzEiwuaG9sbXMudHlwZXMuc3VwcGx5",
            "LnJwYy5QcmljaW5nVXBkYXRlUmVxdWVzdBotLmhvbG1zLnR5cGVzLnN1cHBs",
            "eS5ycGMuUHJpY2luZ1VwZGF0ZVJlc3BvbnNlQiVaCnN1cHBseS9ycGOqAhZI",
            "T0xNUy5UeXBlcy5TdXBwbHkuUlBDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Supply.RPC.PricingUpdateResult), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.PricingDetailsRequest), global::HOLMS.Types.Supply.RPC.PricingDetailsRequest.Parser, new[]{ "DateRange" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.OverridePricing), global::HOLMS.Types.Supply.RPC.OverridePricing.Parser, new[]{ "RoomType", "Date", "OverridePrice" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.RemoveOverrideDates), global::HOLMS.Types.Supply.RPC.RemoveOverrideDates.Parser, new[]{ "Date" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.PricingUpdateRequest), global::HOLMS.Types.Supply.RPC.PricingUpdateRequest.Parser, new[]{ "OverridePricing", "RemovePricing" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.PricingUpdateResponse), global::HOLMS.Types.Supply.RPC.PricingUpdateResponse.Parser, new[]{ "Result", "ErrorMessages" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.PricingDetailsResponse), global::HOLMS.Types.Supply.RPC.PricingDetailsResponse.Parser, new[]{ "OverridePricing" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum PricingUpdateResult {
    [pbr::OriginalName("UPDATE_FAILED")] UpdateFailed = 0,
    [pbr::OriginalName("DB_UPDATE_CR_FAILED")] DbUpdateCrFailed = 1,
    [pbr::OriginalName("UPDATE_SUCCESSFUL")] UpdateSuccessful = 2,
  }

  #endregion

  #region Messages
  public sealed partial class PricingDetailsRequest : pb::IMessage<PricingDetailsRequest> {
    private static readonly pb::MessageParser<PricingDetailsRequest> _parser = new pb::MessageParser<PricingDetailsRequest>(() => new PricingDetailsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricingDetailsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingOverrideSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingDetailsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingDetailsRequest(PricingDetailsRequest other) : this() {
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingDetailsRequest Clone() {
      return new PricingDetailsRequest(this);
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
      return Equals(other as PricingDetailsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricingDetailsRequest other) {
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
    public void MergeFrom(PricingDetailsRequest other) {
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

  public sealed partial class OverridePricing : pb::IMessage<OverridePricing> {
    private static readonly pb::MessageParser<OverridePricing> _parser = new pb::MessageParser<OverridePricing>(() => new OverridePricing());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OverridePricing> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingOverrideSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverridePricing() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverridePricing(OverridePricing other) : this() {
      RoomType = other.roomType_ != null ? other.RoomType.Clone() : null;
      Date = other.date_ != null ? other.Date.Clone() : null;
      OverridePrice = other.overridePrice_ != null ? other.OverridePrice.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverridePricing Clone() {
      return new OverridePricing(this);
    }

    /// <summary>Field number for the "room_type" field.</summary>
    public const int RoomTypeFieldNumber = 1;
    private global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator roomType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator RoomType {
      get { return roomType_; }
      set {
        roomType_ = value;
      }
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 2;
    private global::HOLMS.Types.Primitive.PbLocalDate date_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate Date {
      get { return date_; }
      set {
        date_ = value;
      }
    }

    /// <summary>Field number for the "override_price" field.</summary>
    public const int OverridePriceFieldNumber = 3;
    private global::HOLMS.Types.Primitive.MonetaryAmount overridePrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount OverridePrice {
      get { return overridePrice_; }
      set {
        overridePrice_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OverridePricing);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OverridePricing other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RoomType, other.RoomType)) return false;
      if (!object.Equals(Date, other.Date)) return false;
      if (!object.Equals(OverridePrice, other.OverridePrice)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (roomType_ != null) hash ^= RoomType.GetHashCode();
      if (date_ != null) hash ^= Date.GetHashCode();
      if (overridePrice_ != null) hash ^= OverridePrice.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (roomType_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RoomType);
      }
      if (date_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Date);
      }
      if (overridePrice_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OverridePrice);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (roomType_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoomType);
      }
      if (date_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Date);
      }
      if (overridePrice_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OverridePrice);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OverridePricing other) {
      if (other == null) {
        return;
      }
      if (other.roomType_ != null) {
        if (roomType_ == null) {
          roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator();
        }
        RoomType.MergeFrom(other.RoomType);
      }
      if (other.date_ != null) {
        if (date_ == null) {
          date_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        Date.MergeFrom(other.Date);
      }
      if (other.overridePrice_ != null) {
        if (overridePrice_ == null) {
          overridePrice_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        OverridePrice.MergeFrom(other.OverridePrice);
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
            if (roomType_ == null) {
              roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator();
            }
            input.ReadMessage(roomType_);
            break;
          }
          case 18: {
            if (date_ == null) {
              date_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(date_);
            break;
          }
          case 26: {
            if (overridePrice_ == null) {
              overridePrice_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(overridePrice_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RemoveOverrideDates : pb::IMessage<RemoveOverrideDates> {
    private static readonly pb::MessageParser<RemoveOverrideDates> _parser = new pb::MessageParser<RemoveOverrideDates>(() => new RemoveOverrideDates());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RemoveOverrideDates> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingOverrideSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveOverrideDates() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveOverrideDates(RemoveOverrideDates other) : this() {
      Date = other.date_ != null ? other.Date.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveOverrideDates Clone() {
      return new RemoveOverrideDates(this);
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 1;
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
      return Equals(other as RemoveOverrideDates);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RemoveOverrideDates other) {
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
    public void MergeFrom(RemoveOverrideDates other) {
      if (other == null) {
        return;
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

  public sealed partial class PricingUpdateRequest : pb::IMessage<PricingUpdateRequest> {
    private static readonly pb::MessageParser<PricingUpdateRequest> _parser = new pb::MessageParser<PricingUpdateRequest>(() => new PricingUpdateRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricingUpdateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingOverrideSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingUpdateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingUpdateRequest(PricingUpdateRequest other) : this() {
      overridePricing_ = other.overridePricing_.Clone();
      removePricing_ = other.removePricing_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingUpdateRequest Clone() {
      return new PricingUpdateRequest(this);
    }

    /// <summary>Field number for the "override_pricing" field.</summary>
    public const int OverridePricingFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.RPC.OverridePricing> _repeated_overridePricing_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Supply.RPC.OverridePricing.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.RPC.OverridePricing> overridePricing_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.RPC.OverridePricing>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.RPC.OverridePricing> OverridePricing {
      get { return overridePricing_; }
    }

    /// <summary>Field number for the "remove_pricing" field.</summary>
    public const int RemovePricingFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.RPC.RemoveOverrideDates> _repeated_removePricing_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Supply.RPC.RemoveOverrideDates.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.RPC.RemoveOverrideDates> removePricing_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.RPC.RemoveOverrideDates>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.RPC.RemoveOverrideDates> RemovePricing {
      get { return removePricing_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PricingUpdateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricingUpdateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!overridePricing_.Equals(other.overridePricing_)) return false;
      if(!removePricing_.Equals(other.removePricing_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= overridePricing_.GetHashCode();
      hash ^= removePricing_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      overridePricing_.WriteTo(output, _repeated_overridePricing_codec);
      removePricing_.WriteTo(output, _repeated_removePricing_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += overridePricing_.CalculateSize(_repeated_overridePricing_codec);
      size += removePricing_.CalculateSize(_repeated_removePricing_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PricingUpdateRequest other) {
      if (other == null) {
        return;
      }
      overridePricing_.Add(other.overridePricing_);
      removePricing_.Add(other.removePricing_);
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
            overridePricing_.AddEntriesFrom(input, _repeated_overridePricing_codec);
            break;
          }
          case 18: {
            removePricing_.AddEntriesFrom(input, _repeated_removePricing_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PricingUpdateResponse : pb::IMessage<PricingUpdateResponse> {
    private static readonly pb::MessageParser<PricingUpdateResponse> _parser = new pb::MessageParser<PricingUpdateResponse>(() => new PricingUpdateResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricingUpdateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingOverrideSvcReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingUpdateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingUpdateResponse(PricingUpdateResponse other) : this() {
      result_ = other.result_;
      errorMessages_ = other.errorMessages_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingUpdateResponse Clone() {
      return new PricingUpdateResponse(this);
    }

    /// <summary>Field number for the "Result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Supply.RPC.PricingUpdateResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RPC.PricingUpdateResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "ErrorMessages" field.</summary>
    public const int ErrorMessagesFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_errorMessages_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> errorMessages_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ErrorMessages {
      get { return errorMessages_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PricingUpdateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricingUpdateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if(!errorMessages_.Equals(other.errorMessages_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      hash ^= errorMessages_.GetHashCode();
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
      errorMessages_.WriteTo(output, _repeated_errorMessages_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      size += errorMessages_.CalculateSize(_repeated_errorMessages_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PricingUpdateResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      errorMessages_.Add(other.errorMessages_);
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
            result_ = (global::HOLMS.Types.Supply.RPC.PricingUpdateResult) input.ReadEnum();
            break;
          }
          case 18: {
            errorMessages_.AddEntriesFrom(input, _repeated_errorMessages_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PricingDetailsResponse : pb::IMessage<PricingDetailsResponse> {
    private static readonly pb::MessageParser<PricingDetailsResponse> _parser = new pb::MessageParser<PricingDetailsResponse>(() => new PricingDetailsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricingDetailsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingOverrideSvcReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingDetailsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingDetailsResponse(PricingDetailsResponse other) : this() {
      overridePricing_ = other.overridePricing_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingDetailsResponse Clone() {
      return new PricingDetailsResponse(this);
    }

    /// <summary>Field number for the "override_pricing" field.</summary>
    public const int OverridePricingFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.RPC.OverridePricing> _repeated_overridePricing_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Supply.RPC.OverridePricing.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.RPC.OverridePricing> overridePricing_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.RPC.OverridePricing>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.RPC.OverridePricing> OverridePricing {
      get { return overridePricing_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PricingDetailsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricingDetailsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!overridePricing_.Equals(other.overridePricing_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= overridePricing_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      overridePricing_.WriteTo(output, _repeated_overridePricing_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += overridePricing_.CalculateSize(_repeated_overridePricing_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PricingDetailsResponse other) {
      if (other == null) {
        return;
      }
      overridePricing_.Add(other.overridePricing_);
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
            overridePricing_.AddEntriesFrom(input, _repeated_overridePricing_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

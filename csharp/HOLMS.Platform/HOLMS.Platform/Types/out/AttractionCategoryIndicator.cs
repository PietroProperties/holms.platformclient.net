// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/attractions/attraction_category_indicator.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.Attractions {

  /// <summary>Holder for reflection information generated from operations/attractions/attraction_category_indicator.proto</summary>
  public static partial class AttractionCategoryIndicatorReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/attractions/attraction_category_indicator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AttractionCategoryIndicatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjpvcGVyYXRpb25zL2F0dHJhY3Rpb25zL2F0dHJhY3Rpb25fY2F0ZWdvcnlf",
            "aW5kaWNhdG9yLnByb3RvEiJob2xtcy50eXBlcy5vcGVyYXRpb25zLmF0dHJh",
            "Y3Rpb25zGhRwcmltaXRpdmUvdXVpZC5wcm90byJGChtBdHRyYWN0aW9uQ2F0",
            "ZWdvcnlJbmRpY2F0b3ISJwoCaWQYASABKAsyGy5ob2xtcy50eXBlcy5wcmlt",
            "aXRpdmUuVXVpZEI9WhZvcGVyYXRpb25zL2F0dHJhY3Rpb25zqgIiSE9MTVMu",
            "VHlwZXMuT3BlcmF0aW9ucy5BdHRyYWN0aW9uc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.UuidReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.Attractions.AttractionCategoryIndicator), global::HOLMS.Types.Operations.Attractions.AttractionCategoryIndicator.Parser, new[]{ "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AttractionCategoryIndicator : pb::IMessage<AttractionCategoryIndicator> {
    private static readonly pb::MessageParser<AttractionCategoryIndicator> _parser = new pb::MessageParser<AttractionCategoryIndicator>(() => new AttractionCategoryIndicator());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AttractionCategoryIndicator> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.Attractions.AttractionCategoryIndicatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttractionCategoryIndicator() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttractionCategoryIndicator(AttractionCategoryIndicator other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttractionCategoryIndicator Clone() {
      return new AttractionCategoryIndicator(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::HOLMS.Types.Primitive.Uuid id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.Uuid Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AttractionCategoryIndicator);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AttractionCategoryIndicator other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AttractionCategoryIndicator other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::HOLMS.Types.Primitive.Uuid();
        }
        Id.MergeFrom(other.Id);
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
            if (id_ == null) {
              id_ = new global::HOLMS.Types.Primitive.Uuid();
            }
            input.ReadMessage(id_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: crm/guests/reservation_note_template.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.CRM.Guests {

  /// <summary>Holder for reflection information generated from crm/guests/reservation_note_template.proto</summary>
  public static partial class ReservationNoteTemplateReflection {

    #region Descriptor
    /// <summary>File descriptor for crm/guests/reservation_note_template.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationNoteTemplateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipjcm0vZ3Vlc3RzL3Jlc2VydmF0aW9uX25vdGVfdGVtcGxhdGUucHJvdG8S",
            "FmhvbG1zLnR5cGVzLmNybS5ndWVzdHMaNGNybS9ndWVzdHMvcmVzZXJ2YXRp",
            "b25fbm90ZV90ZW1wbGF0ZV9pbmRpY2F0b3IucHJvdG8aNW9wZXJhdGlvbnMv",
            "bm90ZV9yZXF1ZXN0cy9ub3RlX3JlcXVlc3RfaW5kaWNhdG9yLnByb3RvGixv",
            "cGVyYXRpb25zL25vdGVfcmVxdWVzdHMvbm90ZV9jYXRlZ29yeS5wcm90bxog",
            "Y3JtL2d1ZXN0cy9ndWVzdF9pbmRpY2F0b3IucHJvdG8iiwMKF1Jlc2VydmF0",
            "aW9uTm90ZVRlbXBsYXRlEksKCWVudGl0eV9pZBgBIAEoCzI4LmhvbG1zLnR5",
            "cGVzLmNybS5ndWVzdHMuUmVzZXJ2YXRpb25Ob3RlVGVtcGxhdGVJbmRpY2F0",
            "b3ISTwoLc291cmNlX25vdGUYAiABKAsyOi5ob2xtcy50eXBlcy5vcGVyYXRp",
            "b25zLm5vdGVfcmVxdWVzdHMuTm90ZVJlcXVlc3RJbmRpY2F0b3ISRAoIY2F0",
            "ZWdvcnkYAyABKA4yMi5ob2xtcy50eXBlcy5vcGVyYXRpb25zLm5vdGVfcmVx",
            "dWVzdHMuTm90ZUNhdGVnb3J5EhcKD2FkZGl0aW9uYWxfbm90ZRgEIAEoCRIf",
            "ChdpbmNsdWRlX29uX2NvbmZpcm1hdGlvbhgFIAEoCBIbChNzb3VyY2Vfbm90",
            "ZV9zdWJqZWN0GAcgASgJEjUKBWd1ZXN0GAggASgLMiYuaG9sbXMudHlwZXMu",
            "Y3JtLmd1ZXN0cy5HdWVzdEluZGljYXRvckIZqgIWSE9MTVMuVHlwZXMuQ1JN",
            "Lkd1ZXN0c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.CRM.Guests.ReservationNoteTemplateIndicatorReflection.Descriptor, global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicatorReflection.Descriptor, global::HOLMS.Types.Operations.NoteRequests.NoteCategoryReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.Guests.ReservationNoteTemplate), global::HOLMS.Types.CRM.Guests.ReservationNoteTemplate.Parser, new[]{ "EntityId", "SourceNote", "Category", "AdditionalNote", "IncludeOnConfirmation", "SourceNoteSubject", "Guest" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationNoteTemplate : pb::IMessage<ReservationNoteTemplate> {
    private static readonly pb::MessageParser<ReservationNoteTemplate> _parser = new pb::MessageParser<ReservationNoteTemplate>(() => new ReservationNoteTemplate());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationNoteTemplate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.CRM.Guests.ReservationNoteTemplateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteTemplate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteTemplate(ReservationNoteTemplate other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      SourceNote = other.sourceNote_ != null ? other.SourceNote.Clone() : null;
      category_ = other.category_;
      additionalNote_ = other.additionalNote_;
      includeOnConfirmation_ = other.includeOnConfirmation_;
      sourceNoteSubject_ = other.sourceNoteSubject_;
      Guest = other.guest_ != null ? other.Guest.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteTemplate Clone() {
      return new ReservationNoteTemplate(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.CRM.Guests.ReservationNoteTemplateIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Guests.ReservationNoteTemplateIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "source_note" field.</summary>
    public const int SourceNoteFieldNumber = 2;
    private global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicator sourceNote_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicator SourceNote {
      get { return sourceNote_; }
      set {
        sourceNote_ = value;
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 3;
    private global::HOLMS.Types.Operations.NoteRequests.NoteCategory category_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.NoteRequests.NoteCategory Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "additional_note" field.</summary>
    public const int AdditionalNoteFieldNumber = 4;
    private string additionalNote_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdditionalNote {
      get { return additionalNote_; }
      set {
        additionalNote_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "include_on_confirmation" field.</summary>
    public const int IncludeOnConfirmationFieldNumber = 5;
    private bool includeOnConfirmation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IncludeOnConfirmation {
      get { return includeOnConfirmation_; }
      set {
        includeOnConfirmation_ = value;
      }
    }

    /// <summary>Field number for the "source_note_subject" field.</summary>
    public const int SourceNoteSubjectFieldNumber = 7;
    private string sourceNoteSubject_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceNoteSubject {
      get { return sourceNoteSubject_; }
      set {
        sourceNoteSubject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "guest" field.</summary>
    public const int GuestFieldNumber = 8;
    private global::HOLMS.Types.CRM.Guests.GuestIndicator guest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Guests.GuestIndicator Guest {
      get { return guest_; }
      set {
        guest_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationNoteTemplate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationNoteTemplate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (!object.Equals(SourceNote, other.SourceNote)) return false;
      if (Category != other.Category) return false;
      if (AdditionalNote != other.AdditionalNote) return false;
      if (IncludeOnConfirmation != other.IncludeOnConfirmation) return false;
      if (SourceNoteSubject != other.SourceNoteSubject) return false;
      if (!object.Equals(Guest, other.Guest)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (sourceNote_ != null) hash ^= SourceNote.GetHashCode();
      if (Category != 0) hash ^= Category.GetHashCode();
      if (AdditionalNote.Length != 0) hash ^= AdditionalNote.GetHashCode();
      if (IncludeOnConfirmation != false) hash ^= IncludeOnConfirmation.GetHashCode();
      if (SourceNoteSubject.Length != 0) hash ^= SourceNoteSubject.GetHashCode();
      if (guest_ != null) hash ^= Guest.GetHashCode();
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
      if (sourceNote_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SourceNote);
      }
      if (Category != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Category);
      }
      if (AdditionalNote.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AdditionalNote);
      }
      if (IncludeOnConfirmation != false) {
        output.WriteRawTag(40);
        output.WriteBool(IncludeOnConfirmation);
      }
      if (SourceNoteSubject.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(SourceNoteSubject);
      }
      if (guest_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Guest);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (sourceNote_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SourceNote);
      }
      if (Category != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Category);
      }
      if (AdditionalNote.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdditionalNote);
      }
      if (IncludeOnConfirmation != false) {
        size += 1 + 1;
      }
      if (SourceNoteSubject.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceNoteSubject);
      }
      if (guest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Guest);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationNoteTemplate other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.CRM.Guests.ReservationNoteTemplateIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.sourceNote_ != null) {
        if (sourceNote_ == null) {
          sourceNote_ = new global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicator();
        }
        SourceNote.MergeFrom(other.SourceNote);
      }
      if (other.Category != 0) {
        Category = other.Category;
      }
      if (other.AdditionalNote.Length != 0) {
        AdditionalNote = other.AdditionalNote;
      }
      if (other.IncludeOnConfirmation != false) {
        IncludeOnConfirmation = other.IncludeOnConfirmation;
      }
      if (other.SourceNoteSubject.Length != 0) {
        SourceNoteSubject = other.SourceNoteSubject;
      }
      if (other.guest_ != null) {
        if (guest_ == null) {
          guest_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
        }
        Guest.MergeFrom(other.Guest);
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
            if (entityId_ == null) {
              entityId_ = new global::HOLMS.Types.CRM.Guests.ReservationNoteTemplateIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            if (sourceNote_ == null) {
              sourceNote_ = new global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicator();
            }
            input.ReadMessage(sourceNote_);
            break;
          }
          case 24: {
            category_ = (global::HOLMS.Types.Operations.NoteRequests.NoteCategory) input.ReadEnum();
            break;
          }
          case 34: {
            AdditionalNote = input.ReadString();
            break;
          }
          case 40: {
            IncludeOnConfirmation = input.ReadBool();
            break;
          }
          case 58: {
            SourceNoteSubject = input.ReadString();
            break;
          }
          case 66: {
            if (guest_ == null) {
              guest_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
            }
            input.ReadMessage(guest_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

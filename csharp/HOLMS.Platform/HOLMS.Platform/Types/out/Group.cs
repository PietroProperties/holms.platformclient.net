// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: crm/groups/group.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.CRM.Groups {

  /// <summary>Holder for reflection information generated from crm/groups/group.proto</summary>
  public static partial class GroupReflection {

    #region Descriptor
    /// <summary>File descriptor for crm/groups/group.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZjcm0vZ3JvdXBzL2dyb3VwLnByb3RvEhZob2xtcy50eXBlcy5jcm0uZ3Jv",
            "dXBzGiBjcm0vZ3JvdXBzL2dyb3VwX2luZGljYXRvci5wcm90bxobY3JtL2dy",
            "b3Vwcy9ncm91cF90eXBlLnByb3RvGiNwcmltaXRpdmUvY29udGFjdF9pbmZv",
            "cm1hdGlvbi5wcm90bxofcHJpbWl0aXZlL21vbmV0YXJ5X2Ftb3VudC5wcm90",
            "bxoydGVuYW5jeV9jb25maWcvaW5kaWNhdG9ycy9wcm9wZXJ0eV9pbmRpY2F0",
            "b3IucHJvdG8i9wIKBUdyb3VwEjkKCWVudGl0eV9pZBgBIAEoCzImLmhvbG1z",
            "LnR5cGVzLmNybS5ncm91cHMuR3JvdXBJbmRpY2F0b3ISDAoEbmFtZRgCIAEo",
            "CRI1Cgpncm91cF90eXBlGAMgASgOMiEuaG9sbXMudHlwZXMuY3JtLmdyb3Vw",
            "cy5Hcm91cFR5cGUSFAoMZ3JvdXBfbnVtYmVyGAQgASgJEjsKDGNyZWRpdF9s",
            "aW1pdBgFIAEoCzIlLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFt",
            "b3VudBIOCgZhY3RpdmUYBiABKAgSPwoMY29udGFjdF9pbmZvGAcgASgLMiku",
            "aG9sbXMudHlwZXMucHJpbWl0aXZlLkNvbnRhY3RJbmZvcm1hdGlvbhJKCghw",
            "cm9wZXJ0eRgIIAEoCzI4LmhvbG1zLnR5cGVzLnRlbmFuY3lfY29uZmlnLmlu",
            "ZGljYXRvcnMuUHJvcGVydHlJbmRpY2F0b3JCJVoKY3JtL2dyb3Vwc6oCFkhP",
            "TE1TLlR5cGVzLkNSTS5Hcm91cHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.CRM.Groups.GroupIndicatorReflection.Descriptor, global::HOLMS.Types.CRM.Groups.GroupTypeReflection.Descriptor, global::HOLMS.Types.Primitive.ContactInformationReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.Groups.Group), global::HOLMS.Types.CRM.Groups.Group.Parser, new[]{ "EntityId", "Name", "GroupType", "GroupNumber", "CreditLimit", "Active", "ContactInfo", "Property" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Group : pb::IMessage<Group> {
    private static readonly pb::MessageParser<Group> _parser = new pb::MessageParser<Group>(() => new Group());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Group> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.CRM.Groups.GroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Group() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Group(Group other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      name_ = other.name_;
      groupType_ = other.groupType_;
      groupNumber_ = other.groupNumber_;
      CreditLimit = other.creditLimit_ != null ? other.CreditLimit.Clone() : null;
      active_ = other.active_;
      ContactInfo = other.contactInfo_ != null ? other.ContactInfo.Clone() : null;
      Property = other.property_ != null ? other.Property.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Group Clone() {
      return new Group(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.CRM.Groups.GroupIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Groups.GroupIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "group_type" field.</summary>
    public const int GroupTypeFieldNumber = 3;
    private global::HOLMS.Types.CRM.Groups.GroupType groupType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Groups.GroupType GroupType {
      get { return groupType_; }
      set {
        groupType_ = value;
      }
    }

    /// <summary>Field number for the "group_number" field.</summary>
    public const int GroupNumberFieldNumber = 4;
    private string groupNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GroupNumber {
      get { return groupNumber_; }
      set {
        groupNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "credit_limit" field.</summary>
    public const int CreditLimitFieldNumber = 5;
    private global::HOLMS.Types.Primitive.MonetaryAmount creditLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount CreditLimit {
      get { return creditLimit_; }
      set {
        creditLimit_ = value;
      }
    }

    /// <summary>Field number for the "active" field.</summary>
    public const int ActiveFieldNumber = 6;
    private bool active_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Active {
      get { return active_; }
      set {
        active_ = value;
      }
    }

    /// <summary>Field number for the "contact_info" field.</summary>
    public const int ContactInfoFieldNumber = 7;
    private global::HOLMS.Types.Primitive.ContactInformation contactInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.ContactInformation ContactInfo {
      get { return contactInfo_; }
      set {
        contactInfo_ = value;
      }
    }

    /// <summary>Field number for the "property" field.</summary>
    public const int PropertyFieldNumber = 8;
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
      return Equals(other as Group);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Group other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Name != other.Name) return false;
      if (GroupType != other.GroupType) return false;
      if (GroupNumber != other.GroupNumber) return false;
      if (!object.Equals(CreditLimit, other.CreditLimit)) return false;
      if (Active != other.Active) return false;
      if (!object.Equals(ContactInfo, other.ContactInfo)) return false;
      if (!object.Equals(Property, other.Property)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (GroupType != 0) hash ^= GroupType.GetHashCode();
      if (GroupNumber.Length != 0) hash ^= GroupNumber.GetHashCode();
      if (creditLimit_ != null) hash ^= CreditLimit.GetHashCode();
      if (Active != false) hash ^= Active.GetHashCode();
      if (contactInfo_ != null) hash ^= ContactInfo.GetHashCode();
      if (property_ != null) hash ^= Property.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (GroupType != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) GroupType);
      }
      if (GroupNumber.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(GroupNumber);
      }
      if (creditLimit_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreditLimit);
      }
      if (Active != false) {
        output.WriteRawTag(48);
        output.WriteBool(Active);
      }
      if (contactInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ContactInfo);
      }
      if (property_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Property);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (GroupType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GroupType);
      }
      if (GroupNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupNumber);
      }
      if (creditLimit_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreditLimit);
      }
      if (Active != false) {
        size += 1 + 1;
      }
      if (contactInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContactInfo);
      }
      if (property_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Property);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Group other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.CRM.Groups.GroupIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.GroupType != 0) {
        GroupType = other.GroupType;
      }
      if (other.GroupNumber.Length != 0) {
        GroupNumber = other.GroupNumber;
      }
      if (other.creditLimit_ != null) {
        if (creditLimit_ == null) {
          creditLimit_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        CreditLimit.MergeFrom(other.CreditLimit);
      }
      if (other.Active != false) {
        Active = other.Active;
      }
      if (other.contactInfo_ != null) {
        if (contactInfo_ == null) {
          contactInfo_ = new global::HOLMS.Types.Primitive.ContactInformation();
        }
        ContactInfo.MergeFrom(other.ContactInfo);
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
            if (entityId_ == null) {
              entityId_ = new global::HOLMS.Types.CRM.Groups.GroupIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            groupType_ = (global::HOLMS.Types.CRM.Groups.GroupType) input.ReadEnum();
            break;
          }
          case 34: {
            GroupNumber = input.ReadString();
            break;
          }
          case 42: {
            if (creditLimit_ == null) {
              creditLimit_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(creditLimit_);
            break;
          }
          case 48: {
            Active = input.ReadBool();
            break;
          }
          case 58: {
            if (contactInfo_ == null) {
              contactInfo_ = new global::HOLMS.Types.Primitive.ContactInformation();
            }
            input.ReadMessage(contactInfo_);
            break;
          }
          case 66: {
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
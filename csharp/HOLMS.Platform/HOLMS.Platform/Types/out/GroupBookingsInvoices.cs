// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/groups/group_bookings_invoices.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Groups {

  /// <summary>Holder for reflection information generated from booking/groups/group_bookings_invoices.proto</summary>
  public static partial class GroupBookingsInvoicesReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/groups/group_bookings_invoices.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupBookingsInvoicesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixib29raW5nL2dyb3Vwcy9ncm91cF9ib29raW5nc19pbnZvaWNlcy5wcm90",
            "bxIaaG9sbXMudHlwZXMuYm9va2luZy5ncm91cHMaMGJvb2tpbmcvaW5kaWNh",
            "dG9ycy9ncm91cF9ib29raW5nX2luZGljYXRvci5wcm90byKfAQoaR3JvdXBC",
            "b29raW5nSW52b2ljZU1hcHBpbmcSTwoQZ3JvdXBfYm9va2luZ19pZBgBIAEo",
            "CzI1LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5Hcm91cEJvb2tp",
            "bmdJbmRpY2F0b3ISFgoOaW52b2ljZV9udW1iZXIYAiABKAUSGAoQYWRkaXRp",
            "b25hbF9ub3RlcxgDIAEoCUItWg5ib29raW5nL2dyb3Vwc6oCGkhPTE1TLlR5",
            "cGVzLkJvb2tpbmcuR3JvdXBzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.GroupBookingIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping), global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping.Parser, new[]{ "GroupBookingId", "InvoiceNumber", "AdditionalNotes" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroupBookingInvoiceMapping : pb::IMessage<GroupBookingInvoiceMapping> {
    private static readonly pb::MessageParser<GroupBookingInvoiceMapping> _parser = new pb::MessageParser<GroupBookingInvoiceMapping>(() => new GroupBookingInvoiceMapping());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GroupBookingInvoiceMapping> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Groups.GroupBookingsInvoicesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingInvoiceMapping() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingInvoiceMapping(GroupBookingInvoiceMapping other) : this() {
      GroupBookingId = other.groupBookingId_ != null ? other.GroupBookingId.Clone() : null;
      invoiceNumber_ = other.invoiceNumber_;
      additionalNotes_ = other.additionalNotes_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingInvoiceMapping Clone() {
      return new GroupBookingInvoiceMapping(this);
    }

    /// <summary>Field number for the "group_booking_id" field.</summary>
    public const int GroupBookingIdFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator groupBookingId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator GroupBookingId {
      get { return groupBookingId_; }
      set {
        groupBookingId_ = value;
      }
    }

    /// <summary>Field number for the "invoice_number" field.</summary>
    public const int InvoiceNumberFieldNumber = 2;
    private int invoiceNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int InvoiceNumber {
      get { return invoiceNumber_; }
      set {
        invoiceNumber_ = value;
      }
    }

    /// <summary>Field number for the "additional_notes" field.</summary>
    public const int AdditionalNotesFieldNumber = 3;
    private string additionalNotes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdditionalNotes {
      get { return additionalNotes_; }
      set {
        additionalNotes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GroupBookingInvoiceMapping);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GroupBookingInvoiceMapping other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GroupBookingId, other.GroupBookingId)) return false;
      if (InvoiceNumber != other.InvoiceNumber) return false;
      if (AdditionalNotes != other.AdditionalNotes) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (groupBookingId_ != null) hash ^= GroupBookingId.GetHashCode();
      if (InvoiceNumber != 0) hash ^= InvoiceNumber.GetHashCode();
      if (AdditionalNotes.Length != 0) hash ^= AdditionalNotes.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (groupBookingId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(GroupBookingId);
      }
      if (InvoiceNumber != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(InvoiceNumber);
      }
      if (AdditionalNotes.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AdditionalNotes);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (groupBookingId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GroupBookingId);
      }
      if (InvoiceNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(InvoiceNumber);
      }
      if (AdditionalNotes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdditionalNotes);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GroupBookingInvoiceMapping other) {
      if (other == null) {
        return;
      }
      if (other.groupBookingId_ != null) {
        if (groupBookingId_ == null) {
          groupBookingId_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
        }
        GroupBookingId.MergeFrom(other.GroupBookingId);
      }
      if (other.InvoiceNumber != 0) {
        InvoiceNumber = other.InvoiceNumber;
      }
      if (other.AdditionalNotes.Length != 0) {
        AdditionalNotes = other.AdditionalNotes;
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
            if (groupBookingId_ == null) {
              groupBookingId_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
            }
            input.ReadMessage(groupBookingId_);
            break;
          }
          case 16: {
            InvoiceNumber = input.ReadInt32();
            break;
          }
          case 26: {
            AdditionalNotes = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

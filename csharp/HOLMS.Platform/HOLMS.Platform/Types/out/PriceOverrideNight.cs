// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/pricing/price_override_night.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Pricing {

  /// <summary>Holder for reflection information generated from booking/pricing/price_override_night.proto</summary>
  public static partial class PriceOverrideNightReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/pricing/price_override_night.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PriceOverrideNightReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipib29raW5nL3ByaWNpbmcvcHJpY2Vfb3ZlcnJpZGVfbmlnaHQucHJvdG8S",
            "G2hvbG1zLnR5cGVzLmJvb2tpbmcucHJpY2luZxodcHJpbWl0aXZlL3BiX2xv",
            "Y2FsX2RhdGUucHJvdG8aH3ByaW1pdGl2ZS9tb25ldGFyeV9hbW91bnQucHJv",
            "dG8aK2Jvb2tpbmcvcHJpY2luZy9wcmljZV9vdmVycmlkZV9hY3Rpb24ucHJv",
            "dG8ivgEKElByaWNlT3ZlcnJpZGVOaWdodBIwCgRkYXRlGAEgASgLMiIuaG9s",
            "bXMudHlwZXMucHJpbWl0aXZlLlBiTG9jYWxEYXRlEjQKBXByaWNlGAIgASgL",
            "MiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5QW1vdW50EkAKBmFj",
            "dGlvbhgDIAEoDjIwLmhvbG1zLnR5cGVzLmJvb2tpbmcucHJpY2luZy5Qcmlj",
            "ZU92ZXJyaWRlQWN0aW9uQi9aD2Jvb2tpbmcvcHJpY2luZ6oCG0hPTE1TLlR5",
            "cGVzLkJvb2tpbmcuUHJpY2luZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Booking.Pricing.PriceOverrideActionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Pricing.PriceOverrideNight), global::HOLMS.Types.Booking.Pricing.PriceOverrideNight.Parser, new[]{ "Date", "Price", "Action" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PriceOverrideNight : pb::IMessage<PriceOverrideNight> {
    private static readonly pb::MessageParser<PriceOverrideNight> _parser = new pb::MessageParser<PriceOverrideNight>(() => new PriceOverrideNight());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PriceOverrideNight> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Pricing.PriceOverrideNightReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceOverrideNight() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceOverrideNight(PriceOverrideNight other) : this() {
      Date = other.date_ != null ? other.Date.Clone() : null;
      Price = other.price_ != null ? other.Price.Clone() : null;
      action_ = other.action_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceOverrideNight Clone() {
      return new PriceOverrideNight(this);
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

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "action" field.</summary>
    public const int ActionFieldNumber = 3;
    private global::HOLMS.Types.Booking.Pricing.PriceOverrideAction action_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Pricing.PriceOverrideAction Action {
      get { return action_; }
      set {
        action_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PriceOverrideNight);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PriceOverrideNight other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Date, other.Date)) return false;
      if (!object.Equals(Price, other.Price)) return false;
      if (Action != other.Action) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (date_ != null) hash ^= Date.GetHashCode();
      if (price_ != null) hash ^= Price.GetHashCode();
      if (Action != 0) hash ^= Action.GetHashCode();
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
      if (price_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Price);
      }
      if (Action != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Action);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (date_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Date);
      }
      if (price_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Price);
      }
      if (Action != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Action);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PriceOverrideNight other) {
      if (other == null) {
        return;
      }
      if (other.date_ != null) {
        if (date_ == null) {
          date_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        Date.MergeFrom(other.Date);
      }
      if (other.price_ != null) {
        if (price_ == null) {
          price_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Price.MergeFrom(other.Price);
      }
      if (other.Action != 0) {
        Action = other.Action;
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
          case 18: {
            if (price_ == null) {
              price_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(price_);
            break;
          }
          case 24: {
            action_ = (global::HOLMS.Types.Booking.Pricing.PriceOverrideAction) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
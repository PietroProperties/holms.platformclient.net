// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/reservations/recommended_checkin_card_authorization_amounts.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Reservations {

  /// <summary>Holder for reflection information generated from booking/reservations/recommended_checkin_card_authorization_amounts.proto</summary>
  public static partial class RecommendedCheckinCardAuthorizationAmountsReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/reservations/recommended_checkin_card_authorization_amounts.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RecommendedCheckinCardAuthorizationAmountsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklib29raW5nL3Jlc2VydmF0aW9ucy9yZWNvbW1lbmRlZF9jaGVja2luX2Nh",
            "cmRfYXV0aG9yaXphdGlvbl9hbW91bnRzLnByb3RvEiBob2xtcy50eXBlcy5i",
            "b29raW5nLnJlc2VydmF0aW9ucxofcHJpbWl0aXZlL21vbmV0YXJ5X2Ftb3Vu",
            "dC5wcm90byKgAgomUmVjb21tZW5kZWRDaGVja2luQXV0aG9yaXphdGlvbkFt",
            "b3VudHMSMgoDbWluGAEgASgLMiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLk1v",
            "bmV0YXJ5QW1vdW50EjIKA21heBgCIAEoCzIlLmhvbG1zLnR5cGVzLnByaW1p",
            "dGl2ZS5Nb25ldGFyeUFtb3VudBJGChdtaW5faW5jbHVkaW5nX2d1YXJhbnRl",
            "ZRgDIAEoCzIlLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3Vu",
            "dBJGChdtYXhfaW5jbHVkaW5nX2d1YXJhbnRlZRgEIAEoCzIlLmhvbG1zLnR5",
            "cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudEI5WhRib29raW5nL3Jlc2Vy",
            "dmF0aW9uc6oCIEhPTE1TLlR5cGVzLkJvb2tpbmcuUmVzZXJ2YXRpb25zYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts), global::HOLMS.Types.Booking.Reservations.RecommendedCheckinAuthorizationAmounts.Parser, new[]{ "Min", "Max", "MinIncludingGuarantee", "MaxIncludingGuarantee" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RecommendedCheckinAuthorizationAmounts : pb::IMessage<RecommendedCheckinAuthorizationAmounts> {
    private static readonly pb::MessageParser<RecommendedCheckinAuthorizationAmounts> _parser = new pb::MessageParser<RecommendedCheckinAuthorizationAmounts>(() => new RecommendedCheckinAuthorizationAmounts());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RecommendedCheckinAuthorizationAmounts> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Reservations.RecommendedCheckinCardAuthorizationAmountsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecommendedCheckinAuthorizationAmounts() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecommendedCheckinAuthorizationAmounts(RecommendedCheckinAuthorizationAmounts other) : this() {
      Min = other.min_ != null ? other.Min.Clone() : null;
      Max = other.max_ != null ? other.Max.Clone() : null;
      MinIncludingGuarantee = other.minIncludingGuarantee_ != null ? other.MinIncludingGuarantee.Clone() : null;
      MaxIncludingGuarantee = other.maxIncludingGuarantee_ != null ? other.MaxIncludingGuarantee.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecommendedCheckinAuthorizationAmounts Clone() {
      return new RecommendedCheckinAuthorizationAmounts(this);
    }

    /// <summary>Field number for the "min" field.</summary>
    public const int MinFieldNumber = 1;
    private global::HOLMS.Types.Primitive.MonetaryAmount min_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Min {
      get { return min_; }
      set {
        min_ = value;
      }
    }

    /// <summary>Field number for the "max" field.</summary>
    public const int MaxFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount max_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Max {
      get { return max_; }
      set {
        max_ = value;
      }
    }

    /// <summary>Field number for the "min_including_guarantee" field.</summary>
    public const int MinIncludingGuaranteeFieldNumber = 3;
    private global::HOLMS.Types.Primitive.MonetaryAmount minIncludingGuarantee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount MinIncludingGuarantee {
      get { return minIncludingGuarantee_; }
      set {
        minIncludingGuarantee_ = value;
      }
    }

    /// <summary>Field number for the "max_including_guarantee" field.</summary>
    public const int MaxIncludingGuaranteeFieldNumber = 4;
    private global::HOLMS.Types.Primitive.MonetaryAmount maxIncludingGuarantee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount MaxIncludingGuarantee {
      get { return maxIncludingGuarantee_; }
      set {
        maxIncludingGuarantee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RecommendedCheckinAuthorizationAmounts);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RecommendedCheckinAuthorizationAmounts other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Min, other.Min)) return false;
      if (!object.Equals(Max, other.Max)) return false;
      if (!object.Equals(MinIncludingGuarantee, other.MinIncludingGuarantee)) return false;
      if (!object.Equals(MaxIncludingGuarantee, other.MaxIncludingGuarantee)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (min_ != null) hash ^= Min.GetHashCode();
      if (max_ != null) hash ^= Max.GetHashCode();
      if (minIncludingGuarantee_ != null) hash ^= MinIncludingGuarantee.GetHashCode();
      if (maxIncludingGuarantee_ != null) hash ^= MaxIncludingGuarantee.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (min_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Min);
      }
      if (max_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Max);
      }
      if (minIncludingGuarantee_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MinIncludingGuarantee);
      }
      if (maxIncludingGuarantee_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MaxIncludingGuarantee);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (min_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Min);
      }
      if (max_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Max);
      }
      if (minIncludingGuarantee_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MinIncludingGuarantee);
      }
      if (maxIncludingGuarantee_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaxIncludingGuarantee);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RecommendedCheckinAuthorizationAmounts other) {
      if (other == null) {
        return;
      }
      if (other.min_ != null) {
        if (min_ == null) {
          min_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Min.MergeFrom(other.Min);
      }
      if (other.max_ != null) {
        if (max_ == null) {
          max_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Max.MergeFrom(other.Max);
      }
      if (other.minIncludingGuarantee_ != null) {
        if (minIncludingGuarantee_ == null) {
          minIncludingGuarantee_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        MinIncludingGuarantee.MergeFrom(other.MinIncludingGuarantee);
      }
      if (other.maxIncludingGuarantee_ != null) {
        if (maxIncludingGuarantee_ == null) {
          maxIncludingGuarantee_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        MaxIncludingGuarantee.MergeFrom(other.MaxIncludingGuarantee);
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
            if (min_ == null) {
              min_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(min_);
            break;
          }
          case 18: {
            if (max_ == null) {
              max_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(max_);
            break;
          }
          case 26: {
            if (minIncludingGuarantee_ == null) {
              minIncludingGuarantee_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(minIncludingGuarantee_);
            break;
          }
          case 34: {
            if (maxIncludingGuarantee_ == null) {
              maxIncludingGuarantee_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(maxIncludingGuarantee_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
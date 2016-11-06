// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/booking_hold_conversion_result.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply {

  /// <summary>Holder for reflection information generated from supply/booking_hold_conversion_result.proto</summary>
  public static partial class BookingHoldConversionResultReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/booking_hold_conversion_result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BookingHoldConversionResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitzdXBwbHkvYm9va2luZ19ob2xkX2NvbnZlcnNpb25fcmVzdWx0LnByb3Rv",
            "EhJob2xtcy50eXBlcy5zdXBwbHkaJ3N1cHBseS9yZXNlcnZhdGlvbl9ob2xk",
            "X2luZGljYXRvci5wcm90byKCAQobQm9va2luZ0hvbGRDb252ZXJzaW9uUmVz",
            "dWx0EkQKDmhvbGRfaW5kaWNhdG9yGAEgASgLMiwuaG9sbXMudHlwZXMuc3Vw",
            "cGx5LlJlc2VydmF0aW9uSG9sZEluZGljYXRvchIdChVjb252ZXJzaW9uX3N1",
            "Y2Nlc3NmdWwYAiABKAhCHVoGc3VwcGx5qgISSE9MTVMuVHlwZXMuU3VwcGx5",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Supply.ReservationHoldIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.BookingHoldConversionResult), global::HOLMS.Types.Supply.BookingHoldConversionResult.Parser, new[]{ "HoldIndicator", "ConversionSuccessful" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BookingHoldConversionResult : pb::IMessage<BookingHoldConversionResult> {
    private static readonly pb::MessageParser<BookingHoldConversionResult> _parser = new pb::MessageParser<BookingHoldConversionResult>(() => new BookingHoldConversionResult());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BookingHoldConversionResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.BookingHoldConversionResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BookingHoldConversionResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BookingHoldConversionResult(BookingHoldConversionResult other) : this() {
      HoldIndicator = other.holdIndicator_ != null ? other.HoldIndicator.Clone() : null;
      conversionSuccessful_ = other.conversionSuccessful_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BookingHoldConversionResult Clone() {
      return new BookingHoldConversionResult(this);
    }

    /// <summary>Field number for the "hold_indicator" field.</summary>
    public const int HoldIndicatorFieldNumber = 1;
    private global::HOLMS.Types.Supply.ReservationHoldIndicator holdIndicator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.ReservationHoldIndicator HoldIndicator {
      get { return holdIndicator_; }
      set {
        holdIndicator_ = value;
      }
    }

    /// <summary>Field number for the "conversion_successful" field.</summary>
    public const int ConversionSuccessfulFieldNumber = 2;
    private bool conversionSuccessful_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ConversionSuccessful {
      get { return conversionSuccessful_; }
      set {
        conversionSuccessful_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BookingHoldConversionResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BookingHoldConversionResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(HoldIndicator, other.HoldIndicator)) return false;
      if (ConversionSuccessful != other.ConversionSuccessful) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (holdIndicator_ != null) hash ^= HoldIndicator.GetHashCode();
      if (ConversionSuccessful != false) hash ^= ConversionSuccessful.GetHashCode();
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
      if (ConversionSuccessful != false) {
        output.WriteRawTag(16);
        output.WriteBool(ConversionSuccessful);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (holdIndicator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HoldIndicator);
      }
      if (ConversionSuccessful != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BookingHoldConversionResult other) {
      if (other == null) {
        return;
      }
      if (other.holdIndicator_ != null) {
        if (holdIndicator_ == null) {
          holdIndicator_ = new global::HOLMS.Types.Supply.ReservationHoldIndicator();
        }
        HoldIndicator.MergeFrom(other.HoldIndicator);
      }
      if (other.ConversionSuccessful != false) {
        ConversionSuccessful = other.ConversionSuccessful;
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
              holdIndicator_ = new global::HOLMS.Types.Supply.ReservationHoldIndicator();
            }
            input.ReadMessage(holdIndicator_);
            break;
          }
          case 16: {
            ConversionSuccessful = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
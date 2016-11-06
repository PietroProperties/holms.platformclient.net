// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/pricing/override_price_schedule.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Pricing {

  /// <summary>Holder for reflection information generated from booking/pricing/override_price_schedule.proto</summary>
  public static partial class OverridePriceScheduleReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/pricing/override_price_schedule.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OverridePriceScheduleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1ib29raW5nL3ByaWNpbmcvb3ZlcnJpZGVfcHJpY2Vfc2NoZWR1bGUucHJv",
            "dG8SG2hvbG1zLnR5cGVzLmJvb2tpbmcucHJpY2luZxouYm9va2luZy9pbmRp",
            "Y2F0b3JzL3Jlc2VydmF0aW9uX2luZGljYXRvci5wcm90bxohYm9va2luZy9w",
            "cmljaW5nL3ByaWNlX25pZ2h0LnByb3RvGh1wcmltaXRpdmUvcGJfbG9jYWxf",
            "ZGF0ZS5wcm90byK0AgoVT3ZlcnJpZGVQcmljZVNjaGVkdWxlEkkKC3Jlc2Vy",
            "dmF0aW9uGAEgASgLMjQuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3Jz",
            "LlJlc2VydmF0aW9uSW5kaWNhdG9yEkYKFXByaWNlc193aXRoX292ZXJyaWRl",
            "cxgCIAMoCzInLmhvbG1zLnR5cGVzLmJvb2tpbmcucHJpY2luZy5QcmljZU5p",
            "Z2h0EkkKGHByaWNlc193aXRob3V0X292ZXJyaWRlcxgDIAMoCzInLmhvbG1z",
            "LnR5cGVzLmJvb2tpbmcucHJpY2luZy5QcmljZU5pZ2h0Ej0KEW92ZXJyaWRk",
            "ZW5fbmlnaHRzGAQgAygLMiIuaG9sbXMudHlwZXMucHJpbWl0aXZlLlBiTG9j",
            "YWxEYXRlQi9aD2Jvb2tpbmcvcHJpY2luZ6oCG0hPTE1TLlR5cGVzLkJvb2tp",
            "bmcuUHJpY2luZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Pricing.PriceNightReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Pricing.OverridePriceSchedule), global::HOLMS.Types.Booking.Pricing.OverridePriceSchedule.Parser, new[]{ "Reservation", "PricesWithOverrides", "PricesWithoutOverrides", "OverriddenNights" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OverridePriceSchedule : pb::IMessage<OverridePriceSchedule> {
    private static readonly pb::MessageParser<OverridePriceSchedule> _parser = new pb::MessageParser<OverridePriceSchedule>(() => new OverridePriceSchedule());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OverridePriceSchedule> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Pricing.OverridePriceScheduleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverridePriceSchedule() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverridePriceSchedule(OverridePriceSchedule other) : this() {
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      pricesWithOverrides_ = other.pricesWithOverrides_.Clone();
      pricesWithoutOverrides_ = other.pricesWithoutOverrides_.Clone();
      overriddenNights_ = other.overriddenNights_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverridePriceSchedule Clone() {
      return new OverridePriceSchedule(this);
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    /// <summary>Field number for the "prices_with_overrides" field.</summary>
    public const int PricesWithOverridesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Booking.Pricing.PriceNight> _repeated_pricesWithOverrides_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Booking.Pricing.PriceNight.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight> pricesWithOverrides_ = new pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight> PricesWithOverrides {
      get { return pricesWithOverrides_; }
    }

    /// <summary>Field number for the "prices_without_overrides" field.</summary>
    public const int PricesWithoutOverridesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Booking.Pricing.PriceNight> _repeated_pricesWithoutOverrides_codec
        = pb::FieldCodec.ForMessage(26, global::HOLMS.Types.Booking.Pricing.PriceNight.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight> pricesWithoutOverrides_ = new pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight> PricesWithoutOverrides {
      get { return pricesWithoutOverrides_; }
    }

    /// <summary>Field number for the "overridden_nights" field.</summary>
    public const int OverriddenNightsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Primitive.PbLocalDate> _repeated_overriddenNights_codec
        = pb::FieldCodec.ForMessage(34, global::HOLMS.Types.Primitive.PbLocalDate.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Primitive.PbLocalDate> overriddenNights_ = new pbc::RepeatedField<global::HOLMS.Types.Primitive.PbLocalDate>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Primitive.PbLocalDate> OverriddenNights {
      get { return overriddenNights_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OverridePriceSchedule);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OverridePriceSchedule other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if(!pricesWithOverrides_.Equals(other.pricesWithOverrides_)) return false;
      if(!pricesWithoutOverrides_.Equals(other.pricesWithoutOverrides_)) return false;
      if(!overriddenNights_.Equals(other.overriddenNights_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      hash ^= pricesWithOverrides_.GetHashCode();
      hash ^= pricesWithoutOverrides_.GetHashCode();
      hash ^= overriddenNights_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (reservation_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Reservation);
      }
      pricesWithOverrides_.WriteTo(output, _repeated_pricesWithOverrides_codec);
      pricesWithoutOverrides_.WriteTo(output, _repeated_pricesWithoutOverrides_codec);
      overriddenNights_.WriteTo(output, _repeated_overriddenNights_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      size += pricesWithOverrides_.CalculateSize(_repeated_pricesWithOverrides_codec);
      size += pricesWithoutOverrides_.CalculateSize(_repeated_pricesWithoutOverrides_codec);
      size += overriddenNights_.CalculateSize(_repeated_overriddenNights_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OverridePriceSchedule other) {
      if (other == null) {
        return;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      pricesWithOverrides_.Add(other.pricesWithOverrides_);
      pricesWithoutOverrides_.Add(other.pricesWithoutOverrides_);
      overriddenNights_.Add(other.overriddenNights_);
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
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
          case 18: {
            pricesWithOverrides_.AddEntriesFrom(input, _repeated_pricesWithOverrides_codec);
            break;
          }
          case 26: {
            pricesWithoutOverrides_.AddEntriesFrom(input, _repeated_pricesWithoutOverrides_codec);
            break;
          }
          case 34: {
            overriddenNights_.AddEntriesFrom(input, _repeated_overriddenNights_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
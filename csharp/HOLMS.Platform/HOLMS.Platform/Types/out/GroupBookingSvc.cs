// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/group_booking_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.RPC {

  /// <summary>Holder for reflection information generated from booking/rpc/group_booking_svc.proto</summary>
  public static partial class GroupBookingSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/rpc/group_booking_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupBookingSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNib29raW5nL3JwYy9ncm91cF9ib29raW5nX3N2Yy5wcm90bxIXaG9sbXMu",
            "dHlwZXMuYm9va2luZy5ycGMaG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90",
            "bxoiYm9va2luZy9ncm91cHMvZ3JvdXBfYm9va2luZy5wcm90bxomYm9va2lu",
            "Zy9ncm91cHMvZ3JvdXBfYm9va2luZ19leHQucHJvdG8aMGJvb2tpbmcvaW5k",
            "aWNhdG9ycy9ncm91cF9ib29raW5nX2luZGljYXRvci5wcm90bxo1Ym9va2lu",
            "Zy9ncm91cHMvZ3JvdXBfYm9va2luZ19yb29tX3R5cGVfcXVhbnRpdHkucHJv",
            "dG8aIGNybS9ncm91cHMvZ3JvdXBfaW5kaWNhdG9yLnByb3RvGiFzdXBwbHkv",
            "cHJpY2VfdXBkYXRlX3JlcXVlc3QucHJvdG8aLmJvb2tpbmcvcmVzZXJ2YXRp",
            "b25zL3Jlc2VydmF0aW9uX3N1bW1hcnkucHJvdG8aKnByaW1pdGl2ZS9wYl9p",
            "bmNsdXNpdmVfb3BzZGF0ZV9yYW5nZS5wcm90byJbChpHcm91cEJvb2tpbmdT",
            "dmNBbGxCb29raW5ncxI9Cghib29raW5ncxgBIAMoCzIrLmhvbG1zLnR5cGVz",
            "LmJvb2tpbmcuZ3JvdXBzLkdyb3VwQm9va2luZ0V4dCJjCiVHcm91cEJvb2tp",
            "bmdTdmNHZXRCeURhdGVSYW5nZUJvb2tpbmdzEjoKCGJvb2tpbmdzGAEgAygL",
            "MiguaG9sbXMudHlwZXMuYm9va2luZy5ncm91cHMuR3JvdXBCb29raW5nIqMB",
            "CiFHcm91cEJvb2tpbmdTdmNQcmljZVVwZGF0ZVJlcXVlc3QSRgoHYm9va2lu",
            "ZxgBIAEoCzI1LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5Hcm91",
            "cEJvb2tpbmdJbmRpY2F0b3ISNgoGcHJpY2VzGAIgAygLMiYuaG9sbXMudHlw",
            "ZXMuc3VwcGx5LlByaWNlVXBkYXRlUmVxdWVzdCK8AQokR3JvdXBCb29raW5n",
            "U3ZjUXVhbnRpdHlVcGRhdGVSZXF1ZXN0EkYKB2Jvb2tpbmcYASABKAsyNS5o",
            "b2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuR3JvdXBCb29raW5nSW5k",
            "aWNhdG9yEkwKCnF1YW50aXRpZXMYAiADKAsyOC5ob2xtcy50eXBlcy5ib29r",
            "aW5nLmdyb3Vwcy5Hcm91cEJvb2tpbmdSb29tVHlwZVF1YW50aXR5InsKLUdy",
            "b3VwQm9va2luZ1N2Y0dldFJlc2VydmF0aW9uc1dpdGhUYWdSZXNwb25zZRJK",
            "CgxyZXNlcnZhdGlvbnMYASADKAsyNC5ob2xtcy50eXBlcy5ib29raW5nLnJl",
            "c2VydmF0aW9ucy5SZXNlcnZhdGlvblN1bW1hcnkypwYKD0dyb3VwQm9va2lu",
            "Z1N2YxJSCgNBbGwSFi5nb29nbGUucHJvdG9idWYuRW1wdHkaMy5ob2xtcy50",
            "eXBlcy5ib29raW5nLnJwYy5Hcm91cEJvb2tpbmdTdmNBbGxCb29raW5ncxJd",
            "CgZDcmVhdGUSJi5ob2xtcy50eXBlcy5jcm0uZ3JvdXBzLkdyb3VwSW5kaWNh",
            "dG9yGisuaG9sbXMudHlwZXMuYm9va2luZy5ncm91cHMuR3JvdXBCb29raW5n",
            "RXh0El8KBlVwZGF0ZRIoLmhvbG1zLnR5cGVzLmJvb2tpbmcuZ3JvdXBzLkdy",
            "b3VwQm9va2luZxorLmhvbG1zLnR5cGVzLmJvb2tpbmcuZ3JvdXBzLkdyb3Vw",
            "Qm9va2luZ0V4dBJuChhVcGRhdGVHcm91cEJvb2tpbmdQcmljZXMSOi5ob2xt",
            "cy50eXBlcy5ib29raW5nLnJwYy5Hcm91cEJvb2tpbmdTdmNQcmljZVVwZGF0",
            "ZVJlcXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1wdHkSaQoQVXBkYXRlUXVh",
            "bnRpdGllcxI9LmhvbG1zLnR5cGVzLmJvb2tpbmcucnBjLkdyb3VwQm9va2lu",
            "Z1N2Y1F1YW50aXR5VXBkYXRlUmVxdWVzdBoWLmdvb2dsZS5wcm90b2J1Zi5F",
            "bXB0eRKhAQogR2V0UmVzZXJ2YXRpb25TdW1tYXJpZXNXaXRoR0JUYWcSNS5o",
            "b2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuR3JvdXBCb29raW5nSW5k",
            "aWNhdG9yGkYuaG9sbXMudHlwZXMuYm9va2luZy5ycGMuR3JvdXBCb29raW5n",
            "U3ZjR2V0UmVzZXJ2YXRpb25zV2l0aFRhZ1Jlc3BvbnNlEoABCg5HZXRCeURh",
            "dGVSYW5nZRIuLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5QYkluY2x1c2l2ZU9w",
            "c2RhdGVSYW5nZRo+LmhvbG1zLnR5cGVzLmJvb2tpbmcucnBjLkdyb3VwQm9v",
            "a2luZ1N2Y0dldEJ5RGF0ZVJhbmdlQm9va2luZ3NCJ1oLYm9va2luZy9ycGOq",
            "AhdIT0xNUy5UeXBlcy5Cb29raW5nLlJQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Booking.Groups.GroupBookingReflection.Descriptor, global::HOLMS.Types.Booking.Groups.GroupBookingExtReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.GroupBookingIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Groups.GroupBookingRoomTypeQuantityReflection.Descriptor, global::HOLMS.Types.CRM.Groups.GroupIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.PriceUpdateRequestReflection.Descriptor, global::HOLMS.Types.Booking.Reservations.ReservationSummaryReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.RPC.GroupBookingSvcAllBookings), global::HOLMS.Types.Booking.RPC.GroupBookingSvcAllBookings.Parser, new[]{ "Bookings" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetByDateRangeBookings), global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetByDateRangeBookings.Parser, new[]{ "Bookings" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.RPC.GroupBookingSvcPriceUpdateRequest), global::HOLMS.Types.Booking.RPC.GroupBookingSvcPriceUpdateRequest.Parser, new[]{ "Booking", "Prices" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.RPC.GroupBookingSvcQuantityUpdateRequest), global::HOLMS.Types.Booking.RPC.GroupBookingSvcQuantityUpdateRequest.Parser, new[]{ "Booking", "Quantities" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetReservationsWithTagResponse), global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetReservationsWithTagResponse.Parser, new[]{ "Reservations" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroupBookingSvcAllBookings : pb::IMessage<GroupBookingSvcAllBookings> {
    private static readonly pb::MessageParser<GroupBookingSvcAllBookings> _parser = new pb::MessageParser<GroupBookingSvcAllBookings>(() => new GroupBookingSvcAllBookings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GroupBookingSvcAllBookings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.RPC.GroupBookingSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcAllBookings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcAllBookings(GroupBookingSvcAllBookings other) : this() {
      bookings_ = other.bookings_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcAllBookings Clone() {
      return new GroupBookingSvcAllBookings(this);
    }

    /// <summary>Field number for the "bookings" field.</summary>
    public const int BookingsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Booking.Groups.GroupBookingExt> _repeated_bookings_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Booking.Groups.GroupBookingExt.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Booking.Groups.GroupBookingExt> bookings_ = new pbc::RepeatedField<global::HOLMS.Types.Booking.Groups.GroupBookingExt>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Booking.Groups.GroupBookingExt> Bookings {
      get { return bookings_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GroupBookingSvcAllBookings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GroupBookingSvcAllBookings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!bookings_.Equals(other.bookings_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= bookings_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      bookings_.WriteTo(output, _repeated_bookings_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += bookings_.CalculateSize(_repeated_bookings_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GroupBookingSvcAllBookings other) {
      if (other == null) {
        return;
      }
      bookings_.Add(other.bookings_);
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
            bookings_.AddEntriesFrom(input, _repeated_bookings_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GroupBookingSvcGetByDateRangeBookings : pb::IMessage<GroupBookingSvcGetByDateRangeBookings> {
    private static readonly pb::MessageParser<GroupBookingSvcGetByDateRangeBookings> _parser = new pb::MessageParser<GroupBookingSvcGetByDateRangeBookings>(() => new GroupBookingSvcGetByDateRangeBookings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GroupBookingSvcGetByDateRangeBookings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.RPC.GroupBookingSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcGetByDateRangeBookings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcGetByDateRangeBookings(GroupBookingSvcGetByDateRangeBookings other) : this() {
      bookings_ = other.bookings_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcGetByDateRangeBookings Clone() {
      return new GroupBookingSvcGetByDateRangeBookings(this);
    }

    /// <summary>Field number for the "bookings" field.</summary>
    public const int BookingsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Booking.Groups.GroupBooking> _repeated_bookings_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Booking.Groups.GroupBooking.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Booking.Groups.GroupBooking> bookings_ = new pbc::RepeatedField<global::HOLMS.Types.Booking.Groups.GroupBooking>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Booking.Groups.GroupBooking> Bookings {
      get { return bookings_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GroupBookingSvcGetByDateRangeBookings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GroupBookingSvcGetByDateRangeBookings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!bookings_.Equals(other.bookings_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= bookings_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      bookings_.WriteTo(output, _repeated_bookings_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += bookings_.CalculateSize(_repeated_bookings_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GroupBookingSvcGetByDateRangeBookings other) {
      if (other == null) {
        return;
      }
      bookings_.Add(other.bookings_);
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
            bookings_.AddEntriesFrom(input, _repeated_bookings_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GroupBookingSvcPriceUpdateRequest : pb::IMessage<GroupBookingSvcPriceUpdateRequest> {
    private static readonly pb::MessageParser<GroupBookingSvcPriceUpdateRequest> _parser = new pb::MessageParser<GroupBookingSvcPriceUpdateRequest>(() => new GroupBookingSvcPriceUpdateRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GroupBookingSvcPriceUpdateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.RPC.GroupBookingSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcPriceUpdateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcPriceUpdateRequest(GroupBookingSvcPriceUpdateRequest other) : this() {
      Booking = other.booking_ != null ? other.Booking.Clone() : null;
      prices_ = other.prices_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcPriceUpdateRequest Clone() {
      return new GroupBookingSvcPriceUpdateRequest(this);
    }

    /// <summary>Field number for the "booking" field.</summary>
    public const int BookingFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator booking_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator Booking {
      get { return booking_; }
      set {
        booking_ = value;
      }
    }

    /// <summary>Field number for the "prices" field.</summary>
    public const int PricesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.PriceUpdateRequest> _repeated_prices_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Supply.PriceUpdateRequest.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.PriceUpdateRequest> prices_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.PriceUpdateRequest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.PriceUpdateRequest> Prices {
      get { return prices_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GroupBookingSvcPriceUpdateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GroupBookingSvcPriceUpdateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Booking, other.Booking)) return false;
      if(!prices_.Equals(other.prices_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (booking_ != null) hash ^= Booking.GetHashCode();
      hash ^= prices_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (booking_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Booking);
      }
      prices_.WriteTo(output, _repeated_prices_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (booking_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Booking);
      }
      size += prices_.CalculateSize(_repeated_prices_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GroupBookingSvcPriceUpdateRequest other) {
      if (other == null) {
        return;
      }
      if (other.booking_ != null) {
        if (booking_ == null) {
          booking_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
        }
        Booking.MergeFrom(other.Booking);
      }
      prices_.Add(other.prices_);
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
            if (booking_ == null) {
              booking_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
            }
            input.ReadMessage(booking_);
            break;
          }
          case 18: {
            prices_.AddEntriesFrom(input, _repeated_prices_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GroupBookingSvcQuantityUpdateRequest : pb::IMessage<GroupBookingSvcQuantityUpdateRequest> {
    private static readonly pb::MessageParser<GroupBookingSvcQuantityUpdateRequest> _parser = new pb::MessageParser<GroupBookingSvcQuantityUpdateRequest>(() => new GroupBookingSvcQuantityUpdateRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GroupBookingSvcQuantityUpdateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.RPC.GroupBookingSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcQuantityUpdateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcQuantityUpdateRequest(GroupBookingSvcQuantityUpdateRequest other) : this() {
      Booking = other.booking_ != null ? other.Booking.Clone() : null;
      quantities_ = other.quantities_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcQuantityUpdateRequest Clone() {
      return new GroupBookingSvcQuantityUpdateRequest(this);
    }

    /// <summary>Field number for the "booking" field.</summary>
    public const int BookingFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator booking_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator Booking {
      get { return booking_; }
      set {
        booking_ = value;
      }
    }

    /// <summary>Field number for the "quantities" field.</summary>
    public const int QuantitiesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Booking.Groups.GroupBookingRoomTypeQuantity> _repeated_quantities_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Booking.Groups.GroupBookingRoomTypeQuantity.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Booking.Groups.GroupBookingRoomTypeQuantity> quantities_ = new pbc::RepeatedField<global::HOLMS.Types.Booking.Groups.GroupBookingRoomTypeQuantity>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Booking.Groups.GroupBookingRoomTypeQuantity> Quantities {
      get { return quantities_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GroupBookingSvcQuantityUpdateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GroupBookingSvcQuantityUpdateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Booking, other.Booking)) return false;
      if(!quantities_.Equals(other.quantities_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (booking_ != null) hash ^= Booking.GetHashCode();
      hash ^= quantities_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (booking_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Booking);
      }
      quantities_.WriteTo(output, _repeated_quantities_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (booking_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Booking);
      }
      size += quantities_.CalculateSize(_repeated_quantities_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GroupBookingSvcQuantityUpdateRequest other) {
      if (other == null) {
        return;
      }
      if (other.booking_ != null) {
        if (booking_ == null) {
          booking_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
        }
        Booking.MergeFrom(other.Booking);
      }
      quantities_.Add(other.quantities_);
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
            if (booking_ == null) {
              booking_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
            }
            input.ReadMessage(booking_);
            break;
          }
          case 18: {
            quantities_.AddEntriesFrom(input, _repeated_quantities_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GroupBookingSvcGetReservationsWithTagResponse : pb::IMessage<GroupBookingSvcGetReservationsWithTagResponse> {
    private static readonly pb::MessageParser<GroupBookingSvcGetReservationsWithTagResponse> _parser = new pb::MessageParser<GroupBookingSvcGetReservationsWithTagResponse>(() => new GroupBookingSvcGetReservationsWithTagResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GroupBookingSvcGetReservationsWithTagResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.RPC.GroupBookingSvcReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcGetReservationsWithTagResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcGetReservationsWithTagResponse(GroupBookingSvcGetReservationsWithTagResponse other) : this() {
      reservations_ = other.reservations_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBookingSvcGetReservationsWithTagResponse Clone() {
      return new GroupBookingSvcGetReservationsWithTagResponse(this);
    }

    /// <summary>Field number for the "reservations" field.</summary>
    public const int ReservationsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Booking.Reservations.ReservationSummary> _repeated_reservations_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Booking.Reservations.ReservationSummary.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Booking.Reservations.ReservationSummary> reservations_ = new pbc::RepeatedField<global::HOLMS.Types.Booking.Reservations.ReservationSummary>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Booking.Reservations.ReservationSummary> Reservations {
      get { return reservations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GroupBookingSvcGetReservationsWithTagResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GroupBookingSvcGetReservationsWithTagResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!reservations_.Equals(other.reservations_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= reservations_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      reservations_.WriteTo(output, _repeated_reservations_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += reservations_.CalculateSize(_repeated_reservations_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GroupBookingSvcGetReservationsWithTagResponse other) {
      if (other == null) {
        return;
      }
      reservations_.Add(other.reservations_);
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
            reservations_.AddEntriesFrom(input, _repeated_reservations_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/reservations/reservation_booked_notification.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Reservations {

  /// <summary>Holder for reflection information generated from booking/reservations/reservation_booked_notification.proto</summary>
  public static partial class ReservationBookedNotificationReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/reservations/reservation_booked_notification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationBookedNotificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpib29raW5nL3Jlc2VydmF0aW9ucy9yZXNlcnZhdGlvbl9ib29rZWRfbm90",
            "aWZpY2F0aW9uLnByb3RvEiBob2xtcy50eXBlcy5ib29raW5nLnJlc2VydmF0",
            "aW9ucxouYm9va2luZy9pbmRpY2F0b3JzL3Jlc2VydmF0aW9uX2luZGljYXRv",
            "ci5wcm90byJ9Ch1SZXNlcnZhdGlvbkJvb2tlZE5vdGlmaWNhdGlvbhIRCglq",
            "X3dfdG9rZW4YASABKAkSSQoLcmVzZXJ2YXRpb24YAiABKAsyNC5ob2xtcy50",
            "eXBlcy5ib29raW5nLmluZGljYXRvcnMuUmVzZXJ2YXRpb25JbmRpY2F0b3JC",
            "I6oCIEhPTE1TLlR5cGVzLkJvb2tpbmcuUmVzZXJ2YXRpb25zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Reservations.ReservationBookedNotification), global::HOLMS.Types.Booking.Reservations.ReservationBookedNotification.Parser, new[]{ "JWToken", "Reservation" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationBookedNotification : pb::IMessage<ReservationBookedNotification> {
    private static readonly pb::MessageParser<ReservationBookedNotification> _parser = new pb::MessageParser<ReservationBookedNotification>(() => new ReservationBookedNotification());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationBookedNotification> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Reservations.ReservationBookedNotificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationBookedNotification() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationBookedNotification(ReservationBookedNotification other) : this() {
      jWToken_ = other.jWToken_;
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationBookedNotification Clone() {
      return new ReservationBookedNotification(this);
    }

    /// <summary>Field number for the "j_w_token" field.</summary>
    public const int JWTokenFieldNumber = 1;
    private string jWToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JWToken {
      get { return jWToken_; }
      set {
        jWToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 2;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationBookedNotification);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationBookedNotification other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JWToken != other.JWToken) return false;
      if (!object.Equals(Reservation, other.Reservation)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (JWToken.Length != 0) hash ^= JWToken.GetHashCode();
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (JWToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JWToken);
      }
      if (reservation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Reservation);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (JWToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JWToken);
      }
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationBookedNotification other) {
      if (other == null) {
        return;
      }
      if (other.JWToken.Length != 0) {
        JWToken = other.JWToken;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
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
            JWToken = input.ReadString();
            break;
          }
          case 18: {
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
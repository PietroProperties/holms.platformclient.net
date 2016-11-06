// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/accounting/reservation_ledger.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Accounting {

  /// <summary>Holder for reflection information generated from money/accounting/reservation_ledger.proto</summary>
  public static partial class ReservationLedgerReflection {

    #region Descriptor
    /// <summary>File descriptor for money/accounting/reservation_ledger.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationLedgerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ciltb25leS9hY2NvdW50aW5nL3Jlc2VydmF0aW9uX2xlZGdlci5wcm90bxIc",
            "aG9sbXMudHlwZXMubW9uZXkuYWNjb3VudGluZxouYm9va2luZy9pbmRpY2F0",
            "b3JzL3Jlc2VydmF0aW9uX2luZGljYXRvci5wcm90bxo4bW9uZXkvYWNjb3Vu",
            "dGluZy9hY2NvdW50aW5nX3RyYW5zYWN0aW9uX3dpdGhfZ3Vlc3QucHJvdG8a",
            "KG1vbmV5L2FjY291bnRpbmcvYWNjb3VudF9pbmRpY2F0b3IucHJvdG8aFmNy",
            "bS9ndWVzdHMvZ3Vlc3QucHJvdG8iqwIKEVJlc2VydmF0aW9uTGVkZ2VyEkkK",
            "C3Jlc2VydmF0aW9uGAEgASgLMjQuaG9sbXMudHlwZXMuYm9va2luZy5pbmRp",
            "Y2F0b3JzLlJlc2VydmF0aW9uSW5kaWNhdG9yElIKDHRyYW5zYWN0aW9ucxgC",
            "IAMoCzI8LmhvbG1zLnR5cGVzLm1vbmV5LmFjY291bnRpbmcuQWNjb3VudGlu",
            "Z1RyYW5zYWN0aW9uV2l0aEd1ZXN0EkQKDHN0YXlfYWNjb3VudBgDIAEoCzIu",
            "LmhvbG1zLnR5cGVzLm1vbmV5LmFjY291bnRpbmcuQWNjb3VudEluZGljYXRv",
            "chIxCgphbGxfZ3Vlc3RzGAQgAygLMh0uaG9sbXMudHlwZXMuY3JtLmd1ZXN0",
            "cy5HdWVzdEIxWhBtb25leS9hY2NvdW50aW5nqgIcSE9MTVMuVHlwZXMuTW9u",
            "ZXkuQWNjb3VudGluZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuestReflection.Descriptor, global::HOLMS.Types.Money.Accounting.AccountIndicatorReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Accounting.ReservationLedger), global::HOLMS.Types.Money.Accounting.ReservationLedger.Parser, new[]{ "Reservation", "Transactions", "StayAccount", "AllGuests" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationLedger : pb::IMessage<ReservationLedger> {
    private static readonly pb::MessageParser<ReservationLedger> _parser = new pb::MessageParser<ReservationLedger>(() => new ReservationLedger());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationLedger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Accounting.ReservationLedgerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationLedger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationLedger(ReservationLedger other) : this() {
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      transactions_ = other.transactions_.Clone();
      StayAccount = other.stayAccount_ != null ? other.StayAccount.Clone() : null;
      allGuests_ = other.allGuests_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationLedger Clone() {
      return new ReservationLedger(this);
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

    /// <summary>Field number for the "transactions" field.</summary>
    public const int TransactionsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuest> _repeated_transactions_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuest.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuest> transactions_ = new pbc::RepeatedField<global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Money.Accounting.AccountingTransactionWithGuest> Transactions {
      get { return transactions_; }
    }

    /// <summary>Field number for the "stay_account" field.</summary>
    public const int StayAccountFieldNumber = 3;
    private global::HOLMS.Types.Money.Accounting.AccountIndicator stayAccount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Accounting.AccountIndicator StayAccount {
      get { return stayAccount_; }
      set {
        stayAccount_ = value;
      }
    }

    /// <summary>Field number for the "all_guests" field.</summary>
    public const int AllGuestsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::HOLMS.Types.CRM.Guests.Guest> _repeated_allGuests_codec
        = pb::FieldCodec.ForMessage(34, global::HOLMS.Types.CRM.Guests.Guest.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.CRM.Guests.Guest> allGuests_ = new pbc::RepeatedField<global::HOLMS.Types.CRM.Guests.Guest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.CRM.Guests.Guest> AllGuests {
      get { return allGuests_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationLedger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationLedger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if(!transactions_.Equals(other.transactions_)) return false;
      if (!object.Equals(StayAccount, other.StayAccount)) return false;
      if(!allGuests_.Equals(other.allGuests_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      hash ^= transactions_.GetHashCode();
      if (stayAccount_ != null) hash ^= StayAccount.GetHashCode();
      hash ^= allGuests_.GetHashCode();
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
      transactions_.WriteTo(output, _repeated_transactions_codec);
      if (stayAccount_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(StayAccount);
      }
      allGuests_.WriteTo(output, _repeated_allGuests_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      size += transactions_.CalculateSize(_repeated_transactions_codec);
      if (stayAccount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StayAccount);
      }
      size += allGuests_.CalculateSize(_repeated_allGuests_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationLedger other) {
      if (other == null) {
        return;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      transactions_.Add(other.transactions_);
      if (other.stayAccount_ != null) {
        if (stayAccount_ == null) {
          stayAccount_ = new global::HOLMS.Types.Money.Accounting.AccountIndicator();
        }
        StayAccount.MergeFrom(other.StayAccount);
      }
      allGuests_.Add(other.allGuests_);
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
            transactions_.AddEntriesFrom(input, _repeated_transactions_codec);
            break;
          }
          case 26: {
            if (stayAccount_ == null) {
              stayAccount_ = new global::HOLMS.Types.Money.Accounting.AccountIndicator();
            }
            input.ReadMessage(stayAccount_);
            break;
          }
          case 34: {
            allGuests_.AddEntriesFrom(input, _repeated_allGuests_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
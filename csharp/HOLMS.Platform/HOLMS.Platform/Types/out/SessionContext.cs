// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: primitive/session_context.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Primitive {

  /// <summary>Holder for reflection information generated from primitive/session_context.proto</summary>
  public static partial class SessionContextReflection {

    #region Descriptor
    /// <summary>File descriptor for primitive/session_context.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionContextReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9wcmltaXRpdmUvc2Vzc2lvbl9jb250ZXh0LnByb3RvEhVob2xtcy50eXBl",
            "cy5wcmltaXRpdmUaIGlhbS9zdGFmZl9tZW1iZXJfaW5kaWNhdG9yLnByb3Rv",
            "IvABCg5TZXNzaW9uQ29udGV4dBIUCgxhY2Nlc3NfdG9rZW4YASABKAkSFQoN",
            "cmVmcmVzaF90b2tlbhgCIAEoCRIUCgx0ZW5hbmN5X25hbWUYAyABKAkSEQoJ",
            "dXNlcl9uYW1lGAQgASgJEjMKBHVzZXIYBSABKAsyJS5ob2xtcy50eXBlcy5p",
            "YW0uU3RhZmZNZW1iZXJJbmRpY2F0b3ISPwoQc2VjdXJpdHlfYWN0aW9ucxgG",
            "IAMoDjIlLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5TZWN1cml0eUFjdGlvbhIS",
            "CgpleHBpcmVzX2luGAcgASgEKucCCg5TZWN1cml0eUFjdGlvbhIXChNHRVRf",
            "U1VQUExZX1NOQVBTSE9UEAASEgoOR0VUX1JPT01fVFlQRVMQARIaChZDSEFO",
            "R0VfU1lTVEVNX1NFVFRJTkdTEAISGgoWUEVSRk9STV9CQUNLR1JPVU5EX0pP",
            "QhADEhIKDkNIQU5HRV9QUklDSU5HEAQSFgoSQ0hBTkdFX0RFUEFSVE1FTlRT",
            "EAUSEAoMQ0hBTkdFX1VTRVJTEAYSEQoNQ0hBTkdFX1NVUFBMWRAHEhcKE0NI",
            "QU5HRV9SRVNFUlZBVElPTlMQCBIiCh5DSEFOR0VfSU5DSURFTlRBTF9SRVNF",
            "UlZBVElPTlMQCRIRCg1DSEFOR0VfRk9MSU9TEAoSEAoMQ0hBTkdFX01PTkVZ",
            "EAsSEQoNQ0hBTkdFX0dST1VQUxAMEhcKE0NIQU5HRV9IT1VTRUtFRVBJTkcQ",
            "DRIRCg1DSEFOR0VfR1VFU1RTEA5CI1oJcHJpbWl0aXZlqgIVSE9MTVMuVHlw",
            "ZXMuUHJpbWl0aXZlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.IAM.StaffMemberIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Primitive.SecurityAction), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Primitive.SessionContext), global::HOLMS.Types.Primitive.SessionContext.Parser, new[]{ "AccessToken", "RefreshToken", "TenancyName", "UserName", "User", "SecurityActions", "ExpiresIn" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum SecurityAction {
    [pbr::OriginalName("GET_SUPPLY_SNAPSHOT")] GetSupplySnapshot = 0,
    [pbr::OriginalName("GET_ROOM_TYPES")] GetRoomTypes = 1,
    [pbr::OriginalName("CHANGE_SYSTEM_SETTINGS")] ChangeSystemSettings = 2,
    [pbr::OriginalName("PERFORM_BACKGROUND_JOB")] PerformBackgroundJob = 3,
    [pbr::OriginalName("CHANGE_PRICING")] ChangePricing = 4,
    [pbr::OriginalName("CHANGE_DEPARTMENTS")] ChangeDepartments = 5,
    [pbr::OriginalName("CHANGE_USERS")] ChangeUsers = 6,
    [pbr::OriginalName("CHANGE_SUPPLY")] ChangeSupply = 7,
    [pbr::OriginalName("CHANGE_RESERVATIONS")] ChangeReservations = 8,
    [pbr::OriginalName("CHANGE_INCIDENTAL_RESERVATIONS")] ChangeIncidentalReservations = 9,
    [pbr::OriginalName("CHANGE_FOLIOS")] ChangeFolios = 10,
    [pbr::OriginalName("CHANGE_MONEY")] ChangeMoney = 11,
    [pbr::OriginalName("CHANGE_GROUPS")] ChangeGroups = 12,
    [pbr::OriginalName("CHANGE_HOUSEKEEPING")] ChangeHousekeeping = 13,
    [pbr::OriginalName("CHANGE_GUESTS")] ChangeGuests = 14,
  }

  #endregion

  #region Messages
  public sealed partial class SessionContext : pb::IMessage<SessionContext> {
    private static readonly pb::MessageParser<SessionContext> _parser = new pb::MessageParser<SessionContext>(() => new SessionContext());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SessionContext> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Primitive.SessionContextReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionContext() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionContext(SessionContext other) : this() {
      accessToken_ = other.accessToken_;
      refreshToken_ = other.refreshToken_;
      tenancyName_ = other.tenancyName_;
      userName_ = other.userName_;
      User = other.user_ != null ? other.User.Clone() : null;
      securityActions_ = other.securityActions_.Clone();
      expiresIn_ = other.expiresIn_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionContext Clone() {
      return new SessionContext(this);
    }

    /// <summary>Field number for the "access_token" field.</summary>
    public const int AccessTokenFieldNumber = 1;
    private string accessToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AccessToken {
      get { return accessToken_; }
      set {
        accessToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "refresh_token" field.</summary>
    public const int RefreshTokenFieldNumber = 2;
    private string refreshToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RefreshToken {
      get { return refreshToken_; }
      set {
        refreshToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tenancy_name" field.</summary>
    public const int TenancyNameFieldNumber = 3;
    private string tenancyName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TenancyName {
      get { return tenancyName_; }
      set {
        tenancyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_name" field.</summary>
    public const int UserNameFieldNumber = 4;
    private string userName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 5;
    private global::HOLMS.Types.IAM.StaffMemberIndicator user_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.StaffMemberIndicator User {
      get { return user_; }
      set {
        user_ = value;
      }
    }

    /// <summary>Field number for the "security_actions" field.</summary>
    public const int SecurityActionsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Primitive.SecurityAction> _repeated_securityActions_codec
        = pb::FieldCodec.ForEnum(50, x => (int) x, x => (global::HOLMS.Types.Primitive.SecurityAction) x);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Primitive.SecurityAction> securityActions_ = new pbc::RepeatedField<global::HOLMS.Types.Primitive.SecurityAction>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Primitive.SecurityAction> SecurityActions {
      get { return securityActions_; }
    }

    /// <summary>Field number for the "expires_in" field.</summary>
    public const int ExpiresInFieldNumber = 7;
    private ulong expiresIn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong ExpiresIn {
      get { return expiresIn_; }
      set {
        expiresIn_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SessionContext);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SessionContext other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccessToken != other.AccessToken) return false;
      if (RefreshToken != other.RefreshToken) return false;
      if (TenancyName != other.TenancyName) return false;
      if (UserName != other.UserName) return false;
      if (!object.Equals(User, other.User)) return false;
      if(!securityActions_.Equals(other.securityActions_)) return false;
      if (ExpiresIn != other.ExpiresIn) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AccessToken.Length != 0) hash ^= AccessToken.GetHashCode();
      if (RefreshToken.Length != 0) hash ^= RefreshToken.GetHashCode();
      if (TenancyName.Length != 0) hash ^= TenancyName.GetHashCode();
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (user_ != null) hash ^= User.GetHashCode();
      hash ^= securityActions_.GetHashCode();
      if (ExpiresIn != 0UL) hash ^= ExpiresIn.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AccessToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AccessToken);
      }
      if (RefreshToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RefreshToken);
      }
      if (TenancyName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TenancyName);
      }
      if (UserName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(UserName);
      }
      if (user_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(User);
      }
      securityActions_.WriteTo(output, _repeated_securityActions_codec);
      if (ExpiresIn != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(ExpiresIn);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AccessToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccessToken);
      }
      if (RefreshToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RefreshToken);
      }
      if (TenancyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TenancyName);
      }
      if (UserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (user_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(User);
      }
      size += securityActions_.CalculateSize(_repeated_securityActions_codec);
      if (ExpiresIn != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ExpiresIn);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SessionContext other) {
      if (other == null) {
        return;
      }
      if (other.AccessToken.Length != 0) {
        AccessToken = other.AccessToken;
      }
      if (other.RefreshToken.Length != 0) {
        RefreshToken = other.RefreshToken;
      }
      if (other.TenancyName.Length != 0) {
        TenancyName = other.TenancyName;
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      if (other.user_ != null) {
        if (user_ == null) {
          user_ = new global::HOLMS.Types.IAM.StaffMemberIndicator();
        }
        User.MergeFrom(other.User);
      }
      securityActions_.Add(other.securityActions_);
      if (other.ExpiresIn != 0UL) {
        ExpiresIn = other.ExpiresIn;
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
            AccessToken = input.ReadString();
            break;
          }
          case 18: {
            RefreshToken = input.ReadString();
            break;
          }
          case 26: {
            TenancyName = input.ReadString();
            break;
          }
          case 34: {
            UserName = input.ReadString();
            break;
          }
          case 42: {
            if (user_ == null) {
              user_ = new global::HOLMS.Types.IAM.StaffMemberIndicator();
            }
            input.ReadMessage(user_);
            break;
          }
          case 50:
          case 48: {
            securityActions_.AddEntriesFrom(input, _repeated_securityActions_codec);
            break;
          }
          case 56: {
            ExpiresIn = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

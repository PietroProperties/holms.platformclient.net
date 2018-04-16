// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/cards/transactions/card_authorization_response.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Cards.Transactions {

  /// <summary>Holder for reflection information generated from money/cards/transactions/card_authorization_response.proto</summary>
  public static partial class CardAuthorizationResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for money/cards/transactions/card_authorization_response.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CardAuthorizationResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjptb25leS9jYXJkcy90cmFuc2FjdGlvbnMvY2FyZF9hdXRob3JpemF0aW9u",
            "X3Jlc3BvbnNlLnByb3RvEiRob2xtcy50eXBlcy5tb25leS5jYXJkcy50cmFu",
            "c2FjdGlvbnMaOm1vbmV5L2NhcmRzL3RyYW5zYWN0aW9ucy9wYXltZW50X2Nh",
            "cmRfc2FsZV9pbmRpY2F0b3IucHJvdG8aQ21vbmV5L2NhcmRzL3RyYW5zYWN0",
            "aW9ucy9wYXltZW50X2NhcmRfYXV0aG9yaXphdGlvbl9pbmRpY2F0b3IucHJv",
            "dG8ioAIKGUNhcmRBdXRob3JpemF0aW9uUmVzcG9uc2USVQoIcmVzcG9uc2UY",
            "ASABKA4yQy5ob2xtcy50eXBlcy5tb25leS5jYXJkcy50cmFuc2FjdGlvbnMu",
            "Q2FyZEF1dGhvcml6YXRpb25SZXNwb25zZUNvZGUSTAoEc2FsZRgCIAEoCzI+",
            "LmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLnRyYW5zYWN0aW9ucy5QYXltZW50",
            "Q2FyZFNhbGVJbmRpY2F0b3ISXgoNYXV0aG9yaXphdGlvbhgDIAEoCzJHLmhv",
            "bG1zLnR5cGVzLm1vbmV5LmNhcmRzLnRyYW5zYWN0aW9ucy5QYXltZW50Q2Fy",
            "ZEF1dGhvcml6YXRpb25JbmRpY2F0b3IqgQQKHUNhcmRBdXRob3JpemF0aW9u",
            "UmVzcG9uc2VDb2RlEhkKFUFVVEhPUklaQVRJT05fU1VDQ0VTUxAAEh8KG0FV",
            "VEhPUklaQVRJT05fQ0FSRF9ERUNMSU5FRBABEi0KKUFVVEhPUklaQVRJT05f",
            "VFJBTlNJRU5UX09QRVJBVElPTkFMX0VSUk9SEAISLQopQVVUSE9SSVpBVElP",
            "Tl9QRVJNQU5FTlRfT1BFUkFUSU9OQUxfRVJST1IQAxIpCiVBVVRIT1JJWkFU",
            "SU9OX05PX1RFUk1JTkFMU19DT05GSUdVUkVEEAQSJAogQVVUSE9SSVpBVElP",
            "Tl9BTU9VTlRfTk9UX0FMTE9XRUQQBRIhCh1BVVRIT1JJWkFUSU9OX0lOVkFM",
            "SURfUkVRVUVTVBAGEiEKHUFVVEhPUklaQVRJT05fR0FURVdBWV9GQUlMVVJF",
            "EAcSGQoVQVVUSE9SSVpBVElPTl9USU1FT1VUEAgSGQoVQVVUSE9SSVpBVElP",
            "Tl9BQk9SVEVEEAkSIQodQVVUSE9SSVpBVElPTl9VTktOT1dOX0ZBSUxVUkUQ",
            "ChIsCihBVVRIT1JJWkFUSU9OX0lOVkFMSURfVEFSR0VUX1RSQU5TQUNUSU9O",
            "EAsSKAokQVVUSE9SSVpBVElPTl9BVVRIRU5USUNBVElPTl9GQUlMVVJFEAxC",
            "QVoYbW9uZXkvY2FyZHMvdHJhbnNhY3Rpb25zqgIkSE9MTVMuVHlwZXMuTW9u",
            "ZXkuQ2FyZHMuVHJhbnNhY3Rpb25zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Money.Cards.Transactions.CardAuthorizationResponseCode), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Cards.Transactions.CardAuthorizationResponse), global::HOLMS.Types.Money.Cards.Transactions.CardAuthorizationResponse.Parser, new[]{ "Response", "Sale", "Authorization" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum CardAuthorizationResponseCode {
    [pbr::OriginalName("AUTHORIZATION_SUCCESS")] AuthorizationSuccess = 0,
    [pbr::OriginalName("AUTHORIZATION_CARD_DECLINED")] AuthorizationCardDeclined = 1,
    [pbr::OriginalName("AUTHORIZATION_TRANSIENT_OPERATIONAL_ERROR")] AuthorizationTransientOperationalError = 2,
    [pbr::OriginalName("AUTHORIZATION_PERMANENT_OPERATIONAL_ERROR")] AuthorizationPermanentOperationalError = 3,
    [pbr::OriginalName("AUTHORIZATION_NO_TERMINALS_CONFIGURED")] AuthorizationNoTerminalsConfigured = 4,
    [pbr::OriginalName("AUTHORIZATION_AMOUNT_NOT_ALLOWED")] AuthorizationAmountNotAllowed = 5,
    [pbr::OriginalName("AUTHORIZATION_INVALID_REQUEST")] AuthorizationInvalidRequest = 6,
    [pbr::OriginalName("AUTHORIZATION_GATEWAY_FAILURE")] AuthorizationGatewayFailure = 7,
    [pbr::OriginalName("AUTHORIZATION_TIMEOUT")] AuthorizationTimeout = 8,
    [pbr::OriginalName("AUTHORIZATION_ABORTED")] AuthorizationAborted = 9,
    [pbr::OriginalName("AUTHORIZATION_UNKNOWN_FAILURE")] AuthorizationUnknownFailure = 10,
    [pbr::OriginalName("AUTHORIZATION_INVALID_TARGET_TRANSACTION")] AuthorizationInvalidTargetTransaction = 11,
    [pbr::OriginalName("AUTHORIZATION_AUTHENTICATION_FAILURE")] AuthorizationAuthenticationFailure = 12,
  }

  #endregion

  #region Messages
  public sealed partial class CardAuthorizationResponse : pb::IMessage<CardAuthorizationResponse> {
    private static readonly pb::MessageParser<CardAuthorizationResponse> _parser = new pb::MessageParser<CardAuthorizationResponse>(() => new CardAuthorizationResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardAuthorizationResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Cards.Transactions.CardAuthorizationResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardAuthorizationResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardAuthorizationResponse(CardAuthorizationResponse other) : this() {
      response_ = other.response_;
      Sale = other.sale_ != null ? other.Sale.Clone() : null;
      Authorization = other.authorization_ != null ? other.Authorization.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardAuthorizationResponse Clone() {
      return new CardAuthorizationResponse(this);
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 1;
    private global::HOLMS.Types.Money.Cards.Transactions.CardAuthorizationResponseCode response_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.CardAuthorizationResponseCode Response {
      get { return response_; }
      set {
        response_ = value;
      }
    }

    /// <summary>Field number for the "sale" field.</summary>
    public const int SaleFieldNumber = 2;
    private global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator sale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator Sale {
      get { return sale_; }
      set {
        sale_ = value;
      }
    }

    /// <summary>Field number for the "authorization" field.</summary>
    public const int AuthorizationFieldNumber = 3;
    private global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationIndicator authorization_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationIndicator Authorization {
      get { return authorization_; }
      set {
        authorization_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardAuthorizationResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardAuthorizationResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Response != other.Response) return false;
      if (!object.Equals(Sale, other.Sale)) return false;
      if (!object.Equals(Authorization, other.Authorization)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Response != 0) hash ^= Response.GetHashCode();
      if (sale_ != null) hash ^= Sale.GetHashCode();
      if (authorization_ != null) hash ^= Authorization.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Response != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Response);
      }
      if (sale_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Sale);
      }
      if (authorization_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Authorization);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Response != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Response);
      }
      if (sale_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Sale);
      }
      if (authorization_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Authorization);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardAuthorizationResponse other) {
      if (other == null) {
        return;
      }
      if (other.Response != 0) {
        Response = other.Response;
      }
      if (other.sale_ != null) {
        if (sale_ == null) {
          sale_ = new global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator();
        }
        Sale.MergeFrom(other.Sale);
      }
      if (other.authorization_ != null) {
        if (authorization_ == null) {
          authorization_ = new global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationIndicator();
        }
        Authorization.MergeFrom(other.Authorization);
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
          case 8: {
            response_ = (global::HOLMS.Types.Money.Cards.Transactions.CardAuthorizationResponseCode) input.ReadEnum();
            break;
          }
          case 18: {
            if (sale_ == null) {
              sale_ = new global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator();
            }
            input.ReadMessage(sale_);
            break;
          }
          case 26: {
            if (authorization_ == null) {
              authorization_ = new global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationIndicator();
            }
            input.ReadMessage(authorization_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: pbx_connector/tcp_room_status_message.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.PBXConnector {

  /// <summary>Holder for reflection information generated from pbx_connector/tcp_room_status_message.proto</summary>
  public static partial class TcpRoomStatusMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for pbx_connector/tcp_room_status_message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TcpRoomStatusMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitwYnhfY29ubmVjdG9yL3RjcF9yb29tX3N0YXR1c19tZXNzYWdlLnByb3Rv",
            "Ehlob2xtcy50eXBlcy5wYnhfY29ubmVjdG9yIlsKFFRDUFJvb21TdGF0dXNN",
            "ZXNzYWdlEhEKCWpfd190b2tlbhgBIAEoCRIbChN0ZXJtaW5hbF9pZGVudGlm",
            "aWVyGAIgASgJEhMKC3N0YXR1c19jb2RlGAMgASgJQhuqAhhIT0xNUy5UeXBl",
            "cy5QQlhDb25uZWN0b3JiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.PBXConnector.TCPRoomStatusMessage), global::HOLMS.Types.PBXConnector.TCPRoomStatusMessage.Parser, new[]{ "JWToken", "TerminalIdentifier", "StatusCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TCPRoomStatusMessage : pb::IMessage<TCPRoomStatusMessage> {
    private static readonly pb::MessageParser<TCPRoomStatusMessage> _parser = new pb::MessageParser<TCPRoomStatusMessage>(() => new TCPRoomStatusMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TCPRoomStatusMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.PBXConnector.TcpRoomStatusMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TCPRoomStatusMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TCPRoomStatusMessage(TCPRoomStatusMessage other) : this() {
      jWToken_ = other.jWToken_;
      terminalIdentifier_ = other.terminalIdentifier_;
      statusCode_ = other.statusCode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TCPRoomStatusMessage Clone() {
      return new TCPRoomStatusMessage(this);
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

    /// <summary>Field number for the "terminal_identifier" field.</summary>
    public const int TerminalIdentifierFieldNumber = 2;
    private string terminalIdentifier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TerminalIdentifier {
      get { return terminalIdentifier_; }
      set {
        terminalIdentifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status_code" field.</summary>
    public const int StatusCodeFieldNumber = 3;
    private string statusCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StatusCode {
      get { return statusCode_; }
      set {
        statusCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TCPRoomStatusMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TCPRoomStatusMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JWToken != other.JWToken) return false;
      if (TerminalIdentifier != other.TerminalIdentifier) return false;
      if (StatusCode != other.StatusCode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (JWToken.Length != 0) hash ^= JWToken.GetHashCode();
      if (TerminalIdentifier.Length != 0) hash ^= TerminalIdentifier.GetHashCode();
      if (StatusCode.Length != 0) hash ^= StatusCode.GetHashCode();
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
      if (TerminalIdentifier.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TerminalIdentifier);
      }
      if (StatusCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StatusCode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (JWToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JWToken);
      }
      if (TerminalIdentifier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TerminalIdentifier);
      }
      if (StatusCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatusCode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TCPRoomStatusMessage other) {
      if (other == null) {
        return;
      }
      if (other.JWToken.Length != 0) {
        JWToken = other.JWToken;
      }
      if (other.TerminalIdentifier.Length != 0) {
        TerminalIdentifier = other.TerminalIdentifier;
      }
      if (other.StatusCode.Length != 0) {
        StatusCode = other.StatusCode;
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
            TerminalIdentifier = input.ReadString();
            break;
          }
          case 26: {
            StatusCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
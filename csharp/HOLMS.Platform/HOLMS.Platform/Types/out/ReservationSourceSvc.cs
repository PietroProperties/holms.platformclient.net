// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/rpc/reservation_source_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig.RPC {

  /// <summary>Holder for reflection information generated from tenancy_config/rpc/reservation_source_svc.proto</summary>
  public static partial class ReservationSourceSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/rpc/reservation_source_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationSourceSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci90ZW5hbmN5X2NvbmZpZy9ycGMvcmVzZXJ2YXRpb25fc291cmNlX3N2Yy5w",
            "cm90bxIeaG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcucnBjGipwcmltaXRp",
            "dmUvc2VydmVyX2FjdGlvbl9jb25maXJtYXRpb24ucHJvdG8aG2dvb2dsZS9w",
            "cm90b2J1Zi9lbXB0eS5wcm90bxondGVuYW5jeV9jb25maWcvcmVzZXJ2YXRp",
            "b25fc291cmNlLnByb3RvGjx0ZW5hbmN5X2NvbmZpZy9pbmRpY2F0b3JzL3Jl",
            "c2VydmF0aW9uX3NvdXJjZV9pbmRpY2F0b3IucHJvdG8ibQofUmVzZXJ2YXRp",
            "b25Tb3VyY2VTdmNBbGxSZXNwb25zZRJKChNyZXNlcnZhdGlvbl9zb3VyY2Vz",
            "GAEgAygLMi0uaG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcuUmVzZXJ2YXRp",
            "b25Tb3VyY2UyrQQKFFJlc2VydmF0aW9uU291cmNlU3ZjEl4KA0FsbBIWLmdv",
            "b2dsZS5wcm90b2J1Zi5FbXB0eRo/LmhvbG1zLnR5cGVzLnRlbmFuY3lfY29u",
            "ZmlnLnJwYy5SZXNlcnZhdGlvblNvdXJjZVN2Y0FsbFJlc3BvbnNlEnsKB0dl",
            "dEJ5SWQSQS5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5pbmRpY2F0b3Jz",
            "LlJlc2VydmF0aW9uU291cmNlSW5kaWNhdG9yGi0uaG9sbXMudHlwZXMudGVu",
            "YW5jeV9jb25maWcuUmVzZXJ2YXRpb25Tb3VyY2USZgoGQ3JlYXRlEi0uaG9s",
            "bXMudHlwZXMudGVuYW5jeV9jb25maWcuUmVzZXJ2YXRpb25Tb3VyY2UaLS5o",
            "b2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5SZXNlcnZhdGlvblNvdXJjZRJm",
            "CgZVcGRhdGUSLS5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5SZXNlcnZh",
            "dGlvblNvdXJjZRotLmhvbG1zLnR5cGVzLnRlbmFuY3lfY29uZmlnLlJlc2Vy",
            "dmF0aW9uU291cmNlEmgKBkRlbGV0ZRItLmhvbG1zLnR5cGVzLnRlbmFuY3lf",
            "Y29uZmlnLlJlc2VydmF0aW9uU291cmNlGi8uaG9sbXMudHlwZXMucHJpbWl0",
            "aXZlLlNlcnZlckFjdGlvbkNvbmZpcm1hdGlvbkIzWhF0ZW5hbmN5Y29uZmln",
            "L3JwY6oCHUhPTE1TLlR5cGVzLlRlbmFuY3lDb25maWcuUlBDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.ServerActionConfirmationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.TenancyConfig.ReservationSourceReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.ReservationSourceIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.RPC.ReservationSourceSvcAllResponse), global::HOLMS.Types.TenancyConfig.RPC.ReservationSourceSvcAllResponse.Parser, new[]{ "ReservationSources" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationSourceSvcAllResponse : pb::IMessage<ReservationSourceSvcAllResponse> {
    private static readonly pb::MessageParser<ReservationSourceSvcAllResponse> _parser = new pb::MessageParser<ReservationSourceSvcAllResponse>(() => new ReservationSourceSvcAllResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationSourceSvcAllResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.RPC.ReservationSourceSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationSourceSvcAllResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationSourceSvcAllResponse(ReservationSourceSvcAllResponse other) : this() {
      reservationSources_ = other.reservationSources_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationSourceSvcAllResponse Clone() {
      return new ReservationSourceSvcAllResponse(this);
    }

    /// <summary>Field number for the "reservation_sources" field.</summary>
    public const int ReservationSourcesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.TenancyConfig.ReservationSource> _repeated_reservationSources_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.TenancyConfig.ReservationSource.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.TenancyConfig.ReservationSource> reservationSources_ = new pbc::RepeatedField<global::HOLMS.Types.TenancyConfig.ReservationSource>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.TenancyConfig.ReservationSource> ReservationSources {
      get { return reservationSources_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationSourceSvcAllResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationSourceSvcAllResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!reservationSources_.Equals(other.reservationSources_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= reservationSources_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      reservationSources_.WriteTo(output, _repeated_reservationSources_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += reservationSources_.CalculateSize(_repeated_reservationSources_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationSourceSvcAllResponse other) {
      if (other == null) {
        return;
      }
      reservationSources_.Add(other.reservationSources_);
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
            reservationSources_.AddEntriesFrom(input, _repeated_reservationSources_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

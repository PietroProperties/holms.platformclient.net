// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/rpc/iif_export_config_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.TenancyConfig.RPC {
  public static class IIFExportConfigSvc
  {
    static readonly string __ServiceName = "holms.types.tenancy_config.rpc.IIFExportConfigSvc";

    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.RPC.GetIIFExportConfigResponse> __Marshaller_GetIIFExportConfigResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.RPC.GetIIFExportConfigResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.IIFExportConfiguration> __Marshaller_IIFExportConfiguration = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.IIFExportConfiguration.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.RPC.UpdateDropboxAccessTokenRequest> __Marshaller_UpdateDropboxAccessTokenRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.RPC.UpdateDropboxAccessTokenRequest.Parser.ParseFrom);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.RPC.GetIIFExportConfigResponse> __Method_GetTenancyExportConfig = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.RPC.GetIIFExportConfigResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetTenancyExportConfig",
        __Marshaller_Empty,
        __Marshaller_GetIIFExportConfigResponse);

    static readonly Method<global::HOLMS.Types.TenancyConfig.IIFExportConfiguration, global::HOLMS.Types.TenancyConfig.IIFExportConfiguration> __Method_SetTenancyExportConfig = new Method<global::HOLMS.Types.TenancyConfig.IIFExportConfiguration, global::HOLMS.Types.TenancyConfig.IIFExportConfiguration>(
        MethodType.Unary,
        __ServiceName,
        "SetTenancyExportConfig",
        __Marshaller_IIFExportConfiguration,
        __Marshaller_IIFExportConfiguration);

    static readonly Method<global::HOLMS.Types.TenancyConfig.RPC.UpdateDropboxAccessTokenRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateDropboxAccessToken = new Method<global::HOLMS.Types.TenancyConfig.RPC.UpdateDropboxAccessTokenRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "UpdateDropboxAccessToken",
        __Marshaller_UpdateDropboxAccessTokenRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.TenancyConfig.RPC.IifExportConfigSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of IIFExportConfigSvc</summary>
    public abstract class IIFExportConfigSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.RPC.GetIIFExportConfigResponse> GetTenancyExportConfig(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.IIFExportConfiguration> SetTenancyExportConfig(global::HOLMS.Types.TenancyConfig.IIFExportConfiguration request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateDropboxAccessToken(global::HOLMS.Types.TenancyConfig.RPC.UpdateDropboxAccessTokenRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for IIFExportConfigSvc</summary>
    public class IIFExportConfigSvcClient : ClientBase<IIFExportConfigSvcClient>
    {
      /// <summary>Creates a new client for IIFExportConfigSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public IIFExportConfigSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for IIFExportConfigSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public IIFExportConfigSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected IIFExportConfigSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected IIFExportConfigSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.TenancyConfig.RPC.GetIIFExportConfigResponse GetTenancyExportConfig(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetTenancyExportConfig(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.RPC.GetIIFExportConfigResponse GetTenancyExportConfig(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTenancyExportConfig, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.RPC.GetIIFExportConfigResponse> GetTenancyExportConfigAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetTenancyExportConfigAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.RPC.GetIIFExportConfigResponse> GetTenancyExportConfigAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTenancyExportConfig, null, options, request);
      }
      public virtual global::HOLMS.Types.TenancyConfig.IIFExportConfiguration SetTenancyExportConfig(global::HOLMS.Types.TenancyConfig.IIFExportConfiguration request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetTenancyExportConfig(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.IIFExportConfiguration SetTenancyExportConfig(global::HOLMS.Types.TenancyConfig.IIFExportConfiguration request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetTenancyExportConfig, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.IIFExportConfiguration> SetTenancyExportConfigAsync(global::HOLMS.Types.TenancyConfig.IIFExportConfiguration request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetTenancyExportConfigAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.IIFExportConfiguration> SetTenancyExportConfigAsync(global::HOLMS.Types.TenancyConfig.IIFExportConfiguration request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetTenancyExportConfig, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateDropboxAccessToken(global::HOLMS.Types.TenancyConfig.RPC.UpdateDropboxAccessTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateDropboxAccessToken(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateDropboxAccessToken(global::HOLMS.Types.TenancyConfig.RPC.UpdateDropboxAccessTokenRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateDropboxAccessToken, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateDropboxAccessTokenAsync(global::HOLMS.Types.TenancyConfig.RPC.UpdateDropboxAccessTokenRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateDropboxAccessTokenAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateDropboxAccessTokenAsync(global::HOLMS.Types.TenancyConfig.RPC.UpdateDropboxAccessTokenRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateDropboxAccessToken, null, options, request);
      }
      protected override IIFExportConfigSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new IIFExportConfigSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(IIFExportConfigSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetTenancyExportConfig, serviceImpl.GetTenancyExportConfig)
          .AddMethod(__Method_SetTenancyExportConfig, serviceImpl.SetTenancyExportConfig)
          .AddMethod(__Method_UpdateDropboxAccessToken, serviceImpl.UpdateDropboxAccessToken).Build();
    }

  }
}
#endregion
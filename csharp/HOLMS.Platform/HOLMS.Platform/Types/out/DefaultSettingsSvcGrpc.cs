// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/rpc/default_settings_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.TenancyConfig.RPC {
  public static partial class DefaultSettingsSvc
  {
    static readonly string __ServiceName = "holms.types.tenancy_config.rpc.DefaultSettingsSvc";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.TenancyConfig.RPC.DefaultSettingsSvcResponse> __Marshaller_DefaultSettingsSvcResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.RPC.DefaultSettingsSvcResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.TenancyConfig.DefaultSettings> __Marshaller_DefaultSettings = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.DefaultSettings.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.RPC.DefaultSettingsSvcResponse> __Method_All = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.RPC.DefaultSettingsSvcResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "All",
        __Marshaller_Empty,
        __Marshaller_DefaultSettingsSvcResponse);

    static readonly grpc::Method<global::HOLMS.Types.TenancyConfig.DefaultSettings, global::HOLMS.Types.TenancyConfig.DefaultSettings> __Method_Update = new grpc::Method<global::HOLMS.Types.TenancyConfig.DefaultSettings, global::HOLMS.Types.TenancyConfig.DefaultSettings>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_DefaultSettings,
        __Marshaller_DefaultSettings);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.TenancyConfig.RPC.DefaultSettingsSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DefaultSettingsSvc</summary>
    public abstract partial class DefaultSettingsSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.RPC.DefaultSettingsSvcResponse> All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.DefaultSettings> Update(global::HOLMS.Types.TenancyConfig.DefaultSettings request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DefaultSettingsSvc</summary>
    public partial class DefaultSettingsSvcClient : grpc::ClientBase<DefaultSettingsSvcClient>
    {
      /// <summary>Creates a new client for DefaultSettingsSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DefaultSettingsSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DefaultSettingsSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DefaultSettingsSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DefaultSettingsSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DefaultSettingsSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.TenancyConfig.RPC.DefaultSettingsSvcResponse All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return All(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.RPC.DefaultSettingsSvcResponse All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_All, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.RPC.DefaultSettingsSvcResponse> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.RPC.DefaultSettingsSvcResponse> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_All, null, options, request);
      }
      public virtual global::HOLMS.Types.TenancyConfig.DefaultSettings Update(global::HOLMS.Types.TenancyConfig.DefaultSettings request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.DefaultSettings Update(global::HOLMS.Types.TenancyConfig.DefaultSettings request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.DefaultSettings> UpdateAsync(global::HOLMS.Types.TenancyConfig.DefaultSettings request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.DefaultSettings> UpdateAsync(global::HOLMS.Types.TenancyConfig.DefaultSettings request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DefaultSettingsSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DefaultSettingsSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DefaultSettingsSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_All, serviceImpl.All)
          .AddMethod(__Method_Update, serviceImpl.Update).Build();
    }

  }
}
#endregion

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/ota_channel_provider_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Booking.RPC {
  public static partial class OTAChannelProviderSvc
  {
    static readonly string __ServiceName = "holms.types.booking.rpc.OTAChannelProviderSvc";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.OTAChannelProviderAllResponse> __Marshaller_OTAChannelProviderAllResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.OTAChannelProviderAllResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcQuery> __Marshaller_OTAChannelProviderSvcQuery = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcQuery.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Channels.OTAChannelProvider> __Marshaller_OTAChannelProvider = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Channels.OTAChannelProvider.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator> __Marshaller_OTAChannelProviderIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse> __Marshaller_OTAChannelProviderSvcResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Primitive.ServerActionConfirmation> __Marshaller_ServerActionConfirmation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Primitive.ServerActionConfirmation.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Booking.RPC.OTAChannelProviderAllResponse> __Method_All = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Booking.RPC.OTAChannelProviderAllResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "All",
        __Marshaller_Empty,
        __Marshaller_OTAChannelProviderAllResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcQuery, global::HOLMS.Types.Booking.Channels.OTAChannelProvider> __Method_GetByProviderCode = new grpc::Method<global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcQuery, global::HOLMS.Types.Booking.Channels.OTAChannelProvider>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetByProviderCode",
        __Marshaller_OTAChannelProviderSvcQuery,
        __Marshaller_OTAChannelProvider);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator, global::HOLMS.Types.Booking.Channels.OTAChannelProvider> __Method_GetById = new grpc::Method<global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator, global::HOLMS.Types.Booking.Channels.OTAChannelProvider>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetById",
        __Marshaller_OTAChannelProviderIndicator,
        __Marshaller_OTAChannelProvider);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Channels.OTAChannelProvider, global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse> __Method_Create = new grpc::Method<global::HOLMS.Types.Booking.Channels.OTAChannelProvider, global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_OTAChannelProvider,
        __Marshaller_OTAChannelProviderSvcResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Channels.OTAChannelProvider, global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse> __Method_Update = new grpc::Method<global::HOLMS.Types.Booking.Channels.OTAChannelProvider, global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_OTAChannelProvider,
        __Marshaller_OTAChannelProviderSvcResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Channels.OTAChannelProvider, global::HOLMS.Types.Primitive.ServerActionConfirmation> __Method_Delete = new grpc::Method<global::HOLMS.Types.Booking.Channels.OTAChannelProvider, global::HOLMS.Types.Primitive.ServerActionConfirmation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_OTAChannelProvider,
        __Marshaller_ServerActionConfirmation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Booking.RPC.OtaChannelProviderSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of OTAChannelProviderSvc</summary>
    public abstract partial class OTAChannelProviderSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.OTAChannelProviderAllResponse> All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.Channels.OTAChannelProvider> GetByProviderCode(global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcQuery request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.Channels.OTAChannelProvider> GetById(global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse> Create(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse> Update(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Primitive.ServerActionConfirmation> Delete(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for OTAChannelProviderSvc</summary>
    public partial class OTAChannelProviderSvcClient : grpc::ClientBase<OTAChannelProviderSvcClient>
    {
      /// <summary>Creates a new client for OTAChannelProviderSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OTAChannelProviderSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OTAChannelProviderSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OTAChannelProviderSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OTAChannelProviderSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OTAChannelProviderSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Booking.RPC.OTAChannelProviderAllResponse All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return All(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.OTAChannelProviderAllResponse All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_All, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.OTAChannelProviderAllResponse> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.OTAChannelProviderAllResponse> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_All, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.Channels.OTAChannelProvider GetByProviderCode(global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcQuery request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetByProviderCode(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.Channels.OTAChannelProvider GetByProviderCode(global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetByProviderCode, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.Channels.OTAChannelProvider> GetByProviderCodeAsync(global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcQuery request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetByProviderCodeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.Channels.OTAChannelProvider> GetByProviderCodeAsync(global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetByProviderCode, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.Channels.OTAChannelProvider GetById(global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.Channels.OTAChannelProvider GetById(global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.Channels.OTAChannelProvider> GetByIdAsync(global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.Channels.OTAChannelProvider> GetByIdAsync(global::HOLMS.Types.Booking.Channels.OTAChannelProviderIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetById, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse Create(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse Create(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse> CreateAsync(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse> CreateAsync(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse Update(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse Update(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse> UpdateAsync(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.OTAChannelProviderSvcResponse> UpdateAsync(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      public virtual global::HOLMS.Types.Primitive.ServerActionConfirmation Delete(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Primitive.ServerActionConfirmation Delete(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Primitive.ServerActionConfirmation> DeleteAsync(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Primitive.ServerActionConfirmation> DeleteAsync(global::HOLMS.Types.Booking.Channels.OTAChannelProvider request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OTAChannelProviderSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OTAChannelProviderSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(OTAChannelProviderSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_All, serviceImpl.All)
          .AddMethod(__Method_GetByProviderCode, serviceImpl.GetByProviderCode)
          .AddMethod(__Method_GetById, serviceImpl.GetById)
          .AddMethod(__Method_Create, serviceImpl.Create)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

  }
}
#endregion

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: iam/rpc/client_instance_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.IAM.RPC {
  public static partial class ClientInstanceSvc
  {
    static readonly string __ServiceName = "holms.types.iam.rpc.ClientInstanceSvc";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.IAM.RPC.ClientInstanceSvcEnumResponse> __Marshaller_ClientInstanceSvcEnumResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.IAM.RPC.ClientInstanceSvcEnumResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.IAM.ClientInstance> __Marshaller_ClientInstance = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.IAM.ClientInstance.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.IAM.RPC.ClientInstanceSvcEnumResponse> __Method_All = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.IAM.RPC.ClientInstanceSvcEnumResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "All",
        __Marshaller_Empty,
        __Marshaller_ClientInstanceSvcEnumResponse);

    static readonly grpc::Method<global::HOLMS.Types.IAM.ClientInstance, global::HOLMS.Types.IAM.ClientInstance> __Method_Update = new grpc::Method<global::HOLMS.Types.IAM.ClientInstance, global::HOLMS.Types.IAM.ClientInstance>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_ClientInstance,
        __Marshaller_ClientInstance);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.IAM.RPC.ClientInstanceSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ClientInstanceSvc</summary>
    public abstract partial class ClientInstanceSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.IAM.RPC.ClientInstanceSvcEnumResponse> All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.IAM.ClientInstance> Update(global::HOLMS.Types.IAM.ClientInstance request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ClientInstanceSvc</summary>
    public partial class ClientInstanceSvcClient : grpc::ClientBase<ClientInstanceSvcClient>
    {
      /// <summary>Creates a new client for ClientInstanceSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ClientInstanceSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ClientInstanceSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ClientInstanceSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ClientInstanceSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ClientInstanceSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.IAM.RPC.ClientInstanceSvcEnumResponse All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return All(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.IAM.RPC.ClientInstanceSvcEnumResponse All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_All, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.RPC.ClientInstanceSvcEnumResponse> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.RPC.ClientInstanceSvcEnumResponse> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_All, null, options, request);
      }
      public virtual global::HOLMS.Types.IAM.ClientInstance Update(global::HOLMS.Types.IAM.ClientInstance request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.IAM.ClientInstance Update(global::HOLMS.Types.IAM.ClientInstance request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.ClientInstance> UpdateAsync(global::HOLMS.Types.IAM.ClientInstance request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.ClientInstance> UpdateAsync(global::HOLMS.Types.IAM.ClientInstance request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ClientInstanceSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ClientInstanceSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ClientInstanceSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_All, serviceImpl.All)
          .AddMethod(__Method_Update, serviceImpl.Update).Build();
    }

  }
}
#endregion

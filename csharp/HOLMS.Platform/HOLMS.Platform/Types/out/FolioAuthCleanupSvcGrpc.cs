// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/rpc/folio_auth_cleanup_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Folio.RPC {
  public static partial class FolioAuthCleanupSvc
  {
    static readonly string __ServiceName = "holms.types.folio.rpc.FolioAuthCleanupSvc";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_VoidAuthorizationsForDepartedReservations = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VoidAuthorizationsForDepartedReservations",
        __Marshaller_Empty,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Folio.RPC.FolioAuthCleanupSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FolioAuthCleanupSvc</summary>
    public abstract partial class FolioAuthCleanupSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> VoidAuthorizationsForDepartedReservations(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FolioAuthCleanupSvc</summary>
    public partial class FolioAuthCleanupSvcClient : grpc::ClientBase<FolioAuthCleanupSvcClient>
    {
      /// <summary>Creates a new client for FolioAuthCleanupSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FolioAuthCleanupSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FolioAuthCleanupSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FolioAuthCleanupSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FolioAuthCleanupSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FolioAuthCleanupSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty VoidAuthorizationsForDepartedReservations(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VoidAuthorizationsForDepartedReservations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty VoidAuthorizationsForDepartedReservations(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VoidAuthorizationsForDepartedReservations, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> VoidAuthorizationsForDepartedReservationsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VoidAuthorizationsForDepartedReservationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> VoidAuthorizationsForDepartedReservationsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VoidAuthorizationsForDepartedReservations, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override FolioAuthCleanupSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FolioAuthCleanupSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(FolioAuthCleanupSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_VoidAuthorizationsForDepartedReservations, serviceImpl.VoidAuthorizationsForDepartedReservations).Build();
    }

  }
}
#endregion

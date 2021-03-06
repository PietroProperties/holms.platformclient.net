// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: iam/rpc/staff_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.IAM.RPC {
  public static partial class StaffSvc
  {
    static readonly string __ServiceName = "holms.types.iam.rpc.StaffSvc";

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse> __Marshaller_StaffSvcGetAllResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.IAM.StaffMemberIndicator> __Marshaller_StaffMemberIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.IAM.StaffMemberIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.IAM.StaffMember> __Marshaller_StaffMember = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.IAM.StaffMember.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse> __Marshaller_StaffSvcCreateUpdateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Primitive.ServerActionConfirmation> __Marshaller_ServerActionConfirmation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Primitive.ServerActionConfirmation.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse> __Method_All = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "All",
        __Marshaller_Empty,
        __Marshaller_StaffSvcGetAllResponse);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse> __Method_GetHousekeepers = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetHousekeepers",
        __Marshaller_Empty,
        __Marshaller_StaffSvcGetAllResponse);

    static readonly grpc::Method<global::HOLMS.Types.IAM.StaffMemberIndicator, global::HOLMS.Types.IAM.StaffMember> __Method_GetById = new grpc::Method<global::HOLMS.Types.IAM.StaffMemberIndicator, global::HOLMS.Types.IAM.StaffMember>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetById",
        __Marshaller_StaffMemberIndicator,
        __Marshaller_StaffMember);

    static readonly grpc::Method<global::HOLMS.Types.IAM.StaffMember, global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse> __Method_Create = new grpc::Method<global::HOLMS.Types.IAM.StaffMember, global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_StaffMember,
        __Marshaller_StaffSvcCreateUpdateResponse);

    static readonly grpc::Method<global::HOLMS.Types.IAM.StaffMember, global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse> __Method_Update = new grpc::Method<global::HOLMS.Types.IAM.StaffMember, global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_StaffMember,
        __Marshaller_StaffSvcCreateUpdateResponse);

    static readonly grpc::Method<global::HOLMS.Types.IAM.StaffMember, global::HOLMS.Types.Primitive.ServerActionConfirmation> __Method_Delete = new grpc::Method<global::HOLMS.Types.IAM.StaffMember, global::HOLMS.Types.Primitive.ServerActionConfirmation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_StaffMember,
        __Marshaller_ServerActionConfirmation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.IAM.RPC.StaffSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of StaffSvc</summary>
    public abstract partial class StaffSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse> All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse> GetHousekeepers(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.IAM.StaffMember> GetById(global::HOLMS.Types.IAM.StaffMemberIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse> Create(global::HOLMS.Types.IAM.StaffMember request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse> Update(global::HOLMS.Types.IAM.StaffMember request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Primitive.ServerActionConfirmation> Delete(global::HOLMS.Types.IAM.StaffMember request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for StaffSvc</summary>
    public partial class StaffSvcClient : grpc::ClientBase<StaffSvcClient>
    {
      /// <summary>Creates a new client for StaffSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StaffSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StaffSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StaffSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StaffSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StaffSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return All(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse All(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_All, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse> AllAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_All, null, options, request);
      }
      public virtual global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse GetHousekeepers(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetHousekeepers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse GetHousekeepers(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetHousekeepers, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse> GetHousekeepersAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetHousekeepersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse> GetHousekeepersAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetHousekeepers, null, options, request);
      }
      public virtual global::HOLMS.Types.IAM.StaffMember GetById(global::HOLMS.Types.IAM.StaffMemberIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.IAM.StaffMember GetById(global::HOLMS.Types.IAM.StaffMemberIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.StaffMember> GetByIdAsync(global::HOLMS.Types.IAM.StaffMemberIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.StaffMember> GetByIdAsync(global::HOLMS.Types.IAM.StaffMemberIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetById, null, options, request);
      }
      public virtual global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse Create(global::HOLMS.Types.IAM.StaffMember request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse Create(global::HOLMS.Types.IAM.StaffMember request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse> CreateAsync(global::HOLMS.Types.IAM.StaffMember request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse> CreateAsync(global::HOLMS.Types.IAM.StaffMember request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      public virtual global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse Update(global::HOLMS.Types.IAM.StaffMember request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse Update(global::HOLMS.Types.IAM.StaffMember request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse> UpdateAsync(global::HOLMS.Types.IAM.StaffMember request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.IAM.RPC.StaffSvcCreateUpdateResponse> UpdateAsync(global::HOLMS.Types.IAM.StaffMember request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      public virtual global::HOLMS.Types.Primitive.ServerActionConfirmation Delete(global::HOLMS.Types.IAM.StaffMember request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Primitive.ServerActionConfirmation Delete(global::HOLMS.Types.IAM.StaffMember request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Primitive.ServerActionConfirmation> DeleteAsync(global::HOLMS.Types.IAM.StaffMember request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Primitive.ServerActionConfirmation> DeleteAsync(global::HOLMS.Types.IAM.StaffMember request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StaffSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StaffSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StaffSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_All, serviceImpl.All)
          .AddMethod(__Method_GetHousekeepers, serviceImpl.GetHousekeepers)
          .AddMethod(__Method_GetById, serviceImpl.GetById)
          .AddMethod(__Method_Create, serviceImpl.Create)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

  }
}
#endregion

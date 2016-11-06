// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rpc/hk_management_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Operations.RPC {
  public static class HousekeepingManagementSvc
  {
    static readonly string __ServiceName = "holms.types.operations.rpc.HousekeepingManagementSvc";

    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Timestamp> __Marshaller_Timestamp = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Timestamp.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentsResponse> __Marshaller_HousekeepingManagementSvcAssignmentsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentRequest> __Marshaller_HousekeepingManagementSvcAssignmentRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcUpdateRoomStatusRequest> __Marshaller_HousekeepingManagementSvcUpdateRoomStatusRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcUpdateRoomStatusRequest.Parser.ParseFrom);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Timestamp, global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentsResponse> __Method_GetAssignmentsByDate = new Method<global::Google.Protobuf.WellKnownTypes.Timestamp, global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentsResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetAssignmentsByDate",
        __Marshaller_Timestamp,
        __Marshaller_HousekeepingManagementSvcAssignmentsResponse);

    static readonly Method<global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AssignHousekeeperToRoomsNow = new Method<global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "AssignHousekeeperToRoomsNow",
        __Marshaller_HousekeepingManagementSvcAssignmentRequest,
        __Marshaller_Empty);

    static readonly Method<global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcUpdateRoomStatusRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateRoomStatus = new Method<global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcUpdateRoomStatusRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "UpdateRoomStatus",
        __Marshaller_HousekeepingManagementSvcUpdateRoomStatusRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Operations.RPC.HkManagementSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of HousekeepingManagementSvc</summary>
    public abstract class HousekeepingManagementSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentsResponse> GetAssignmentsByDate(global::Google.Protobuf.WellKnownTypes.Timestamp request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AssignHousekeeperToRoomsNow(global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateRoomStatus(global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcUpdateRoomStatusRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for HousekeepingManagementSvc</summary>
    public class HousekeepingManagementSvcClient : ClientBase<HousekeepingManagementSvcClient>
    {
      /// <summary>Creates a new client for HousekeepingManagementSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HousekeepingManagementSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HousekeepingManagementSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HousekeepingManagementSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HousekeepingManagementSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HousekeepingManagementSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentsResponse GetAssignmentsByDate(global::Google.Protobuf.WellKnownTypes.Timestamp request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAssignmentsByDate(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentsResponse GetAssignmentsByDate(global::Google.Protobuf.WellKnownTypes.Timestamp request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAssignmentsByDate, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentsResponse> GetAssignmentsByDateAsync(global::Google.Protobuf.WellKnownTypes.Timestamp request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAssignmentsByDateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentsResponse> GetAssignmentsByDateAsync(global::Google.Protobuf.WellKnownTypes.Timestamp request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAssignmentsByDate, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AssignHousekeeperToRoomsNow(global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AssignHousekeeperToRoomsNow(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AssignHousekeeperToRoomsNow(global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AssignHousekeeperToRoomsNow, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AssignHousekeeperToRoomsNowAsync(global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AssignHousekeeperToRoomsNowAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AssignHousekeeperToRoomsNowAsync(global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcAssignmentRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AssignHousekeeperToRoomsNow, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateRoomStatus(global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcUpdateRoomStatusRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateRoomStatus(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateRoomStatus(global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcUpdateRoomStatusRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateRoomStatus, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateRoomStatusAsync(global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcUpdateRoomStatusRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateRoomStatusAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateRoomStatusAsync(global::HOLMS.Types.Operations.RPC.HousekeepingManagementSvcUpdateRoomStatusRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateRoomStatus, null, options, request);
      }
      protected override HousekeepingManagementSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HousekeepingManagementSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(HousekeepingManagementSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAssignmentsByDate, serviceImpl.GetAssignmentsByDate)
          .AddMethod(__Method_AssignHousekeeperToRoomsNow, serviceImpl.AssignHousekeeperToRoomsNow)
          .AddMethod(__Method_UpdateRoomStatus, serviceImpl.UpdateRoomStatus).Build();
    }

  }
}
#endregion
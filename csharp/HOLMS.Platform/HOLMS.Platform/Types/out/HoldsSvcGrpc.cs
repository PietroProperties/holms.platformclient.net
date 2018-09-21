// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/rpc/holds_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Supply.RPC {
  public static partial class HoldsSvc
  {
    static readonly string __ServiceName = "holms.types.supply.rpc.HoldsSvc";

    static readonly grpc::Marshaller<global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRq> __Marshaller_HoldsSvcGbQtySnapRq = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRq.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRsp> __Marshaller_HoldsSvcGbQtySnapRsp = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRsp.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest> __Marshaller_HoldsSvcAdjustManagementHoldsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator> __Marshaller_GroupBookingIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse> __Marshaller_HoldsSvcGetGroupBookingHoldsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Reservations.ReservationWithManagementHold> __Marshaller_ReservationWithManagementHold = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Reservations.ReservationWithManagementHold.Parser.ParseFrom);

    static readonly grpc::Method<global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRq, global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRsp> __Method_GetGroupBookingsQuantitySnapshot = new grpc::Method<global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRq, global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRsp>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetGroupBookingsQuantitySnapshot",
        __Marshaller_HoldsSvcGbQtySnapRq,
        __Marshaller_HoldsSvcGbQtySnapRsp);

    static readonly grpc::Method<global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AdjustManagementHolds = new grpc::Method<global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AdjustManagementHolds",
        __Marshaller_HoldsSvcAdjustManagementHoldsRequest,
        __Marshaller_Empty);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator, global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse> __Method_GetGroupBookingHolds = new grpc::Method<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator, global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetGroupBookingHolds",
        __Marshaller_GroupBookingIndicator,
        __Marshaller_HoldsSvcGetGroupBookingHoldsResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Reservations.ReservationWithManagementHold, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddReservationManagementHolds = new grpc::Method<global::HOLMS.Types.Booking.Reservations.ReservationWithManagementHold, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddReservationManagementHolds",
        __Marshaller_ReservationWithManagementHold,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Supply.RPC.HoldsSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of HoldsSvc</summary>
    public abstract partial class HoldsSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRsp> GetGroupBookingsQuantitySnapshot(global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AdjustManagementHolds(global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse> GetGroupBookingHolds(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AddReservationManagementHolds(global::HOLMS.Types.Booking.Reservations.ReservationWithManagementHold request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for HoldsSvc</summary>
    public partial class HoldsSvcClient : grpc::ClientBase<HoldsSvcClient>
    {
      /// <summary>Creates a new client for HoldsSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HoldsSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HoldsSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HoldsSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HoldsSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HoldsSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRsp GetGroupBookingsQuantitySnapshot(global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRq request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetGroupBookingsQuantitySnapshot(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRsp GetGroupBookingsQuantitySnapshot(global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRq request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetGroupBookingsQuantitySnapshot, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRsp> GetGroupBookingsQuantitySnapshotAsync(global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRq request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetGroupBookingsQuantitySnapshotAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRsp> GetGroupBookingsQuantitySnapshotAsync(global::HOLMS.Types.Supply.RPC.HoldsSvcGbQtySnapRq request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetGroupBookingsQuantitySnapshot, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AdjustManagementHolds(global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AdjustManagementHolds(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AdjustManagementHolds(global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AdjustManagementHolds, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AdjustManagementHoldsAsync(global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AdjustManagementHoldsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AdjustManagementHoldsAsync(global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AdjustManagementHolds, null, options, request);
      }
      public virtual global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse GetGroupBookingHolds(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetGroupBookingHolds(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse GetGroupBookingHolds(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetGroupBookingHolds, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse> GetGroupBookingHoldsAsync(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetGroupBookingHoldsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse> GetGroupBookingHoldsAsync(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetGroupBookingHolds, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddReservationManagementHolds(global::HOLMS.Types.Booking.Reservations.ReservationWithManagementHold request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddReservationManagementHolds(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddReservationManagementHolds(global::HOLMS.Types.Booking.Reservations.ReservationWithManagementHold request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddReservationManagementHolds, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddReservationManagementHoldsAsync(global::HOLMS.Types.Booking.Reservations.ReservationWithManagementHold request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddReservationManagementHoldsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddReservationManagementHoldsAsync(global::HOLMS.Types.Booking.Reservations.ReservationWithManagementHold request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddReservationManagementHolds, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override HoldsSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HoldsSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(HoldsSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetGroupBookingsQuantitySnapshot, serviceImpl.GetGroupBookingsQuantitySnapshot)
          .AddMethod(__Method_AdjustManagementHolds, serviceImpl.AdjustManagementHolds)
          .AddMethod(__Method_GetGroupBookingHolds, serviceImpl.GetGroupBookingHolds)
          .AddMethod(__Method_AddReservationManagementHolds, serviceImpl.AddReservationManagementHolds).Build();
    }

  }
}
#endregion

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/group_booking_search_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Booking.RPC {
  public static class GroupBookingSearchSvc
  {
    static readonly string __ServiceName = "holms.types.booking.rpc.GroupBookingSearchSvc";

    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListRequest> __Marshaller_GroupBookingSvcGetFilteredBookingsListRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> __Marshaller_GroupBookingSvcGetFilteredBookingsListResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Primitive.PbLocalDate> __Marshaller_PbLocalDate = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Primitive.PbLocalDate.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListRequest, global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> __Method_GetFilteredBookingsList = new Method<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListRequest, global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetFilteredBookingsList",
        __Marshaller_GroupBookingSvcGetFilteredBookingsListRequest,
        __Marshaller_GroupBookingSvcGetFilteredBookingsListResponse);

    static readonly Method<global::HOLMS.Types.Primitive.PbLocalDate, global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> __Method_GetArrivalsByCalendarDate = new Method<global::HOLMS.Types.Primitive.PbLocalDate, global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetArrivalsByCalendarDate",
        __Marshaller_PbLocalDate,
        __Marshaller_GroupBookingSvcGetFilteredBookingsListResponse);

    static readonly Method<global::HOLMS.Types.Primitive.PbLocalDate, global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> __Method_GetDeparturesByCalendarDate = new Method<global::HOLMS.Types.Primitive.PbLocalDate, global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetDeparturesByCalendarDate",
        __Marshaller_PbLocalDate,
        __Marshaller_GroupBookingSvcGetFilteredBookingsListResponse);

    static readonly Method<global::HOLMS.Types.Primitive.PbLocalDate, global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> __Method_GetAllDuringDate = new Method<global::HOLMS.Types.Primitive.PbLocalDate, global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetAllDuringDate",
        __Marshaller_PbLocalDate,
        __Marshaller_GroupBookingSvcGetFilteredBookingsListResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Booking.RPC.GroupBookingSearchSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GroupBookingSearchSvc</summary>
    public abstract class GroupBookingSearchSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetFilteredBookingsList(global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetArrivalsByCalendarDate(global::HOLMS.Types.Primitive.PbLocalDate request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetDeparturesByCalendarDate(global::HOLMS.Types.Primitive.PbLocalDate request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetAllDuringDate(global::HOLMS.Types.Primitive.PbLocalDate request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GroupBookingSearchSvc</summary>
    public class GroupBookingSearchSvcClient : ClientBase<GroupBookingSearchSvcClient>
    {
      /// <summary>Creates a new client for GroupBookingSearchSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GroupBookingSearchSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GroupBookingSearchSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GroupBookingSearchSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GroupBookingSearchSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GroupBookingSearchSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse GetFilteredBookingsList(global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFilteredBookingsList(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse GetFilteredBookingsList(global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFilteredBookingsList, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetFilteredBookingsListAsync(global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFilteredBookingsListAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetFilteredBookingsListAsync(global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFilteredBookingsList, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse GetArrivalsByCalendarDate(global::HOLMS.Types.Primitive.PbLocalDate request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetArrivalsByCalendarDate(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse GetArrivalsByCalendarDate(global::HOLMS.Types.Primitive.PbLocalDate request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetArrivalsByCalendarDate, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetArrivalsByCalendarDateAsync(global::HOLMS.Types.Primitive.PbLocalDate request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetArrivalsByCalendarDateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetArrivalsByCalendarDateAsync(global::HOLMS.Types.Primitive.PbLocalDate request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetArrivalsByCalendarDate, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse GetDeparturesByCalendarDate(global::HOLMS.Types.Primitive.PbLocalDate request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetDeparturesByCalendarDate(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse GetDeparturesByCalendarDate(global::HOLMS.Types.Primitive.PbLocalDate request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetDeparturesByCalendarDate, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetDeparturesByCalendarDateAsync(global::HOLMS.Types.Primitive.PbLocalDate request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetDeparturesByCalendarDateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetDeparturesByCalendarDateAsync(global::HOLMS.Types.Primitive.PbLocalDate request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetDeparturesByCalendarDate, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse GetAllDuringDate(global::HOLMS.Types.Primitive.PbLocalDate request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllDuringDate(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse GetAllDuringDate(global::HOLMS.Types.Primitive.PbLocalDate request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllDuringDate, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetAllDuringDateAsync(global::HOLMS.Types.Primitive.PbLocalDate request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllDuringDateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GroupBookingSvcGetFilteredBookingsListResponse> GetAllDuringDateAsync(global::HOLMS.Types.Primitive.PbLocalDate request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllDuringDate, null, options, request);
      }
      protected override GroupBookingSearchSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GroupBookingSearchSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(GroupBookingSearchSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFilteredBookingsList, serviceImpl.GetFilteredBookingsList)
          .AddMethod(__Method_GetArrivalsByCalendarDate, serviceImpl.GetArrivalsByCalendarDate)
          .AddMethod(__Method_GetDeparturesByCalendarDate, serviceImpl.GetDeparturesByCalendarDate)
          .AddMethod(__Method_GetAllDuringDate, serviceImpl.GetAllDuringDate).Build();
    }

  }
}
#endregion
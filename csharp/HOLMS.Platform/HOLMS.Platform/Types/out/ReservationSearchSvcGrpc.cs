// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/reservation_search_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Booking.RPC {
  public static class ReservationSearchSvc
  {
    static readonly string __ServiceName = "holms.types.booking.rpc.ReservationSearchSvc";

    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListRequest> __Marshaller_ReservationSearchSvcGetFilteredReservationListRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> __Marshaller_ReservationSearchSvcGetFilteredReservationListResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest> __Marshaller_ReservationSearchSvcGetDateFilteredReservationListRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.Indicators.ReservationIndicator> __Marshaller_ReservationIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.ReservationIndicator.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetReservationSummaryResponse> __Marshaller_ReservationSearchSvcGetReservationSummaryResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetReservationSummaryResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.GetReservationSummariesRequest> __Marshaller_GetReservationSummariesRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.GetReservationSummariesRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcSearchReservationsRequest> __Marshaller_ReservationSearchSvcSearchReservationsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.ReservationSearchSvcSearchReservationsRequest.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> __Method_GetFilteredReservationList = new Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetFilteredReservationList",
        __Marshaller_ReservationSearchSvcGetFilteredReservationListRequest,
        __Marshaller_ReservationSearchSvcGetFilteredReservationListResponse);

    static readonly Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> __Method_GetArrivalsByCalendarDate = new Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetArrivalsByCalendarDate",
        __Marshaller_ReservationSearchSvcGetDateFilteredReservationListRequest,
        __Marshaller_ReservationSearchSvcGetFilteredReservationListResponse);

    static readonly Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> __Method_GetDeparturesByCalendarDate = new Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetDeparturesByCalendarDate",
        __Marshaller_ReservationSearchSvcGetDateFilteredReservationListRequest,
        __Marshaller_ReservationSearchSvcGetFilteredReservationListResponse);

    static readonly Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> __Method_GetNoShowsByDate = new Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetNoShowsByDate",
        __Marshaller_ReservationSearchSvcGetDateFilteredReservationListRequest,
        __Marshaller_ReservationSearchSvcGetFilteredReservationListResponse);

    static readonly Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> __Method_GetStayOversByDate = new Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetStayOversByDate",
        __Marshaller_ReservationSearchSvcGetDateFilteredReservationListRequest,
        __Marshaller_ReservationSearchSvcGetFilteredReservationListResponse);

    static readonly Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> __Method_GetAllDuringDate = new Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetAllDuringDate",
        __Marshaller_ReservationSearchSvcGetDateFilteredReservationListRequest,
        __Marshaller_ReservationSearchSvcGetFilteredReservationListResponse);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetReservationSummaryResponse> __Method_GetReservationSummary = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetReservationSummaryResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetReservationSummary",
        __Marshaller_ReservationIndicator,
        __Marshaller_ReservationSearchSvcGetReservationSummaryResponse);

    static readonly Method<global::HOLMS.Types.Booking.RPC.GetReservationSummariesRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> __Method_GetReservationSummaries = new Method<global::HOLMS.Types.Booking.RPC.GetReservationSummariesRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetReservationSummaries",
        __Marshaller_GetReservationSummariesRequest,
        __Marshaller_ReservationSearchSvcGetFilteredReservationListResponse);

    static readonly Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcSearchReservationsRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> __Method_SearchReservations = new Method<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcSearchReservationsRequest, global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse>(
        MethodType.Unary,
        __ServiceName,
        "SearchReservations",
        __Marshaller_ReservationSearchSvcSearchReservationsRequest,
        __Marshaller_ReservationSearchSvcGetFilteredReservationListResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Booking.RPC.ReservationSearchSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReservationSearchSvc</summary>
    public abstract class ReservationSearchSvcBase
    {
      /// <summary>
      ///  Get all of type - no date
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetFilteredReservationList(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Date-scoped searches
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetArrivalsByCalendarDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetDeparturesByCalendarDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetNoShowsByDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetStayOversByDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetAllDuringDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Search/GetById(s)
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetReservationSummaryResponse> GetReservationSummary(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetReservationSummaries(global::HOLMS.Types.Booking.RPC.GetReservationSummariesRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> SearchReservations(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcSearchReservationsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReservationSearchSvc</summary>
    public class ReservationSearchSvcClient : ClientBase<ReservationSearchSvcClient>
    {
      /// <summary>Creates a new client for ReservationSearchSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReservationSearchSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReservationSearchSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReservationSearchSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReservationSearchSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReservationSearchSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Get all of type - no date
      /// </summary>
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetFilteredReservationList(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFilteredReservationList(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Get all of type - no date
      /// </summary>
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetFilteredReservationList(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFilteredReservationList, null, options, request);
      }
      /// <summary>
      ///  Get all of type - no date
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetFilteredReservationListAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFilteredReservationListAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Get all of type - no date
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetFilteredReservationListAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFilteredReservationList, null, options, request);
      }
      /// <summary>
      ///  Date-scoped searches
      /// </summary>
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetArrivalsByCalendarDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetArrivalsByCalendarDate(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Date-scoped searches
      /// </summary>
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetArrivalsByCalendarDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetArrivalsByCalendarDate, null, options, request);
      }
      /// <summary>
      ///  Date-scoped searches
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetArrivalsByCalendarDateAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetArrivalsByCalendarDateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Date-scoped searches
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetArrivalsByCalendarDateAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetArrivalsByCalendarDate, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetDeparturesByCalendarDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetDeparturesByCalendarDate(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetDeparturesByCalendarDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetDeparturesByCalendarDate, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetDeparturesByCalendarDateAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetDeparturesByCalendarDateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetDeparturesByCalendarDateAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetDeparturesByCalendarDate, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetNoShowsByDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetNoShowsByDate(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetNoShowsByDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetNoShowsByDate, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetNoShowsByDateAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetNoShowsByDateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetNoShowsByDateAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetNoShowsByDate, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetStayOversByDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetStayOversByDate(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetStayOversByDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStayOversByDate, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetStayOversByDateAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetStayOversByDateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetStayOversByDateAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStayOversByDate, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetAllDuringDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllDuringDate(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetAllDuringDate(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllDuringDate, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetAllDuringDateAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAllDuringDateAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetAllDuringDateAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetDateFilteredReservationListRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllDuringDate, null, options, request);
      }
      /// <summary>
      ///  Search/GetById(s)
      /// </summary>
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetReservationSummaryResponse GetReservationSummary(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationSummary(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Search/GetById(s)
      /// </summary>
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetReservationSummaryResponse GetReservationSummary(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationSummary, null, options, request);
      }
      /// <summary>
      ///  Search/GetById(s)
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetReservationSummaryResponse> GetReservationSummaryAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationSummaryAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Search/GetById(s)
      /// </summary>
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetReservationSummaryResponse> GetReservationSummaryAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationSummary, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetReservationSummaries(global::HOLMS.Types.Booking.RPC.GetReservationSummariesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationSummaries(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse GetReservationSummaries(global::HOLMS.Types.Booking.RPC.GetReservationSummariesRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationSummaries, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetReservationSummariesAsync(global::HOLMS.Types.Booking.RPC.GetReservationSummariesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationSummariesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> GetReservationSummariesAsync(global::HOLMS.Types.Booking.RPC.GetReservationSummariesRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationSummaries, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse SearchReservations(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcSearchReservationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchReservations(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse SearchReservations(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcSearchReservationsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchReservations, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> SearchReservationsAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcSearchReservationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchReservationsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.ReservationSearchSvcGetFilteredReservationListResponse> SearchReservationsAsync(global::HOLMS.Types.Booking.RPC.ReservationSearchSvcSearchReservationsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchReservations, null, options, request);
      }
      protected override ReservationSearchSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReservationSearchSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ReservationSearchSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFilteredReservationList, serviceImpl.GetFilteredReservationList)
          .AddMethod(__Method_GetArrivalsByCalendarDate, serviceImpl.GetArrivalsByCalendarDate)
          .AddMethod(__Method_GetDeparturesByCalendarDate, serviceImpl.GetDeparturesByCalendarDate)
          .AddMethod(__Method_GetNoShowsByDate, serviceImpl.GetNoShowsByDate)
          .AddMethod(__Method_GetStayOversByDate, serviceImpl.GetStayOversByDate)
          .AddMethod(__Method_GetAllDuringDate, serviceImpl.GetAllDuringDate)
          .AddMethod(__Method_GetReservationSummary, serviceImpl.GetReservationSummary)
          .AddMethod(__Method_GetReservationSummaries, serviceImpl.GetReservationSummaries)
          .AddMethod(__Method_SearchReservations, serviceImpl.SearchReservations).Build();
    }

  }
}
#endregion

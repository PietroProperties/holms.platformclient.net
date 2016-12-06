// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/rpc/check_in_service.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Booking.RPC {
  public static class CheckInService
  {
    static readonly string __ServiceName = "holms.types.booking.rpc.CheckInService";

    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.CheckInRequest> __Marshaller_CheckInRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.CheckInRequest.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.CheckInServiceRequestResponse> __Marshaller_CheckInServiceRequestResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.CheckInServiceRequestResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.Indicators.ReservationIndicator> __Marshaller_ReservationIndicator = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.ReservationIndicator.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.GetPreCheckinInfoResponse> __Marshaller_GetPreCheckinInfoResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.GetPreCheckinInfoResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Booking.RPC.SetPreCheckinInfoRequest> __Marshaller_SetPreCheckinInfoRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.RPC.SetPreCheckinInfoRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.Booking.RPC.CheckInRequest, global::HOLMS.Types.Booking.RPC.CheckInServiceRequestResponse> __Method_StartStay = new Method<global::HOLMS.Types.Booking.RPC.CheckInRequest, global::HOLMS.Types.Booking.RPC.CheckInServiceRequestResponse>(
        MethodType.Unary,
        __ServiceName,
        "StartStay",
        __Marshaller_CheckInRequest,
        __Marshaller_CheckInServiceRequestResponse);

    static readonly Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.RPC.GetPreCheckinInfoResponse> __Method_GetPreCheckinInfo = new Method<global::HOLMS.Types.Booking.Indicators.ReservationIndicator, global::HOLMS.Types.Booking.RPC.GetPreCheckinInfoResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetPreCheckinInfo",
        __Marshaller_ReservationIndicator,
        __Marshaller_GetPreCheckinInfoResponse);

    static readonly Method<global::HOLMS.Types.Booking.RPC.SetPreCheckinInfoRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetPreCheckinInfo = new Method<global::HOLMS.Types.Booking.RPC.SetPreCheckinInfoRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "SetPreCheckinInfo",
        __Marshaller_SetPreCheckinInfoRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Booking.RPC.CheckInServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CheckInService</summary>
    public abstract class CheckInServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.CheckInServiceRequestResponse> StartStay(global::HOLMS.Types.Booking.RPC.CheckInRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Booking.RPC.GetPreCheckinInfoResponse> GetPreCheckinInfo(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> SetPreCheckinInfo(global::HOLMS.Types.Booking.RPC.SetPreCheckinInfoRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CheckInService</summary>
    public class CheckInServiceClient : ClientBase<CheckInServiceClient>
    {
      /// <summary>Creates a new client for CheckInService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CheckInServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CheckInService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CheckInServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CheckInServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CheckInServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Booking.RPC.CheckInServiceRequestResponse StartStay(global::HOLMS.Types.Booking.RPC.CheckInRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return StartStay(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.CheckInServiceRequestResponse StartStay(global::HOLMS.Types.Booking.RPC.CheckInRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_StartStay, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.CheckInServiceRequestResponse> StartStayAsync(global::HOLMS.Types.Booking.RPC.CheckInRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return StartStayAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.CheckInServiceRequestResponse> StartStayAsync(global::HOLMS.Types.Booking.RPC.CheckInRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_StartStay, null, options, request);
      }
      public virtual global::HOLMS.Types.Booking.RPC.GetPreCheckinInfoResponse GetPreCheckinInfo(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetPreCheckinInfo(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Booking.RPC.GetPreCheckinInfoResponse GetPreCheckinInfo(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPreCheckinInfo, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GetPreCheckinInfoResponse> GetPreCheckinInfoAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetPreCheckinInfoAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Booking.RPC.GetPreCheckinInfoResponse> GetPreCheckinInfoAsync(global::HOLMS.Types.Booking.Indicators.ReservationIndicator request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPreCheckinInfo, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetPreCheckinInfo(global::HOLMS.Types.Booking.RPC.SetPreCheckinInfoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetPreCheckinInfo(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty SetPreCheckinInfo(global::HOLMS.Types.Booking.RPC.SetPreCheckinInfoRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetPreCheckinInfo, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SetPreCheckinInfoAsync(global::HOLMS.Types.Booking.RPC.SetPreCheckinInfoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetPreCheckinInfoAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SetPreCheckinInfoAsync(global::HOLMS.Types.Booking.RPC.SetPreCheckinInfoRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetPreCheckinInfo, null, options, request);
      }
      protected override CheckInServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CheckInServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(CheckInServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_StartStay, serviceImpl.StartStay)
          .AddMethod(__Method_GetPreCheckinInfo, serviceImpl.GetPreCheckinInfo)
          .AddMethod(__Method_SetPreCheckinInfo, serviceImpl.SetPreCheckinInfo).Build();
    }

  }
}
#endregion

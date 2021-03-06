// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/rpc/folios_reporting_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Reporting.RPC {
  public static partial class FoliosReportingSvc
  {
    static readonly string __ServiceName = "holms.types.reporting.rpc.FoliosReportingSvc";

    static readonly grpc::Marshaller<global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest> __Marshaller_GroupBookingAssociatedFoliosRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Marshaller_HtmlReportResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator> __Marshaller_GroupBookingIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping> __Marshaller_GroupBookingInvoiceMapping = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Reporting.RPC.BookingStatementRequest> __Marshaller_BookingStatementRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Reporting.RPC.BookingStatementRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest> __Marshaller_FolioPaymentReceiptRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetBookingAssociatedFoliosDetail = new grpc::Method<global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBookingAssociatedFoliosDetail",
        __Marshaller_GroupBookingAssociatedFoliosRequest,
        __Marshaller_HtmlReportResponse);

    static readonly grpc::Method<global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetBookingAssociatedFoliosSummary = new grpc::Method<global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBookingAssociatedFoliosSummary",
        __Marshaller_GroupBookingAssociatedFoliosRequest,
        __Marshaller_HtmlReportResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetReservationFolioSummary = new grpc::Method<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetReservationFolioSummary",
        __Marshaller_GroupBookingIndicator,
        __Marshaller_HtmlReportResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetBookingWorksheetDetail = new grpc::Method<global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBookingWorksheetDetail",
        __Marshaller_GroupBookingIndicator,
        __Marshaller_HtmlReportResponse);

    static readonly grpc::Method<global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetInvoice = new grpc::Method<global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetInvoice",
        __Marshaller_GroupBookingInvoiceMapping,
        __Marshaller_HtmlReportResponse);

    static readonly grpc::Method<global::HOLMS.Types.Reporting.RPC.BookingStatementRequest, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetBookingStatement = new grpc::Method<global::HOLMS.Types.Reporting.RPC.BookingStatementRequest, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBookingStatement",
        __Marshaller_BookingStatementRequest,
        __Marshaller_HtmlReportResponse);

    static readonly grpc::Method<global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetFolioPaymentReceipt = new grpc::Method<global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFolioPaymentReceipt",
        __Marshaller_FolioPaymentReceiptRequest,
        __Marshaller_HtmlReportResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Reporting.RPC.FoliosReportingSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FoliosReportingSvc</summary>
    public abstract partial class FoliosReportingSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingAssociatedFoliosDetail(global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingAssociatedFoliosSummary(global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetReservationFolioSummary(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingWorksheetDetail(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetInvoice(global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingStatement(global::HOLMS.Types.Reporting.RPC.BookingStatementRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioPaymentReceipt(global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FoliosReportingSvc</summary>
    public partial class FoliosReportingSvcClient : grpc::ClientBase<FoliosReportingSvcClient>
    {
      /// <summary>Creates a new client for FoliosReportingSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FoliosReportingSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FoliosReportingSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FoliosReportingSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FoliosReportingSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FoliosReportingSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetBookingAssociatedFoliosDetail(global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetBookingAssociatedFoliosDetail(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetBookingAssociatedFoliosDetail(global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBookingAssociatedFoliosDetail, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingAssociatedFoliosDetailAsync(global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetBookingAssociatedFoliosDetailAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingAssociatedFoliosDetailAsync(global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBookingAssociatedFoliosDetail, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetBookingAssociatedFoliosSummary(global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetBookingAssociatedFoliosSummary(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetBookingAssociatedFoliosSummary(global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBookingAssociatedFoliosSummary, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingAssociatedFoliosSummaryAsync(global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetBookingAssociatedFoliosSummaryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingAssociatedFoliosSummaryAsync(global::HOLMS.Types.Reporting.RPC.GroupBookingAssociatedFoliosRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBookingAssociatedFoliosSummary, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetReservationFolioSummary(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationFolioSummary(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetReservationFolioSummary(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetReservationFolioSummary, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetReservationFolioSummaryAsync(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetReservationFolioSummaryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetReservationFolioSummaryAsync(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetReservationFolioSummary, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetBookingWorksheetDetail(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetBookingWorksheetDetail(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetBookingWorksheetDetail(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBookingWorksheetDetail, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingWorksheetDetailAsync(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetBookingWorksheetDetailAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingWorksheetDetailAsync(global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBookingWorksheetDetail, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetInvoice(global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetInvoice(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetInvoice(global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetInvoice, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetInvoiceAsync(global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetInvoiceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetInvoiceAsync(global::HOLMS.Types.Booking.Groups.GroupBookingInvoiceMapping request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetInvoice, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetBookingStatement(global::HOLMS.Types.Reporting.RPC.BookingStatementRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetBookingStatement(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetBookingStatement(global::HOLMS.Types.Reporting.RPC.BookingStatementRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBookingStatement, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingStatementAsync(global::HOLMS.Types.Reporting.RPC.BookingStatementRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetBookingStatementAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetBookingStatementAsync(global::HOLMS.Types.Reporting.RPC.BookingStatementRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBookingStatement, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetFolioPaymentReceipt(global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioPaymentReceipt(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetFolioPaymentReceipt(global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFolioPaymentReceipt, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioPaymentReceiptAsync(global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioPaymentReceiptAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioPaymentReceiptAsync(global::HOLMS.Types.Reporting.RPC.FolioPaymentReceiptRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFolioPaymentReceipt, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override FoliosReportingSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FoliosReportingSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(FoliosReportingSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetBookingAssociatedFoliosDetail, serviceImpl.GetBookingAssociatedFoliosDetail)
          .AddMethod(__Method_GetBookingAssociatedFoliosSummary, serviceImpl.GetBookingAssociatedFoliosSummary)
          .AddMethod(__Method_GetReservationFolioSummary, serviceImpl.GetReservationFolioSummary)
          .AddMethod(__Method_GetBookingWorksheetDetail, serviceImpl.GetBookingWorksheetDetail)
          .AddMethod(__Method_GetInvoice, serviceImpl.GetInvoice)
          .AddMethod(__Method_GetBookingStatement, serviceImpl.GetBookingStatement)
          .AddMethod(__Method_GetFolioPaymentReceipt, serviceImpl.GetFolioPaymentReceipt).Build();
    }

  }
}
#endregion

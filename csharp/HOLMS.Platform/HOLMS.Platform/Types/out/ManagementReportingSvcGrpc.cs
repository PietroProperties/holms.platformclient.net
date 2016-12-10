// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/rpc/management_reporting_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Reporting.RPC {
  public static class ManagementReportingSvc
  {
    static readonly string __ServiceName = "holms.types.reporting.rpc.ManagementReportingSvc";

    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Marshaller_HtmlReportResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange> __Marshaller_PropertyClockTimeRange = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange.Parser.ParseFrom);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetFolioBalancesReport = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetFolioBalancesReport",
        __Marshaller_Empty,
        __Marshaller_HtmlReportResponse);

    static readonly Method<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetFolioGrossChargesReport = new Method<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetFolioGrossChargesReport",
        __Marshaller_PropertyClockTimeRange,
        __Marshaller_HtmlReportResponse);

    static readonly Method<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetFolioPaymentsReport = new Method<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetFolioPaymentsReport",
        __Marshaller_PropertyClockTimeRange,
        __Marshaller_HtmlReportResponse);

    static readonly Method<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetFolioAdjustmentsReport = new Method<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetFolioAdjustmentsReport",
        __Marshaller_PropertyClockTimeRange,
        __Marshaller_HtmlReportResponse);

    static readonly Method<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetCallAccountingReport = new Method<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetCallAccountingReport",
        __Marshaller_PropertyClockTimeRange,
        __Marshaller_HtmlReportResponse);

    static readonly Method<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> __Method_GetLedgerActivitySummary = new Method<global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetLedgerActivitySummary",
        __Marshaller_PropertyClockTimeRange,
        __Marshaller_HtmlReportResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Reporting.RPC.ManagementReportingSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ManagementReportingSvc</summary>
    public abstract class ManagementReportingSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioBalancesReport(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioGrossChargesReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioPaymentsReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioAdjustmentsReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetCallAccountingReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetLedgerActivitySummary(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ManagementReportingSvc</summary>
    public class ManagementReportingSvcClient : ClientBase<ManagementReportingSvcClient>
    {
      /// <summary>Creates a new client for ManagementReportingSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ManagementReportingSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ManagementReportingSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ManagementReportingSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ManagementReportingSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ManagementReportingSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetFolioBalancesReport(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioBalancesReport(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetFolioBalancesReport(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFolioBalancesReport, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioBalancesReportAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioBalancesReportAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioBalancesReportAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFolioBalancesReport, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetFolioGrossChargesReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioGrossChargesReport(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetFolioGrossChargesReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFolioGrossChargesReport, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioGrossChargesReportAsync(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioGrossChargesReportAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioGrossChargesReportAsync(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFolioGrossChargesReport, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetFolioPaymentsReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioPaymentsReport(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetFolioPaymentsReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFolioPaymentsReport, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioPaymentsReportAsync(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioPaymentsReportAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioPaymentsReportAsync(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFolioPaymentsReport, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetFolioAdjustmentsReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioAdjustmentsReport(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetFolioAdjustmentsReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFolioAdjustmentsReport, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioAdjustmentsReportAsync(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetFolioAdjustmentsReportAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetFolioAdjustmentsReportAsync(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFolioAdjustmentsReport, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetCallAccountingReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCallAccountingReport(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetCallAccountingReport(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCallAccountingReport, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetCallAccountingReportAsync(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCallAccountingReportAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetCallAccountingReportAsync(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCallAccountingReport, null, options, request);
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetLedgerActivitySummary(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLedgerActivitySummary(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse GetLedgerActivitySummary(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLedgerActivitySummary, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetLedgerActivitySummaryAsync(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLedgerActivitySummaryAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Reporting.Outputs.HtmlReportResponse> GetLedgerActivitySummaryAsync(global::HOLMS.Types.Reporting.ReportParams.PropertyClockTimeRange request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLedgerActivitySummary, null, options, request);
      }
      protected override ManagementReportingSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ManagementReportingSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ManagementReportingSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFolioBalancesReport, serviceImpl.GetFolioBalancesReport)
          .AddMethod(__Method_GetFolioGrossChargesReport, serviceImpl.GetFolioGrossChargesReport)
          .AddMethod(__Method_GetFolioPaymentsReport, serviceImpl.GetFolioPaymentsReport)
          .AddMethod(__Method_GetFolioAdjustmentsReport, serviceImpl.GetFolioAdjustmentsReport)
          .AddMethod(__Method_GetCallAccountingReport, serviceImpl.GetCallAccountingReport)
          .AddMethod(__Method_GetLedgerActivitySummary, serviceImpl.GetLedgerActivitySummary).Build();
    }

  }
}
#endregion
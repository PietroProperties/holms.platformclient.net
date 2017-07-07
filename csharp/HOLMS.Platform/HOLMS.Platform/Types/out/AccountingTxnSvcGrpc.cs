// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/rpc/accounting_txn_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Money.RPC {
  public static class AccountingTxnSvc
  {
    static readonly string __ServiceName = "holms.types.money.rpc.AccountingTxnSvc";

    static readonly Marshaller<global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq> __Marshaller_AssignGuestOwnerToTxnReq = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatus> __Marshaller_AccountingTxnExportStatus = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatus.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest> __Marshaller_AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest.Parser.ParseFrom);

    static readonly Method<global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AssignGuestOwnerToTransaction = new Method<global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "AssignGuestOwnerToTransaction",
        __Marshaller_AssignGuestOwnerToTxnReq,
        __Marshaller_Empty);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatus> __Method_GetExportJobStatus = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatus>(
        MethodType.Unary,
        __ServiceName,
        "GetExportJobStatus",
        __Marshaller_Empty,
        __Marshaller_AccountingTxnExportStatus);

    static readonly Method<global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UploadPropertyTransactionsInFormat = new Method<global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "UploadPropertyTransactionsInFormat",
        __Marshaller_AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Money.RPC.AccountingTxnSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AccountingTxnSvc</summary>
    public abstract class AccountingTxnSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AssignGuestOwnerToTransaction(global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatus> GetExportJobStatus(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UploadPropertyTransactionsInFormat(global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AccountingTxnSvc</summary>
    public class AccountingTxnSvcClient : ClientBase<AccountingTxnSvcClient>
    {
      /// <summary>Creates a new client for AccountingTxnSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AccountingTxnSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AccountingTxnSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AccountingTxnSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AccountingTxnSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AccountingTxnSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty AssignGuestOwnerToTransaction(global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AssignGuestOwnerToTransaction(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AssignGuestOwnerToTransaction(global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AssignGuestOwnerToTransaction, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AssignGuestOwnerToTransactionAsync(global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AssignGuestOwnerToTransactionAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AssignGuestOwnerToTransactionAsync(global::HOLMS.Types.Money.RPC.AssignGuestOwnerToTxnReq request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AssignGuestOwnerToTransaction, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatus GetExportJobStatus(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetExportJobStatus(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatus GetExportJobStatus(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetExportJobStatus, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatus> GetExportJobStatusAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetExportJobStatusAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.Money.Accounting.AccountingTxnExportStatus> GetExportJobStatusAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetExportJobStatus, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UploadPropertyTransactionsInFormat(global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UploadPropertyTransactionsInFormat(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UploadPropertyTransactionsInFormat(global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UploadPropertyTransactionsInFormat, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UploadPropertyTransactionsInFormatAsync(global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UploadPropertyTransactionsInFormatAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UploadPropertyTransactionsInFormatAsync(global::HOLMS.Types.Money.RPC.AccountTxnExportSvcUploadPropertyTransactionsInFormatRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UploadPropertyTransactionsInFormat, null, options, request);
      }
      protected override AccountingTxnSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccountingTxnSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(AccountingTxnSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AssignGuestOwnerToTransaction, serviceImpl.AssignGuestOwnerToTransaction)
          .AddMethod(__Method_GetExportJobStatus, serviceImpl.GetExportJobStatus)
          .AddMethod(__Method_UploadPropertyTransactionsInFormat, serviceImpl.UploadPropertyTransactionsInFormat).Build();
    }

  }
}
#endregion

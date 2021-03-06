// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/rpc/card_processing_svc.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace HOLMS.Types.Money.RPC {
  public static partial class CardProcessingSvc
  {
    static readonly string __ServiceName = "holms.types.money.rpc.CardProcessingSvc";

    static readonly grpc::Marshaller<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest> __Marshaller_CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> __Marshaller_CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Money.Cards.CardMerchantIndicator> __Marshaller_CardMerchantIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Cards.CardMerchantIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse> __Marshaller_GetOpenBatchStateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest> __Marshaller_CardProcessingSvcSearchHistoricalBatchesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> __Marshaller_MerchantBatchEnumResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch> __Marshaller_ClosedMerchantBatch = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator> __Marshaller_PaymentCardSaleIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse> __Marshaller_CardProcessingSvcVoidTransactionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator> __Marshaller_PaymentCardRefundIndicator = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchOpenClosedBatchesRequest> __Marshaller_CardProcessingSvcSearchOpenClosedBatchesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchOpenClosedBatchesRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest, global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> __Method_VerifyAndTokenizeNotPresentCard = new grpc::Method<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest, global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VerifyAndTokenizeNotPresentCard",
        __Marshaller_CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest,
        __Marshaller_CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse);

    static readonly grpc::Method<global::HOLMS.Types.Money.Cards.CardMerchantIndicator, global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse> __Method_GetCurrentBatchState = new grpc::Method<global::HOLMS.Types.Money.Cards.CardMerchantIndicator, global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCurrentBatchState",
        __Marshaller_CardMerchantIndicator,
        __Marshaller_GetOpenBatchStateResponse);

    static readonly grpc::Method<global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest, global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> __Method_SearchHistoricalBatches = new grpc::Method<global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest, global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchHistoricalBatches",
        __Marshaller_CardProcessingSvcSearchHistoricalBatchesRequest,
        __Marshaller_MerchantBatchEnumResponse);

    static readonly grpc::Method<global::HOLMS.Types.Money.Cards.CardMerchantIndicator, global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch> __Method_CloseProcessorBatch = new grpc::Method<global::HOLMS.Types.Money.Cards.CardMerchantIndicator, global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CloseProcessorBatch",
        __Marshaller_CardMerchantIndicator,
        __Marshaller_ClosedMerchantBatch);

    static readonly grpc::Method<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator, global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse> __Method_VoidSale = new grpc::Method<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator, global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VoidSale",
        __Marshaller_PaymentCardSaleIndicator,
        __Marshaller_CardProcessingSvcVoidTransactionResponse);

    static readonly grpc::Method<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator, global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse> __Method_VoidRefund = new grpc::Method<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator, global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VoidRefund",
        __Marshaller_PaymentCardRefundIndicator,
        __Marshaller_CardProcessingSvcVoidTransactionResponse);

    static readonly grpc::Method<global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchOpenClosedBatchesRequest, global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse> __Method_GetOpenClosedBatchState = new grpc::Method<global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchOpenClosedBatchesRequest, global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOpenClosedBatchState",
        __Marshaller_CardProcessingSvcSearchOpenClosedBatchesRequest,
        __Marshaller_GetOpenBatchStateResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CardProcessingSvc</summary>
    public abstract partial class CardProcessingSvcBase
    {
      /// <summary>
      /// Tokenize a new card
      /// TODO (DRA): Move this onto the reservation folio svc endpoint
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> VerifyAndTokenizeNotPresentCard(global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Batches
      /// Get info about batches
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse> GetCurrentBatchState(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> SearchHistoricalBatches(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Request batch closure
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch> CloseProcessorBatch(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Post-creation card transaction management
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse> VoidSale(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse> VoidRefund(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse> GetOpenClosedBatchState(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchOpenClosedBatchesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CardProcessingSvc</summary>
    public partial class CardProcessingSvcClient : grpc::ClientBase<CardProcessingSvcClient>
    {
      /// <summary>Creates a new client for CardProcessingSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CardProcessingSvcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CardProcessingSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CardProcessingSvcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CardProcessingSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CardProcessingSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Tokenize a new card
      /// TODO (DRA): Move this onto the reservation folio svc endpoint
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse VerifyAndTokenizeNotPresentCard(global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VerifyAndTokenizeNotPresentCard(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Tokenize a new card
      /// TODO (DRA): Move this onto the reservation folio svc endpoint
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse VerifyAndTokenizeNotPresentCard(global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VerifyAndTokenizeNotPresentCard, null, options, request);
      }
      /// <summary>
      /// Tokenize a new card
      /// TODO (DRA): Move this onto the reservation folio svc endpoint
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> VerifyAndTokenizeNotPresentCardAsync(global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VerifyAndTokenizeNotPresentCardAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Tokenize a new card
      /// TODO (DRA): Move this onto the reservation folio svc endpoint
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> VerifyAndTokenizeNotPresentCardAsync(global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VerifyAndTokenizeNotPresentCard, null, options, request);
      }
      /// <summary>
      /// Batches
      /// Get info about batches
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse GetCurrentBatchState(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCurrentBatchState(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Batches
      /// Get info about batches
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse GetCurrentBatchState(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCurrentBatchState, null, options, request);
      }
      /// <summary>
      /// Batches
      /// Get info about batches
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse> GetCurrentBatchStateAsync(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetCurrentBatchStateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Batches
      /// Get info about batches
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse> GetCurrentBatchStateAsync(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCurrentBatchState, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse SearchHistoricalBatches(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchHistoricalBatches(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse SearchHistoricalBatches(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchHistoricalBatches, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> SearchHistoricalBatchesAsync(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SearchHistoricalBatchesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse> SearchHistoricalBatchesAsync(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchHistoricalBatches, null, options, request);
      }
      /// <summary>
      /// Request batch closure
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch CloseProcessorBatch(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CloseProcessorBatch(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Request batch closure
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch CloseProcessorBatch(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CloseProcessorBatch, null, options, request);
      }
      /// <summary>
      /// Request batch closure
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch> CloseProcessorBatchAsync(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CloseProcessorBatchAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Request batch closure
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch> CloseProcessorBatchAsync(global::HOLMS.Types.Money.Cards.CardMerchantIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CloseProcessorBatch, null, options, request);
      }
      /// <summary>
      /// Post-creation card transaction management
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse VoidSale(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VoidSale(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Post-creation card transaction management
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse VoidSale(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VoidSale, null, options, request);
      }
      /// <summary>
      /// Post-creation card transaction management
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse> VoidSaleAsync(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VoidSaleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Post-creation card transaction management
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse> VoidSaleAsync(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VoidSale, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse VoidRefund(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VoidRefund(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse VoidRefund(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VoidRefund, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse> VoidRefundAsync(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VoidRefundAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse> VoidRefundAsync(global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicator request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VoidRefund, null, options, request);
      }
      public virtual global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse GetOpenClosedBatchState(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchOpenClosedBatchesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetOpenClosedBatchState(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse GetOpenClosedBatchState(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchOpenClosedBatchesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOpenClosedBatchState, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse> GetOpenClosedBatchStateAsync(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchOpenClosedBatchesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetOpenClosedBatchStateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponse> GetOpenClosedBatchStateAsync(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchOpenClosedBatchesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOpenClosedBatchState, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CardProcessingSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CardProcessingSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CardProcessingSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_VerifyAndTokenizeNotPresentCard, serviceImpl.VerifyAndTokenizeNotPresentCard)
          .AddMethod(__Method_GetCurrentBatchState, serviceImpl.GetCurrentBatchState)
          .AddMethod(__Method_SearchHistoricalBatches, serviceImpl.SearchHistoricalBatches)
          .AddMethod(__Method_CloseProcessorBatch, serviceImpl.CloseProcessorBatch)
          .AddMethod(__Method_VoidSale, serviceImpl.VoidSale)
          .AddMethod(__Method_VoidRefund, serviceImpl.VoidRefund)
          .AddMethod(__Method_GetOpenClosedBatchState, serviceImpl.GetOpenClosedBatchState).Build();
    }

  }
}
#endregion

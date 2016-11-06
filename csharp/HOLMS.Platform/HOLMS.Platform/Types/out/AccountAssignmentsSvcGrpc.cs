// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/rpc/account_assignments_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.TenancyConfig.RPC {
  public static class AccountAssignmentsSvc
  {
    static readonly string __ServiceName = "holms.types.tenancy_config.rpc.AccountAssignmentsSvc";

    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.AccountAssignments> __Marshaller_AccountAssignments = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.AccountAssignments.Parser.ParseFrom);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.AccountAssignments> __Method_Get = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.AccountAssignments>(
        MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_Empty,
        __Marshaller_AccountAssignments);

    static readonly Method<global::HOLMS.Types.TenancyConfig.AccountAssignments, global::HOLMS.Types.TenancyConfig.AccountAssignments> __Method_Set = new Method<global::HOLMS.Types.TenancyConfig.AccountAssignments, global::HOLMS.Types.TenancyConfig.AccountAssignments>(
        MethodType.Unary,
        __ServiceName,
        "Set",
        __Marshaller_AccountAssignments,
        __Marshaller_AccountAssignments);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.TenancyConfig.RPC.AccountAssignmentsSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AccountAssignmentsSvc</summary>
    public abstract class AccountAssignmentsSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.AccountAssignments> Get(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.AccountAssignments> Set(global::HOLMS.Types.TenancyConfig.AccountAssignments request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AccountAssignmentsSvc</summary>
    public class AccountAssignmentsSvcClient : ClientBase<AccountAssignmentsSvcClient>
    {
      /// <summary>Creates a new client for AccountAssignmentsSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AccountAssignmentsSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AccountAssignmentsSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AccountAssignmentsSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AccountAssignmentsSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AccountAssignmentsSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.TenancyConfig.AccountAssignments Get(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Get(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.AccountAssignments Get(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.AccountAssignments> GetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.AccountAssignments> GetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      public virtual global::HOLMS.Types.TenancyConfig.AccountAssignments Set(global::HOLMS.Types.TenancyConfig.AccountAssignments request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Set(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.AccountAssignments Set(global::HOLMS.Types.TenancyConfig.AccountAssignments request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Set, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.AccountAssignments> SetAsync(global::HOLMS.Types.TenancyConfig.AccountAssignments request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.AccountAssignments> SetAsync(global::HOLMS.Types.TenancyConfig.AccountAssignments request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Set, null, options, request);
      }
      protected override AccountAssignmentsSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccountAssignmentsSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(AccountAssignmentsSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Set, serviceImpl.Set).Build();
    }

  }
}
#endregion
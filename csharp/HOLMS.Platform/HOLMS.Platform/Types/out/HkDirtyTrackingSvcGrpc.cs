// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rpc/hk_dirty_tracking_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.Operations.RPC {
  public static class HKDirtyTrackingSvc
  {
    static readonly string __ServiceName = "holms.types.operations.rpc.HKDirtyTrackingSvc";

    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RunUpdateJobIfScheduled = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "RunUpdateJobIfScheduled",
        __Marshaller_Empty,
        __Marshaller_Empty);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RunUpdateJobImmediately = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "RunUpdateJobImmediately",
        __Marshaller_Empty,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.Operations.RPC.HkDirtyTrackingSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of HKDirtyTrackingSvc</summary>
    public abstract class HKDirtyTrackingSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> RunUpdateJobIfScheduled(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> RunUpdateJobImmediately(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for HKDirtyTrackingSvc</summary>
    public class HKDirtyTrackingSvcClient : ClientBase<HKDirtyTrackingSvcClient>
    {
      /// <summary>Creates a new client for HKDirtyTrackingSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HKDirtyTrackingSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HKDirtyTrackingSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HKDirtyTrackingSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HKDirtyTrackingSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HKDirtyTrackingSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty RunUpdateJobIfScheduled(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RunUpdateJobIfScheduled(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RunUpdateJobIfScheduled(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RunUpdateJobIfScheduled, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RunUpdateJobIfScheduledAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RunUpdateJobIfScheduledAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RunUpdateJobIfScheduledAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RunUpdateJobIfScheduled, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RunUpdateJobImmediately(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RunUpdateJobImmediately(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty RunUpdateJobImmediately(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RunUpdateJobImmediately, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RunUpdateJobImmediatelyAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RunUpdateJobImmediatelyAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> RunUpdateJobImmediatelyAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RunUpdateJobImmediately, null, options, request);
      }
      protected override HKDirtyTrackingSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HKDirtyTrackingSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(HKDirtyTrackingSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RunUpdateJobIfScheduled, serviceImpl.RunUpdateJobIfScheduled)
          .AddMethod(__Method_RunUpdateJobImmediately, serviceImpl.RunUpdateJobImmediately).Build();
    }

  }
}
#endregion
// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/rpc/hk_phone_code_svc.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace HOLMS.Types.TenancyConfig.RPC {
  public static class HkPhoneCodeSvc
  {
    static readonly string __ServiceName = "holms.types.tenancy_config.rpc.HkPhoneCodeSvc";

    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::HOLMS.Types.TenancyConfig.HKPhoneCodes> __Marshaller_HKPhoneCodes = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HOLMS.Types.TenancyConfig.HKPhoneCodes.Parser.ParseFrom);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.HKPhoneCodes> __Method_Get = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::HOLMS.Types.TenancyConfig.HKPhoneCodes>(
        MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_Empty,
        __Marshaller_HKPhoneCodes);

    static readonly Method<global::HOLMS.Types.TenancyConfig.HKPhoneCodes, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdatePhoneCodes = new Method<global::HOLMS.Types.TenancyConfig.HKPhoneCodes, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "UpdatePhoneCodes",
        __Marshaller_HKPhoneCodes,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HOLMS.Types.TenancyConfig.RPC.HkPhoneCodeSvcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of HkPhoneCodeSvc</summary>
    public abstract class HkPhoneCodeSvcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HOLMS.Types.TenancyConfig.HKPhoneCodes> Get(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdatePhoneCodes(global::HOLMS.Types.TenancyConfig.HKPhoneCodes request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for HkPhoneCodeSvc</summary>
    public class HkPhoneCodeSvcClient : ClientBase<HkPhoneCodeSvcClient>
    {
      /// <summary>Creates a new client for HkPhoneCodeSvc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HkPhoneCodeSvcClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HkPhoneCodeSvc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HkPhoneCodeSvcClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HkPhoneCodeSvcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HkPhoneCodeSvcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HOLMS.Types.TenancyConfig.HKPhoneCodes Get(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Get(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HOLMS.Types.TenancyConfig.HKPhoneCodes Get(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.HKPhoneCodes> GetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::HOLMS.Types.TenancyConfig.HKPhoneCodes> GetAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdatePhoneCodes(global::HOLMS.Types.TenancyConfig.HKPhoneCodes request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdatePhoneCodes(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdatePhoneCodes(global::HOLMS.Types.TenancyConfig.HKPhoneCodes request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdatePhoneCodes, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdatePhoneCodesAsync(global::HOLMS.Types.TenancyConfig.HKPhoneCodes request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdatePhoneCodesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdatePhoneCodesAsync(global::HOLMS.Types.TenancyConfig.HKPhoneCodes request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdatePhoneCodes, null, options, request);
      }
      protected override HkPhoneCodeSvcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HkPhoneCodeSvcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(HkPhoneCodeSvcBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_UpdatePhoneCodes, serviceImpl.UpdatePhoneCodes).Build();
    }

  }
}
#endregion
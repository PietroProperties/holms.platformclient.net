// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/rpc/management_reporting_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Reporting.RPC {

  /// <summary>Holder for reflection information generated from reporting/rpc/management_reporting_svc.proto</summary>
  public static partial class ManagementReportingSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for reporting/rpc/management_reporting_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ManagementReportingSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixyZXBvcnRpbmcvcnBjL21hbmFnZW1lbnRfcmVwb3J0aW5nX3N2Yy5wcm90",
            "bxIZaG9sbXMudHlwZXMucmVwb3J0aW5nLnJwYxobZ29vZ2xlL3Byb3RvYnVm",
            "L2VtcHR5LnByb3RvGjVyZXBvcnRpbmcvaW5wdXRfcGFyYW1zL3Byb3BlcnR5",
            "X2Nsb2NrdGltZV9yYW5nZS5wcm90bxoscmVwb3J0aW5nL291dHB1dHMvaHRt",
            "bF9yZXBvcnRfcmVzcG9uc2UucHJvdG8aKnByaW1pdGl2ZS9wYl9pbmNsdXNp",
            "dmVfb3BzZGF0ZV9yYW5nZS5wcm90bzLFCQoWTWFuYWdlbWVudFJlcG9ydGlu",
            "Z1N2YxJjChZHZXRGb2xpb0JhbGFuY2VzUmVwb3J0EhYuZ29vZ2xlLnByb3Rv",
            "YnVmLkVtcHR5GjEuaG9sbXMudHlwZXMucmVwb3J0aW5nLm91dHB1dHMuSHRt",
            "bFJlcG9ydFJlc3BvbnNlEosBChpHZXRGb2xpb0dyb3NzQ2hhcmdlc1JlcG9y",
            "dBI6LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5pbnB1dF9wYXJhbXMuUHJvcGVy",
            "dHlDbG9ja1RpbWVSYW5nZRoxLmhvbG1zLnR5cGVzLnJlcG9ydGluZy5vdXRw",
            "dXRzLkh0bWxSZXBvcnRSZXNwb25zZRKHAQoWR2V0Rm9saW9QYXltZW50c1Jl",
            "cG9ydBI6LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5pbnB1dF9wYXJhbXMuUHJv",
            "cGVydHlDbG9ja1RpbWVSYW5nZRoxLmhvbG1zLnR5cGVzLnJlcG9ydGluZy5v",
            "dXRwdXRzLkh0bWxSZXBvcnRSZXNwb25zZRKKAQoZR2V0Rm9saW9BZGp1c3Rt",
            "ZW50c1JlcG9ydBI6LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5pbnB1dF9wYXJh",
            "bXMuUHJvcGVydHlDbG9ja1RpbWVSYW5nZRoxLmhvbG1zLnR5cGVzLnJlcG9y",
            "dGluZy5vdXRwdXRzLkh0bWxSZXBvcnRSZXNwb25zZRKIAQoXR2V0Q2FsbEFj",
            "Y291bnRpbmdSZXBvcnQSOi5ob2xtcy50eXBlcy5yZXBvcnRpbmcuaW5wdXRf",
            "cGFyYW1zLlByb3BlcnR5Q2xvY2tUaW1lUmFuZ2UaMS5ob2xtcy50eXBlcy5y",
            "ZXBvcnRpbmcub3V0cHV0cy5IdG1sUmVwb3J0UmVzcG9uc2USiQEKGEdldExl",
            "ZGdlckFjdGl2aXR5U3VtbWFyeRI6LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5p",
            "bnB1dF9wYXJhbXMuUHJvcGVydHlDbG9ja1RpbWVSYW5nZRoxLmhvbG1zLnR5",
            "cGVzLnJlcG9ydGluZy5vdXRwdXRzLkh0bWxSZXBvcnRSZXNwb25zZRKIAQoX",
            "R2V0TGVkZ2VySm91cm5hbEVudHJpZXMSOi5ob2xtcy50eXBlcy5yZXBvcnRp",
            "bmcuaW5wdXRfcGFyYW1zLlByb3BlcnR5Q2xvY2tUaW1lUmFuZ2UaMS5ob2xt",
            "cy50eXBlcy5yZXBvcnRpbmcub3V0cHV0cy5IdG1sUmVwb3J0UmVzcG9uc2US",
            "fwoaR2V0Um9vbVVzYWdlUmVwb3J0RGV0YWlsZWQSLi5ob2xtcy50eXBlcy5w",
            "cmltaXRpdmUuUGJJbmNsdXNpdmVPcHNkYXRlUmFuZ2UaMS5ob2xtcy50eXBl",
            "cy5yZXBvcnRpbmcub3V0cHV0cy5IdG1sUmVwb3J0UmVzcG9uc2USfgoZR2V0",
            "Um9vbVVzYWdlUmVwb3J0U3VtbWFyeRIuLmhvbG1zLnR5cGVzLnByaW1pdGl2",
            "ZS5QYkluY2x1c2l2ZU9wc2RhdGVSYW5nZRoxLmhvbG1zLnR5cGVzLnJlcG9y",
            "dGluZy5vdXRwdXRzLkh0bWxSZXBvcnRSZXNwb25zZUIrWg1yZXBvcnRpbmcv",
            "cnBjqgIZSE9MTVMuVHlwZXMuUmVwb3J0aW5nLlJQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Reporting.ReportParams.PropertyClocktimeRangeReflection.Descriptor, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponseReflection.Descriptor, global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null));
    }
    #endregion

  }
}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/guarantees/reservation_guarantee_status.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio.Guarantees {

  /// <summary>Holder for reflection information generated from folio/guarantees/reservation_guarantee_status.proto</summary>
  public static partial class ReservationGuaranteeStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/guarantees/reservation_guarantee_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationGuaranteeStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNmb2xpby9ndWFyYW50ZWVzL3Jlc2VydmF0aW9uX2d1YXJhbnRlZV9zdGF0",
            "dXMucHJvdG8SIGhvbG1zLnR5cGVzLmJvb2tpbmcucmVzZXJ2YXRpb25zKs4B",
            "ChpSZXNlcnZhdGlvbkd1YXJhbnRlZVN0YXR1cxIfChtHVUFSQU5URUVfU1RB",
            "VFVTX0dVQVJBTlRFRUQQABIrCidHVUFSQU5URUVfU1RBVFVTX05PVF9EVUVf",
            "Tk9UX0dVQVJBTlRFRUQQARIrCidHVUFSQU5URUVfU1RBVFVTX09WRVJEVUVf",
            "Tk9UX0dVQVJBTlRFRUQQAhI1CjFHVUFSQU5URUVfU1RBVFVTX05PVF9EVUVf",
            "UFJPVklTSU9OQUxMWV9HVUFSQU5URUVEEANCH6oCHEhPTE1TLlR5cGVzLkZv",
            "bGlvLkd1YXJhbnRlZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Folio.Guarantees.ReservationGuaranteeStatus), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ReservationGuaranteeStatus {
    [pbr::OriginalName("GUARANTEE_STATUS_GUARANTEED")] GuaranteeStatusGuaranteed = 0,
    [pbr::OriginalName("GUARANTEE_STATUS_NOT_DUE_NOT_GUARANTEED")] GuaranteeStatusNotDueNotGuaranteed = 1,
    [pbr::OriginalName("GUARANTEE_STATUS_OVERDUE_NOT_GUARANTEED")] GuaranteeStatusOverdueNotGuaranteed = 2,
    [pbr::OriginalName("GUARANTEE_STATUS_NOT_DUE_PROVISIONALLY_GUARANTEED")] GuaranteeStatusNotDueProvisionallyGuaranteed = 3,
  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/accounting/ledger_account_category.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Accounting {

  /// <summary>Holder for reflection information generated from money/accounting/ledger_account_category.proto</summary>
  public static partial class LedgerAccountCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for money/accounting/ledger_account_category.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LedgerAccountCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5tb25leS9hY2NvdW50aW5nL2xlZGdlcl9hY2NvdW50X2NhdGVnb3J5LnBy",
            "b3RvEhxob2xtcy50eXBlcy5tb25leS5hY2NvdW50aW5nKlgKFUxlZGdlckFj",
            "Y291bnRDYXRlZ29yeRIJCgVBU1NFVBAAEg0KCUxJQUJJTElUWRABEgoKBkVR",
            "VUlUWRACEgsKB1JFVkVOVUUQAxIMCghFWFBFTlNFUxAEQjFaEG1vbmV5L2Fj",
            "Y291bnRpbmeqAhxIT0xNUy5UeXBlcy5Nb25leS5BY2NvdW50aW5nYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Money.Accounting.LedgerAccountCategory), }, null));
    }
    #endregion

  }
  #region Enums
  public enum LedgerAccountCategory {
    [pbr::OriginalName("ASSET")] Asset = 0,
    [pbr::OriginalName("LIABILITY")] Liability = 1,
    [pbr::OriginalName("EQUITY")] Equity = 2,
    [pbr::OriginalName("REVENUE")] Revenue = 3,
    [pbr::OriginalName("EXPENSES")] Expenses = 4,
  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/packages/lodging_package.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.Packages {

  /// <summary>Holder for reflection information generated from supply/packages/lodging_package.proto</summary>
  public static partial class LodgingPackageReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/packages/lodging_package.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LodgingPackageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVzdXBwbHkvcGFja2FnZXMvbG9kZ2luZ19wYWNrYWdlLnByb3RvEhtob2xt",
            "cy50eXBlcy5zdXBwbHkucGFja2FnZXMaI3N1cHBseS9wcmljZWRfb2ZmZXJl",
            "ZF9sb2RnaW5nLnByb3RvIlwKDkxvZGdpbmdQYWNrYWdlEhAKCGJvb2thYmxl",
            "GAEgASgIEjgKBm9mZmVycxgCIAMoCzIoLmhvbG1zLnR5cGVzLnN1cHBseS5Q",
            "cmljZWRPZmZlcmVkTG9kZ2luZ0IvWg9zdXBwbHkvcGFja2FnZXOqAhtIT0xN",
            "Uy5UeXBlcy5TdXBwbHkuUGFja2FnZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Supply.PricedOfferedLodgingReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.Packages.LodgingPackage), global::HOLMS.Types.Supply.Packages.LodgingPackage.Parser, new[]{ "Bookable", "Offers" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LodgingPackage : pb::IMessage<LodgingPackage> {
    private static readonly pb::MessageParser<LodgingPackage> _parser = new pb::MessageParser<LodgingPackage>(() => new LodgingPackage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LodgingPackage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.Packages.LodgingPackageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LodgingPackage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LodgingPackage(LodgingPackage other) : this() {
      bookable_ = other.bookable_;
      offers_ = other.offers_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LodgingPackage Clone() {
      return new LodgingPackage(this);
    }

    /// <summary>Field number for the "bookable" field.</summary>
    public const int BookableFieldNumber = 1;
    private bool bookable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Bookable {
      get { return bookable_; }
      set {
        bookable_ = value;
      }
    }

    /// <summary>Field number for the "offers" field.</summary>
    public const int OffersFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.PricedOfferedLodging> _repeated_offers_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Supply.PricedOfferedLodging.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.PricedOfferedLodging> offers_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.PricedOfferedLodging>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.PricedOfferedLodging> Offers {
      get { return offers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LodgingPackage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LodgingPackage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Bookable != other.Bookable) return false;
      if(!offers_.Equals(other.offers_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Bookable != false) hash ^= Bookable.GetHashCode();
      hash ^= offers_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Bookable != false) {
        output.WriteRawTag(8);
        output.WriteBool(Bookable);
      }
      offers_.WriteTo(output, _repeated_offers_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Bookable != false) {
        size += 1 + 1;
      }
      size += offers_.CalculateSize(_repeated_offers_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LodgingPackage other) {
      if (other == null) {
        return;
      }
      if (other.Bookable != false) {
        Bookable = other.Bookable;
      }
      offers_.Add(other.offers_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Bookable = input.ReadBool();
            break;
          }
          case 18: {
            offers_.AddEntriesFrom(input, _repeated_offers_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
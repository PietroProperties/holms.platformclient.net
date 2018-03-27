using Google.Protobuf;
using HOLMS.Types.Primitive;
using System;

namespace HOLMS.Types.Extensions.Support {
    public static class GuidConversions {
        public static Uuid ToUUID(this Guid g) =>
            new Uuid { Value = ByteString.CopyFrom(g.ToByteArray()) };

        public static Guid ToGuid(this Uuid u) => new Guid(u.Value.ToByteArray());
    }
}

using System.Linq;
using HOLMS.Types.Supply.Packages;

namespace HOLMS.Support.DTOExtensions.Supply.Packages {
    public static class LodgingPackageExtensions {
        public static bool IsAvailable(this LodgingPackage package) =>
            package.Offers.All(o => o.Available > 0);

        public static bool IsPriceable(this LodgingPackage package) =>
            package.Offers.All(o => o.NightlyPrice != null);
    }
}

using HOLMS.Types.Extensions;

namespace HOLMS.Types.Operations.Attractions {
    public partial class Attraction : EntityDTO<AttractionIndicator> {
        public Attraction(AttractionIndicator i, string name, string info,
            string categoryName, AttractionCategoryIndicator ci) {
            EntityId = i;
            Name = name;
            Information = info;
            CategoryName = categoryName;
            Category = ci;
        }

        public override AttractionIndicator GetIndicator() => EntityId;
    }
}

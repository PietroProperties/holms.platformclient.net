using System.Collections.Generic;
using HOLMS.Platform.Types;
using HOLMS.Types.Extensions;

namespace HOLMS.Types.Operations.Attractions {
    public partial class AttractionCategory : EntityDTO<AttractionCategoryIndicator> {
        public AttractionCategory(AttractionCategoryIndicator ci, string name,
                IEnumerable<Attraction> attractions) {
            EntityId = ci;
            Name = name;
            Attractions.Add(attractions);
        }

        public override AttractionCategoryIndicator GetIndicator() => EntityId;
    }
}

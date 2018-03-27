using HOLMS.Types.Primitive;

namespace HOLMS.Types.TenancyConfig {
    public partial class RoomStatusColors {
        public RoomStatusColors(StatusColor cleanColor, StatusColor dirtyColor,
                StatusColor deepCleanColor, StatusColor inspectColor, StatusColor dustColor,
                StatusColor outOfOrderColor, StatusColor blockedColor, StatusColor maidInRoomColor,
                StatusColor showRoomColor, StatusColor leftDirtyColor, StatusColor holdsColor) {
            CleanColor = cleanColor;
            DirtyColor = dirtyColor;
            DeepCleanColor = deepCleanColor;
            InspectColor = inspectColor;
            DustColor = dustColor;
            OutOfOrderColor = outOfOrderColor;
            BlockedColor = blockedColor;
            MaidInRoomColor = maidInRoomColor;
            ShowRoomColor = showRoomColor;
            LeftDirtyColor = leftDirtyColor;
            HoldsColor = holdsColor;
        }
    }
}

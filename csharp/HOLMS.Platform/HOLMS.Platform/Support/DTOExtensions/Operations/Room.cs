namespace HOLMS.Types.Operations.Rooms {
    public partial class Room {
        public bool Occupied => OccupancyState != RoomOccupancyState.OccupancyStateVacant;
    }
}

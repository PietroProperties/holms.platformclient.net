namespace HOLMS.Types.Booking.History {
    public partial class HistoryEvent {
        public void AddDetail(string category, string content) {
            Details.Add(new HistoryEventDetail() {
                Category = category ?? string.Empty,
                Content = content ?? string.Empty
            });
        }
    }
}

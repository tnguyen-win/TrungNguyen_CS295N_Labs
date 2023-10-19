namespace PopularGameEngines.Models {
    public class Message {
        public string? Title { get; set; }
        public string? Text { get; set; }
        public AppUser? From { get; set; }
        public DateOnly? Date { get; set; }
        public int? Rating { get; set; }
    }
}
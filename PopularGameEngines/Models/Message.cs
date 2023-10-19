namespace PopularGameEngines.Models {
    public class Message {
        public string? Title { get; set; }
        public string? Body { get; set; }
        public AppUser? From { get; set; }
        public DateOnly? Date { get; set; }
        public int? Rating { get; set; }
    }
}

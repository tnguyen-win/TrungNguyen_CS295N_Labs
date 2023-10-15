namespace PopularGameEngines.Models {
    public class Message {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Rating { get; set; }
        public string Author { get; set; }
        public DateOnly Date { get; set; }
    }
}

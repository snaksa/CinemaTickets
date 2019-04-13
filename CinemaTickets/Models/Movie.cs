namespace CinemaTickets.Models
{
    class Movie
    {
        public Movie(
            int id = 0, 
            string title = "",
            string subtitle = "",
            string description = "",
            string trailerUrl = "",
            Category category = null,
            Genre genre = null,
            float duration = 0,
            string producer = "",
            string actors = "")
        {
            this.Id = id;
            this.Title = title;
            this.Subtitle = subtitle;
            this.Description = description;
            this.TrailerUrl = trailerUrl;
            this.Category = category;
            this.Genre = genre;
            this.Duration = duration;
            this.Producer = producer;
            this.Actors = actors;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string TrailerUrl { get; set; }
        public Category Category { get; set; }
        public Genre Genre { get; set; }
        public float Duration { get; set; }
        public string Producer { get; set; }
        public string Actors { get; set; }
    }
}

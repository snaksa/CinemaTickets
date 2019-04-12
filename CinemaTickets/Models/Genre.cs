namespace CinemaTickets.Models
{
    class Genre
    {
        public Genre(int id = 0, string name = "")
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}

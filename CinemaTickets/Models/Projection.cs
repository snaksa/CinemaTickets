using System;

namespace CinemaTickets.Models
{
    class Projection
    {
        public Projection(
            int id = 0, 
            Movie movie = null,
            MovieType movieType = null,
            Room room = null,
            DateTime time = new DateTime())
        {
            this.Id = id;
            this.Movie = movie;
            this.MovieType = movieType;
            this.Room = room;
            this.Time = time;
        }

        public int Id { get; set; }
        public Movie Movie { get; set; }
        public MovieType MovieType{ get; set; }
        public Room Room { get; set; }
        public DateTime Time { get; set; }
    }
}

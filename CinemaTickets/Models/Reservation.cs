namespace CinemaTickets.Models
{
    class Reservation
    {
        public Reservation(int id = 0, Projection projection = null)
        {
            this.Id = id;
            this.Projection = projection;
        }

        public int Id { get; set; }
        public Projection Projection { get; set; }
    }
}

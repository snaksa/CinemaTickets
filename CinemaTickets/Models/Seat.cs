namespace CinemaTickets.Models
{
    class Seat
    {
        public Seat(int id = 0, Ticket ticket = null, int position = 0)
        {
            this.Id = id;
            this.Ticket = ticket;
            this.Position = position;
        }

        public int Id { get; set; }
        public Ticket Ticket { get; set; }
        public int Position { get; set; }
    }
}

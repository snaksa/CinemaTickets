namespace CinemaTickets.Models
{
    class Ticket
    {
        public Ticket(int id = 0, Reservation reservation = null, TicketType type = null)
        {
            this.Id = id;
            this.Reservation = reservation;
            this.Type = type;
        }

        public int Id { get; set; }
        public Reservation Reservation { get; set; }
        public TicketType Type { get; set; }
    }
}

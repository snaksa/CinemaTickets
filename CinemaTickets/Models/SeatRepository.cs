using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CinemaTickets.Models
{
    class SeatRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["CinemaTicketsConnectionString"]
            .ConnectionString;

        public static void Add(int ticketId, int seat)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO seats (ticket_id, seat) " +
                    "VALUES(@ticketId, @seat)", con))
                {
                    command.Parameters.Add("@ticketId", SqlDbType.Int);
                    command.Parameters["@ticketId"].Value = ticketId;
                    command.Parameters.Add("@seat", SqlDbType.Int);
                    command.Parameters["@seat"].Value = seat;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Seat> GetByProjection(int projectionId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT s.id, s.seat FROM seats s " +
                    "INNER JOIN tickets t ON t.id = s.ticket_id " +
                    "INNER JOIN reservations r ON r.id = t.reservation_id " +
                    "WHERE r.projection_id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = projectionId;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Seat> seats = new List<Seat>();
                        while (reader.Read())
                        {
                            seats.Add(new Seat(reader.GetInt32(0), null, reader.GetInt32(1)));
                        }
                        return seats;
                    }
                }
            }
        }
        public static void RemoveByReservation(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM seats WHERE ticket_id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

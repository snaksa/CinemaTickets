using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CinemaTickets.Models
{
    class TicketRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["CinemaTicketsConnectionString"]
            .ConnectionString;
        
        public static void Add(int reservationId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO tickets (reservation_id) " +
                    "VALUES(@reservationId)", con))
                {
                    command.Parameters.Add("@reservationId", SqlDbType.Int);
                    command.Parameters["@reservationId"].Value = reservationId;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static int GetLatest()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT TOP 1 id FROM tickets " +
                    "ORDER BY id DESC", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                    }
                }
            }

            return 0;
        }

    }
}

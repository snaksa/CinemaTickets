using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CinemaTickets.Models
{
    class ReservationRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["CinemaTicketsConnectionString"]
            .ConnectionString;
        
        public static void Add(int projectionId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO reservations (projection_id) " +
                    "VALUES(@projectionId)", con))
                {
                    command.Parameters.Add("@projectionId", SqlDbType.Int);
                    command.Parameters["@projectionId"].Value = projectionId;

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
                    "SELECT TOP 1 id FROM reservations " +
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

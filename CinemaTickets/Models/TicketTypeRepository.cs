using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CinemaTickets.Models
{
    class TicketTypeRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["CinemaTicketsConnectionString"]
            .ConnectionString;

        public static TicketType Get(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT id, name, price FROM ticket_types where id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new TicketType(reader.GetInt32(0), reader.GetString(1).Trim(), reader.GetInt32(2));
                        }
                    }
                }
            }

            return null;
        }
        public static List<TicketType> GetAll()
        {
            List<TicketType> movieTypes = new List<TicketType>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT id, name, price FROM ticket_types", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movieTypes.Add(new TicketType(reader.GetInt32(0), reader.GetString(1).Trim(), reader.GetInt32(2)));
                        }
                    }
                }
            }

            return movieTypes;
        }

        public static void Add(string name, float price)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO ticket_types (name, price) VALUES(@name, @price)", con))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar);
                    command.Parameters["@name"].Value = name;
                    command.Parameters.Add("@rice", SqlDbType.Float);
                    command.Parameters["@price"].Value = price;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Update(TicketType ticketType)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("UPDATE ticket_types SET name = @name, price = @price WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = ticketType.Id;
                    command.Parameters.Add("@name", SqlDbType.NVarChar);
                    command.Parameters["@name"].Value = ticketType.Name;
                    command.Parameters.Add("@price", SqlDbType.Int);
                    command.Parameters["@price"].Value = ticketType.Price;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Remove(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM ticket_types WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

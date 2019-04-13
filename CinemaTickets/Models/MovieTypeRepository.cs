using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CinemaTickets.Models
{
    class MovieTypeRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["CinemaTicketsConnectionString"]
            .ConnectionString;

        public static MovieType Get(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT id, name, price FROM movie_types where id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new MovieType(reader.GetInt32(0), reader.GetString(1).Trim(), reader.GetInt32(2));
                        }
                    }
                }
            }

            return null;
        }
        public static List<MovieType> GetAll()
        {
            List<MovieType> movieTypes = new List<MovieType>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT id, name, price FROM movie_types", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movieTypes.Add(new MovieType(reader.GetInt32(0), reader.GetString(1).Trim(), reader.GetInt32(2)));
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
                using (SqlCommand command = new SqlCommand("INSERT INTO movie_types (name, price) VALUES(@name, @price)", con))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar);
                    command.Parameters["@name"].Value = name;
                    command.Parameters.Add("@rice", SqlDbType.Float);
                    command.Parameters["@price"].Value = price;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Update(MovieType movieType)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("UPDATE movie_types SET name = @name, price = @price WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = movieType.Id;
                    command.Parameters.Add("@name", SqlDbType.NVarChar);
                    command.Parameters["@name"].Value = movieType.Name;
                    command.Parameters.Add("@price", SqlDbType.Int);
                    command.Parameters["@price"].Value = movieType.Price;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Remove(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM movie_types WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

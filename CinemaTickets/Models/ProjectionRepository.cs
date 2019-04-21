using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CinemaTickets.Models
{
    class ProjectionRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["CinemaTicketsConnectionString"]
            .ConnectionString;

        public static Projection Get(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT p.id, m.id,m.imgurl, m.title, m.subtitle, m.description, m.trailer_url," +
                    "c.id, c.name, g.id, g.name, m.duration, m.producer, m.actors " +
                    "t.id, t.name, t.price, r.id, r.name, p.time " +
                    "FROM projections p " +
                    "LEFT JOIN movies m ON m.id = p.movie_id " +
                    "LEFT JOIN movie_types t ON t.id = p.movie_type_id " +
                    "LEFT JOIN room r ON r.id = p.room_id " +
                    "LEFT JOIN categories c ON c.id = m.category_id" +
                    "LEFT JOIN genres g ON g.id = m.genre_id" +
                    "WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Projection(
                                reader.GetInt32(0), //projection id
                                new Movie(
                                    reader.GetInt32(1), // id
                                    reader.GetString(2).Trim(),
                                    reader.GetString(3).Trim(), // title
                                    reader.GetString(4).Trim(), // subtitle
                                    reader.GetString(5).Trim(), // description
                                    reader.GetString(6).Trim(), // trailer_url
                                    new Category(
                                        reader.GetInt32(7), // category id
                                        reader.GetString(8).Trim() // category name
                                    ),
                                    new Genre(
                                        reader.GetInt32(9), // genre id
                                        reader.GetString(10).Trim() // genre name
                                        ),
                                    reader.GetDecimal(11), // duration
                                    reader.GetString(12).Trim(), // producer
                                    reader.GetString(13).Trim() // actors
                                ),
                                new MovieType(reader.GetInt32(14), reader.GetString(15).Trim()),
                                new Room(reader.GetInt32(16), reader.GetString(17).Trim()),
                                reader.GetDateTime(18)
                            );
                        }
                    }
                }
            }

            return null;
        }
        public static List<Projection> GetAll(int movieId = 0)
        {
            List<Projection> projections = new List<Projection>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT p.id, m.id, m.imgurl, m.title, m.subtitle, m.description, m.trailer_url, " +
                    "c.id, c.name, g.id, g.name, m.duration, m.producer, m.actors, " +
                    "t.id, t.name, t.price, r.id, r.name, p.time " +
                    "FROM projections p " +
                    "LEFT JOIN movies m ON m.id = p.movie_id " +
                    "LEFT JOIN movie_types t ON t.id = p.movie_type_id " +
                    "LEFT JOIN rooms r ON r.id = p.room_id " +
                    "LEFT JOIN categories c ON c.id = m.category_id " +
                    "LEFT JOIN genres g ON g.id = m.genre_id " +
                    (movieId != 0 ? "WHERE m.id = @movieId " : "") + 
                    "ORDER BY p.time", con))
                {
                    if (movieId != 0)
                    {
                        command.Parameters.Add("@movieId", SqlDbType.Int);
                        command.Parameters["@movieId"].Value = movieId;
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {


                            projections.Add(new Projection(
                                reader.GetInt32(0), //projection id
                                new Movie(
                                    reader.GetInt32(1), // id
                                    !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "", // urlpicture
                                    !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "", // title
                                    !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "", // subtitle
                                    !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "", // description
                                    !reader.IsDBNull(6) ? reader.GetString(6).Trim() : "", // trailer_url
                                    new Category(
                                        !reader.IsDBNull(7) ? reader.GetInt32(7) : 0, // category id
                                        !reader.IsDBNull(8) ? reader.GetString(8).Trim() : "" // category name
                                    ),
                                    new Genre(
                                        !reader.IsDBNull(9) ? reader.GetInt32(9) : 0, // genre id
                                        !reader.IsDBNull(10) ? reader.GetString(10).Trim() : "" // genre name
                                    ),
                                    !reader.IsDBNull(11) ? reader.GetDecimal(11) : 0, // duration
                                    !reader.IsDBNull(12) ? reader.GetString(12).Trim() : "", // producer
                                    !reader.IsDBNull(13) ? reader.GetString(13).Trim() : "" // actors
                                ),
                                new MovieType(reader.GetInt32(14), reader.GetString(15).Trim(), reader.GetInt32(16)),
                                new Room(reader.GetInt32(17), reader.GetString(18).Trim()),
                                reader.GetDateTime(19)
                            ));
                        }
                    }
                }
            }

            return projections;
        }

        public static void Add(int movieId, int movieTypeId, int roomId, DateTime time)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO projections (movie_id, movie_type_id, room_id, time) " +
                    "VALUES(@movie_id, @movie_type_id, @room_id, time)", con))
                {
                    command.Parameters.Add("@movie_id", SqlDbType.Int);
                    command.Parameters["@movie_id"].Value = movieId;
                    command.Parameters.Add("@movie_type_id", SqlDbType.Int);
                    command.Parameters["@movie_type_id"].Value = movieTypeId;
                    command.Parameters.Add("@room_id", SqlDbType.Int);
                    command.Parameters["@room_id"].Value = roomId;
                    command.Parameters.Add("@time", SqlDbType.DateTime);
                    command.Parameters["@time"].Value = time;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Projection projection)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "UPDATE projections SET movie_id = @movie_id, movie_type_id = @movie_type_id, " +
                    "room_id = @room_id, time = @time) " +
                    "WHERE id= @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = projection.Id;
                    command.Parameters.Add("@movie_id", SqlDbType.Int);
                    command.Parameters["@movie_id"].Value = projection.Movie.Id;
                    command.Parameters.Add("@movie_type_id", SqlDbType.Int);
                    command.Parameters["@movie_type_id"].Value = projection.MovieType.Id;
                    command.Parameters.Add("@room_id", SqlDbType.Int);
                    command.Parameters["@room_id"].Value = projection.Room.Id;
                    command.Parameters.Add("@time", SqlDbType.DateTime);
                    command.Parameters["@time"].Value = projection.Time;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Remove(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM projections WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CinemaTickets.Models
{
    class MovieRepository
    {
        public static string connectionString = System.Configuration
            .ConfigurationManager
            .ConnectionStrings["CinemaTicketsConnectionString"]
            .ConnectionString;

        public static Movie Get(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT m.id, m.title, m.subtitle, m.description, m.trailer_url," +
                    "c.id, c.name, g.id, g.name, m.duration, m.producer, m.actors " +
                    "FROM movies m " +
                    "LEFT JOIN categories c ON c.id = m.category_id " +
                    "LEFT JOIN genres g ON g.id = m.genre_id " +
                    "where id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Movie(
                                reader.GetInt32(0), // id
                                reader.GetString(1).Trim(), // title
                                reader.GetString(2).Trim(), // subtitle
                                reader.GetString(3).Trim(), // description
                                reader.GetString(4).Trim(), // trailer_url
                                new Category(
                                    reader.GetInt32(5), // category id
                                    reader.GetString(6).Trim() // category name
                                ),
                                new Genre(
                                    reader.GetInt32(7), // genre id
                                    reader.GetString(8).Trim() // genre name
                                    ),
                                reader.GetFloat(9), // duration
                                reader.GetString(10).Trim(), // producer
                                reader.GetString(11).Trim() // actors
                            );
                        }
                    }
                }
            }

            return null;
        }
        public static List<Movie> GetAll()
        {
            List<Movie> movies = new List<Movie>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT m.id, m.title, m.subtitle, m.description, m.trailer_url," +
                    "c.id, c.name, g.id, g.name, m.duration, m.producer, m.actors " +
                    "FROM movies m " +
                    "LEFT JOIN categories c ON c.id = m.category_id " +
                    "LEFT JOIN genres g ON g.id = m.genre_id", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new Movie(
                                reader.GetInt32(0), // id
                                reader.GetString(1).Trim(), // title
                                reader.GetString(2).Trim(), // subtitle
                                reader.GetString(3).Trim(), // description
                                reader.GetString(4).Trim(), // trailer_url
                                new Category(
                                    reader.GetInt32(5), // category id
                                    reader.GetString(6).Trim() // category name
                                ),
                                new Genre(
                                    reader.GetInt32(7), // genre id
                                    reader.GetString(8).Trim() // genre name
                                    ),
                                reader.GetFloat(9), // duration
                                reader.GetString(10).Trim(), // producer
                                reader.GetString(11).Trim() // actors
                            ));
                        }
                    }
                }
            }

            return movies;
        }

        public static void Add(string title, string subtitle, string description, string trailerUrl,
            int categoryId, int genreId, float duration, string producer, string actors)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO movies (title, subtitle, description, trailer_url, " +
                    "category_id, genre_id, duration, producer, actors) " +
                    "VALUES(@title, @subtitle, @descritpion, @trailer_url, " +
                    "@category_id, @genre_id, @duration, @producer, @actors)", con))
                {
                    command.Parameters.Add("@title", SqlDbType.NVarChar);
                    command.Parameters["@title"].Value = title;
                    command.Parameters.Add("@name", SqlDbType.NVarChar);
                    command.Parameters["@subtitle"].Value = subtitle;
                    command.Parameters.Add("@description", SqlDbType.NVarChar);
                    command.Parameters["@description"].Value = description;
                    command.Parameters.Add("@trailer_url", SqlDbType.NVarChar);
                    command.Parameters["@trailer_url"].Value = trailerUrl;
                    command.Parameters.Add("@category_id", SqlDbType.Int);
                    command.Parameters["@category_id"].Value = categoryId;
                    command.Parameters.Add("@genre_id", SqlDbType.Int);
                    command.Parameters["@genre_id"].Value = genreId;
                    command.Parameters.Add("@duration", SqlDbType.Float);
                    command.Parameters["@duration"].Value = duration;
                    command.Parameters.Add("@producer", SqlDbType.NVarChar);
                    command.Parameters["@producer"].Value = producer;
                    command.Parameters.Add("@actors", SqlDbType.NVarChar);
                    command.Parameters["@actors"].Value = actors;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Movie movie)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "UPDATE movies SET title = @title, subtitle = @subtitle, " +
                    "description = @description, trailer_url = @trailer_url, " +
                    "category_id = @category_id, genre_id = @genre_id, duration = @duration, " +
                    "producer = @producer, actors = @actors) " +
                    "WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = movie.Id;
                    command.Parameters.Add("@title", SqlDbType.NVarChar);
                    command.Parameters["@title"].Value = movie.Title;
                    command.Parameters.Add("@name", SqlDbType.NVarChar);
                    command.Parameters["@subtitle"].Value = movie.Subtitle;
                    command.Parameters.Add("@description", SqlDbType.NVarChar);
                    command.Parameters["@description"].Value = movie.Description;
                    command.Parameters.Add("@trailer_url", SqlDbType.NVarChar);
                    command.Parameters["@trailer_url"].Value = movie.TrailerUrl;
                    command.Parameters.Add("@category_id", SqlDbType.Int);
                    command.Parameters["@category_id"].Value = movie.Category.Id;
                    command.Parameters.Add("@genre_id", SqlDbType.Int);
                    command.Parameters["@genre_id"].Value = movie.Genre.Id;
                    command.Parameters.Add("@duration", SqlDbType.Float);
                    command.Parameters["@duration"].Value = movie.Duration;
                    command.Parameters.Add("@producer", SqlDbType.NVarChar);
                    command.Parameters["@producer"].Value = movie.Producer;
                    command.Parameters.Add("@actors", SqlDbType.NVarChar);
                    command.Parameters["@actors"].Value = movie.Actors;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Remove(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM movies WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

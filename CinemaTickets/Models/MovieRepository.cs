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
                    "SELECT m.id, m.imgurl, m.title, m.subtitle, m.description, m.trailer_url," +
                    "c.id, c.name, g.id, g.name, m.duration, m.producer, m.actors " +
                    "FROM movies m " +
                    "LEFT JOIN categories c ON c.id = m.category_id " +
                    "LEFT JOIN genres g ON g.id = m.genre_id " +
                    "WHERE m.id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Movie(
                                reader.GetInt32(0), // id
                                !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "", // urlpicture
                                !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "", // title
                                !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "", // subtitle
                                !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "", // description
                                !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "", // trailer_url
                                new Category(
                                    !reader.IsDBNull(6) ? reader.GetInt32(6) : 0, // category id
                                    !reader.IsDBNull(7) ? reader.GetString(7).Trim() : "" // category name
                                ),
                                new Genre(
                                    !reader.IsDBNull(8) ? reader.GetInt32(8) : 0, // genre id
                                    !reader.IsDBNull(9) ? reader.GetString(9).Trim() : "" // genre name
                                ),
                                !reader.IsDBNull(10) ? reader.GetDecimal(10) : 0, // duration
                                !reader.IsDBNull(11) ? reader.GetString(11).Trim() : "", // producer
                                !reader.IsDBNull(12) ? reader.GetString(12).Trim() : "" // actors
                            );
                        }
                    }
                }
            }

            return null;
        }
        public static List<Movie> GetAll(bool limit = false, int genre_id = 0, string searchText = "")
        {
            List<Movie> movies = new List<Movie>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT " + (limit ? "TOP 6" : "") + " m.id, m.imgurl, m.title, m.subtitle, m.description, m.trailer_url," +
                    "c.id, c.name, g.id, g.name, m.duration, m.producer, m.actors " +
                    "FROM movies m " +
                    "LEFT JOIN categories c ON c.id = m.category_id " +
                    "LEFT JOIN genres g ON g.id = m.genre_id " +
                    (genre_id != 0 ? " WHERE g.id = @genreId " : "") +
                    (genre_id != 0 && searchText != "" ? " AND " : searchText != "" ? " WHERE " : "") +
                    (searchText != "" ? " m.title LIKE @search " : ""), con))
                {
                    if(genre_id != 0)
                    {
                        command.Parameters.Add("@genreId", SqlDbType.Int);
                        command.Parameters["@genreId"].Value = genre_id;
                    }

                    if (searchText != "")
                    {
                        command.Parameters.Add("@search", SqlDbType.NVarChar);
                        command.Parameters["@search"].Value = "%" + searchText + "%";
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            movies.Add(new Movie(
                                reader.GetInt32(0), // id
                                !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "", // urlpicture
                                !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "", // title
                                !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "", // subtitle
                                !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "", // description
                                !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "", // trailer_url
                                new Category(
                                    !reader.IsDBNull(6) ? reader.GetInt32(6) : 0, // category id
                                    !reader.IsDBNull(7) ? reader.GetString(7).Trim() : "" // category name
                                ),
                                new Genre(
                                    !reader.IsDBNull(8) ? reader.GetInt32(8) : 0, // genre id
                                    !reader.IsDBNull(9) ? reader.GetString(9).Trim() : "" // genre name
                                ),
                                !reader.IsDBNull(10) ? reader.GetDecimal(10) : 0, // duration
                                !reader.IsDBNull(11) ? reader.GetString(11).Trim() : "", // producer
                                !reader.IsDBNull(12) ? reader.GetString(12).Trim() : "" // actors
                            ));
                        }
                    }
                }
            }

            return movies;
        }

        public static void Add(Movie m)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO movies (title, subtitle, description, trailer_url, " +
                    "category_id, genre_id, duration, producer, actors, imgurl) " +
                    "VALUES(@title, @subtitle, @description, @trailer_url, " +
                    "@category_id, @genre_id, @duration, @producer, @actors, @imgurl)", con))
                {

                    
                    command.Parameters.AddWithValue("@title", m.Title);
                    command.Parameters.AddWithValue("@subtitle", m.Subtitle);
                    command.Parameters.AddWithValue("@description", m.Description);
                    command.Parameters.AddWithValue("@trailer_url", m.TrailerUrl);
                    command.Parameters.AddWithValue("@category_id", m.Category.Id);
                    command.Parameters.AddWithValue("@genre_id", m.Genre.Id);
                    command.Parameters.AddWithValue("@duration", m.Duration);
                    command.Parameters.AddWithValue("@producer", m.Producer);
                    command.Parameters.AddWithValue("@actors", m.Actors);
                    command.Parameters.AddWithValue("@imgurl", m.ImgUrl);

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
                    "UPDATE movies SET imgurl=@imgurl title = @title, subtitle = @subtitle, " +
                    "description = @description, trailer_url = @trailer_url, " +
                    "category_id = @category_id, genre_id = @genre_id, duration = @duration, " +
                    "producer = @producer, actors = @actors) " +
                    "WHERE id = @id", con))
                {
                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = movie.Id;
                    command.Parameters.Add("@imgurl", SqlDbType.NVarChar);
                    command.Parameters["@imgurl"].Value = movie.ImgUrl;
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

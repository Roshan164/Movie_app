using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieDAL
    {
        string connectionString = "Data Source=DESKTOP-CUC35RH\\ROSHANSQL;Initial Catalog=MoviesDB;Persist Security Info=False;";

        //Get All
        public IEnumerable<MovieInfo> GetAllMovieTitle()
        {
            List<MovieInfo> movieList = new List<MovieInfo>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetAllMovie", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MovieInfo movie = new MovieInfo();
                    movie.Id = Convert.ToInt32(dr["Id"].ToString());
                    movie.MovieTitle = dr["MovieTitle"].ToString();
                    movie.DateReleased = Convert.ToDateTime(dr["DateReleased"].ToString());

                    movieList.Add(movie);
                }
                con.Close();
            }
            return movieList;
        }

        internal MovieInfo GetMovieById(int? id)
        {
            throw new NotImplementedException();
        }



        //To Insert 
        public void AddMovie(MovieInfo movie)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_InsertMovie", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MovieTitle", movie.MovieTitle);
                cmd.Parameters.AddWithValue("@DateReleased", movie.DateReleased);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //To Update 
        public void UpdateMovie(MovieInfo movie)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_UpdateMovie", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MovieId", movie.Id);
                cmd.Parameters.AddWithValue("@MovieTitle", movie.MovieTitle);
                cmd.Parameters.AddWithValue("@DateReleased", movie.DateReleased);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //To Delete
        public void DeleteMovie(int? movieId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_DeleteMovie", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MovieId", movieId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Get Movie by Id
        public MovieInfo GetMovieById(int movieId)
        {
            MovieInfo movie = new MovieInfo();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetAllMovie", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MovieId", movieId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    movie.Id = Convert.ToInt32(dr["Id"].ToString());
                    movie.MovieTitle = dr["MovieTitle"].ToString();
                    movie.DateReleased = Convert.ToDateTime(dr["DateReleased"].ToString());

                }
                con.Close();
            }
            return movie;
        }
    }
}


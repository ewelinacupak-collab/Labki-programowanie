using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Repository
{
    public class CinemaRepository : ICinemaRepository
    {

        private List<Movie> movies = new List<Movie>();

        public void Add(Movie movie)
        {
            movies.Add(movie);
        }

        public void Delete(int id)
        {
            var movie = GetMovieById(id);
            if (movie != null)
            {
                movies.Remove(movie);
            }
        }

        public Movie GetMovieById(int id)
        {
            return movies.First(m=>m.Id == id);
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }
    }
}

using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Repository
{
    public interface ICinemaRepository
    {
        List<Movie> GetMovies();

        Movie GetMovieById(int id);

        void Add(Movie movie);

        void Delete(int id);
    }
}

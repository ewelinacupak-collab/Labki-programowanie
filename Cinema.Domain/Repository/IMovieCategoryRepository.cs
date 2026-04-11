using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Repository
{
    public interface IMovieCategoryRepository
    {

        List<MovieCategory> GetMovieCategories();

        MovieCategory GetMovieCategyByName( string name);

        MovieCategory GetMovieCategyById(int id);
    }
}

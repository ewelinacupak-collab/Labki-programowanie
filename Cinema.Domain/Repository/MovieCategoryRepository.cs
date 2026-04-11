using Cinema.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Repository
{
    public class MovieCategoryRepository : IMovieCategoryRepository
    {
        private List<MovieCategory> movieCategory = new List<MovieCategory>()
        {
            new MovieCategory { Id = 1 , Name = "Komedia"},
            new MovieCategory { Id = 2 , Name = "Dokumentalny" },
            new MovieCategory { Id = 3 , Name = "Historyczny" },
        };

        public List<MovieCategory> GetMovieCategories()
        {
            return movieCategory;
        }

        public MovieCategory GetMovieCategyByName(string name)
        {
            return movieCategory.First(c => c.Name == name);
        }
    }
}

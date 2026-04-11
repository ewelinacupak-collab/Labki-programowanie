using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }

        public int DurationInMinutes { get; set; }

        public double Rating { get; set; }

        //Relacja do kategorii

        public int MovieCategoryId { get; set; }

        public MovieCategory Category {  get; set; }
    }
}

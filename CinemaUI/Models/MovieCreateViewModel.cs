using Cinema.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace CinemaUI.Models
{
    public class MovieCreateViewModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(1900, 2100)]
        public int Year { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty ;

        [Range(1, 500)]
        public int DurationInMinutes { get; set; }

        [Range(0, 10)]
        public double Rating { get; set; }

        [Display(Name = "Kategoria")]
        public int MovieCategoryId { get; set; }

        public List<MovieCategory> Categories { get; set; } = new();
    }
}

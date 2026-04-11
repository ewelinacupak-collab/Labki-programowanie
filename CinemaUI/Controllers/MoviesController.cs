using Cinema.Domain.Entities;
using Cinema.Domain.Repository;
using CinemaUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace CinemaUI.Controllers
{
    public class MoviesController : Controller

    {
        private readonly ICinemaRepository _cinemaRepository;
        private readonly IMovieCategoryRepository _movieCategoryRepository;

        public MoviesController(
            ICinemaRepository cinemaRepository,
            IMovieCategoryRepository movieCategoryRepository)
        {
            _cinemaRepository = cinemaRepository;
            _movieCategoryRepository = movieCategoryRepository;
        }

        public IActionResult Index()
        {
            var movies = _cinemaRepository.GetMovies();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var vm = new MovieCreateViewModel
            {
                Categories = _movieCategoryRepository.GetMovieCategories()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(MovieCreateViewModel vm)
        {
            if (!ModelState.IsValid)
            { 
                vm.Categories = _movieCategoryRepository.GetMovieCategories();
                return View(vm);
            }

            var category = _movieCategoryRepository.GetMovieCategyById(vm.MovieCategoryId);

            var movie = new Movie
            {
                Name = vm.Name,
                Year = vm.Year,
                Description = vm.Description,
                DurationInMinutes = vm.DurationInMinutes,
                Rating = vm.Rating,
                MovieCategoryId = vm.MovieCategoryId,
                Category = category
            };

            _cinemaRepository.Add(movie);

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            _cinemaRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

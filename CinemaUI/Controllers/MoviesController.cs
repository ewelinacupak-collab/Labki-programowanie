using Microsoft.AspNetCore.Mvc;

namespace CinemaUI.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using eTickets.Data.Services.MoviesService;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _moviesService.GetAllAsync(n => n.Cinema);
            return View(movies);
        }

        public IActionResult Create()
        {
            ViewData["Welcome"] = "Welcome to our store";
            ViewBag.Description = "This is the store description";
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _moviesService.GetMovieByIdAsync(id);
            if (movieDetails == null)
            {
                return View("NotFound");
            }
            return View(movieDetails);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var movieDetails = await _moviesService.GetByIdAsync(id);
            if (movieDetails == null)
            {
                return View("NotFound");
            }
            return View(movieDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price,ImageURL,StartDate,EndDate,MovieCategory,Cinema,Producer")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }
            await _moviesService.UpdateAsync(id, movie);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var movieDetails = await _moviesService.GetByIdAsync(id);
            if (movieDetails == null)
            {
                return View("NotFound");
            }
            return View(movieDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieDetails = await _moviesService.GetByIdAsync(id);
            if (movieDetails == null)
            {
                return View("NotFound");
            }
            await _moviesService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

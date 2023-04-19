using eTickets.Data;
using eTickets.Data.Services.CinemasService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _cinemasService;

        public CinemasController(ICinemasService cinemasService)
        {
            _cinemasService = cinemasService;
        }

        public async Task<IActionResult> Index()
        {
            var cinemas = await _cinemasService.GetAllAsync();
            return View(cinemas);
        }
    }
}

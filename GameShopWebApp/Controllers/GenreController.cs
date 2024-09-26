using GameShopWebApp.Data;
using GameShopWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameShopWebApp.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GenreController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Genre> aListOfGenres = _context.Genres.ToList();

            return View(aListOfGenres);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                _context.Genres.Add(genre);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

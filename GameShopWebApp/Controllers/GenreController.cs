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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            // making custom error message.
            //if (genre.Name == null)
            //{
            //    ModelState.AddModelError("NotInput", "You must fill the genre input field!");
            //}

            if (ModelState.IsValid)
            {
                _context.Genres.Add(genre);
                _context.SaveChanges();
                TempData["success"] = "A new genre has been created successfully.";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }

            Genre? genre = _context.Genres.FirstOrDefault(g => g.Id == id);
            // Different ways to get a record
            //Genre? genre2 = _context.Genres.Find(id);
            //Genre? genre3 = _context.Genres.Where(g => g.Id != id).FirstOrDefault();

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        [HttpPost]
        public IActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {
                _context.Genres.Update(genre);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            Genre? genre = _context.Genres.FirstOrDefault(gen => gen.Id == id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int id)
        {
  
            Genre? genre = _context.Genres.Find(id);
            if(genre == null)
            {
                return NotFound();
            }
            _context.Genres.Remove(genre);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

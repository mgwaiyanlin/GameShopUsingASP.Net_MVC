using GameShopRazorPage.Data;
using GameShopRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameShopRazorPage.Pages.GenrePages
{
    [BindProperties]
    public class UpdateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Genre Genre { get; set; }

        public UpdateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            if (id != 0)
            {
                Genre = _context.Genres.Find(id)!;
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Genres.Update(Genre);
                _context.SaveChanges();
                TempData["success"] = "A new genre has been updated successfully.";
                return RedirectToPage("/GenrePages/Index");
            }
            return Redirect("/GenrePages/Update");
        }
    }
}

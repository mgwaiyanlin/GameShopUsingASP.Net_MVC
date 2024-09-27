using GameShopRazorPage.Data;
using GameShopRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameShopRazorPage.Pages.GenrePages
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        // [BindProperty] // You do not need this if you binded them above the class.
        public Genre Genre { get; set; }
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Genres.Add(Genre);
                _context.SaveChanges();
                TempData["success"] = "A new genre has been created successfully.";
                return RedirectToPage("/GenrePages/Index");
            }
            return Redirect("/GenrePages/Create");
        }
    }
}

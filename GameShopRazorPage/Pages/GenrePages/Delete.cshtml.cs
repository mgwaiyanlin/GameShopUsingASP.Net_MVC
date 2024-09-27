using GameShopRazorPage.Data;
using GameShopRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameShopRazorPage.Pages.GenrePages
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Genre Genre { get; set; }

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Genre = _context.Genres.Find(id)!;
        }

        public IActionResult OnPost(int id)
        {
            Genre = _context.Genres.Find(id)!;
            _context.Genres.Remove(Genre);
            _context.SaveChanges();
            TempData["success"] = "A genre has been deleted successfully.";
            return RedirectToPage("/GenrePages/Index");
        }
    }
}

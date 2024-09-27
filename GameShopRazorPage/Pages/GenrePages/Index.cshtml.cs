using GameShopRazorPage.Data;
using GameShopRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameShopRazorPage.Pages.GenrePages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Genre> genreLists { get; set; }
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            genreLists = _context.Genres.ToList();
        }
    }
}

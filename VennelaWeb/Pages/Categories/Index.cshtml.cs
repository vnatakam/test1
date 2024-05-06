using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VennelaWeb.Data;
using VennelaWeb.Model;

namespace VennelaWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(ApplicationDBContext db)
        {
            _db = db;

        }
        public void OnGet()
        {
            Categories = _db.Category;
        }
    }
}

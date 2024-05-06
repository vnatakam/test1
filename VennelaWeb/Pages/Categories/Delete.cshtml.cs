using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Query;
using VennelaWeb.Data;
using VennelaWeb.Model;

namespace VennelaWeb.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public DeleteModel(ApplicationDBContext db)
        {
            _db = db;

        }
        public void OnGet(int id)
        {
            Category=_db.Category.Find(id);
        }
        public async Task<ActionResult> OnPost()
        {
            var categoryfound = _db.Category.Find(Category.Id);
            if (categoryfound!=null)
            {
                _db.Category.Remove(categoryfound);
                await _db.SaveChangesAsync();

            }
            return RedirectToPage("Index");
        }
    }
}

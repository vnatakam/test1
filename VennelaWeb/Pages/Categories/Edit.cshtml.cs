using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Query;
using VennelaWeb.Data;
using VennelaWeb.Model;

namespace VennelaWeb.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public EditModel(ApplicationDBContext db)
        {
            _db = db;

        }
        public void OnGet(int id)
        {
            Category=_db.Category.Find(id);
        }
        public async Task<ActionResult> OnPost()
        {
            if(ModelState.IsValid) {
                _db.Category.Update(Category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}

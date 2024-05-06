using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Query;
using VennelaWeb.Data;
using VennelaWeb.Model;

namespace VennelaWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(ApplicationDBContext db)
        {
            _db = db;

        }
        public void OnGet()
        {
        }
        public async Task<ActionResult> OnPost()
        {
            if(ModelState.IsValid) {
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}

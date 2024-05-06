using Microsoft.EntityFrameworkCore;
using VennelaWeb.Model;

namespace VennelaWeb.Data
{
    public class ApplicationDBContext: DbContext 
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {

        }
        public DbSet<Category>Category { get; set; } 
    }
}

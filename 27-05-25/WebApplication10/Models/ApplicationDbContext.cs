using System.Data.Entity;

namespace WebApplication10.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }
        public DbSet<product> products { get; set; }
    }
}

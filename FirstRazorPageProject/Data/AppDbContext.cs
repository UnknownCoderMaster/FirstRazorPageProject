using FirstRazorPageProject.Model;
using Microsoft.EntityFrameworkCore;

namespace FirstRazorPageProject.Data
{
	public class AppDbContext : DbContext
	{
        public DbSet<CommentModel> Comments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}

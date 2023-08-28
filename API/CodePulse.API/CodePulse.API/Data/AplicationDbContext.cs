using Microsoft.EntityFrameworkCore;
using CodePulse.API.Models.Domain;
namespace CodePulse.API.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

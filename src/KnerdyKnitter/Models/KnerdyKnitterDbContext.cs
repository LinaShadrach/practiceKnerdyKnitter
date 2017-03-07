using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KnerdyKnitter.Models
{
    public class KnerdyKnitterDbContext : IdentityDbContext<ApplicationUser>
    {
        public KnerdyKnitterDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KnerdyKnitter;integrated security=True");
        }

        public KnerdyKnitterDbContext(DbContextOptions<KnerdyKnitterDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using xiaoPage.Model;
namespace xiaoPage.Data
{
    public class ApplicationDb:DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options):base(options) { }

        public DbSet<Actor> actors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { ID = 1, Name = "Action", Birthday = 1990 },
                new Actor { ID = 2, Name = "history", Birthday = 2000 },
                new Actor { ID = 3, Name = "but", Birthday = 1993 }
                );
        }


    }
}

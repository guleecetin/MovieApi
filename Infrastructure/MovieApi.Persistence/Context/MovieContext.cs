using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;

namespace MovieApi.Persistence.Context
{
    public class MovieContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3K46L5U\\SQLEXPRESS01; inital Catalog=MovieApiDb;integrated Security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Movie> Movies{ get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}

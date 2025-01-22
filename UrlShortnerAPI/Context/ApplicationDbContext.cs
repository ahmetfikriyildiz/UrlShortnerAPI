using Microsoft.EntityFrameworkCore;
using UrlShortnerAPI.Models;

namespace UrlShortnerAPI.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<ShortenedUrl> ShortenedUrls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ShortenedUrl>(builder =>
            {
                


            });



            base.OnModelCreating(modelBuilder);
        }

    }
}

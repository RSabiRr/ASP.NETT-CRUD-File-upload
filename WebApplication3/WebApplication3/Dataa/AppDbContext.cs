using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Dataa
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Partenrs> Partenrs { get; set; }
        public DbSet<Positsion> Positsions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Sosial> Sosials { get; set; }
        public DbSet<Valuation> Valuations { get; set; }


    }
}

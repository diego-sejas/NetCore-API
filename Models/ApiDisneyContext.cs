using Microsoft.EntityFrameworkCore;

namespace WebApi_Disney.Models
{
    public class ApiDisneyContext : DbContext
    {
        public ApiDisneyContext(DbContextOptions<ApiDisneyContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character_Movie>()
                .HasOne(c => c.Character)
                .WithMany(cm => cm.Character_Movies)
                .HasForeignKey(ci => ci.Id);


            modelBuilder.Entity<Character_Movie>()
                .HasOne(b => b.Movie)
                .WithMany(cm => cm.Character_Movies)
                .HasForeignKey(ci => ci.Id);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Character_Movie> Character_movies { get; set; }
        public DbSet<Genere> Generes { get; set; }



    }
}
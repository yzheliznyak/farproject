using FarSolution.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FarSolution.DataAccess
{
    public class VeliDb : DbContext
    {
       public DbSet<ArtworkEntity> Artworks { get; set; }

        public VeliDb() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Vel\farproject\FarSolution\Data\VeliDb.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //for (int i = 1; i < 10; i++)
            //{
            //    modelBuilder.Entity<ArtworkEntity>().HasData(
            //        new ArtworkEntity()
            //        {
            //            Id = i,
            //            Name = $"Painting {i}",
            //            Description = $"some test{i} description."
            //        });

            //}
        }

    }
}

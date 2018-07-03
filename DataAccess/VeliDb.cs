using System.Data.Entity;
using FarSolution.DataAccess.Entities;

namespace FarSolution.DataAccess
{
    public class VeliDb : DbContext
    {
       public DbSet<ArtworkEntity> Artworks { get; set; }

        public VeliDb() : base("VeliContext")
        {
            Database.SetInitializer<VeliDb>(new DropCreateDatabaseIfModelChanges<VeliDb>());
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Configurations.Add(new configuration());

            for (int i = 1; i < 10; i++)
            {
                Artworks.Add(new ArtworkEntity()
                {
                    Id = i,
                    Name = $"Painting {i}",
                    Description = $"some test{i} description."
                });
            }
        }

    }
}

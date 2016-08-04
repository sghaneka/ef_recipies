using EF.DataAccess.EntityTypeConfigurations.Baga_Fluent;
using EF.DataAccess.Models.Baga_Fluent;
using System.Data.Entity;

namespace EF.DataAccess.Contexts
{
    public class BreakAwayContextFluent : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Lodging> Lodgings { get; set; }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("bf");
            modelBuilder.Configurations.Add(new DestinationConfiguration());
            modelBuilder.Configurations.Add(new LodgingConfiguration());
            modelBuilder.Configurations.Add(new TripConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.ComplexType<Address>();
            base.OnModelCreating(modelBuilder);
        }
    }
}

using EF.DataAccess.Models.Baga;
using System.Data.Entity;

namespace EF.DataAccess.Contexts
{
    public class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Lodging> Lodgings { get; set; }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("baga");
            base.OnModelCreating(modelBuilder);
        }
    }
}

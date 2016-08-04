using EF.DataAccess.Models.Poems;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.Contexts
{
    public class PoetryModelContext : DbContext
    {
        public DbSet<Poet> Poets { get; set; }

        public DbSet<Meter> Meters { get; set; }

        public DbSet<Poem> Poems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Poet>()
                .HasMany(x => x.Poems)
                .WithOptional(x => x.Poet)
                .WillCascadeOnDelete(false);
        }
    }
}

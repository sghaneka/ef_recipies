using EF.DataAccess.Models.Albums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.Contexts
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<PictureCategory> PictureCategories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("alb");

            modelBuilder.Entity<PictureCategory>()
                    .HasMany(cat => cat.SubCategories)
                    .WithOptional(cat => cat.ParentCategory);

            base.OnModelCreating(modelBuilder);
        }
    }
}

using EF.DataAccess.Models.Baga_Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.EntityTypeConfigurations.Baga_Fluent
{
    public class TripConfiguration : EntityTypeConfiguration<Trip>
    {
        public TripConfiguration()
        {
            this.HasKey(t => t.Identifier);
            this.Property(t => t.Identifier).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.RowVersion).IsRowVersion();
        }
    }
}

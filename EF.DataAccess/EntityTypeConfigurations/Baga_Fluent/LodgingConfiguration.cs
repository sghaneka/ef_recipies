using EF.DataAccess.Models.Baga_Fluent;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.EntityTypeConfigurations.Baga_Fluent
{
    public class LodgingConfiguration : EntityTypeConfiguration<Lodging>
    {
        public LodgingConfiguration()
        {          
            Property(l => l.Name).IsRequired().HasMaxLength(200);
            Property(l => l.MilesFromNearestAirport).HasPrecision(8, 1);
        }
    }
}

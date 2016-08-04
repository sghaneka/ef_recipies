using EF.DataAccess.Models.Baga_Fluent;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.EntityTypeConfigurations.Baga_Fluent
{
    public class DestinationConfiguration : EntityTypeConfiguration<Destination>
    {
        public DestinationConfiguration()
        {
            Property(d => d.Name).IsRequired();
            Property(d => d.Description).HasMaxLength(500);
            Property(d => d.Photo).HasColumnType("image");
        }
    }
}

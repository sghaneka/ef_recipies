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
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            HasKey(p => p.SocialSecurityNumber).
                Property(p => p.SocialSecurityNumber).
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(p => p.RowVersion).IsRowVersion();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.Models.Baga
{
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SocialSecurityNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Address Address { get; set; }

        public PersonalInfo Info { get; set; }

        [InverseProperty("PrimaryContactFor")]
        public List<Lodging> PrimaryContactFor { get; set; }
        [InverseProperty("SecondaryContactFor")]
        public List<Lodging> SecondaryContactFor { get; set; }

        public Person()
        {
            Address = new Address();
            Info = new PersonalInfo
            {
                Weight = new Measurement(),
                Height = new Measurement()
            };
        }
    }
}

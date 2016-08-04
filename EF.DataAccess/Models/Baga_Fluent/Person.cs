using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.Models.Baga_Fluent
{
    public class Person
    {
        public int SocialSecurityNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte[] RowVersion { get; set; }

        public Address Address { get; set; }
    }
}

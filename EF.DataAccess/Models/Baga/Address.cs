using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.Models.Baga
{
    [ComplexType]
    public class Address
    {
        // For a complex type, we don't want it's id set here...
        //public int AddressId { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
    }
}

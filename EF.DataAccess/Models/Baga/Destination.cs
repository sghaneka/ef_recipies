using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.DataAccess.Models.Baga
{

    public class Destination
    {
        public int DestinationId { get; set; }
        [Required]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Country { get; set; }

        public string Description { get; set; }
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        public List<Lodging> Lodgings { get; set; }
    }
}

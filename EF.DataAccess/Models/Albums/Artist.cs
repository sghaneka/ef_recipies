using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.Models.Albums
{
    public class Artist
    {
        public Artist()
        {
            Albums = new List<Album>();
        }
        public int ArtistId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Album> Albums { get; set; }
    }
}

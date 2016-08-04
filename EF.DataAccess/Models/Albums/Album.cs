using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.Models.Albums
{
    public class Album
    {
        public Album()
        {
            Artists = new List<Artist>();
        }
        public int AlbumId { get; set; }

        public string AlbumName { get; set; }

        public List<Artist> Artists { get; set; }
    }
}

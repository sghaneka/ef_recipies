using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.Models.Poems
{
    public class Meter
    {
        public int MeterId { get; set; }

        public string MeterName { get; set; }

        public List<Poem> Poems { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataAccess.Models.Poems
{
    public class Poet
    {
        public int PoetId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Poem> Poems { get; set; }
    }
}

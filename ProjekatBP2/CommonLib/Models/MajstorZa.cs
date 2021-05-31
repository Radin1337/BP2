using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class MajstorZa
    {
        public long MajstorJMBG;
        public int DeoDEOID;

        public MajstorZa(long majstorJMBG, int deoDEOID)
        {
            MajstorJMBG = majstorJMBG;
            DeoDEOID = deoDEOID;
            Popravljeni = new HashSet<Popravljen>();
        }

        public Majstor Majstor { get; set; }
        public Deo Deo { get; set; }

        public ICollection<Popravljen> Popravljeni { get; set; }
    }
}

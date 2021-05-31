using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Pokvaren
    {
        public long PregledAutomobilSASIJA;
        public long PregledDijagnosticarJMBG;
        public int DeoDEOID;

        public Pokvaren(long pregledAutomobilSASIJA, long pregledDijagnosticarJMBG, int deoDEOID)
        {
            PregledAutomobilSASIJA = pregledAutomobilSASIJA;
            PregledDijagnosticarJMBG = pregledDijagnosticarJMBG;
            DeoDEOID = deoDEOID;
            Popravljeni = new HashSet<Popravljen>();
        }

        public Pregled Pregled { get; set; }
        public Deo Deo { get; set; }

        public ICollection<Popravljen> Popravljeni { get; set; }
    }
}

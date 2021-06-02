using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    [DataContract]
    public class Pokvaren
    {
        [DataMember]
        public long PregledAutomobilSASIJA { get; set; }
        [DataMember]
        public long PregledDijagnosticarJMBG { get; set; }
        [DataMember]
        public int DeoDEOID { get; set; }

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

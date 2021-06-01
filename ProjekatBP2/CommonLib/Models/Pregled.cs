using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    [DataContract]
    public class Pregled
    {
        [DataMember]
        public DateTime DatPre = new DateTime();
        [DataMember]
        public bool Stanje;
        [DataMember]
        public long AutomobilSASIJA;
        [DataMember]
        public long DijagnosticarJMBG;

        public Pregled(long automobilSASIJA, long dijagnosticarJMBG, DateTime datPre, bool stanje)
        {
            DatPre = datPre;
            Stanje = stanje;
            AutomobilSASIJA = automobilSASIJA;
            DijagnosticarJMBG = dijagnosticarJMBG;
            Pokvareni = new HashSet<Pokvaren>();
        }

        public Dijagnosticar Dijagnosticar { get; set; }
        public Automobil Automobil { get; set; }

        public ICollection<Pokvaren> Pokvareni { get; set; }
    }
}

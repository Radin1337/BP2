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
        public DateTime DatPre { get; set; } = new DateTime();
        [DataMember]
        public bool Stanje { get; set; }
        [DataMember]
        public long AutomobilSASIJA { get; set; }
        [DataMember]
        public long DijagnosticarJMBG { get; set; }

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

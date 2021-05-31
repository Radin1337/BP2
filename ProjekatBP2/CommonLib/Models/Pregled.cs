using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Pregled
    {
        public DateTime DatPre = new DateTime();
        public bool Stanje;
        public long AutomobilSASIJA;
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

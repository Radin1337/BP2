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
        public int AutomobilSASIJA;
        public int DijagnosticarSASIJA;

        public Pregled(int automobilSASIJA, int dijagnosticarSASIJA, DateTime datPre, bool stanje)
        {
            DatPre = datPre;
            Stanje = stanje;
            AutomobilSASIJA = automobilSASIJA;
            DijagnosticarSASIJA = dijagnosticarSASIJA;
        }

        public Dijagnosticar Dijagnosticar { get; set }
        public Automobil Automobil { get; set; }
    }
}

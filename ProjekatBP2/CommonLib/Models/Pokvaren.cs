using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Pokvaren
    {
        public int PregledAutomobilSASIJA;
        public int PregledDijagnosticarSASIJA;
        public int DeoDEOID;

        public Pokvaren(int pregledAutomobilSASIJA, int pregledDijagnosticarSASIJA, int deoDEOID)
        {
            PregledAutomobilSASIJA = pregledAutomobilSASIJA;
            PregledDijagnosticarSASIJA = pregledDijagnosticarSASIJA;
            DeoDEOID = deoDEOID;
        }

        public Pregled Pregled { get; set; }
        public Deo Deo { get; set; }
    }
}

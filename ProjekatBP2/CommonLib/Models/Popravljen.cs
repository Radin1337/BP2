using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Popravljen
    {
        public int PokvarenPregledAutomobilSASIJA;
        public int PokvarenPregledDijagnosticarSASIJA;
        public int PokvarenDeoDEOID;
        public int MajstorZaDeoDEOID;
        public int MajstorZaMajstorJMBG;
        public DateTime DatPop = new DateTime();

        public Popravljen(int pokvarenPregledAutomobilSASIJA, int pokvarenPregledDijagnosticarSASIJA, int pokvarenDeoDEOID, int majstorZaDeoDEOID, int majstorZaMajstorJMBG, DateTime datPop)
        {
            PokvarenPregledAutomobilSASIJA = pokvarenPregledAutomobilSASIJA;
            PokvarenPregledDijagnosticarSASIJA = pokvarenPregledDijagnosticarSASIJA;
            PokvarenDeoDEOID = pokvarenDeoDEOID;
            MajstorZaDeoDEOID = majstorZaDeoDEOID;
            MajstorZaMajstorJMBG = majstorZaMajstorJMBG;
            DatPop = datPop;
        }

        public Pokvaren Pokvaren { get; set; }
        public MajstorZa MajstorZa { get; set; }
    }
}

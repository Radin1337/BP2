using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Popravljen
    {
        public long PokvarenPregledAutomobilSASIJA;
        public long PokvarenPregledDijagnosticarJMBG;
        public int PokvarenDeoDEOID;
        public int MajstorZaDeoDEOID;
        public long MajstorZaMajstorJMBG;
        public DateTime DatPop = new DateTime();

        public Popravljen(long pokvarenPregledAutomobilSASIJA, long pokvarenPregledDijagnosticarJMBG, int pokvarenDeoDEOID, int majstorZaDeoDEOID, long majstorZaMajstorJMBG, DateTime datPop)
        {
            PokvarenPregledAutomobilSASIJA = pokvarenPregledAutomobilSASIJA;
            PokvarenPregledDijagnosticarJMBG = pokvarenPregledDijagnosticarJMBG;
            PokvarenDeoDEOID = pokvarenDeoDEOID;
            MajstorZaDeoDEOID = majstorZaDeoDEOID;
            MajstorZaMajstorJMBG = majstorZaMajstorJMBG;
            DatPop = datPop;
        }

        public Pokvaren Pokvaren { get; set; }
        public MajstorZa MajstorZa { get; set; }
    }
}

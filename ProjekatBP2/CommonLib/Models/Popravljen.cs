using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    [DataContract]
    public class Popravljen
    {
        [DataMember]
        public long PokvarenPregledAutomobilSASIJA { get; set; }
        [DataMember]
        public long PokvarenPregledDijagnosticarJMBG { get; set; }
        [DataMember]
        public int PokvarenDeoDEOID { get; set; }
        [DataMember]
        public int MajstorZaDeoDEOID { get; set; }
        [DataMember]
        public long MajstorZaMajstorJMBG { get; set; }
        [DataMember]
        public DateTime DatPop { get; set; } = new DateTime();

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

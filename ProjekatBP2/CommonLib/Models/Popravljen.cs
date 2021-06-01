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
        public long PokvarenPregledAutomobilSASIJA;
        [DataMember]
        public long PokvarenPregledDijagnosticarJMBG;
        [DataMember]
        public int PokvarenDeoDEOID;
        [DataMember]
        public int MajstorZaDeoDEOID;
        [DataMember]
        public long MajstorZaMajstorJMBG;
        [DataMember]
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

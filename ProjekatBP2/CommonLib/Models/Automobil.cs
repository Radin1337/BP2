using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CommonLib.Models
{
    [DataContract]
    public class Automobil
    {
        [DataMember]
        public long SASIJA { get; set; }
        [DataMember]
        public string Marka { get; set; }
        [DataMember]
        public int BrSK { get; set; }
        [DataMember]
        public DateTime DatSK { get; set; } = new DateTime();
        [DataMember]
        public int ServisIDS { get; set; }
        [DataMember]
        public string TipMot { get; set; }

    public Automobil(long sASIJA, string marka, int brSK, DateTime datSK, int servisIDS, string tipMot)
        {
            SASIJA = sASIJA;
            Marka = marka;
            BrSK = brSK;
            DatSK = datSK;
            ServisIDS = servisIDS;
            TipMot = tipMot;
            Pregledi = new HashSet<Pregled>();
        }

        public Servis Servis { get; set; }

        public ICollection<Pregled> Pregledi { get; set; }
    }
}

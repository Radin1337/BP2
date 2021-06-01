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
        public long SASIJA;
        [DataMember]
        public string Marka;
        [DataMember]
        public int BrSK;
        [DataMember]
        public DateTime DatSK = new DateTime();
        [DataMember]
        public int ServisIDS;
        [DataMember]
        public string TipMot;

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

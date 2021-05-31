using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Automobil
    {
        public long SASIJA;
        public string Marka;
        public int BrSK;
        public DateTime DatSK = new DateTime();
        public int ServisIDS;
        public string TipMot;

        public Automobil(long sASIJA, string marka, int brSK, DateTime datSK, int servisIDS, string tipMot="")
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

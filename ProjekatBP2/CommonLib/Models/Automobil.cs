using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Automobil
    {
        public int SASIJA;
        public string Marka;
        public int BrSK;
        public int DatSK;
        public int ServisIDS;
        public string TipMot;

        public Automobil(int sASIJA, string marka, int brSK, int datSK, int servisIDS, string tipMot="")
        {
            SASIJA = sASIJA;
            Marka = marka;
            BrSK = brSK;
            DatSK = datSK;
            ServisIDS = servisIDS;
            TipMot = tipMot;
        }
    }
}

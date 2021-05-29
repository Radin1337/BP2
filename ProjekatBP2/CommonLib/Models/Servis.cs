using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Servis
    {
        public int IDS;
        public string NazivS;
        public Adresa Adresa;
        public string Telefon;

        public Servis(int iDS, string nazivS, Adresa adresa, string telefon)
        {
            IDS = iDS;
            NazivS = nazivS;
            Adresa = adresa;
            Telefon = telefon;
        }
    }
}

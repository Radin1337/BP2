using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Serviser
    {
        public long JMBG;
        public string Ime;
        public string Prezime;
        public string TipServ;
        public int? ServisIDS;

        public Serviser(long jMBG, string ime, string prezime, int? servisIDS, string tipServ)
        {
            JMBG = jMBG;
            Ime = ime;
            Prezime = prezime;
            TipServ = tipServ;
            ServisIDS = servisIDS;
        }

        public Servis Servis { get; set; }
    }
}

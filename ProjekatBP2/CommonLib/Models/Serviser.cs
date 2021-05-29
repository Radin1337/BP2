using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Serviser
    {
        public int JMBG;
        public string Ime;
        public string Prezime;
        public string TipServ;
        public int? ServisIDS;

        public Serviser(int jMBG, string ime, string prezime, int? servisIDS, string tipServ="")
        {
            JMBG = jMBG;
            Ime = ime;
            Prezime = prezime;
            TipServ = tipServ;
            ServisIDS = servisIDS;
        }
    }
}

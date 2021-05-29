using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Dijagnosticar : Serviser
    {
        public Dijagnosticar(int jMBG, string ime, string prezime, int? servisIDS, string tipServ = "") : base(jMBG, ime, prezime, servisIDS, tipServ)
        {
        }
    }
}

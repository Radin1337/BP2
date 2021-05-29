using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Adresa
    {
        public string Mesto;
        public string Ulica;
        public string Broj;

        public Adresa(string m, string u, string b)
        {
            Mesto = m;
            Ulica = u;
            Broj = b;
        }

        public override string ToString()
        {
            return Mesto+"; "+Ulica+"; "+Broj;
        }
    }
}

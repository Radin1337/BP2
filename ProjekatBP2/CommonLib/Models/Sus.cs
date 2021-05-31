using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Sus : Automobil
    {
        public string Gorivo;
        public Sus(string gorivo, int sASIJA, string marka, int brSK, DateTime datSK, int servisIDS, string tipMot = "Sus") : base(sASIJA, marka, brSK, datSK, servisIDS, tipMot)
        {
            Gorivo = gorivo;
        }
    }
}

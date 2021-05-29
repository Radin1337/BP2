using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Elektricni : Automobil
    {
        public int BrMot;
        public Elektricni(int brMot,int sASIJA, string marka, int brSK, int datSK, int servisIDS, string tipMot = "") : base(sASIJA, marka, brSK, datSK, servisIDS, tipMot)
        {
            BrMot = brMot;
        }
    }
}

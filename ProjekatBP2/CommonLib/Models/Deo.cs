using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class Deo
    {
        public int DEOID;
        public string NazivD;

        public Deo(int dEOID, string nazivD)
        {
            DEOID = dEOID;
            NazivD = nazivD;
        }
    }
}

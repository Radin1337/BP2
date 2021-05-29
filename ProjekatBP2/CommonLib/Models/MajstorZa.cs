using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Models
{
    public class MajstorZa
    {
        public int MajstorJMBG;
        public int DeoDEOID;

        public MajstorZa(int majstorJMBG, int deoDEOID)
        {
            MajstorJMBG = majstorJMBG;
            DeoDEOID = deoDEOID;
        }

        public Majstor Majstor { get; set; }
        public Deo Deo { get; set; }
    }
}

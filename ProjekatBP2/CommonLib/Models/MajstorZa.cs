using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CommonLib.Models
{
    [DataContract]
    public class MajstorZa
    {
        [DataMember]
        public long MajstorJMBG { get; set; }
        [DataMember]
        public int DeoDEOID { get; set; }

        public MajstorZa(long majstorJMBG, int deoDEOID)
        {
            MajstorJMBG = majstorJMBG;
            DeoDEOID = deoDEOID;
            Popravljeni = new HashSet<Popravljen>();
        }

        public Majstor Majstor { get; set; }
        public Deo Deo { get; set; }

        public ICollection<Popravljen> Popravljeni { get; set; }
    }
}

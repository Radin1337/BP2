using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CommonLib.Models
{
    [DataContract]
    public class Deo
    {
        [DataMember]
        public int DEOID { get; set; }
        [DataMember]
        public string NazivD { get; set; }

        public Deo(int dEOID, string nazivD)
        {
            DEOID = dEOID;
            NazivD = nazivD;
            Pokvareni = new HashSet<Pokvaren>();
            MajstoriZa = new HashSet<MajstorZa>();
        }

        public ICollection<Pokvaren> Pokvareni { get; set; }
        public ICollection<MajstorZa> MajstoriZa { get; set; }
    }
}

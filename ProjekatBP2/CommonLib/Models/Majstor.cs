using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CommonLib.Models
{
    [DataContract]
    public class Majstor : Serviser
    {
        public Majstor(long jMBG, string ime, string prezime, int? servisIDS, string tipServ = "Majstor") : base(jMBG, ime, prezime, servisIDS, tipServ)
        {
            MajstorZa = new HashSet<MajstorZa>();
        }

        public ICollection<MajstorZa> MajstorZa {get;set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CommonLib.Models
{
    [DataContract]
    public class Dijagnosticar : Serviser
    {
        public Dijagnosticar(long jMBG, string ime, string prezime, int? servisIDS, string tipServ = "Dijagnosticar") : base(jMBG, ime, prezime, servisIDS, tipServ)
        {
            Pregledi = new HashSet<Pregled>();
        }

        public ICollection<Pregled> Pregledi { get; set; }
    }
}

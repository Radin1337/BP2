using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CommonLib.Models
{
    [DataContract]
    public class Servis
    {
        [DataMember]
        public int IDS { get; set; }
        [DataMember]
        public string NazivS { get; set; }
        [DataMember]
        public string Adresa { get; set; }
        [DataMember]
        public string Telefon { get; set; }

        public Servis(int iDS, string nazivS, Adresa adresa, string telefon)
        {
            IDS = iDS;
            NazivS = nazivS;
            Adresa = adresa.ToString();
            Telefon = telefon;
            Automobili = new HashSet<Automobil>();
            Serviseri = new HashSet<Serviser>();
        }

        public ICollection<Automobil> Automobili { get; set; }
        public ICollection<Serviser> Serviseri { get; set; }

    }
}

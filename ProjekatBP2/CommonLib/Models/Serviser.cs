using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CommonLib.Models
{
    [DataContract]
    public class Serviser
    {
        [DataMember]
        public long JMBG { get; set; }
        [DataMember]
        public string Ime { get; set; }
        [DataMember]
        public string Prezime { get; set; }
        [DataMember]
        public string TipServ { get; set; }
        [DataMember]
        public int? ServisIDS { get; set; }

        public Serviser(long jMBG, string ime, string prezime, int? servisIDS, string tipServ)
        {
            JMBG = jMBG;
            Ime = ime;
            Prezime = prezime;
            TipServ = tipServ;
            ServisIDS = servisIDS;
        }

        public Servis Servis { get; set; }
    }
}

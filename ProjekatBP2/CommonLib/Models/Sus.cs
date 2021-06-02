using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CommonLib.Models
{
    [DataContract]
    public class Sus : Automobil
    {
        [DataMember]
        public string Gorivo { get; set; }
        public Sus(string gorivo, long sASIJA, string marka, int brSK, DateTime datSK, int servisIDS, string tipMot = "Sus") : base(sASIJA, marka, brSK, datSK, servisIDS, tipMot)
        {
            Gorivo = gorivo;
        }
    }
}

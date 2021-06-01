using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CommonLib.Models
{
    [DataContract]
    public class Elektricni : Automobil
    {
        [DataMember]
        public int BrMot;
        public Elektricni(int brMot,long sASIJA, string marka, int brSK, DateTime datSK, int servisIDS, string tipMot = "Elektricni") : base(sASIJA, marka, brSK, datSK, servisIDS, tipMot)
        {
            BrMot = brMot;
        }
    }
}

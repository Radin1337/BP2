using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CommonLib.Models;

namespace CommonLib.Interfaces
{
    [ServiceContract]
    public interface IDodaj
    {
        [OperationContract]
        void DodajServis(Servis s);
        [OperationContract]
        void DodajServisera(Serviser s);
        [OperationContract]
        void DodajMajstora(Majstor m);
        [OperationContract]
        void DodajDijagnosticara(Dijagnosticar d);
        [OperationContract]
        void DodajAutomobil(Automobil a);
        [OperationContract]
        void DodajSus(Sus s);
        [OperationContract]
        void DodajElektricni(Elektricni e);
        [OperationContract]
        void DodajPregled(Pregled p);
        [OperationContract]
        void DodajPokvaren(Pokvaren p);
        [OperationContract]
        void DodajDeo(Deo d);
        [OperationContract]
        void DodajPopravljen(Popravljen p);
        [OperationContract]
        void DodajMajstoraZa(MajstorZa m);
    }
}

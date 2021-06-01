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
        bool DodajServis(Servis s);
        [OperationContract]
        bool DodajServisera(Serviser s);
        [OperationContract]
        bool DodajMajstora(Majstor m);
        [OperationContract]
        bool DodajDijagnosticara(Dijagnosticar d);
        [OperationContract]
        bool DodajAutomobil(Automobil a);
        [OperationContract]
        bool DodajSus(Sus s);
        [OperationContract]
        bool DodajElektricni(Elektricni e);
        [OperationContract]
        bool DodajPregled(Pregled p);
        [OperationContract]
        bool DodajPokvaren(Pokvaren p);
        [OperationContract]
        bool DodajDeo(Deo d);
        [OperationContract]
        bool DodajPopravljen(Popravljen p);
        [OperationContract]
        bool DodajMajstoraZa(MajstorZa m);
    }
}

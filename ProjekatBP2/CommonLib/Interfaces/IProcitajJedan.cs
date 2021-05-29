using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CommonLib.Models;

namespace CommonLib.Interfaces
{
    public interface IProcitajJedan
    {
        [OperationContract]
        void ProcitajServis(Servis s);
        [OperationContract]
        void ProcitajServisera(Serviser s);
        [OperationContract]
        void ProcitajMajstora(Majstor m);
        [OperationContract]
        void ProcitajDijagnosticara(Dijagnosticar d);
        [OperationContract]
        void ProcitajAutomobil(Automobil a);
        [OperationContract]
        void ProcitajSus(Sus s);
        [OperationContract]
        void ProcitajElektricni(Elektricni e);
        [OperationContract]
        void ProcitajPregled(Pregled p);
        [OperationContract]
        void ProcitajPokvaren(Pokvaren p);
        [OperationContract]
        void ProcitajDeo(Deo d);
        [OperationContract]
        void ProcitajPopravljen(Popravljen p);
        [OperationContract]
        void ProcitajMajstoraZa(MajstorZa m);
    }
}

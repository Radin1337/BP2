using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CommonLib.Models;
namespace CommonLib.Interfaces
{
    public interface IProcitajSve
    {
        [OperationContract]
        IEnumerable<Servis> ProcitajSveServis();
        [OperationContract]
        IEnumerable<Serviser> ProcitajSveServisera();
        [OperationContract]
        IEnumerable<Majstor> ProcitajSveMajstora();
        [OperationContract]
        IEnumerable<Dijagnosticar> ProcitajSveDijagnosticara();
        [OperationContract]
        IEnumerable<Automobil> ProcitajSveAutomobil();
        [OperationContract]
        IEnumerable<Sus> ProcitajSveSus();
        [OperationContract]
        IEnumerable<Elektricni> ProcitajSveElektricni();
        [OperationContract]
        IEnumerable<Pregled> ProcitajSvePregled();
        [OperationContract]
        IEnumerable<Pokvaren> ProcitajSvePokvaren();
        [OperationContract]
        IEnumerable<Deo> ProcitajSveDeo();
        [OperationContract]
        IEnumerable<Popravljen> ProcitajSvePopravljen();
        [OperationContract]
        IEnumerable<MajstorZa> ProcitajSveMajstoraZa();
    }
}

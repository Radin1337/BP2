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
    public interface IProcitajJedan
    {
        [OperationContract]
        Servis ProcitajServis(int ids);
        [OperationContract]
        Serviser ProcitajServisera(long jmbg);
        [OperationContract]
        Majstor ProcitajMajstora(long jmbg);
        [OperationContract]
        Dijagnosticar ProcitajDijagnosticara(long jmbg);
        [OperationContract]
        Automobil ProcitajAutomobil(long sasija);
        [OperationContract]
        Sus ProcitajSus(long sasija);
        [OperationContract]
        Elektricni ProcitajElektricni(long sasija);
        [OperationContract]
        Pregled ProcitajPregled(long sasija, long jmbg);
        [OperationContract]
        Pokvaren ProcitajPokvaren(long sasija, long jmbg,int deoid);
        [OperationContract]
        Deo ProcitajDeo(int deoid);
        [OperationContract]
        Popravljen ProcitajPopravljen(long sasija, long jmbg, int deoid,long jmbgg, int deoidd);
        [OperationContract]
        MajstorZa ProcitajMajstoraZa(long jmbg, int deoid);
    }
}

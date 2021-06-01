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
    public interface IIzmeni
    {
        [OperationContract]
        bool IzmeniServis(Servis s);
        [OperationContract]
        bool IzmeniServisera(Serviser s);
        [OperationContract]
        bool IzmeniMajstora(Majstor m);
        [OperationContract]
        bool IzmeniDijagnosticara(Dijagnosticar d);
        [OperationContract]
        bool IzmeniAutomobil(Automobil a);
        [OperationContract]
        bool IzmeniSus(Sus s);
        [OperationContract]
        bool IzmeniElektricni(Elektricni e);
        [OperationContract]
        bool IzmeniPregled(Pregled p);
        [OperationContract]
        bool IzmeniPokvaren(Pokvaren p);
        [OperationContract]
        bool IzmeniDeo(Deo d);
        [OperationContract]
        bool IzmeniPopravljen(Popravljen p);
        [OperationContract]
        bool IzmeniMajstoraZa(MajstorZa m);
    }
}

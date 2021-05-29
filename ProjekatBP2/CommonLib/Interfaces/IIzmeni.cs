using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CommonLib.Models;

namespace CommonLib.Interfaces
{
    public interface IIzmeni
    {
        [OperationContract]
        void IzmeniServis(Servis s);
        [OperationContract]
        void IzmeniServisera(Serviser s);
        [OperationContract]
        void IzmeniMajstora(Majstor m);
        [OperationContract]
        void IzmeniDijagnosticara(Dijagnosticar d);
        [OperationContract]
        void IzmeniAutomobil(Automobil a);
        [OperationContract]
        void IzmeniSus(Sus s);
        [OperationContract]
        void IzmeniElektricni(Elektricni e);
        [OperationContract]
        void IzmeniPregled(Pregled p);
        [OperationContract]
        void IzmeniPokvaren(Pokvaren p);
        [OperationContract]
        void IzmeniDeo(Deo d);
        [OperationContract]
        void IzmeniPopravljen(Popravljen p);
        [OperationContract]
        void IzmeniMajstoraZa(MajstorZa m);
    }
}

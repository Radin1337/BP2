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
    public interface IObrisi
    {
        [OperationContract]
        void ObrisiServis(Servis s);
        [OperationContract]
        void ObrisiServisera(Serviser s);
        [OperationContract]
        void ObrisiMajstora(Majstor m);
        [OperationContract]
        void ObrisiDijagnosticara(Dijagnosticar d);
        [OperationContract]
        void ObrisiAutomobil(Automobil a);
        [OperationContract]
        void ObrisiSus(Sus s);
        [OperationContract]
        void ObrisiElektricni(Elektricni e);
        [OperationContract]
        void ObrisiPregled(Pregled p);
        [OperationContract]
        void ObrisiPokvaren(Pokvaren p);
        [OperationContract]
        void ObrisiDeo(Deo d);
        [OperationContract]
        void ObrisiPopravljen(Popravljen p);
        [OperationContract]
        void ObrisiMajstoraZa(MajstorZa m);
    }
}

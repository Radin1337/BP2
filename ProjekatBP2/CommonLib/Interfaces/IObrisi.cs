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
        void ObrisiServis(int ids);
        [OperationContract]
        void ObrisiServisera(long jmbg);
        [OperationContract]
        void ObrisiMajstora(long jmbg);
        [OperationContract]
        void ObrisiDijagnosticara(long jmbg);
        [OperationContract]
        void ObrisiAutomobil(long sasija);
        [OperationContract]
        void ObrisiSus(long sasija);
        [OperationContract]
        void ObrisiElektricni(long sasija);
        [OperationContract]
        void ObrisiPregled(long sasija, long jmbg);
        [OperationContract]
        void ObrisiPokvaren(long sasija, long jmbg, int deoid);
        [OperationContract]
        void ObrisiDeo(int deoid);
        [OperationContract]
        void ObrisiPopravljen(long sasija, long jmbg, int deoid, long jmbgg, long deoidd);
        [OperationContract]
        void ObrisiMajstoraZa(long jmbg, int deoid);
    }
}

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
        bool ObrisiServis(int ids);
        [OperationContract]
        bool ObrisiServisera(long jmbg);
        [OperationContract]
        bool ObrisiMajstora(long jmbg);
        [OperationContract]
        bool ObrisiDijagnosticara(long jmbg);
        [OperationContract]
        bool ObrisiAutomobil(long sasija);
        [OperationContract]
        bool ObrisiSus(long sasija);
        [OperationContract]
        bool ObrisiElektricni(long sasija);
        [OperationContract]
        bool ObrisiPregled(long sasija, long jmbg);
        [OperationContract]
        bool ObrisiPokvaren(long sasija, long jmbg, int deoid);
        [OperationContract]
        bool ObrisiDeo(int deoid);
        [OperationContract]
        bool ObrisiPopravljen(long sasija, long jmbg, int deoid, long jmbgg, int deoidd);
        [OperationContract]
        bool ObrisiMajstoraZa(long jmbg, int deoid);
    }
}

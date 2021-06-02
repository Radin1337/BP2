using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLib.Interfaces;
using CommonLib.Models;
using System.ServiceModel;

namespace Client
{
    public sealed class ServiceProvider : ISveOp
    {
        public static ServiceProvider Instance { get; } = new ServiceProvider();
        private ISveOp proxy;

        private ServiceProvider()
        {
            proxy = new ChannelFactory<ISveOp>("Client").CreateChannel();
        }

        public bool DodajAutomobil(Automobil a)
        {
            return proxy.DodajAutomobil(a);
        }

        public bool DodajDeo(Deo d)
        {
            return proxy.DodajDeo(d);
        }

        public bool DodajDijagnosticara(Dijagnosticar d)
        {
            return proxy.DodajDijagnosticara(d);
        }

        public bool DodajElektricni(Elektricni e)
        {
            return proxy.DodajElektricni(e);
        }

        public bool DodajMajstora(Majstor m)
        {
            return proxy.DodajMajstora(m);
        }

        public bool DodajMajstoraZa(MajstorZa m)
        {
            return proxy.DodajMajstoraZa(m);
        }

        public bool DodajPokvaren(Pokvaren p)
        {
            return proxy.DodajPokvaren(p);
        }

        public bool DodajPopravljen(Popravljen p)
        {
            return proxy.DodajPopravljen(p);
        }

        public bool DodajPregled(Pregled p)
        {
            return proxy.DodajPregled(p);
        }

        public bool DodajServis(Servis s)
        {
            return proxy.DodajServis(s);
        }

        public bool DodajServisera(Serviser s)
        {
            return proxy.DodajServisera(s);
        }

        public bool DodajSus(Sus s)
        {
            return proxy.DodajSus(s);
        }

        public bool IzmeniAutomobil(Automobil a)
        {
            return proxy.IzmeniAutomobil(a);
        }

        public bool IzmeniDeo(Deo d)
        {
            return proxy.IzmeniDeo(d);
        }

        public bool IzmeniDijagnosticara(Dijagnosticar d)
        {
            return proxy.IzmeniDijagnosticara(d);
        }

        public bool IzmeniElektricni(Elektricni e)
        {
            return proxy.IzmeniElektricni(e);
        }

        public bool IzmeniMajstora(Majstor m)
        {
            return proxy.IzmeniMajstora(m);
        }

        public bool IzmeniMajstoraZa(MajstorZa m)
        {
            return proxy.IzmeniMajstoraZa(m);
        }

        public bool IzmeniPokvaren(Pokvaren p)
        {
            return proxy.IzmeniPokvaren(p);
        }

        public bool IzmeniPopravljen(Popravljen p)
        {
            return proxy.IzmeniPopravljen(p);
        }

        public bool IzmeniPregled(Pregled p)
        {
            return proxy.IzmeniPregled(p);
        }

        public bool IzmeniServis(Servis s)
        {
            return proxy.IzmeniServis(s);
        }

        public bool IzmeniServisera(Serviser s)
        {
            return proxy.IzmeniServisera(s);
        }

        public bool IzmeniSus(Sus s)
        {
            return proxy.IzmeniSus(s);
        }

        public bool ObrisiAutomobil(long sasija)
        {
            return proxy.ObrisiAutomobil(sasija);
        }

        public bool ObrisiDeo(int deoid)
        {
            return proxy.ObrisiDeo(deoid);
        }

        public bool ObrisiDijagnosticara(long jmbg)
        {
            return proxy.ObrisiDijagnosticara(jmbg);
        }

        public bool ObrisiElektricni(long sasija)
        {
            return proxy.ObrisiElektricni(sasija);
        }

        public bool ObrisiMajstora(long jmbg)
        {
            return proxy.ObrisiMajstora(jmbg);
        }

        public bool ObrisiMajstoraZa(long jmbg, int deoid)
        {
            return proxy.ObrisiMajstoraZa(jmbg, deoid);
        }

        public bool ObrisiPokvaren(long sasija, long jmbg, int deoid)
        {
            return proxy.ObrisiPokvaren(sasija, jmbg, deoid);
        }

        public bool ObrisiPopravljen(long sasija, long jmbg, int deoid, long jmbgg, int deoidd)
        {
            return proxy.ObrisiPopravljen(sasija, jmbg, deoid, jmbgg, deoidd);
        }

        public bool ObrisiPregled(long sasija, long jmbg)
        {
            return proxy.ObrisiPregled(sasija, jmbg);
        }

        public bool ObrisiServis(int ids)
        {
            return proxy.ObrisiServis(ids);
        }

        public bool ObrisiServisera(long jmbg)
        {
            return proxy.ObrisiServisera(jmbg);
        }

        public bool ObrisiSus(long sasija)
        {
            return proxy.ObrisiSus(sasija);
        }

        public Automobil ProcitajAutomobil(long sasija)
        {
            return proxy.ProcitajAutomobil(sasija);
        }

        public Deo ProcitajDeo(int deoid)
        {
            return proxy.ProcitajDeo(deoid);
        }

        public Dijagnosticar ProcitajDijagnosticara(long jmbg)
        {
            return proxy.ProcitajDijagnosticara(jmbg);
        }

        public Elektricni ProcitajElektricni(long sasija)
        {
            return proxy.ProcitajElektricni(sasija);
        }

        public Majstor ProcitajMajstora(long jmbg)
        {
            return proxy.ProcitajMajstora(jmbg);
        }

        public MajstorZa ProcitajMajstoraZa(long jmbg, int deoid)
        {
            return proxy.ProcitajMajstoraZa(jmbg, deoid);
        }

        public Pokvaren ProcitajPokvaren(long sasija, long jmbg, int deoid)
        {
            return proxy.ProcitajPokvaren(sasija, jmbg, deoid);
        }

        public Popravljen ProcitajPopravljen(long sasija, long jmbg, int deoid, long jmbgg, int deoidd)
        {
            return proxy.ProcitajPopravljen(sasija, jmbg, deoid, jmbgg, deoidd);
        }

        public Pregled ProcitajPregled(long sasija, long jmbg)
        {
            return proxy.ProcitajPregled(sasija, jmbg);
        }

        public Servis ProcitajServis(int ids)
        {
            return proxy.ProcitajServis(ids);
        }

        public Serviser ProcitajServisera(long jmbg)
        {
            return proxy.ProcitajServisera(jmbg);
        }

        public Sus ProcitajSus(long sasija)
        {
            return proxy.ProcitajSus(sasija);
        }

        public IEnumerable<Automobil> ProcitajSveAutomobil()
        {
            return proxy.ProcitajSveAutomobil();
        }

        public IEnumerable<Deo> ProcitajSveDeo()
        {
            return proxy.ProcitajSveDeo();
        }

        public IEnumerable<Dijagnosticar> ProcitajSveDijagnosticara()
        {
            return proxy.ProcitajSveDijagnosticara();
        }

        public IEnumerable<Elektricni> ProcitajSveElektricni()
        {
            return proxy.ProcitajSveElektricni();
        }

        public IEnumerable<Majstor> ProcitajSveMajstora()
        {
            return proxy.ProcitajSveMajstora();
        }

        public IEnumerable<MajstorZa> ProcitajSveMajstoraZa()
        {
            return proxy.ProcitajSveMajstoraZa();
        }

        public IEnumerable<Pokvaren> ProcitajSvePokvaren()
        {
            return proxy.ProcitajSvePokvaren();
        }

        public IEnumerable<Popravljen> ProcitajSvePopravljen()
        {
            return proxy.ProcitajSvePopravljen();
        }

        public IEnumerable<Pregled> ProcitajSvePregled()
        {
            return proxy.ProcitajSvePregled();
        }

        public IEnumerable<Servis> ProcitajSveServis()
        {
            return proxy.ProcitajSveServis();
        }

        public IEnumerable<Serviser> ProcitajSveServisera()
        {
            return proxy.ProcitajSveServisera();
        }

        public IEnumerable<Sus> ProcitajSveSus()
        {
            return proxy.ProcitajSveSus();
        }
    }
}

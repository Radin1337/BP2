using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatBP2.Managers;
using CommonLib.Interfaces;

namespace ProjekatBP2.Services
{
    public class SveOperacije:ISveOp
    {
        ManageCRUD mc = new ManageCRUD(new ServisDBMFContainer());

        #region Dodavanje
        public bool DodajAutomobil(CommonLib.Models.Automobil a)
        {
            return mc.AutomobilCRUD.Dodaj(a);
        }

        public bool DodajDeo(CommonLib.Models.Deo d)
        {
            return mc.DeoCRUD.Dodaj(d);
        }

        public bool DodajDijagnosticara(CommonLib.Models.Dijagnosticar d)
        {
            return mc.ServiserCRUD.Dodaj(d);
        }

        public bool DodajElektricni(CommonLib.Models.Elektricni e)
        {
            return mc.AutomobilCRUD.Dodaj(e);
        }

        public bool DodajMajstora(CommonLib.Models.Majstor m)
        {
            return mc.ServiserCRUD.Dodaj(m);
        }

        public bool DodajMajstoraZa(CommonLib.Models.MajstorZa m)
        {
            return mc.MajstorZaCRUD.Dodaj(m);
        }

        public bool DodajPokvaren(CommonLib.Models.Pokvaren p)
        {
            return mc.PokvarenCRUD.Dodaj(p);
        }

        public bool DodajPopravljen(CommonLib.Models.Popravljen p)
        {
            return mc.PopravljenCRUD.Dodaj(p);
        }

        public bool DodajPregled(CommonLib.Models.Pregled p)
        {
            return mc.PregledCRUD.Dodaj(p);
        }

        public bool DodajServis(CommonLib.Models.Servis s)
        {
            return mc.ServisCRUD.Dodaj(s);
        }

        public bool DodajServisera(CommonLib.Models.Serviser s)
        {
            return mc.ServiserCRUD.Dodaj(s);
        }

        public bool DodajSus(CommonLib.Models.Sus s)
        {
            return mc.AutomobilCRUD.Dodaj(s);
        }
        #endregion

        #region Izmena
        public bool IzmeniAutomobil(CommonLib.Models.Automobil a)
        {
            return mc.AutomobilCRUD.Izmeni(a);
        }

        public bool IzmeniDeo(CommonLib.Models.Deo d)
        {
            return mc.DeoCRUD.Izmeni(d);
        }

        public bool IzmeniDijagnosticara(CommonLib.Models.Dijagnosticar d)
        {
            return mc.ServiserCRUD.Izmeni(d);
        }

        public bool IzmeniElektricni(CommonLib.Models.Elektricni e)
        {
            return mc.AutomobilCRUD.Izmeni(e);
        }

        public bool IzmeniMajstora(CommonLib.Models.Majstor m)
        {
            return mc.ServiserCRUD.Izmeni(m);
        }

        public bool IzmeniMajstoraZa(CommonLib.Models.MajstorZa m)
        {
            return mc.MajstorZaCRUD.Izmeni(m);
        }

        public bool IzmeniPokvaren(CommonLib.Models.Pokvaren p)
        {
            return mc.PokvarenCRUD.Izmeni(p);
        }

        public bool IzmeniPopravljen(CommonLib.Models.Popravljen p)
        {
            return mc.PopravljenCRUD.Izmeni(p);
        }

        public bool IzmeniPregled(CommonLib.Models.Pregled p)
        {
            return mc.PregledCRUD.Izmeni(p);
        }

        public bool IzmeniServis(CommonLib.Models.Servis s)
        {
            return mc.ServisCRUD.Izmeni(s);
        }

        public bool IzmeniServisera(CommonLib.Models.Serviser s)
        {
            return mc.ServiserCRUD.Izmeni(s);
        }

        public bool IzmeniSus(CommonLib.Models.Sus s)
        {
            return mc.AutomobilCRUD.Izmeni(s);
        }
        #endregion

        #region Brisanje
        public bool ObrisiAutomobil(long sasija)
        {
            return mc.AutomobilCRUD.Obrisi(sasija);
        }

        public bool ObrisiDeo(int deoid)
        {
            return mc.DeoCRUD.Obrisi(deoid);
        }

        public bool ObrisiDijagnosticara(long jmbg)
        {
            return mc.ServiserCRUD.Obrisi(jmbg);
        }

        public bool ObrisiElektricni(long sasija)
        {
            return mc.AutomobilCRUD.Obrisi(sasija);
        }

        public bool ObrisiMajstora(long jmbg)
        {
            return mc.ServiserCRUD.Obrisi(jmbg);
        }

        public bool ObrisiMajstoraZa(long jmbg, int deoid)
        {
            return mc.MajstorZaCRUD.Obrisi(jmbg, deoid);
        }

        public bool ObrisiPokvaren(long sasija, long jmbg, int deoid)
        {
            return mc.PokvarenCRUD.Obrisi(sasija, jmbg, deoid);
        }

        public bool ObrisiPopravljen(long sasija, long jmbg, int deoid, long jmbgg, int deoidd)
        {
            return mc.PopravljenCRUD.Obrisi(sasija, jmbg, deoid, jmbgg, deoidd);
        }

        public bool ObrisiPregled(long sasija, long jmbg)
        {
            return mc.PregledCRUD.Obrisi(sasija,jmbg);
        }

        public bool ObrisiServis(int ids)
        {
            return mc.ServisCRUD.Obrisi(ids);
        }

        public bool ObrisiServisera(long jmbg)
        {
            return mc.ServiserCRUD.Obrisi(jmbg);
        }

        public bool ObrisiSus(long sasija)
        {
            return mc.AutomobilCRUD.Obrisi(sasija);
        }

        #endregion

        #region CitanjeJednog
        public CommonLib.Models.Automobil ProcitajAutomobil(long sasija)
        {
            return mc.AutomobilCRUD.Procitaj(sasija);
        }

        public CommonLib.Models.Deo ProcitajDeo(int deoid)
        {
            return mc.DeoCRUD.Procitaj(deoid);
        }

        public CommonLib.Models.Dijagnosticar ProcitajDijagnosticara(long jmbg)
        {
            return (CommonLib.Models.Dijagnosticar)mc.ServiserCRUD.Procitaj(jmbg);
        }

        public CommonLib.Models.Elektricni ProcitajElektricni(long sasija)
        {
            return (CommonLib.Models.Elektricni)mc.AutomobilCRUD.Procitaj(sasija);
        }

        public CommonLib.Models.Majstor ProcitajMajstora(long jmbg)
        {
            return (CommonLib.Models.Majstor)mc.ServiserCRUD.Procitaj(jmbg);
        }

        public CommonLib.Models.MajstorZa ProcitajMajstoraZa(long jmbg, int deoid)
        {
            return mc.MajstorZaCRUD.Procitaj(jmbg, deoid);
        }

        public CommonLib.Models.Pokvaren ProcitajPokvaren(long sasija, long jmbg, int deoid)
        {
            return mc.PokvarenCRUD.Procitaj(sasija, jmbg, deoid);
        }

        public CommonLib.Models.Popravljen ProcitajPopravljen(long sasija, long jmbg, int deoid, long jmbgg, int deoidd)
        {
            return mc.PopravljenCRUD.Procitaj(sasija, jmbg, deoid, jmbgg, deoidd);
        }

        public CommonLib.Models.Pregled ProcitajPregled(long sasija, long jmbg)
        {
            return mc.PregledCRUD.Procitaj(sasija, jmbg);
        }

        public CommonLib.Models.Servis ProcitajServis(int ids)
        {
            return mc.ServisCRUD.Procitaj(ids);
        }

        public CommonLib.Models.Serviser ProcitajServisera(long jmbg)
        {
            return mc.ServiserCRUD.Procitaj(jmbg);
        }

        public CommonLib.Models.Sus ProcitajSus(long sasija)
        {
            return (CommonLib.Models.Sus)mc.AutomobilCRUD.Procitaj(sasija);
        }
        #endregion

        #region CitanjeSvih
        public IEnumerable<CommonLib.Models.Automobil> ProcitajSveAutomobil()
        {
            return mc.AutomobilCRUD.ProcitajSve();
        }

        public IEnumerable<CommonLib.Models.Deo> ProcitajSveDeo()
        {
            return mc.DeoCRUD.ProcitajSve();
        }

        public IEnumerable<CommonLib.Models.Dijagnosticar> ProcitajSveDijagnosticara()
        {
            IEnumerable<CommonLib.Models.Serviser> s = mc.ServiserCRUD.ProcitajSve().Where(x => x.TipServ.Equals("Dijagnosticar"));
            HashSet<CommonLib.Models.Dijagnosticar> d = new HashSet<CommonLib.Models.Dijagnosticar>();
            foreach(var item in s)
            {
                d.Add(new CommonLib.Models.Dijagnosticar(item.JMBG, item.Ime, item.Prezime, item.ServisIDS, item.TipServ));
            }
            return d;
        }

        public IEnumerable<CommonLib.Models.Elektricni> ProcitajSveElektricni()
        {
            IEnumerable<CommonLib.Models.Automobil> a = mc.AutomobilCRUD.ProcitajSve().Where(x => x.TipMot.Equals("Elektricni"));
            HashSet<CommonLib.Models.Elektricni> e = new HashSet<CommonLib.Models.Elektricni>();
            foreach (var item in a)
            {
                var temp = (CommonLib.Models.Elektricni)item;
                e.Add(new CommonLib.Models.Elektricni(temp.BrMot, temp.SASIJA, temp.Marka, temp.BrSK, temp.DatSK, temp.ServisIDS, temp.TipMot));
            }
            return e;
            
        }

        public IEnumerable<CommonLib.Models.Majstor> ProcitajSveMajstora()
        {
            IEnumerable<CommonLib.Models.Serviser> s = mc.ServiserCRUD.ProcitajSve().Where(x => x.TipServ.Equals("Majstor"));
            HashSet<CommonLib.Models.Majstor> m = new HashSet<CommonLib.Models.Majstor>();
            foreach (var item in s)
            {
                m.Add(new CommonLib.Models.Majstor(item.JMBG, item.Ime, item.Prezime, item.ServisIDS, item.TipServ));
            }
            return m;
        }

        public IEnumerable<CommonLib.Models.MajstorZa> ProcitajSveMajstoraZa()
        {
            return mc.MajstorZaCRUD.ProcitajSve();
        }

        public IEnumerable<CommonLib.Models.Pokvaren> ProcitajSvePokvaren()
        {
            return mc.PokvarenCRUD.ProcitajSve();
        }

        public IEnumerable<CommonLib.Models.Popravljen> ProcitajSvePopravljen()
        {
            return mc.PopravljenCRUD.ProcitajSve();
        }

        public IEnumerable<CommonLib.Models.Pregled> ProcitajSvePregled()
        {
            return mc.PregledCRUD.ProcitajSve();
        }

        public IEnumerable<CommonLib.Models.Servis> ProcitajSveServis()
        {
            return mc.ServisCRUD.ProcitajSve();
        }

        public IEnumerable<CommonLib.Models.Serviser> ProcitajSveServisera()
        {
            return mc.ServiserCRUD.ProcitajSve();
        }

        public IEnumerable<CommonLib.Models.Sus> ProcitajSveSus()
        {
            IEnumerable<CommonLib.Models.Automobil> a = mc.AutomobilCRUD.ProcitajSve().Where(x => x.TipMot.Equals("Sus"));
            HashSet<CommonLib.Models.Sus> s = new HashSet<CommonLib.Models.Sus>();
            foreach (var item in a)
            {
                var temp = (CommonLib.Models.Sus)item;
                s.Add(new CommonLib.Models.Sus(temp.Gorivo, temp.SASIJA, temp.Marka, temp.BrSK, temp.DatSK, temp.ServisIDS, temp.TipMot));
            }
            return s;
        }

        #endregion
    }
}

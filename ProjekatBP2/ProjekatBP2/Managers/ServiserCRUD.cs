using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBP2.Managers
{
    public class ServiserCRUD
    {
        private readonly ServisDBMFContainer dbContext;

        public ServiserCRUD(ServisDBMFContainer db)
        {
            dbContext = db;
        }

        public bool Dodaj(CommonLib.Models.Serviser serviser)
        {
            if (dbContext.Servisers.FirstOrDefault(x => x.JMBG.Equals(serviser.JMBG)) != null)
            {
                return false;
            }

            if (serviser.TipServ == "Dijagnosticar")
            {
                dbContext.Servisers.Add(new Dijagnosticar()
                {
                    JMBG = serviser.JMBG,
                    Ime = serviser.Ime,
                    Prezime = serviser.Prezime,
                    ServisIDS = serviser.ServisIDS,
                    TipServ = serviser.TipServ
                });
            }
            else
            {
                dbContext.Servisers.Add(new Majstor()
                {
                    JMBG = serviser.JMBG,
                    Ime = serviser.Ime,
                    Prezime = serviser.Prezime,
                    ServisIDS = serviser.ServisIDS,
                    TipServ = serviser.TipServ
                });
            }
            

            return dbContext.SaveChanges() > 0;
        }

        public bool Obrisi(long jmbg)
        {
            Serviser s = dbContext.Servisers.FirstOrDefault(x => x.JMBG.Equals(jmbg));
            if (s == null)
            {
                return false;
            }
            dbContext.Servisers.Remove(s);
            dbContext.SaveChanges();
            return true;
        }

        public bool Izmeni(CommonLib.Models.Serviser serviser)
        {
            Serviser s;
            if ((s = dbContext.Servisers.FirstOrDefault(x => x.JMBG.Equals(serviser.JMBG))) == null)
            {
                return false;
            }

            dbContext.Entry(s).CurrentValues.SetValues(new Serviser()
            {
                JMBG = serviser.JMBG,
                Ime = serviser.Ime,
                Prezime = serviser.Prezime,
                ServisIDS = serviser.ServisIDS,
                TipServ = serviser.TipServ
            });

            dbContext.SaveChanges();
            return true;
        }

        public CommonLib.Models.Serviser Procitaj(long jmbg)
        {
            Serviser s;
            if ((s = dbContext.Servisers.FirstOrDefault(x => x.JMBG.Equals(jmbg))) == null)
            {
                return null;
            }

            if(s.TipServ == "Dijagnosticar")
                return new CommonLib.Models.Dijagnosticar(jmbg, s.Ime, s.Prezime, s.ServisIDS, s.TipServ);
            else if(s.TipServ == "Majstor")
                return new CommonLib.Models.Majstor(jmbg, s.Ime,s.Prezime,s.ServisIDS, s.TipServ);
            else
                return new CommonLib.Models.Serviser(jmbg, s.Ime, s.Prezime, s.ServisIDS, s.TipServ);
        }

        public IEnumerable<CommonLib.Models.Serviser> ProcitajSve()
        {
            HashSet<CommonLib.Models.Serviser> serviseri = new HashSet<CommonLib.Models.Serviser>();

            foreach (Serviser s in dbContext.Servisers)
            {
                serviseri.Add(new CommonLib.Models.Serviser(s.JMBG, s.Ime, s.Prezime, s.ServisIDS, s.TipServ));
            }
            return serviseri;
        }

        ~ServiserCRUD()
        {
            dbContext.Dispose();
        }
    }
}

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
            if (!dbContext.Servisers.FirstOrDefault(x => x.JMBG.Equals(serviser.JMBG)).Equals(null))
            {
                return false;
            }

            dbContext.Servisers.Add(new Serviser()
            {
                JMBG = serviser.JMBG,
                Ime = serviser.Ime,
                Prezime = serviser.Prezime,
                ServisIDS = serviser.ServisIDS,
                TipServ = serviser.TipServ
            });

            return dbContext.SaveChanges() > 0;
        }

        public bool Obrisi(long jmbg)
        {
            Serviser s = dbContext.Servisers.FirstOrDefault(x => x.JMBG.Equals(jmbg));
            if (s.Equals(null))
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
            if ((s = dbContext.Servisers.FirstOrDefault(x => x.JMBG.Equals(serviser.JMBG))).Equals(null))
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
            if ((s = dbContext.Servisers.FirstOrDefault(x => x.JMBG.Equals(jmbg))).Equals(null))
            {
                return null;
            }

            return new CommonLib.Models.Serviser(jmbg, s.Ime,s.Prezime,s.ServisIDS, s.TipServ);
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

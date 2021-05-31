using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBP2.Managers
{
    public class ServisCRUD
    {
        private readonly ServisDBMFContainer dbContext;

        public ServisCRUD(ServisDBMFContainer db)
        {
            dbContext = db;
        }

        public bool Dodaj (CommonLib.Models.Servis servis)
        {
            if(!dbContext.Servis.FirstOrDefault(x => x.IDS.Equals(servis.IDS)).Equals(null))
            {
                return false;
            }

            dbContext.Servis.Add(new Servis()
            {
                IDS = servis.IDS,
                Adresa = servis.Adresa,
                NazivS = servis.NazivS,
                Telefon = servis.Telefon,
            });
            
            return dbContext.SaveChanges() > 0;
        }

        public bool Obrisi(int ids)
        {
            Servis s = dbContext.Servis.FirstOrDefault(x => x.IDS.Equals(ids));
            if (s.Equals(null))
            {
                return false;
            }
            dbContext.Servis.Remove(s);
            dbContext.SaveChanges();
            return true;
        }

        public bool Izmeni(CommonLib.Models.Servis servis)
        {
            Servis s;
            if((s = dbContext.Servis.FirstOrDefault(x => x.IDS.Equals(servis.IDS))).Equals(null))
            {
                return false;
            }

            dbContext.Entry(s).CurrentValues.SetValues(new Servis()
            {
                IDS = servis.IDS,
                Adresa = servis.Adresa,
                NazivS = servis.NazivS,
                Telefon = servis.Telefon,
            });

            dbContext.SaveChanges();
            return true;
        }

        public CommonLib.Models.Servis Procitaj(int ids)
        {
            Servis s;
            if ((s = dbContext.Servis.FirstOrDefault(x => x.IDS.Equals(ids))).Equals(null))
            {
                return null;
            }

            string[] adr = s.Adresa.Split(';');
            return new CommonLib.Models.Servis(ids, s.NazivS, new CommonLib.Models.Adresa(adr[0], adr[1], adr[2]), s.Telefon);
        }

        public IEnumerable<CommonLib.Models.Servis> ProcitajSve()
        {
            HashSet<CommonLib.Models.Servis> servisi = new HashSet<CommonLib.Models.Servis>();
            foreach(Servis s in dbContext.Servis)
            {
                string[] adr = s.Adresa.Split(';');
                servisi.Add(new CommonLib.Models.Servis(s.IDS, s.NazivS, new CommonLib.Models.Adresa(adr[0], adr[1], adr[2]), s.Telefon));
            }
            return servisi;
        }

        ~ServisCRUD()
        {
            dbContext.Dispose();
        }
    }
}

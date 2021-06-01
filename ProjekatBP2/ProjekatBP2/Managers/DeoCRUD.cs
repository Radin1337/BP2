using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBP2.Managers
{
    public class DeoCRUD
    {
        private readonly ServisDBMFContainer dbContext;

        public DeoCRUD(ServisDBMFContainer db)
        {
            dbContext = db;
        }

        public bool Dodaj(CommonLib.Models.Deo deo)
        {
            if(dbContext.Deos.FirstOrDefault(x=> x.DEOID.Equals(deo.DEOID)) != null)
            {
                return false;
            }

            dbContext.Deos.Add(new Deo()
            {
                DEOID = deo.DEOID,
                NazivD = deo.NazivD
            });

            return dbContext.SaveChanges() > 0;
        }

        public bool Obrisi(int deoid)
        {
            Deo d = dbContext.Deos.FirstOrDefault(x => x.DEOID.Equals(deoid));
            if (d == null)
                return false;

            dbContext.Deos.Remove(d);
            dbContext.SaveChanges();

            return true;
        }

        public bool Izmeni(CommonLib.Models.Deo deo)
        {
            Deo d;
            if ((d = dbContext.Deos.FirstOrDefault(x => x.DEOID.Equals(deo.DEOID))) ==null)
                return false;

            dbContext.Entry(d).CurrentValues.SetValues(new Deo()
            {
                DEOID = deo.DEOID,
                NazivD = deo.NazivD
            });

            dbContext.SaveChanges();

            return true;
        }

        public CommonLib.Models.Deo Procitaj(int deoid)
        {
            Deo d;
            if ((d = dbContext.Deos.FirstOrDefault(x => x.DEOID.Equals(deoid))) == null)
                return null;

            return new CommonLib.Models.Deo(deoid, d.NazivD);
        }

        public IEnumerable<CommonLib.Models.Deo> ProcitajSve()
        {
            HashSet<CommonLib.Models.Deo> delovi = new HashSet<CommonLib.Models.Deo>();
            foreach(Deo d in dbContext.Deos)
            {
                delovi.Add(new CommonLib.Models.Deo(d.DEOID, d.NazivD));
            }


            return delovi;
        }

        ~DeoCRUD()
        {
            dbContext.Dispose();
        }

    }
}

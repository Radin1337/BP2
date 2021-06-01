using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBP2.Managers
{
    public class MajstorZaCRUD
    {
        private readonly ServisDBMFContainer dbContext;

        public MajstorZaCRUD(ServisDBMFContainer db)
        {
            dbContext = db;
        }

        public bool Dodaj(CommonLib.Models.MajstorZa mz)
        {
            if (dbContext.MajstorZas.FirstOrDefault(x => x.DeoDEOID.Equals(mz.DeoDEOID) && x.MajstorJMBG.Equals(mz.MajstorJMBG)) != null)
                return false;

            dbContext.MajstorZas.Add(new MajstorZa()
            {
                DeoDEOID = mz.DeoDEOID,
                MajstorJMBG = mz.MajstorJMBG
            });

            return dbContext.SaveChanges() > 0;
        }

        public bool Obrisi(long jmbg, int deoid)
        {
            MajstorZa m = dbContext.MajstorZas.FirstOrDefault(x => x.DeoDEOID.Equals(deoid) && x.MajstorJMBG.Equals(jmbg));
            if (m == null)
            {
                return false;
            }

            dbContext.MajstorZas.Remove(m);
            dbContext.SaveChanges();


            return true;
        }
        
        public bool Izmeni(CommonLib.Models.MajstorZa mz)
        {
            MajstorZa m = dbContext.MajstorZas.FirstOrDefault(x => x.DeoDEOID.Equals(mz.DeoDEOID) && x.MajstorJMBG.Equals(mz.MajstorJMBG));
            if (m == null)
                return false;

            dbContext.Entry(m).CurrentValues.SetValues(new MajstorZa()
            {
                DeoDEOID = mz.DeoDEOID,
                MajstorJMBG = mz.MajstorJMBG
            });

            dbContext.SaveChanges();
            return true;
        }

        public CommonLib.Models.MajstorZa Procitaj(long jmbg, int deoid)
        {
            MajstorZa m = dbContext.MajstorZas.FirstOrDefault(x => x.DeoDEOID.Equals(deoid) && x.MajstorJMBG.Equals(jmbg));
            if (m == null)
                return null;

            return new CommonLib.Models.MajstorZa(jmbg, deoid);
        }

        public IEnumerable<CommonLib.Models.MajstorZa> ProcitajSve()
        {
            HashSet<CommonLib.Models.MajstorZa> majstori = new HashSet<CommonLib.Models.MajstorZa>();

            foreach(MajstorZa m in dbContext.MajstorZas)
            {
                majstori.Add(new CommonLib.Models.MajstorZa(m.MajstorJMBG, m.DeoDEOID));
            }
            return majstori;
        }


        ~MajstorZaCRUD()
        {
            dbContext.Dispose();
        }

    }
}

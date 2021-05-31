using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBP2.Managers
{
    public class PregledCRUD
    {
        private readonly ServisDBMFContainer dbContext;

        public PregledCRUD(ServisDBMFContainer db)
        {
            dbContext = db;
        }

        public bool Dodaj(CommonLib.Models.Pregled p)
        {
            if(!dbContext.Pregleds.FirstOrDefault(x=> x.DijagnosticarJMBG.Equals(p.DijagnosticarJMBG) && x.AutomobilSASIJA.Equals(p.AutomobilSASIJA)).Equals(null))
                return false;

            dbContext.Pregleds.Add(new Pregled()
            {
                DatPre = p.DatPre,
                DijagnosticarJMBG = p.DijagnosticarJMBG,
                AutomobilSASIJA = p.AutomobilSASIJA,
                Stanje = p.Stanje
            });

            return dbContext.SaveChanges() > 0;
        }

        public bool Obrisi(long sasija, long jmbg)
        {
            Pregled p = dbContext.Pregleds.FirstOrDefault(x => x.DijagnosticarJMBG.Equals(jmbg) && x.AutomobilSASIJA.Equals(sasija));
            if (p.Equals(null))
                return false;

            dbContext.Pregleds.Remove(p);
            dbContext.SaveChanges();

            return true;
        }

        public bool Izmeni(CommonLib.Models.Pregled pregled)
        {
            Pregled p;

            if ((p = dbContext.Pregleds.FirstOrDefault(x => x.DijagnosticarJMBG.Equals(pregled.DijagnosticarJMBG) && x.AutomobilSASIJA.Equals(pregled.AutomobilSASIJA))).Equals(null))
                return false;

            dbContext.Entry(p).CurrentValues.SetValues(new Pregled()
            {
                DatPre = pregled.DatPre,
                DijagnosticarJMBG = pregled.DijagnosticarJMBG,
                AutomobilSASIJA = pregled.AutomobilSASIJA,
                Stanje = pregled.Stanje
            });
            dbContext.SaveChanges();

            return true;
        }

        public CommonLib.Models.Pregled Procitaj(long sasija, long jmbg)
        {
            Pregled p;
            if ((p = dbContext.Pregleds.FirstOrDefault(x => x.DijagnosticarJMBG.Equals(jmbg) && x.AutomobilSASIJA.Equals(sasija))).Equals(null))
                return null;

            return new CommonLib.Models.Pregled(sasija, jmbg, p.DatPre, p.Stanje);
        }

        public IEnumerable<CommonLib.Models.Pregled> ProcitajSve()
        {
            HashSet<CommonLib.Models.Pregled> pregledi = new HashSet<CommonLib.Models.Pregled>();

            foreach(Pregled p in dbContext.Pregleds)
            {
                pregledi.Add(new CommonLib.Models.Pregled(p.AutomobilSASIJA, p.DijagnosticarJMBG, p.DatPre, p.Stanje));
            }

            return pregledi;
        }


        ~PregledCRUD()
        {
            dbContext.Dispose();
        }
    }
}

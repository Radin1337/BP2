using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBP2.Managers
{
    public class PokvarenCRUD
    {
        private readonly ServisDBMFContainer dbContext;

        public PokvarenCRUD(ServisDBMFContainer db)
        {
            dbContext = db;
        }

        public bool Dodaj(CommonLib.Models.Pokvaren pok)
        {
            if (dbContext.Pokvarens.FirstOrDefault(x=> x.DeoDEOID.Equals(pok.DeoDEOID) &&
                                                        x.PregledAutomobilSASIJA.Equals(pok.PregledAutomobilSASIJA) &&
                                                        x.PregledDijagnosticarJMBG.Equals(pok.PregledDijagnosticarJMBG)) != null)
                return false;

            dbContext.Pokvarens.Add(new Pokvaren()
            {
                DeoDEOID = pok.DeoDEOID,
                PregledAutomobilSASIJA = pok.PregledAutomobilSASIJA,
                PregledDijagnosticarJMBG = pok.PregledDijagnosticarJMBG
            });

            return dbContext.SaveChanges() > 0;
        }

        public bool Obrisi(long sasija, long jmbg, int deoid)
        {
            Pokvaren p = dbContext.Pokvarens.FirstOrDefault(x => x.DeoDEOID.Equals(deoid) &&
                                                        x.PregledAutomobilSASIJA.Equals(sasija) &&
                                                        x.PregledDijagnosticarJMBG.Equals(jmbg));
            if (p == null)
                return false;

            dbContext.Pokvarens.Remove(p);
            dbContext.SaveChanges();

            return true;
        }

        public bool Izmeni(CommonLib.Models.Pokvaren pok)
        {
            Pokvaren p = dbContext.Pokvarens.FirstOrDefault(x => x.DeoDEOID.Equals(pok.DeoDEOID) &&
                                                        x.PregledAutomobilSASIJA.Equals(pok.PregledAutomobilSASIJA) &&
                                                        x.PregledDijagnosticarJMBG.Equals(pok.PregledDijagnosticarJMBG));
            if (p == null)
                return false;

            dbContext.Entry(p).CurrentValues.SetValues(new Pokvaren()
            {
                DeoDEOID = pok.DeoDEOID,
                PregledAutomobilSASIJA = pok.PregledAutomobilSASIJA,
                PregledDijagnosticarJMBG = pok.PregledDijagnosticarJMBG
            });
            dbContext.SaveChanges();

            return true;
        }


        public CommonLib.Models.Pokvaren Procitaj(long sasija, long jmbg, int deoid)
        {
            Pokvaren p = dbContext.Pokvarens.FirstOrDefault(x => x.DeoDEOID.Equals(deoid) &&
                                                        x.PregledAutomobilSASIJA.Equals(sasija) &&
                                                        x.PregledDijagnosticarJMBG.Equals(jmbg));

            if (p == null)
                return null;



            return new CommonLib.Models.Pokvaren(sasija,jmbg,deoid);
        }

        public IEnumerable<CommonLib.Models.Pokvaren> ProcitajSve()
        {
            HashSet<CommonLib.Models.Pokvaren> pokvareni = new HashSet<CommonLib.Models.Pokvaren>();
            foreach(Pokvaren p in dbContext.Pokvarens)
            {
                pokvareni.Add(new CommonLib.Models.Pokvaren(p.PregledAutomobilSASIJA, p.PregledDijagnosticarJMBG, p.DeoDEOID));
            }

            return pokvareni;
        }


        ~PokvarenCRUD()
        {
            dbContext.Dispose();
        }
    }
}

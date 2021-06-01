using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBP2.Managers
{
    public class PopravljenCRUD
    {
        private readonly ServisDBMFContainer dbContext;

        public PopravljenCRUD(ServisDBMFContainer db)
        {
            dbContext = db;
        }

        public bool Dodaj(CommonLib.Models.Popravljen pop)
        {
            if (dbContext.Popravljens.FirstOrDefault(x=> x.MajstorZaDeoDEOID.Equals(pop.MajstorZaDeoDEOID) &&
                                                          x.MajstorZaMajstorJMBG.Equals(pop.MajstorZaMajstorJMBG) &&
                                                          x.PokvarenPregledAutomobilSASIJA.Equals(pop.PokvarenPregledAutomobilSASIJA) &&
                                                          x.PokvarenPregledDijagnosticarJMBG.Equals(pop.PokvarenPregledDijagnosticarJMBG) &&
                                                          x.PokvarenDeoDEOID.Equals(pop.PokvarenDeoDEOID)
                                                          ) != null)
                return false;

            dbContext.Popravljens.Add(new Popravljen()
            {
                DatPop = pop.DatPop,
                MajstorZaDeoDEOID = pop.MajstorZaDeoDEOID,
                MajstorZaMajstorJMBG = pop.MajstorZaMajstorJMBG,
                PokvarenPregledAutomobilSASIJA = pop.PokvarenPregledAutomobilSASIJA,
                PokvarenPregledDijagnosticarJMBG = pop.PokvarenPregledDijagnosticarJMBG,
                PokvarenDeoDEOID = pop.PokvarenDeoDEOID
            });

            return dbContext.SaveChanges() > 0;
        }

        public bool Obrisi(long sasija, long jmbg, int deoid, long jmbgg, int deoidd)
        {
            Popravljen p = dbContext.Popravljens.FirstOrDefault(x => x.MajstorZaDeoDEOID.Equals(deoidd) &&
                                                          x.MajstorZaMajstorJMBG.Equals(jmbgg) &&
                                                          x.PokvarenPregledAutomobilSASIJA.Equals(sasija) &&
                                                          x.PokvarenPregledDijagnosticarJMBG.Equals(jmbg) &&
                                                          x.PokvarenDeoDEOID.Equals(deoid)
                                                          );

            if (p == null)
                return false;

            dbContext.Popravljens.Remove(p);
            dbContext.SaveChanges();

            return true;
        }

        public bool Izmeni(CommonLib.Models.Popravljen pop)
        {
            Popravljen p = dbContext.Popravljens.FirstOrDefault(x => x.MajstorZaDeoDEOID.Equals(pop.MajstorZaDeoDEOID) &&
                                                          x.MajstorZaMajstorJMBG.Equals(pop.MajstorZaMajstorJMBG) &&
                                                          x.PokvarenPregledAutomobilSASIJA.Equals(pop.PokvarenPregledAutomobilSASIJA) &&
                                                          x.PokvarenPregledDijagnosticarJMBG.Equals(pop.PokvarenPregledDijagnosticarJMBG) &&
                                                          x.PokvarenDeoDEOID.Equals(pop.PokvarenDeoDEOID)
                                                          );

            if (p == null)
            {
                return false;
            }

            dbContext.Entry(p).CurrentValues.SetValues(new Popravljen()
            {
                DatPop = pop.DatPop,
                MajstorZaDeoDEOID = pop.MajstorZaDeoDEOID,
                MajstorZaMajstorJMBG = pop.MajstorZaMajstorJMBG,
                PokvarenPregledAutomobilSASIJA = pop.PokvarenPregledAutomobilSASIJA,
                PokvarenPregledDijagnosticarJMBG = pop.PokvarenPregledDijagnosticarJMBG,
                PokvarenDeoDEOID = pop.PokvarenDeoDEOID
            });
            dbContext.SaveChanges();

            return true;
        }

        public CommonLib.Models.Popravljen Procitaj(long sasija, long jmbg, int deoid, long jmbgg, int deoidd)
        {
            Popravljen p = dbContext.Popravljens.FirstOrDefault(x => x.MajstorZaDeoDEOID.Equals(deoidd) &&
                                                          x.MajstorZaMajstorJMBG.Equals(jmbgg) &&
                                                          x.PokvarenPregledAutomobilSASIJA.Equals(sasija) &&
                                                          x.PokvarenPregledDijagnosticarJMBG.Equals(jmbg) &&
                                                          x.PokvarenDeoDEOID.Equals(deoid)
                                                          );

            if (p == null)
                return null;

            return new CommonLib.Models.Popravljen(sasija, jmbg, deoid, deoidd, jmbgg, p.DatPop);
        }

        public IEnumerable<CommonLib.Models.Popravljen> ProcitajSve()
        {
            HashSet<CommonLib.Models.Popravljen> popravljeni = new HashSet<CommonLib.Models.Popravljen>();

            foreach(Popravljen p in dbContext.Popravljens)
            {
                popravljeni.Add(new CommonLib.Models.Popravljen(p.PokvarenPregledAutomobilSASIJA,
                                                                p.PokvarenPregledDijagnosticarJMBG,
                                                                p.PokvarenDeoDEOID,
                                                                p.MajstorZaDeoDEOID,
                                                                p.MajstorZaMajstorJMBG,
                                                                p.DatPop));
            }
            return popravljeni;
        }



        ~PopravljenCRUD()
        {
            dbContext.Dispose();
        }
    }
}

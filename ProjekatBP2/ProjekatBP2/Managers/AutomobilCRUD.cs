using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBP2.Managers
{
    public class AutomobilCRUD
    {
        private readonly ServisDBMFContainer dbContext;

        public AutomobilCRUD(ServisDBMFContainer db)
        {
            dbContext = db;
        }

        public bool Dodaj(CommonLib.Models.Automobil automobil)
        {
            if (dbContext.Automobils.FirstOrDefault(x => x.SASIJA.Equals(automobil.SASIJA)) != null)
            {
                return false;
            }

            if (automobil.TipMot == "Elektricni")
                dbContext.Automobils.Add(new Elektricni()
                {
                    SASIJA = automobil.SASIJA,
                    Marka = automobil.Marka,
                    BrSK = automobil.BrSK,
                    DatSK = automobil.DatSK,
                    TipMot = automobil.TipMot,
                    ServisIDS = automobil.ServisIDS,
                    BrMot = ((CommonLib.Models.Elektricni)automobil).BrMot
                });
            else
            {
                dbContext.Automobils.Add(new Sus()
                {
                    SASIJA = automobil.SASIJA,
                    Marka = automobil.Marka,
                    BrSK = automobil.BrSK,
                    DatSK = automobil.DatSK,
                    TipMot = automobil.TipMot,
                    ServisIDS = automobil.ServisIDS,
                    Gorivo = ((CommonLib.Models.Sus)automobil).Gorivo
                });
            }

            return dbContext.SaveChanges() > 0;
        }

        public bool Obrisi(long sasija)
        {
            Automobil a = dbContext.Automobils.FirstOrDefault(x => x.SASIJA.Equals(sasija));
            if (a == null)
            {
                return false;
            }

            dbContext.Automobils.Remove(a);
            dbContext.SaveChanges();
            return true;
        }

        public bool Izmeni(CommonLib.Models.Automobil automobil)
        {
            Automobil a;
            if((a = dbContext.Automobils.FirstOrDefault(x => x.SASIJA.Equals(automobil.SASIJA))) == null)
            {
                return false;
            }

            dbContext.Entry(a).CurrentValues.SetValues(new Automobil()
            {
                SASIJA = automobil.SASIJA,
                Marka = automobil.Marka,
                BrSK = automobil.BrSK,
                DatSK = automobil.DatSK,
                TipMot = automobil.TipMot,
                ServisIDS = automobil.ServisIDS
            });

            dbContext.SaveChanges();
            return true;
        }

        public CommonLib.Models.Automobil Procitaj(long sasija)
        {
            Automobil a;
            if ((a = dbContext.Automobils.FirstOrDefault(x => x.SASIJA.Equals(sasija))) == null)
            {
                return null;
            }

            if(a.TipMot == "Elektricni")
            {
                return new CommonLib.Models.Elektricni(((Elektricni)a).BrMot, sasija, a.Marka, a.BrSK, a.DatSK, a.ServisIDS, a.TipMot);
            }
            else if(a.TipMot == "Sus")
            {
                return new CommonLib.Models.Sus(((Sus)a).Gorivo, sasija, a.Marka, a.BrSK, a.DatSK, a.ServisIDS, a.TipMot);
            }
            else
            {
                return new CommonLib.Models.Automobil(sasija, a.Marka, a.BrSK, a.DatSK, a.ServisIDS, a.TipMot);
            }
        }

        public IEnumerable<CommonLib.Models.Automobil> ProcitajSve()
        {
            HashSet<CommonLib.Models.Automobil> automobili = new HashSet<CommonLib.Models.Automobil>();
            foreach(Automobil a in dbContext.Automobils)
            {
                if (a.TipMot == "Elektricni")
                {
                    automobili.Add(new CommonLib.Models.Elektricni(((Elektricni)a).BrMot, a.SASIJA, a.Marka, a.BrSK, a.DatSK, a.ServisIDS, a.TipMot));
                }
                else
                {
                    automobili.Add(new CommonLib.Models.Sus(((Sus)a).Gorivo, a.SASIJA, a.Marka, a.BrSK, a.DatSK, a.ServisIDS, a.TipMot));
                }
                
            }

            return automobili;
        }

        ~AutomobilCRUD()
        {
            dbContext.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatBP2.Services;
using CommonLib.Models;
using System.ServiceModel;

namespace ProjekatBP2
{
    class Program
    {
        private static ServiceHost svcHost;
        static void Main(string[] args)
        {
            /*SveOperacije server = new SveOperacije();
            var temp = server.ProcitajSveAutomobil();
            foreach(var item in temp)
            {
                Console.WriteLine(item.Marka);
            }
            return;*/

            using (svcHost = new ServiceHost(typeof(SveOperacije)))
            {
                svcHost.Open();
                Console.WriteLine("Server is up and running...");
                Console.WriteLine("Press any key to shutdown.");
                Console.ReadKey();
                svcHost.Close();
            }

            //test test test

            /*SveOperacije server = new SveOperacije(); 
            CommonLib.Models.Servis teslaServis = new CommonLib.Models.Servis(0, "Tesla", new Adresa("Kikinda", "Djure Jaksica", "3"), "061/213-22-32");
            CommonLib.Models.Servis fordServis = new CommonLib.Models.Servis(0, "Ford", new Adresa("Zrenjanin", "Kralja Aleksandra", "123"), "069/213-22-32");
            CommonLib.Models.Serviser d1 = new CommonLib.Models.Dijagnosticar(1210998850140, "Aleksej", "Tovilovic",1);
            CommonLib.Models.Serviser d2 = new CommonLib.Models.Dijagnosticar(1210998340140, "Ivan", "Gajic", 2);
            CommonLib.Models.Serviser m1 = new CommonLib.Models.Majstor(1210912302140, "Miroslav", "Radin", 1);
            CommonLib.Models.Serviser m2 = new CommonLib.Models.Majstor(1210998812340, "Branko", "Radin", 2);
            CommonLib.Models.Automobil ae1 = new CommonLib.Models.Elektricni(2, 12345, "Tesla Model X", 111, DateTime.Now, 1);
            CommonLib.Models.Automobil ae2 = new CommonLib.Models.Elektricni(1, 12245, "Tesla Model Y", 112, DateTime.Now, 1);
            CommonLib.Models.Automobil as3 = new CommonLib.Models.Sus("Dizel", 17245, "Ford Escort TD", 113, DateTime.Now, 2);
            CommonLib.Models.Automobil as4 = new CommonLib.Models.Sus("Benzin", 18245, "Ford Mustang", 114, DateTime.Now, 2);
            CommonLib.Models.Pregled p1 = new CommonLib.Models.Pregled(12345, 1210998850140, DateTime.Now, false);
            CommonLib.Models.Pregled p2 = new CommonLib.Models.Pregled(12245, 1210998850140, DateTime.Now, false);
            CommonLib.Models.Pregled p3 = new CommonLib.Models.Pregled(17245, 1210998340140, DateTime.Now, false);
            CommonLib.Models.Pregled p4 = new CommonLib.Models.Pregled(18245, 1210998340140, DateTime.Now, false);
            CommonLib.Models.Deo deo1 = new CommonLib.Models.Deo(0, "Alnaser");
            CommonLib.Models.Deo deo2 = new CommonLib.Models.Deo(0, "Akumulator");
            CommonLib.Models.Deo deo3 = new CommonLib.Models.Deo(0, "Multimedija");
            CommonLib.Models.Deo deo4 = new CommonLib.Models.Deo(0, "Kocnica");
            CommonLib.Models.Pokvaren pok1 = new CommonLib.Models.Pokvaren(12345, 1210998850140, 3);
            CommonLib.Models.Pokvaren pok2 = new CommonLib.Models.Pokvaren(12245, 1210998850140, 4);
            CommonLib.Models.Pokvaren pok3 = new CommonLib.Models.Pokvaren(17245, 1210998340140, 1);
            CommonLib.Models.Pokvaren pok4 = new CommonLib.Models.Pokvaren(18245, 1210998340140, 2);
            CommonLib.Models.MajstorZa mz1 = new CommonLib.Models.MajstorZa(1210912302140, 3);
            CommonLib.Models.MajstorZa mz2 = new CommonLib.Models.MajstorZa(1210912302140, 4);
            CommonLib.Models.MajstorZa mz3 = new CommonLib.Models.MajstorZa(1210998812340, 1);
            CommonLib.Models.MajstorZa mz4 = new CommonLib.Models.MajstorZa(1210998812340, 2);
            CommonLib.Models.Popravljen pop1 = new CommonLib.Models.Popravljen(pok1.PregledAutomobilSASIJA, pok1.PregledDijagnosticarJMBG, pok1.DeoDEOID, mz1.DeoDEOID,mz1.MajstorJMBG, DateTime.Now);
            CommonLib.Models.Popravljen pop2 = new CommonLib.Models.Popravljen(pok2.PregledAutomobilSASIJA, pok2.PregledDijagnosticarJMBG, pok2.DeoDEOID, mz2.DeoDEOID,mz2.MajstorJMBG, DateTime.Now);
            CommonLib.Models.Popravljen pop3 = new CommonLib.Models.Popravljen(pok3.PregledAutomobilSASIJA, pok3.PregledDijagnosticarJMBG, pok3.DeoDEOID, mz3.DeoDEOID,mz3.MajstorJMBG, DateTime.Now);
            CommonLib.Models.Popravljen pop4 = new CommonLib.Models.Popravljen(pok4.PregledAutomobilSASIJA, pok4.PregledDijagnosticarJMBG, pok4.DeoDEOID, mz4.DeoDEOID,mz4.MajstorJMBG, DateTime.Now);
            

            server.DodajServis(teslaServis);
            server.DodajServis(fordServis);
            server.DodajServisera(d1);
            server.DodajServisera(d2);
            server.DodajServisera(m1);
            server.DodajServisera(m2);
            server.DodajAutomobil(ae1);
            server.DodajAutomobil(ae2);
            server.DodajAutomobil(as3);
            server.DodajAutomobil(as4);
            server.DodajPregled(p1);
            server.DodajPregled(p2);
            server.DodajPregled(p3);
            server.DodajPregled(p4);
            server.DodajDeo(deo1);
            server.DodajDeo(deo2);
            server.DodajDeo(deo3);
            server.DodajDeo(deo4);
            server.DodajPokvaren(pok1);
            server.DodajPokvaren(pok2);
            server.DodajPokvaren(pok3);
            server.DodajPokvaren(pok4);
            server.DodajMajstoraZa(mz1);
            server.DodajMajstoraZa(mz2);
            server.DodajMajstoraZa(mz3);
            server.DodajMajstoraZa(mz4);
            server.DodajPopravljen(pop1);
            server.DodajPopravljen(pop2);*/

        }
    }
}

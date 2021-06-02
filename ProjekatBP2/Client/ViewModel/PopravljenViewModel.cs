using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommonLib.Models;
using System.Windows;

namespace Client.ViewModel
{
    public class PopravljenViewModel:BindableBase
    {
        public ObservableCollection<Popravljen> Popravljeni { get; set; } = new ObservableCollection<Popravljen>();



        public ObservableCollection<Automobil> a { get; set; } = new ObservableCollection<Automobil>();
        public ObservableCollection<Dijagnosticar> d { get; set; } = new ObservableCollection<Dijagnosticar>();
        public ObservableCollection<Majstor> m { get; set; } = new ObservableCollection<Majstor>();
        public ObservableCollection<Deo> de { get; set; } = new ObservableCollection<Deo>();

        public ObservableCollection<long> Sasije { get; set; } = new ObservableCollection<long>();
        public ObservableCollection<long> Dijag { get; set; } = new ObservableCollection<long>();
        public ObservableCollection<long> Majstori { get; set; } = new ObservableCollection<long>();
        public ObservableCollection<int> MDeoID { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<int> PDeoID { get; set; } = new ObservableCollection<int>();


        private Popravljen izabran;
        private bool radioDodaj;
        private bool radioIzmeni;
        private bool radioObrisi;
        private bool firstPick;
        private bool onStart = true;
        public Popravljen Upamti { get; private set; } = new Popravljen(0, 0, 0,0,0,DateTime.Now);

        public MyICommand KomandaIzvrsi { get; set; }
        public bool RadioDodaj { get => radioDodaj; set { radioDodaj = value; OnPropertyChanged("RadioDodaj"); if (!radioDodaj || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioIzmeni { get => radioIzmeni; set { radioIzmeni = value; OnPropertyChanged("RadioIzmeni"); if (!radioIzmeni || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioObrisi { get => radioObrisi; set { radioObrisi = value; OnPropertyChanged("RadioObrisi"); if (!radioObrisi || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public Popravljen Izabran
        {
            get => izabran; set
            {
                if (izabran != null)
                {
                    izabran.PokvarenPregledAutomobilSASIJA = Upamti.PokvarenPregledAutomobilSASIJA;
                    izabran.PokvarenPregledDijagnosticarJMBG = Upamti.PokvarenPregledDijagnosticarJMBG;
                    izabran.PokvarenDeoDEOID = Upamti.PokvarenDeoDEOID;
                    izabran.MajstorZaDeoDEOID = Upamti.MajstorZaDeoDEOID;
                    izabran.MajstorZaMajstorJMBG = Upamti.MajstorZaMajstorJMBG;
                    izabran.DatPop = Upamti.DatPop;
                }; izabran = value; OnPropertyChanged("Izabran"); if (izabran != null) Upamti =
                           new Popravljen(izabran.PokvarenPregledAutomobilSASIJA, izabran.PokvarenPregledDijagnosticarJMBG, izabran.PokvarenDeoDEOID, izabran.MajstorZaDeoDEOID, izabran.MajstorZaMajstorJMBG,izabran.DatPop);
            }
        }

        public PopravljenViewModel()
        {
            KomandaIzvrsi = new MyICommand(Izvrsi, DozvolaIzvrsi);
            Reload();
        }

        public void Izvrsi()
        {
            if (radioDodaj)
            {
                if (ProveriPodatke(Izabran, Upamti, 0))
                {
                    if (!ServiceProvider.Instance.DodajPopravljen(Izabran))
                        MessageBox.Show("Greska pri dodavanju popravljenog auta.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioIzmeni)
            {
                if (ProveriPodatke(Izabran, Upamti, 1))
                {
                    if (!ServiceProvider.Instance.IzmeniPopravljen(Izabran))
                        MessageBox.Show("Greska pri izmeni pokvarenog auta.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioObrisi)
            {
                if (!ServiceProvider.Instance.ObrisiPopravljen(Izabran.PokvarenPregledAutomobilSASIJA, Izabran.PokvarenPregledDijagnosticarJMBG, Izabran.PokvarenDeoDEOID, Izabran.MajstorZaMajstorJMBG, Izabran.MajstorZaDeoDEOID))
                    MessageBox.Show("Greska pri izmeni pokvarenog auta.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Obelezite jednu od punudjenih opcija.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reload();
        }

        private bool ProveriPodatke(Popravljen izabran, Popravljen upamti, int v)
        {
            Pokvaren pokvaren;
            if (v == 0)
            {

                if ((pokvaren = ServiceProvider.Instance.ProcitajPokvaren(izabran.PokvarenPregledAutomobilSASIJA, izabran.PokvarenPregledDijagnosticarJMBG, izabran.PokvarenDeoDEOID)) == null)
                {
                    MessageBox.Show("Nije potrebno popravljati auto koji nije pokvaren.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else
                {
                    Pregled pregled;
                    if ((pregled = ServiceProvider.Instance.ProcitajPregled(pokvaren.PregledAutomobilSASIJA, pokvaren.PregledDijagnosticarJMBG)) != null)
                    {
                        if (pregled.DatPre.CompareTo(izabran.DatPop) >= 0)
                        {
                            MessageBox.Show("Nije moguce popravljati auto pre pregleda...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            return true;
                        }

                    }
                    return false;
                }

            }
            else
            {
                if ((pokvaren = ServiceProvider.Instance.ProcitajPokvaren(izabran.PokvarenPregledAutomobilSASIJA, izabran.PokvarenPregledDijagnosticarJMBG, izabran.PokvarenDeoDEOID)) == null)
                {
                    return false;
                }
                else
                {
                    Pregled pregled;
                    if ((pregled = ServiceProvider.Instance.ProcitajPregled(pokvaren.PregledAutomobilSASIJA, pokvaren.PregledDijagnosticarJMBG)) != null)
                    {
                        if (pregled.DatPre.CompareTo(izabran.DatPop) >= 0)
                        {
                            MessageBox.Show("Nije moguce popravljati auto pre pregleda...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            return true;
                        }
                        
                    }
                    return false;
                }

            }
        }

        public bool DozvolaIzvrsi()
        {
            if (onStart)
            {
                onStart = false;
                firstPick = true;
            }

            if (Izabran != null)
            {
                return true;
            }
            return false;
        }

        private void Reload()
        {
            Majstori.Clear();
            Dijag.Clear();
            Sasije.Clear();
            MDeoID.Clear();
            PDeoID.Clear();

            a = new ObservableCollection<Automobil>(ServiceProvider.Instance.ProcitajSveAutomobil());
            foreach(var item in a)
            {
                Sasije.Add(item.SASIJA);
            }

            d = new ObservableCollection<Dijagnosticar>(ServiceProvider.Instance.ProcitajSveDijagnosticara());
            foreach(var item in d)
            {
                Dijag.Add(item.JMBG);
            }

            m = new ObservableCollection<Majstor>(ServiceProvider.Instance.ProcitajSveMajstora());
            foreach(var item in m)
            {
                Majstori.Add(item.JMBG);
            }

            de = new ObservableCollection<Deo>(ServiceProvider.Instance.ProcitajSveDeo());
            foreach(var item in de)
            {
                MDeoID.Add(item.DEOID);
                PDeoID.Add(item.DEOID);
            }



            Popravljeni = new ObservableCollection<Popravljen>(ServiceProvider.Instance.ProcitajSvePopravljen());
            if (Popravljeni.Count > 0)
                Izabran = Popravljeni[0];

            OnPropertyChanged("Izabran");
            OnPropertyChanged("Popravljeni");
            OnPropertyChanged("Pokvareni");
            OnPropertyChanged("MajstorZai");
            OnPropertyChanged("Majstori");
            OnPropertyChanged("Dijag");
            OnPropertyChanged("Sasije");
            OnPropertyChanged("MDeoID");
            OnPropertyChanged("PDeoID");
        }
    }
}

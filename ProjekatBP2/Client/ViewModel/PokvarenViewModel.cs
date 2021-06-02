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
    public class PokvarenViewModel:BindableBase
    {
        public ObservableCollection<Pokvaren> Pokvareni { get; set; } = new ObservableCollection<Pokvaren>();
        
        public ObservableCollection<Deo> Deoi { get; set; } = new ObservableCollection<Deo>();
        public ObservableCollection<Dijagnosticar> Dijagnosticari { get; set; } = new ObservableCollection<Dijagnosticar>();
        public ObservableCollection<Automobil> Automobili { get; set; } = new ObservableCollection<Automobil>();


        public ObservableCollection<int> delovi { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<long> dijag { get; set; } = new ObservableCollection<long>();
        public ObservableCollection<long> sasije { get; set; } = new ObservableCollection<long>();

        private Pokvaren izabran;
        private bool radioDodaj;
        private bool radioIzmeni;
        private bool radioObrisi;
        private bool firstPick;
        private bool onStart = true;
        public Pokvaren Upamti { get; private set; } = new Pokvaren(0, 0, 0);

        public MyICommand KomandaIzvrsi { get; set; }
        public bool RadioDodaj { get => radioDodaj; set { radioDodaj = value; OnPropertyChanged("RadioDodaj"); if (!radioDodaj || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioIzmeni { get => radioIzmeni; set { radioIzmeni = value; OnPropertyChanged("RadioIzmeni"); if (!radioIzmeni || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioObrisi { get => radioObrisi; set { radioObrisi = value; OnPropertyChanged("RadioObrisi"); if (!radioObrisi || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public Pokvaren Izabran
        {
            get => izabran; set
            {
                if (izabran != null)
                {
                    izabran.PregledAutomobilSASIJA = Upamti.PregledAutomobilSASIJA;
                    izabran.PregledDijagnosticarJMBG = Upamti.PregledDijagnosticarJMBG;
                    izabran.DeoDEOID = Upamti.DeoDEOID;
                }; izabran = value; OnPropertyChanged("Izabran"); if (izabran != null) Upamti =
                           new Pokvaren(izabran.PregledAutomobilSASIJA, izabran.PregledDijagnosticarJMBG, izabran.DeoDEOID);
            }
        }

        public PokvarenViewModel()
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
                    if (!ServiceProvider.Instance.DodajPokvaren(Izabran))
                        MessageBox.Show("Greska pri dodavanju pokvarenog auta.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioIzmeni)
            {
                if (ProveriPodatke(Izabran, Upamti, 1))
                {
                    if (!ServiceProvider.Instance.IzmeniPokvaren(Izabran))
                        MessageBox.Show("Greska pri izmeni pokvarenog auta.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioObrisi)
            {
                if (!ServiceProvider.Instance.ObrisiPokvaren(Izabran.PregledAutomobilSASIJA, Izabran.PregledDijagnosticarJMBG, Izabran.DeoDEOID))
                    MessageBox.Show("Greska pri izmeni pokvarenog auta.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Obelezite jednu od punudjenih opcija.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reload();
        }

        private bool ProveriPodatke(Pokvaren izabran, Pokvaren upamti, int v)
        {
            Pregled pregled;
            if (v == 0)
            {
                if((pregled = ServiceProvider.Instance.ProcitajPregled(izabran.PregledAutomobilSASIJA, izabran.PregledDijagnosticarJMBG)) == null)
                {
                    MessageBox.Show("Nije moguce napisati izvestaj o ne pregledanom autu...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else
                {
                    Automobil auto;
                    if((auto = ServiceProvider.Instance.ProcitajAutomobil(izabran.PregledAutomobilSASIJA)) != null)
                    {
                        if (pregled.DatPre.CompareTo(auto.DatSK) >= 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Nije moguce pregledati auto pre otvaranja servisne knjizice...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    return false;
                }

            }
            else
            {
                Automobil auto;
                if((pregled = ServiceProvider.Instance.ProcitajPregled(izabran.PregledAutomobilSASIJA, izabran.PregledDijagnosticarJMBG)) == null)
                {
                    return false;
                }
                else 
                {
                    if (((auto = ServiceProvider.Instance.ProcitajAutomobil(izabran.PregledAutomobilSASIJA)) != null))
                    {
                        if (pregled.DatPre.CompareTo(auto.DatSK) >= 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Nije moguce pregledati auto pre otvaranja servisne knjizice...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
            delovi.Clear();
            dijag.Clear();
            sasije.Clear();
            Deoi = new ObservableCollection<Deo>(ServiceProvider.Instance.ProcitajSveDeo());

            foreach(var item in Deoi)
            {
                delovi.Add(item.DEOID);
            }
            


            Dijagnosticari = new ObservableCollection<Dijagnosticar>(ServiceProvider.Instance.ProcitajSveDijagnosticara());
            foreach (var item in Dijagnosticari)
            {
                dijag.Add(item.JMBG);
            }


            Automobili = new ObservableCollection<Automobil>(ServiceProvider.Instance.ProcitajSveAutomobil());

            foreach (var item in Automobili)
            {
                sasije.Add(item.SASIJA);
            }

            
            Pokvareni = new ObservableCollection<Pokvaren>(ServiceProvider.Instance.ProcitajSvePokvaren());
            if (Pokvareni.Count > 0)
                Izabran = Pokvareni[0];
            OnPropertyChanged("Izabran");
            OnPropertyChanged("Pokvareni");
            OnPropertyChanged("Pregledi");
            OnPropertyChanged("Deoi");
            OnPropertyChanged("dijag");
            OnPropertyChanged("sasije");
            OnPropertyChanged("delovi");

        }
    }
}

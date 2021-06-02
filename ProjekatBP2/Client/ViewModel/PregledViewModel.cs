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
    public class PregledViewModel:BindableBase
    {
        public ObservableCollection<Pregled> Pregledi { get; set; } = new ObservableCollection<Pregled>();
        public ObservableCollection<Dijagnosticar> Dijagnosticari { get; set; } = new ObservableCollection<Dijagnosticar>();
        public ObservableCollection<Automobil> Automobili { get; set; } = new ObservableCollection<Automobil>();


        public ObservableCollection<long> dijag { get; set; } = new ObservableCollection<long>();
        public ObservableCollection<long> sasije { get; set; } = new ObservableCollection<long>();

        public List<bool> state { get; set; } = new List<bool>();

        private Pregled izabran;
        private bool radioDodaj;
        private bool radioIzmeni;
        private bool radioObrisi;
        private bool firstPick;
        private bool onStart = true;
        public Pregled Upamti { get; private set; } = new Pregled(0, 0, DateTime.Now,false);

        public MyICommand KomandaIzvrsi { get; set; }
        public bool RadioDodaj { get => radioDodaj; set { radioDodaj = value; OnPropertyChanged("RadioDodaj"); if (!radioDodaj || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioIzmeni { get => radioIzmeni; set { radioIzmeni = value; OnPropertyChanged("RadioIzmeni"); if (!radioIzmeni || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioObrisi { get => radioObrisi; set { radioObrisi = value; OnPropertyChanged("RadioObrisi"); if (!radioObrisi || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public Pregled Izabran
        {
            get => izabran; set
            {
                if (izabran != null)
                {
                    izabran.AutomobilSASIJA = Upamti.AutomobilSASIJA;
                    izabran.DijagnosticarJMBG = Upamti.DijagnosticarJMBG;
                    izabran.DatPre = Upamti.DatPre;
                    izabran.Stanje = Upamti.Stanje;
                }; izabran = value; OnPropertyChanged("Izabran"); if (izabran != null) Upamti =
                           new Pregled(izabran.AutomobilSASIJA, izabran.DijagnosticarJMBG, izabran.DatPre, izabran.Stanje);
            }
        }

        public PregledViewModel()
        {
            state.Add(true);
            state.Add(false);
            KomandaIzvrsi = new MyICommand(Izvrsi, DozvolaIzvrsi);
            Reload();
        }

        public void Izvrsi()
        {
            if (radioDodaj)
            {
                if (ProveriPodatke(Izabran, Upamti, 0))
                {
                    if (!ServiceProvider.Instance.DodajPregled(Izabran))
                        MessageBox.Show("Greska pri dodavanju pregleda.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioIzmeni)
            {
                if (ProveriPodatke(Izabran, Upamti, 1))
                {
                    if (!ServiceProvider.Instance.IzmeniPregled(Izabran))
                        MessageBox.Show("Greska pri izmeni pregleda.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioObrisi)
            {
                if (!ServiceProvider.Instance.ObrisiPregled(Izabran.AutomobilSASIJA, Izabran.DijagnosticarJMBG))
                    MessageBox.Show("Greska pri izmeni pregleda.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Obelezite jednu od punudjenih opcija.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reload();
        }

        private bool ProveriPodatke(Pregled izabran, Pregled upamti, int v)
        {
            Automobil auto;
            if((auto = ServiceProvider.Instance.ProcitajAutomobil(izabran.AutomobilSASIJA)) == null)
            {
                return false;
            }
            else
            {
                if(auto.DatSK.CompareTo(izabran.DatPre) >= 0)
                {
                    MessageBox.Show("Nije moguce pregledati auto pre otvaranja servisne knjizce.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else
                {
                    return true;
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
            dijag.Clear();
            sasije.Clear();

            Dijagnosticari = new ObservableCollection<Dijagnosticar>(ServiceProvider.Instance.ProcitajSveDijagnosticara());
            foreach(var item in Dijagnosticari)
            {
                dijag.Add(item.JMBG);
            }


            Automobili = new ObservableCollection<Automobil>(ServiceProvider.Instance.ProcitajSveAutomobil());

            foreach(var item in Automobili)
            {
                sasije.Add(item.SASIJA);
            }

            Pregledi = new ObservableCollection<Pregled>(ServiceProvider.Instance.ProcitajSvePregled());
            if (Pregledi.Count > 0)
                Izabran = Pregledi[0];
            OnPropertyChanged("Izabran");
            OnPropertyChanged("Pregledi");
            OnPropertyChanged("Dijagnosticari");
            OnPropertyChanged("Automobili");
            OnPropertyChanged("dijag");
            OnPropertyChanged("sasije");
        }
    }
}

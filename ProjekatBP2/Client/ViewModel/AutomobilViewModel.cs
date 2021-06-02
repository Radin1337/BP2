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
    public class AutomobilViewModel:BindableBase
    {
        public ObservableCollection<Automobil> Automobili { get; set; } = new ObservableCollection<Automobil>();
        public ObservableCollection<Servis> Servisi { get; set; } = new ObservableCollection<Servis>();

        public ObservableCollection<int> ids { get; set; } = new ObservableCollection<int>();
        public List<string> tipAuto { get; set; } = new List<string>();

        private Automobil izabran;
        private bool radioDodaj;
        private bool radioIzmeni;
        private bool radioObrisi;
        private bool firstPick;
        private bool onStart = true;
        public Automobil Upamti { get; private set; } = new Automobil(0, "", 0, DateTime.Now,0, "");

        public MyICommand KomandaIzvrsi { get; set; }
        public bool RadioDodaj { get => radioDodaj; set { radioDodaj = value; OnPropertyChanged("RadioDodaj"); if (!radioDodaj || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioIzmeni { get => radioIzmeni; set { radioIzmeni = value; OnPropertyChanged("RadioIzmeni"); if (!radioIzmeni || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioObrisi { get => radioObrisi; set { radioObrisi = value; OnPropertyChanged("RadioObrisi"); if (!radioObrisi || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public Automobil Izabran
        {
            get => izabran; set
            {
                if (izabran != null)
                {
                    izabran.SASIJA = Upamti.SASIJA;
                    izabran.Marka = Upamti.Marka;
                    izabran.TipMot = Upamti.TipMot;
                    izabran.BrSK = Upamti.BrSK;
                    izabran.DatSK = Upamti.DatSK;
                    izabran.ServisIDS = Upamti.ServisIDS;
                }; izabran = value; OnPropertyChanged("Izabran"); if (izabran != null) Upamti =
                           new Automobil(izabran.SASIJA, izabran.Marka, izabran.BrSK, izabran.DatSK, izabran.ServisIDS,izabran.TipMot);
            }
        }

        public AutomobilViewModel()
        {
            tipAuto.Add("Elektricni");
            tipAuto.Add("Sus");
            KomandaIzvrsi = new MyICommand(Izvrsi, DozvolaIzvrsi);
            Reload();
        }

        public void Izvrsi()
        {
            if (radioDodaj)
            {
                if (ProveriPodatke(Izabran, Upamti, 0))
                {
                    if (!ServiceProvider.Instance.DodajAutomobil(Izabran))
                        MessageBox.Show("Greska pri dodavanju automobila.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioIzmeni)
            {
                if (ProveriPodatke(Izabran, Upamti, 1))
                {
                    if (!ServiceProvider.Instance.IzmeniAutomobil(Izabran))
                        MessageBox.Show("Greska pri izmeni automobila.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioObrisi)
            {
                if (!ServiceProvider.Instance.ObrisiAutomobil(Izabran.SASIJA))
                    MessageBox.Show("Greska pri izmeni automobila.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Obelezite jednu od punudjenih opcija.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reload();
        }

        private bool ProveriPodatke(Automobil izabran, Automobil upamti, int v)
        {
            if(izabran.Marka == "")
            {
                MessageBox.Show("Morate uneti marku automobila.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
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
            ids.Clear();

            Servisi = new ObservableCollection<Servis>(ServiceProvider.Instance.ProcitajSveServis());
            foreach(var item in Servisi)
            {
                ids.Add(item.IDS);
            }
            Automobili = new ObservableCollection<Automobil>(ServiceProvider.Instance.ProcitajSveAutomobil());
            if (Automobili.Count > 0)
                Izabran = Automobili[0];
            OnPropertyChanged("Izabran");
            OnPropertyChanged("Automobili");
            OnPropertyChanged("ids");
        }
    }
}

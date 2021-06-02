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
    public class ElektricniViewModel:BindableBase
    {
        public ObservableCollection<Elektricni> Elektricnii { get; set; } = new ObservableCollection<Elektricni>();

        public ObservableCollection<Servis> Servisi { get; set; } = new ObservableCollection<Servis>();

        public ObservableCollection<int> ids { get; set; } = new ObservableCollection<int>();

        private Elektricni izabran;
        private bool radioDodaj;
        private bool radioIzmeni;
        private bool radioObrisi;
        private bool firstPick;
        private bool onStart = true;
        public Elektricni Upamti { get; private set; } = new Elektricni(0,0, "", 0, DateTime.Now, 0, "");

        public MyICommand KomandaIzvrsi { get; set; }
        public bool RadioDodaj { get => radioDodaj; set { radioDodaj = value; OnPropertyChanged("RadioDodaj"); if (!radioDodaj || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioIzmeni { get => radioIzmeni; set { radioIzmeni = value; OnPropertyChanged("RadioIzmeni"); if (!radioIzmeni || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioObrisi { get => radioObrisi; set { radioObrisi = value; OnPropertyChanged("RadioObrisi"); if (!radioObrisi || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public Elektricni Izabran
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
                    izabran.BrMot = Upamti.BrMot;
                }; izabran = value; OnPropertyChanged("Izabran"); if (izabran != null) Upamti =
                           new Elektricni(izabran.BrMot,izabran.SASIJA, izabran.Marka, izabran.BrSK, izabran.DatSK, izabran.ServisIDS, izabran.TipMot);
            }
        }

        public ElektricniViewModel()
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
                    if (!ServiceProvider.Instance.DodajElektricni(Izabran))
                        MessageBox.Show("Greska pri dodavanju elektro automobila.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioIzmeni)
            {
                if (ProveriPodatke(Izabran, Upamti, 1))
                {
                    if (!ServiceProvider.Instance.IzmeniElektricni(Izabran))
                        MessageBox.Show("Greska pri izmeni elektro automobila.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioObrisi)
            {
                if (!ServiceProvider.Instance.ObrisiElektricni(Izabran.SASIJA))
                    MessageBox.Show("Greska pri izmeni elektro automobila.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Obelezite jednu od punudjenih opcija.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reload();
        }

        private bool ProveriPodatke(Elektricni izabran, Elektricni upamti, int v)
        {
            if (izabran.Marka == "")
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
            foreach (var item in Servisi)
            {
                ids.Add(item.IDS);
            }

            Elektricnii = new ObservableCollection<Elektricni>(ServiceProvider.Instance.ProcitajSveElektricni());
            if (Elektricnii.Count > 0)
                Izabran = Elektricnii[0];
            OnPropertyChanged("Izabran");
            OnPropertyChanged("Elektricnii");
            OnPropertyChanged("ids");
        }
    }
}

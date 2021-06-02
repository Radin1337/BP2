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
    public class DeoViewModel:BindableBase
    {
        public ObservableCollection<Deo> Deoi { get; set; } = new ObservableCollection<Deo>();

        private Deo izabran;
        private bool radioDodaj;
        private bool radioIzmeni;
        private bool radioObrisi;
        private bool firstPick;
        private bool onStart = true;
        public Deo Upamti { get; private set; } = new Deo(0, "");

        public MyICommand KomandaIzvrsi { get; set; }
        public bool RadioDodaj { get => radioDodaj; set { radioDodaj = value; OnPropertyChanged("RadioDodaj"); if (!radioDodaj || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioIzmeni { get => radioIzmeni; set { radioIzmeni = value; OnPropertyChanged("RadioIzmeni"); if (!radioIzmeni || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioObrisi { get => radioObrisi; set { radioObrisi = value; OnPropertyChanged("RadioObrisi"); if (!radioObrisi || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public Deo Izabran
        {
            get => izabran; set
            {
                if (izabran != null)
                {
                    izabran.DEOID = Upamti.DEOID;
                    izabran.DEOID = Upamti.DEOID;
                }; izabran = value; OnPropertyChanged("Izabran"); if (izabran != null) Upamti =
                           new Deo(izabran.DEOID, izabran.NazivD);
            }
        }

        public DeoViewModel()
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
                    Izabran.DEOID = 0;
                    if (!ServiceProvider.Instance.DodajDeo(Izabran))
                        MessageBox.Show("Greska pri dodavanju dela.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioIzmeni)
            {
                if (ProveriPodatke(Izabran, Upamti, 1))
                {
                    if (!ServiceProvider.Instance.IzmeniDeo(Izabran))
                        MessageBox.Show("Greska pri izmeni dela.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioObrisi)
            {
                if (!ServiceProvider.Instance.ObrisiDeo(Izabran.DEOID))
                    MessageBox.Show("Greska pri izmeni dela.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Obelezite jednu od punudjenih opcija.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reload();
        }

        private bool ProveriPodatke(Deo izabran, Deo upamti, int v)
        {
            if(izabran.NazivD == "")
            {
                MessageBox.Show("Polje za naziv dela ne moze biti prazno.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
            Deoi = new ObservableCollection<Deo>(ServiceProvider.Instance.ProcitajSveDeo());
            if (Deoi.Count > 0)
                Izabran = Deoi[0];
            OnPropertyChanged("Izabran");
            OnPropertyChanged("Deoi");
        }
    }
}

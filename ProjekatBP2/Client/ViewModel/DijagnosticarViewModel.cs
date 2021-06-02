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
    public class DijagnosticarViewModel:BindableBase
    {
        public ObservableCollection<Dijagnosticar> Dijagnosticari { get; set; } = new ObservableCollection<Dijagnosticar>();

        public ObservableCollection<Servis> Servisi { get; set; } = new ObservableCollection<Servis>();

        public ObservableCollection<Nullable<int>> ids { get; set; } = new ObservableCollection<Nullable<int>>();

        private Dijagnosticar izabran;
        private bool radioDodaj;
        private bool radioIzmeni;
        private bool radioObrisi;
        private bool firstPick;
        private bool onStart = true;
        public Dijagnosticar Upamti { get; private set; } = new Dijagnosticar(0, "", "", null, "");

        public MyICommand KomandaIzvrsi { get; set; }
        public bool RadioDodaj { get => radioDodaj; set { radioDodaj = value; OnPropertyChanged("RadioDodaj"); if (!radioDodaj || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioIzmeni { get => radioIzmeni; set { radioIzmeni = value; OnPropertyChanged("RadioIzmeni"); if (!radioIzmeni || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioObrisi { get => radioObrisi; set { radioObrisi = value; OnPropertyChanged("RadioObrisi"); if (!radioObrisi || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public Dijagnosticar Izabran
        {
            get => izabran; set
            {
                if (izabran != null)
                {
                    izabran.JMBG = Upamti.JMBG;
                    izabran.Ime = Upamti.Ime;
                    izabran.Prezime = Upamti.Prezime;
                    izabran.TipServ = Upamti.TipServ;
                    izabran.ServisIDS = Upamti.ServisIDS;
                }; izabran = value; OnPropertyChanged("Izabran"); if (izabran != null) Upamti =
                           new Dijagnosticar(izabran.JMBG, izabran.Ime, izabran.Prezime, izabran.ServisIDS, izabran.TipServ);
            }
        }

        public DijagnosticarViewModel()
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
                    if (Izabran.ServisIDS == 0)
                        Izabran.ServisIDS = null;
                    if (!ServiceProvider.Instance.DodajDijagnosticara(Izabran))
                        MessageBox.Show("Greska pri dodavanju dijagnosticara.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioIzmeni)
            {
                if (ProveriPodatke(Izabran, Upamti, 1))
                {
                    if (!ServiceProvider.Instance.IzmeniDijagnosticara(Izabran))
                        MessageBox.Show("Greska pri izmeni dijagnosticara.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioObrisi)
            {
                if (!ServiceProvider.Instance.ObrisiDijagnosticara(Izabran.JMBG))
                    MessageBox.Show("Greska pri izmeni dijagnosticara.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Obelezite jednu od punudjenih opcija.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reload();
        }

        private bool ProveriPodatke(Dijagnosticar izabran, Dijagnosticar upamti, int v)
        {
            if (izabran.Ime == "" && izabran.Prezime == "")
            {

                MessageBox.Show("Ime i Prezime servisera su obavezna polja.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
            ids.Add(0);
            Servisi = new ObservableCollection<Servis>(ServiceProvider.Instance.ProcitajSveServis());
            foreach (var item in Servisi)
            {
                ids.Add(item.IDS);
            }

            Dijagnosticari = new ObservableCollection<Dijagnosticar>(ServiceProvider.Instance.ProcitajSveDijagnosticara());
            if (Dijagnosticari.Count > 0)
                Izabran = Dijagnosticari[0];
            OnPropertyChanged("Izabran");
            OnPropertyChanged("Dijagnosticari");
        }
    }
}

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
    public class MajstorZaViewModel:BindableBase
    {
        public ObservableCollection<MajstorZa> MajstorZai { get; set; } = new ObservableCollection<MajstorZa>();
        public ObservableCollection<Deo> Deoi { get; set; } = new ObservableCollection<Deo>();

        public ObservableCollection<Majstor> Majstori { get; set; } = new ObservableCollection<Majstor>();


        public ObservableCollection<long> majstorii { get; set; } = new ObservableCollection<long>();
        public ObservableCollection<int> Delovi { get; set; } = new ObservableCollection<int>();

        private MajstorZa izabran;
        private bool radioDodaj;
        private bool radioIzmeni;
        private bool radioObrisi;
        private bool firstPick;
        private bool onStart = true;
        public MajstorZa Upamti { get; private set; } = new MajstorZa(0, 0);

        public MyICommand KomandaIzvrsi { get; set; }
        public bool RadioDodaj { get => radioDodaj; set { radioDodaj = value; OnPropertyChanged("RadioDodaj"); if (!radioDodaj || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioIzmeni { get => radioIzmeni; set { radioIzmeni = value; OnPropertyChanged("RadioIzmeni"); if (!radioIzmeni || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public bool RadioObrisi { get => radioObrisi; set { radioObrisi = value; OnPropertyChanged("RadioObrisi"); if (!radioObrisi || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }
        public MajstorZa Izabran
        {
            get => izabran; set
            {
                if (izabran != null)
                {
                    izabran.MajstorJMBG = Upamti.MajstorJMBG;
                    izabran.DeoDEOID = Upamti.DeoDEOID;
                }; izabran = value; OnPropertyChanged("Izabran"); if (izabran != null) Upamti =
                           new MajstorZa(izabran.MajstorJMBG, izabran.DeoDEOID);
            }
        }

        public MajstorZaViewModel()
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
                    if (!ServiceProvider.Instance.DodajMajstoraZa(Izabran))
                        MessageBox.Show("Greska pri dodavanju majstora za deo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioIzmeni)
            {
                if (ProveriPodatke(Izabran, Upamti, 1))
                {
                    if (!ServiceProvider.Instance.IzmeniMajstoraZa(Izabran))
                        MessageBox.Show("Greska pri izmeni majstora za deo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioObrisi)
            {
                if (!ServiceProvider.Instance.ObrisiMajstoraZa(Izabran.MajstorJMBG, Izabran.DeoDEOID))
                    MessageBox.Show("Greska pri izmeni majstora za deo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Obelezite jednu od punudjenih opcija.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reload();
        }

        private bool ProveriPodatke(MajstorZa izabran, MajstorZa upamti, int v)
        {
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
            Delovi.Clear();
            majstorii.Clear();
            Majstori = new ObservableCollection<Majstor>(ServiceProvider.Instance.ProcitajSveMajstora());
            foreach(var item in Majstori)
            {
                majstorii.Add(item.JMBG);
            }


            Deoi = new ObservableCollection<Deo>(ServiceProvider.Instance.ProcitajSveDeo());
            foreach(var item in Deoi)
            {
                Delovi.Add(item.DEOID);
            }
            MajstorZai = new ObservableCollection<MajstorZa>(ServiceProvider.Instance.ProcitajSveMajstoraZa());
            if (MajstorZai.Count > 0)
                Izabran = MajstorZai[0];
            OnPropertyChanged("Izabran");
            OnPropertyChanged("MajstorZai");
            OnPropertyChanged("Deoi");
            OnPropertyChanged("Delovi");
            OnPropertyChanged("majstorii");
        }
    }
}

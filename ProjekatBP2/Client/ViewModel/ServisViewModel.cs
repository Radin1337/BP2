using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client;
using CommonLib.Models;
using System.Windows;

namespace Client.ViewModel
{
    public class ServisViewModel:BindableBase
    {
        public ObservableCollection<Servis> Servisi { get; set; } = new ObservableCollection<Servis>();

        public MyICommand KomandaIzvrsi { get; set; }

        private Servis izabranServis;
        public Servis upamtiServis { get; private set; } = new Servis(0,"",new Adresa("","",""),"");
        public Servis IzabranServis { get =>izabranServis; set {
                if (izabranServis != null)
                {
                    izabranServis.IDS = upamtiServis.IDS;
                    izabranServis.NazivS = upamtiServis.NazivS;
                    izabranServis.Adresa = upamtiServis.Adresa;
                    izabranServis.Telefon = upamtiServis.Telefon;
                }
                izabranServis = value; OnPropertyChanged("IzabranServis"); if(izabranServis!=null) upamtiServis = 
                        new Servis(izabranServis.IDS, IzabranServis.NazivS, new Adresa(IzabranServis.Adresa.Split(';')[0], IzabranServis.Adresa.Split(';')[1], IzabranServis.Adresa.Split(';')[2]), IzabranServis.Telefon); } }

        private bool radioDodaj;
        private bool radioIzmeni;
        private bool radioObrisi;
        private bool firstPick;
        private bool onStart = true;
        public bool RadioDodaj { get => radioDodaj; set { radioDodaj = value; OnPropertyChanged("RadioDodaj"); if (!radioDodaj || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged();firstPick = false; } } }
        public bool RadioIzmeni { get => radioIzmeni; set { radioIzmeni = value; OnPropertyChanged("RadioIzmeni");
                                                            if (!radioIzmeni || firstPick) 
                                                            { 
                                                                KomandaIzvrsi.RaiseCanExecuteChanged(); 
                                                                firstPick = false;
                                                            } } }
        public bool RadioObrisi { get => radioObrisi; set { radioObrisi = value; OnPropertyChanged("RadioObrisi"); if(!radioObrisi || firstPick) { KomandaIzvrsi.RaiseCanExecuteChanged(); firstPick = false; } } }

        public ServisViewModel()
        {
            KomandaIzvrsi = new MyICommand(Izvrsi, DozvolaIzvrsi);
            Reload();
        }

        public bool ProveriPodatke(Servis u, Servis i, int n)
        {
            if(i.NazivS == "")
            {
                MessageBox.Show("Polje naziv ne moze biti prazno.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (i.Adresa.Split(';').Count() != 3)
            {
                MessageBox.Show("Polje adresa ne moze biti prazno. Format: Mesto;Ulica;Broj", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if(i.Telefon.Split('/', '-').Count() != 4 && i.Telefon.Split('/', '-').Count() != 3)
            {
                var item = IzabranServis.Telefon.Split('/', '-');
                for (int ix = 1; ix < item.Count(); ix++)
                {
                    item[0] += item[ix];
                }
                if (item[0].Length < 9)
                    MessageBox.Show("Broj telefona ima najmanje 9 cifara. Format: xxx/yyy-zz-tt ili xxx/yyy-zzz", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                    MessageBox.Show("Broj telefona nije u dobrom formatu. Format: xxx/yyy-zz-tt ili xxx/yyy-zzz", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (n == 0)
            {
                if (u.Adresa.Replace(" ", "").ToUpper() == i.Adresa.Replace(" ", "").ToUpper() || u.Telefon == i.Telefon)
                {
                    MessageBox.Show("Nije moguce dodati servis sa istom adresom ili telefonom.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            return true;

        }

        public void Izvrsi()
        {
            if (radioDodaj)
            {
                if (ProveriPodatke(IzabranServis, upamtiServis, 0))
                {
                    IzabranServis.IDS = 0;
                    if (!ServiceProvider.Instance.DodajServis(IzabranServis))
                        MessageBox.Show("Greska pri dodavanju servisa.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioIzmeni)
            {
                if (ProveriPodatke(IzabranServis, upamtiServis, 1))
                {
                    if (!ServiceProvider.Instance.IzmeniServis(IzabranServis))
                        MessageBox.Show("Greska pri izmeni servisa.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (radioObrisi)
            {
                if (!ServiceProvider.Instance.ObrisiServis(IzabranServis.IDS))
                    MessageBox.Show("Greska pri izmeni servisa.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Obelezite jednu od punudjenih opcija.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Reload();
        }

        public bool DozvolaIzvrsi()
        {
            if (onStart)
            {
                onStart = false;
                firstPick = true;
            }

            if (IzabranServis != null)
            {
                return true;
            }
            return false;
        }

        private void Reload()
        {
            Servisi = new ObservableCollection<Servis>(ServiceProvider.Instance.ProcitajSveServis());
            if (Servisi.Count > 0)
                IzabranServis = Servisi[0];
            OnPropertyChanged("IzabranServis");
            OnPropertyChanged("Servisi");
        }
    }
}

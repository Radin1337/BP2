using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ViewModel;

namespace Client
{
    public class MainWindowViewModel:BindableBase
    {
        public MainWindowViewModel()
        {
            CurrentViewModel = new ServisViewModel();
            buttonClick = new MyICommand<string>(ChangeWindow);
        }

        public void ChangeWindow(string view)
        {
            switch (view)
            {
                case "Servis":
                    CurrentViewModel = new ServisViewModel();
                    break;
                case "Serviser":
                    CurrentViewModel = new ServiserViewModel();
                    break;
                case "Dijagnosticar":
                    CurrentViewModel = new DijagnosticarViewModel();
                    break;
                case "Majstor":
                    CurrentViewModel = new MajstorViewModel();
                    break;
                case "Automobil":
                    CurrentViewModel = new AutomobilViewModel();
                    break;
                case "Sus":
                    CurrentViewModel = new SusViewModel();
                    break;
                case "Elektricni":
                    CurrentViewModel = new ElektricniViewModel();
                    break;
                case "Pregled":
                    CurrentViewModel = new PregledViewModel();
                    break;
                case "Pokvaren":
                    CurrentViewModel = new PokvarenViewModel();
                    break;
                case "Deo":
                    CurrentViewModel = new DeoViewModel();
                    break;
                case "MajstorZa":
                    CurrentViewModel = new MajstorZaViewModel();
                    break;
                case "Popravljen":
                    CurrentViewModel = new PopravljenViewModel();
                    break;
            }
        }

        public MyICommand<string> buttonClick { get; set; }

        private BindableBase currentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }
    }
}

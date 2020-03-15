using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class ProfVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Profesor");
        private readonly APIService _service_ispit = new APIService("Ispit");
        private readonly APIService _service_obavijset = new APIService("Obavijest");

        public ProfVM()
        {

        }
        public ProfVM(int role, int userId)
        {
            MojiPodaciCommand = new Command(()=> {
                KomandaMojiPodaci(ProfID, Role);
            });

            OdjavaCommand = new Command(() => {
                KomandaOdjava();
            });

            DodajIspitCommand = new Command(() =>
            {
                Application.Current.MainPage = new IspitDodajProfPage(userId, role);
            });

            PrikazObavijestiCommand = new Command(() =>
            {
                LoadObavjestenja();
            });
        }
        
        public ICommand MojiPodaciCommand { get; set; }

        public ICommand OdjavaCommand { get; set; }

        public ICommand DodajIspitCommand { get; set; }

        public ICommand PrikazObavijestiCommand { get; set; }

        int ProfID;
        public int _profId
        {
            get { return ProfID; }
            set { SetProperty(ref ProfID, value); }
        }

        int Role;
        public int _role
        {
            get { return Role; }
            set { SetProperty(ref Role, value); }
        }

        public void KomandaMojiPodaci(int id, int role)
        {
            Application.Current.MainPage = new MojiPodaciProfPage(id, role);
        }

        public async void KomandaOdjava()
        {
            var t = await Application.Current.MainPage.DisplayAlert("Upozorenje", "Da li ste sigurni da se želite odjaviti?", "Da", "Ne");

            if (t == true)
            {
                Application.Current.MainPage = new AuthPage();
            }
        }

        public async void LoadObavjestenja() {

            var listaObavjestenja = await _service_obavijset.Get<List<obavijesti>>(null);

            Application.Current.MainPage = new ObavijestiPage(listaObavjestenja, ProfID, Role);
        }
    }

}

using StudentskiServis.MobileApp.Views;
using StudentskiServis.MobileApp.Views.Administracija;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class AdminVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Student");
        private readonly APIService _service_obavijest = new APIService("Obavijest");
        private readonly APIService _service_ispit = new APIService("Ispit");
        private readonly APIService _service_pohadjanja = new APIService("Pohadjanja");
        private readonly APIService _service_uplata = new APIService("Uplata");
        private readonly APIService _service_raspored = new APIService("Raspored");
        private readonly APIService _service_admin = new APIService("Administracija");
        private readonly APIService _service_prof = new APIService("Profesor");
        private readonly APIService _service_kurs = new APIService("Kurs");
        public AdminVM()
        {

        }

        public AdminVM(int userId, int role)
        {
            UserID = userId;
            Role = role;

            Command_Odjava = new Command(async () =>
            {
                var t = await Application.Current.MainPage.DisplayAlert("Upozorenje", "Da li ste sigurni da se želite odjaviti?", "Da", "Ne");

                if (t == true)
                {
                    Application.Current.MainPage = new AuthPage();
                }
            });

            Command_MojiPodaci = new Command(async () =>
            {
                AdministracijaAdmin t =await _service_admin.GetById<AdministracijaAdmin>(userId);

                Application.Current.MainPage = new AdminMojiPodaciPage(userId, role, t);
            });

            
            Command_Administracija = new Command(async () =>
            {
                List<AdministracijaAdmin> lista = await _service_admin.Get<List<AdministracijaAdmin>>(null);

                Application.Current.MainPage = new AdminPrikazAdministracijePage(userId, role, lista);

            });

            Command_Profesori = new Command(async () =>
            {
                List<ProfesorAdmin> lista = await _service_prof.Get<List<ProfesorAdmin>>(null);

                Application.Current.MainPage = new AdminPrikazProfesoraPage(userId, role, lista);
            });

            Command_Studenti = new Command(async () =>
            {
                List<StudentAdmin> lista = await _service.Get<List<StudentAdmin>>(null);

                Application.Current.MainPage = new AdminPrikazStudenataPage(userId, role, lista);
            });

            Command_Uplate = new Command(async () =>
            {
                List<uplate> lista = await _service_uplata.Get<List<uplate>>(null);

                Application.Current.MainPage = new AdminPrikazUplataPage(userId, role, lista);
            });

            Command_Kursevi = new Command(async () =>
            {
                List<kursevi> lista = await _service_kurs.Get<List<kursevi>>(null);

                Application.Current.MainPage = new AdminPrikazKursevaPage(userId, role, lista);
            });

            //Command_Dodaj_Predavanja = new Command(async () =>
            //{

            //});

            //Command_Dodaj_Pohadjanja = new Command(async () =>
            //{

            //});
        }


        public ICommand Command_MojiPodaci { get; set; }
        public ICommand Command_Administracija { get; set; }
        public ICommand Command_Profesori { get; set; }
        public ICommand Command_Studenti { get; set; }
        public ICommand Command_Uplate { get; set; }
        public ICommand Command_Kursevi { get; set; }
        //public ICommand Command_Dodaj_Predavanja { get; set; }
        //public ICommand Command_Dodaj_Pohadjanja { get; set; }
        public ICommand Command_Odjava { get; set; }

        int _userId;
        public int UserID { get { return _userId; } set { SetProperty(ref _userId, value); } }

        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }
    }
}

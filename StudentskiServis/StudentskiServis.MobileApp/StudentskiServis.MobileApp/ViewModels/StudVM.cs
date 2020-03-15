using StudentskiServis.MobileApp.Views;
using StudentskiServis.MobileApp.Views.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class StudVM : BaseViewModel
    {
        private readonly APIService _service = new APIService("Student");
        private readonly APIService _service_obavijest = new APIService("Obavijest");
        private readonly APIService _service_ispit = new APIService("Ispit");
        private readonly APIService _service_pohadjanja = new APIService("Pohadjanja");
        private readonly APIService _service_uplata = new APIService("Uplata");
        private readonly APIService _service_raspored = new APIService("Raspored");
        private readonly APIService _service_admin = new APIService("Administracija");
        private readonly APIService _service_prof = new APIService("Profesor");
        public StudVM()
        {

        }

        public StudVM(int userId, int role)
        {
            UserID = userId;
            Role = role;

            Command_Odjava = new Command(() =>
            {
                Odjava();
            });

            Command_MojiPodaci = new Command(() =>
            {
                LoadMyData(userId, role);
            });

            Command_Obavijesti = new Command(() =>
            {
                LoadNotifications(userId, role);
            });

            Command_Ispiti = new Command(() =>
            {
                LoadExams(userId, role);
            });

            Command_MojeUplate = new Command(() =>
            {
                LoadPayments(userId, role);
            });

            Command_Mojraspored = new Command(() =>
            {
                LoadSchedule(userId, role);
            });

            Command_Administracija = new Command(() =>
            {
                LoadAdmin(userId, role);

            });

            Command_Profesori = new Command(() =>
            {
                LoadProf(userId, role);
            });

            CommandKoPohadja = new Command(() =>
            {
                LoadKoPohadja(userId, role);
            });

        }



        public List<ProfesorAll> listaProf { get; set; } = new List<ProfesorAll>();

        public void LoadKoPohadja(int userId, int role)
        {
            Application.Current.MainPage = new KoPohadjaPage(userId, role);
        }

        public async void LoadProf(int userId, int role)
        {
            var source = await _service_prof.Get<List<ProfesorAll>>(null);

            foreach(var x in source)
            {
                listaProf.Add(new ProfesorAll
                {
                    Ime = x.Ime,
                    Kancelarija = x.Kancelarija,
                    KorisnickiNalogId = x.KorisnickiNalogId,
                    Mail = x.Mail,
                    Prezime = x.Prezime,
                    ProfesorId = x.ProfesorId,
                    Slika = x.Slika,
                    Zvanje = x.Zvanje
                });
            }

            Application.Current.MainPage = new StudProfPrikazPage(userId, role, listaProf);
        }


        public List<AdministracijaAll> listaAdmin { get; set; } = new List<AdministracijaAll>();

        public async void LoadAdmin(int userId, int role)
        {
            var source = await _service_admin.Get<List<AdministracijaAll>>(null);

            foreach(var x in source)
            {
                listaAdmin.Add(new AdministracijaAll
                {
                    Ime=x.Ime,
                    AdministracijaId=x.AdministracijaId,
                    Kancelarija=x.Kancelarija,
                    Mail=x.Mail,
                    Prezime=x.Prezime,
                    Slika=x.Slika
                });
            }

            Application.Current.MainPage = new StudAdminPrikazPage(userId, role, listaAdmin);

        }

        public async void LoadSchedule(int userId, int role)
        {
            List<Raspored> t = await _service_raspored.Get<List<Raspored>>(null);
            List<Raspored> listaRaspored = new List<Raspored>();

            foreach(var x in t)
            {
                if (x.StudentId == userId)
                {
                    listaRaspored.Add(new Raspored
                    {
                        StudentId=x.StudentId,
                        Datum=x.Datum,
                        Naslov=x.Naslov,
                        Opis=x.Opis,
                        RasporedId=x.RasporedId,
                        Vazno=x.Vazno
                    });
                }
            }

            Application.Current.MainPage = new StudMojRasporedPrikazPage(userId, role, listaRaspored);
        }

        public List<uplate> listaUplata { get; set; } = new List<uplate>();

        public async void LoadPayments(int userId, int role)
        {
            List<uplate> t = await _service_uplata.Get<List<uplate>>(null);

            foreach (var x in t)
            {
                if (x.StudentId == userId)
                {
                    listaUplata.Add(new uplate
                    {
                        AdministracijaId = x.AdministracijaId,
                        DatumUplate=x.DatumUplate,
                        Evidentirao=x.Evidentirao,
                        Iznos=x.Iznos,
                        Ovjereno=x.Ovjereno,
                        Slika=x.Slika,
                        StudentId=x.StudentId,
                        Svrha=x.Svrha,
                        UplataId=x.UplataId,
                        Uplatio=x.Uplatio
                    });
                }
            }

            Application.Current.MainPage = new StudMojeUplatePrikazPage(userId, role, listaUplata);

        }

        public List<ispiti> listaIspita { get; set; } = new List<ispiti>();

        public async void LoadExams(int userId, int role)
        {
            var source = await _service_ispit.Get<List<ispiti>>(null);

            int[] niz = new int[30];
            int brojac = 0;

            var pohadjanja = await _service_pohadjanja.Get<List<pohadjanja>>(null);

            foreach (var x in pohadjanja)
            {
                if (x.StudentId == userId)
                {
                    niz[brojac] = (int)x.KursId;
                    brojac++;
                }
            }

            foreach (var y in source)
            {
                while (brojac >= 0)
                {
                    if (y.KursId == niz[brojac])
                    {
                        listaIspita.Add(new ispiti
                        {
                            BrojPitanja = y.BrojPitanja,
                            Datum = y.Datum,
                            IspitId = y.IspitId,
                            Kurs = y.Kurs,
                            KursId = y.KursId,
                            MaxBodova = y.MaxBodova,
                            ParcijalnoBodovanje = y.ParcijalnoBodovanje,
                            Profesor = y.Profesor,
                            ProfesorId = y.ProfesorId,
                            Trajanje = y.Trajanje,
                            Ucionica = y.Ucionica
                        });
                    }
                    brojac--;
                }
            }

            Application.Current.MainPage = new StudMojiIspitiPrikazPage(userId, role, listaIspita);
        }

        public List<obavijesti> listaObavijesti { get; set; } = new List<obavijesti>();

        public async void LoadNotifications(int userId, int role)
        {
            if (listaObavijesti.Count == 0)
            {
                var source = await _service_obavijest.Get<List<obavijesti>>(null);

                foreach(var x in source)
                {
                    listaObavijesti.Add(new obavijesti
                    {
                        Naslov=x.Naslov,
                        DatumObjave=x.DatumObjave,
                        ObavijestId=x.ObavijestId,
                        Objavio=x.Objavio,
                        ProfesorID=x.ProfesorID,
                        Sadrzaj=x.Sadrzaj
                    });
                }
            }

            Application.Current.MainPage = new StudObavijestiPage(userId, role, listaObavijesti);
        }

        public async void LoadMyData(int userId, int role)
        {
            var t = await _service.GetById<StudentAdmin>(userId);

            Application.Current.MainPage = new StudMojiPodaciPrikazPage(t, userId, role);
        }

        public async void Odjava()
        {
            var t =await Application.Current.MainPage.DisplayAlert("Upozorenje", "Da li ste sigurni da se želite odjaviti?", "Da", "Ne");

            if (t == true)
            {
                Application.Current.MainPage = new AuthPage();
            }
        }

        public ICommand Command_MojiPodaci { get; set; }
        public ICommand CommandKoPohadja { get; set; }
        public ICommand Command_Obavijesti { get; set; }
        public ICommand Command_Ispiti { get; set; }
        public ICommand Command_MojeUplate { get; set; }
        public ICommand Command_Mojraspored { get; set; }
        public ICommand Command_Administracija { get; set; }
        public ICommand Command_Profesori { get; set; }
        public ICommand Command_Odjava { get; set; }

        int _userId;
        public int UserID { get { return _userId; } set { SetProperty(ref _userId,value); } }

        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }
    }
}

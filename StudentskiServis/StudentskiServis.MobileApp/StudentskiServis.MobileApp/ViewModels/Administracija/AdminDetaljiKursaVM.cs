using StudentskiServis.MobileApp.ViewModels;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.Views.Administracija
{
    public class AdminDetaljiKursaVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Kurs");

        public AdminDetaljiKursaVM()
        {

        }

        public AdminDetaljiKursaVM(int userId, int role, kursevi t)
        {
            UkloniCommand = new Command(async () =>
            {
                var tmp = await Application.Current.MainPage.DisplayAlert("Poruka", "Da li ste sigurni da želite obrisati odabranu uplatu", "Da", "Ne");

                if (tmp == true)
                {
                    await _service.Delete(KursID);

                    Application.Current.MainPage = new AdminPage(role, userId);

                    await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno te uklonuli kurs", "OK");
                }
            });

            NazadCommand = new Command(async() =>
            {
                List<kursevi> temp = await _service.Get<List<kursevi>>(null);

                Application.Current.MainPage = new AdminPrikazKursevaPage(userId, role, temp);
            });
            KursID = t.KursId;
            Naziv = t.Naziv;
            ECTS = t.Ects;
            if (t.PosjedujeSeminarski == "Da")
                Seminarski = true;
            if (t.PosjedujePraksu == "Da")
                Praksa = true;
        }

        public ICommand NazadCommand { get; set; }
        public ICommand UkloniCommand { get; set; }

        int _kursId;
        public int KursID { get { return _kursId; } set{ SetProperty(ref _kursId, value); } }

        string _naziv;
        public string Naziv { get { return _naziv; } set{ SetProperty(ref _naziv,value); } }

        int? _ects;
        public int? ECTS { get { return _ects; } set{ SetProperty(ref _ects, value); } }

        bool _seminarski=false;
        public bool Seminarski { get { return _seminarski; } set{ SetProperty(ref _seminarski, value); } }

        bool _praksa = false;
        public bool Praksa { get { return _praksa; } set{ SetProperty(ref _praksa, value); } }


    }
}

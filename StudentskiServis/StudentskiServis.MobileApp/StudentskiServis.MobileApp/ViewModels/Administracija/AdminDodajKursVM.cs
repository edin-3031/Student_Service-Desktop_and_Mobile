using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Administracija
{
    public class AdminDodajKursVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Kurs");
        public AdminDodajKursVM()
        {

        }

        public AdminDodajKursVM(int role, int userId)
        {
            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new AdminPage(role,userId);
            });

            SnimiCommand = new Command(async() =>
            {
                kursevi temp = new kursevi
                {
                    Ects = ECTS,
                    Naziv = Naziv
                };

                if (Praksa == true)
                    temp.PosjedujePraksu = "Da";
                else if (Praksa == false)
                    temp.PosjedujePraksu = "Ne";

                if (Seminarski == true)
                    temp.PosjedujeSeminarski = "Da";
                else if (Seminarski == false)
                    temp.PosjedujeSeminarski = "Ne";

                try
                {
                    if (!string.IsNullOrWhiteSpace(Naziv) && ECTS > 0)
                    {
                        await _service.Insert(temp);
                        Application.Current.MainPage = new AdminPage(role, userId);
                        await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste unijeli nove podatke", "OK");
                    }

                }
                catch(Exception e)
                {
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Unijeli ste pogrešne podatke", "OK");
                };
            });
        }

        public ICommand NazadCommand { get; set; }
        public ICommand SnimiCommand { get; set; }

        string _naziv;
        public string Naziv { get { return _naziv; } set { SetProperty(ref _naziv, value); } }

        int? _ects;
        public int? ECTS { get { return _ects; } set { SetProperty(ref _ects, value); } }

        bool _seminarski = false;
        public bool Seminarski { get { return _seminarski; } set { SetProperty(ref _seminarski, value); } }

        bool _praksa = false;
        public bool Praksa { get { return _praksa; } set { SetProperty(ref _praksa, value); } }
    }
}

using StudentskiServis.MobileApp.Views.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudMojRasporedDetaljiIzmijeniVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Raspored");

        public StudMojRasporedDetaljiIzmijeniVM()
        {

        }

        public StudMojRasporedDetaljiIzmijeniVM(int userId, int role, Raspored raspored)
        {
            SnimiCommand = new Command(async() =>
            {
                raspored.Datum = Datum;
                raspored.Naslov = Naslov;
                raspored.Opis = Opis;
                if (Vazno == true)
                    raspored.Vazno = "Da";
                else if (Vazno == false)
                    raspored.Vazno = "Ne";

                await _service.Update<Raspored>(raspored.RasporedId, raspored);
                Application.Current.MainPage = new StudMojRasporedDetaljiPage(userId, role, raspored);
                await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješto ste izmijenili podatke", "OK");
            });
            
            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new StudMojRasporedDetaljiPage(userId, role, raspored);
            });

            Role = role;
            UserID = userId;
            Naslov = raspored.Naslov;
            Opis = raspored.Opis;
            Datum = raspored.Datum.Value;
            if (raspored.Vazno == "Da")
                Vazno = true;
        }

        public ICommand NazadCommand { get; set; }
        public ICommand SnimiCommand { get; set; }

        string _naslov;
        public string Naslov { get { return _naslov; } set { SetProperty(ref _naslov, value); } }
        string _opis;
        public string Opis { get { return _opis; } set { SetProperty(ref _opis, value); } }
        DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }
        bool _vazno = false;
        public bool Vazno { get { return _vazno; } set { SetProperty(ref _vazno, value); } }
        int _userId;
        public int UserID { get { return _userId; } set { SetProperty(ref _userId, value); } }
        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }
    }
}

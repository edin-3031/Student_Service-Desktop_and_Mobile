using StudentskiServis.MobileApp.Views;
using StudentskiServis.MobileApp.Views.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudMojiispitiDetaljiVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Ispit");
        public StudMojiispitiDetaljiVM()
        {

        }
        public StudMojiispitiDetaljiVM(ispiti temp, int userId, int role)
        {
            NazadCommand = new Command(() =>
            {
                Nazad(role, userId);
            });

            Datum = temp.Datum.Value;
            Trajanje = temp.Trajanje.ToString();
            Bodovi = temp.MaxBodova.ToString();
            Pitanja = temp.BrojPitanja.ToString();
            if(temp.ParcijalnoBodovanje=="Da")
                Parcijalno = true;
            Ucionica = temp.Ucionica;
            Kurs = temp.Kurs;
            Objavio = temp.Profesor;
        }

        public void Nazad(int role, int userId)
        {

            Application.Current.MainPage = new StudPage(role, userId);
        }

        public ICommand NazadCommand { get; set; }

        DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }
        
        string _trajanje;
        public string Trajanje { get { return _trajanje; } set { SetProperty(ref _trajanje, value); } }

        string _bodovi;
        public string Bodovi { get { return _bodovi; } set { SetProperty(ref _bodovi, value); } }

        string _pitanja;
        public string Pitanja { get { return _pitanja; } set { SetProperty(ref _pitanja, value); } }

        bool _parcijalno=false;
        public bool Parcijalno { get { return _parcijalno; } set { SetProperty(ref _parcijalno, value); } }

        string _ucionica;
        public string Ucionica { get { return _ucionica; } set { SetProperty(ref _ucionica, value); } }

        string _kurs;
        public string Kurs { get { return _kurs; } set { SetProperty(ref _kurs, value); } }

        string _objavio;
        public string Objavio { get { return _objavio; } set { SetProperty(ref _objavio, value); } }

        

    }
}

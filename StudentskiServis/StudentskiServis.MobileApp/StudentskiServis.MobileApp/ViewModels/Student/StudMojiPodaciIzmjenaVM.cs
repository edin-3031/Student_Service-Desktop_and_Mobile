using StudentskiServis.MobileApp.Views.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudMojiPodaciIzmjenaVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Student");
        public StudMojiPodaciIzmjenaVM()
        {

        }

        public StudMojiPodaciIzmjenaVM(int userId, int role, StudentAdmin t)
        {
            Ime = t.Ime;
            Prezime = t.Prezime;
            Mail = t.Mail;
            Adresa = t.Adresa;
            Telefon = t.Telefon;

            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new StudMojiPodaciPrikazPage(t, userId, role);
            });

            SnimiCommand = new Command(() =>
            {
                Snimi(userId, role, t);
            });
        }

        public async void Snimi(int userId, int role, StudentAdmin t)
        {
            t.Ime = Ime;
            t.Prezime = Prezime;
            t.Mail = Mail;
            t.Telefon = Telefon;
            t.Adresa = Adresa;
            await _service.Update<StudentAdmin>(userId, t);
            Application.Current.MainPage = new StudMojiPodaciPrikazPage(t, userId, role);
            await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste izmijenili podatke", "OK");
        }

        public ICommand NazadCommand { get; set; }
        public ICommand SnimiCommand { get; set; }

        string _ime;
        public string Ime { get { return _ime; } set { SetProperty(ref _ime, value); } }

        string _prezime;
        public string Prezime { get { return _prezime; } set { SetProperty(ref _prezime, value); } }

        string _mail;
        public string Mail { get { return _mail; } set { SetProperty(ref _mail, value); } }

        string _telefon;
        public string Telefon { get { return _telefon; } set { SetProperty(ref _telefon, value); } }

        string _adresa;
        public string Adresa { get { return _adresa; } set { SetProperty(ref _adresa, value); } }

    }
}

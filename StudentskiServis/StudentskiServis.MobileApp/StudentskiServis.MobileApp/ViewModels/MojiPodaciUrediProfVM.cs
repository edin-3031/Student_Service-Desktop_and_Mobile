using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class MojiPodaciUrediProfVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Profesor");
        public MojiPodaciUrediProfVM()
        {

        }
        
        public MojiPodaciUrediProfVM(int id, int role, ProfesorAdmin podaci)
        {
            Uredi(id, role, podaci);

            SnimiCommand = new Command(() =>
            {
                Snimi(id, role, podaci);
                Application.Current.MainPage = new MojiPodaciProfPage(id, role);
                Application.Current.MainPage.DisplayAlert("Izmjena", "Uspješno ste izvršili izmjene nad svojim podacima", "OK");
            });

            NazadCommad = new Command(() =>
            {
                Nazad(id,role);
            });
        }

        public void Nazad(int id, int role)
        {
            Application.Current.MainPage = new MojiPodaciProfPage(id, role);
        }

        public async void Snimi(int id, int role, ProfesorAdmin podaci)
        {
            podaci.Ime = Ime;
            podaci.Prezime = Prezime;
            podaci.Adresa = Adresa;
            podaci.Mail = Mail;

            await _service.Update<ProfesorAdmin>(id, podaci);
        }
        public ICommand SnimiCommand { get; set; }
        public ICommand NazadCommad { get; set; }

        public void Uredi(int id, int role, ProfesorAdmin podaci)
        {
            Prezime = podaci.Prezime;
            Ime = podaci.Ime;
            Mail = podaci.Mail;
            Adresa = podaci.Adresa;
            UserId = id;
            Role = role;
        }


        string _prezime=string.Empty;
        public string Prezime { get { return _prezime; } set { SetProperty(ref _prezime, value); } }

        string _ime = string.Empty;
        public string Ime { get { return _ime; } set { SetProperty(ref _ime, value); } }

        string _mail = string.Empty;
        public string Mail { get { return _mail; } set { SetProperty(ref _mail, value); } }

        string _adresa = string.Empty;
        public string Adresa { get { return _adresa; } set { SetProperty(ref _adresa, value); } }

        int _userId;
        public int UserId { get { return _userId; } set { SetProperty(ref _userId, value); } }

        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }
    }
}

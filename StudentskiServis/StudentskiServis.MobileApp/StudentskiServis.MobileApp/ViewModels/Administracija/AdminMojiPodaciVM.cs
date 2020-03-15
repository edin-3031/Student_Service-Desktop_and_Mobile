using StudentskiServis.MobileApp.Views;
using StudentskiServis.MobileApp.Views.Administracija;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Administracija
{
    public class AdminMojiPodaciVM:BaseViewModel
    {
        public AdminMojiPodaciVM()
        {

        }

        public AdminMojiPodaciVM(int userId, int role, AdministracijaAdmin t)
        {
            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage=new AdminPage(role,userId);
            });

            IzmijeniCommand = new Command(() =>
            {
                Application.Current.MainPage = new AdminMojiPodaciIzmjenaPage(role, userId, t);
            });

            UserID = userId;
            Role = role;

            Ime = t.Ime;
            Prezime = t.Prezime;
            Mail = t.Mail;
            Kancelarija = t.Kancelarija;
            Slika = ImageSource.FromStream(() => new MemoryStream(t.Slika));
            KorisnickoIme = t.KorisnickoIme;
            DatumRodjenja = t.DatumRodjenja.Value;
            DatumZaposlenja = t.DatumZaposlenja.Value;
            Adresa = t.Adresa;
            Spol = t.Spol;
            Staz= t.Staz;
            Ugovor = t.VrstaUgovora;
        }

        public ICommand NazadCommand { get; set; }
        public ICommand IzmijeniCommand { get; set; }

        int _userId;
        public int UserID { get { return _userId; } set { SetProperty(ref _userId, value); } }

        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }

        string _ime;
        public string Ime { get { return _ime; } set { SetProperty(ref _ime, value); } }
        string _prezime;
        public string Prezime { get { return _prezime; } set { SetProperty(ref _prezime, value); } }
        string _mail;
        public string Mail { get { return _mail; } set { SetProperty(ref _mail, value); } }
        string _kancelarija;
        public string Kancelarija { get { return _kancelarija; } set { SetProperty(ref _kancelarija, value); } }
        ImageSource _slika;
        public ImageSource Slika { get { return _slika; } set { SetProperty(ref _slika, value); } }
        string _ki;
        public string KorisnickoIme { get { return _ki; } set { SetProperty(ref _ki, value); } }
        DateTime _rodjenje;
        public DateTime DatumRodjenja { get { return _rodjenje; } set { SetProperty(ref _rodjenje, value); } }
        DateTime _zaposlenja;
        public DateTime DatumZaposlenja { get { return _zaposlenja; } set { SetProperty(ref _zaposlenja, value); } }
        string _adresa;
        public string Adresa{ get { return _adresa; } set { SetProperty(ref _adresa, value); } }
        string _spol;
        public string Spol{ get { return _spol; } set { SetProperty(ref _spol, value); } }
        int? _staz;
        public int? Staz{ get { return _staz; } set { SetProperty(ref _staz, value); } }
        string _ugovor;
        public string Ugovor { get { return _ugovor; } set { SetProperty(ref _ugovor, value); } }
    }
}

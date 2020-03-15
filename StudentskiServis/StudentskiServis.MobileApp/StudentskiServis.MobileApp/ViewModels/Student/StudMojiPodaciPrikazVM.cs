using StudentskiServis.MobileApp.Views;
using StudentskiServis.MobileApp.Views.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudMojiPodaciPrikazVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Student");
        public StudMojiPodaciPrikazVM()
        {

        }
        
        public StudMojiPodaciPrikazVM(int userId, int role, StudentAdmin t)
        {
            LoadData(userId, role, t);

            IzmijeniCommand = new Command(() =>
            {
                Izmijeni(userId,role,t);
            });

            NazadCommand = new Command(() =>
            {
                Nazad(role,userId);
            });

        }

        public ICommand NazadCommand { get; set; }
        public ICommand IzmijeniCommand { get; set; }

        public void Izmijeni(int userId, int role, StudentAdmin podatak)
        {
            Application.Current.MainPage = new StudMojiPodaciIzmjenaPage(userId, role, podatak);
        }

        public void Nazad(int userId, int role)
        {
            Application.Current.MainPage = new StudPage(role, userId);
        }

        public void LoadData(int userId, int role, StudentAdmin t)
        {
            //StudentAdmin t = await _service.GetById<StudentAdmin>(userId);

            _profId = userId;
            _role = role;
            Ime = t.Ime;
            Prezime = t.Prezime;
            Indeks = t.Indeks;
            DatumUpisa = t.DatumUpisa.Value;
            KorisnickoIme = t.KorisnickoIme;
            Mail = t.Mail;
            Adresa = t.Adresa;
            Telefon = t.Telefon;
            Status = t.Status;
            Prosjek = t.ProsjecnaOcjena.ToString();
            ObnavljaGodinu = t.ObnavljaGodinu;
            OvjerenSemestar = t.OvjerenSemestar.ToString();
            UpisanSemestar = t.UpisanSemestar.ToString();
            NacinStudiranja = t.NacinStudiranja;
            Slika = ImageSource.FromStream(() => new MemoryStream(t.Slika));
        }

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

        ImageSource _slika= null;
        public ImageSource Slika { get { return _slika; } set { SetProperty(ref _slika, value); } }

        string _nacinStudiranja;
        public string NacinStudiranja { get { return _nacinStudiranja; } set { SetProperty(ref _nacinStudiranja, value); } }

        string _upisanSemestar;
        public string UpisanSemestar { get { return _upisanSemestar; } set { SetProperty(ref _upisanSemestar, value); } }

        string _ovjerenSemestar;
        public string OvjerenSemestar { get { return _ovjerenSemestar; } set { SetProperty(ref _ovjerenSemestar, value); } }

        string _obanvalja;
        public string ObnavljaGodinu { get { return _obanvalja; } set { SetProperty(ref _obanvalja, value); } }

        string _prosjek;
        public string Prosjek { get { return _prosjek; } set { SetProperty(ref _prosjek, value); } }

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

        string _indeks;
        public string Indeks { get { return _indeks; } set { SetProperty(ref _indeks, value); } }

        DateTime _datumUpisa;
        public DateTime DatumUpisa { get { return _datumUpisa; } set { SetProperty(ref _datumUpisa, value); } }

        string _korisnickoIme;
        public string KorisnickoIme { get { return _korisnickoIme; } set { SetProperty(ref _korisnickoIme, value); } }


       

        string _status;
        public string Status { get { return _status; } set { SetProperty(ref _status, value); } }
    }
}

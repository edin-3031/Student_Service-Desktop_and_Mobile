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
    public class AdminDetaljiStudentVM:BaseViewModel
    {
        private APIService _servis = new APIService("Student");
        public AdminDetaljiStudentVM()
        {

        }

        public AdminDetaljiStudentVM(int _user, int _role, StudentAdmin t)
        {
            Ime = t.Ime;
            Prezime = t.Prezime;
            Indeks = t.Indeks;
            Mail = t.Mail;
            Slika = ImageSource.FromStream(() => new MemoryStream(t.Slika));
            KorisnickoIme = t.KorisnickoIme;
            DatumRodjenja = t.DatumRodjenja.Value;
            DatumUpisa = t.DatumUpisa.Value;
            Adresa = t.Adresa;
            Spol = t.Spol;
            Telefon = t.Telefon;
            Status = t.Status;
            NacinStudiranja = t.NacinStudiranja;
            UpisanSemastar = t.UpisanSemestar;
            OvjerenSemastar = t.OvjerenSemestar;
            ObnavljaGodinu = t.ObnavljaGodinu;
            Ocjena = t.ProsjecnaOcjena;

            NazadCommand = new Command(async() =>
            {
                List<StudentAdmin> lista = await _servis.Get<List<StudentAdmin>>(null);

                Application.Current.MainPage = new AdminPrikazStudenataPage(_user, _role, lista);
            });
        }

        public ICommand NazadCommand { get; set; }

        string _ime;
        public string Ime { get { return _ime; } set { SetProperty(ref _ime, value); } }
        string _indeks;
        public string Indeks { get { return _indeks; } set { SetProperty(ref _indeks, value); } }
        string _prezime;
        public string Prezime { get { return _prezime; } set { SetProperty(ref _prezime, value); } }
        string _mail;
        public string Mail { get { return _mail; } set { SetProperty(ref _mail, value); } }
        ImageSource _slika;
        public ImageSource Slika { get { return _slika; } set { SetProperty(ref _slika, value); } }
        string _ki;
        public string KorisnickoIme { get { return _ki; } set { SetProperty(ref _ki, value); } }
        DateTime _rodjenje;
        public DateTime DatumRodjenja { get { return _rodjenje; } set { SetProperty(ref _rodjenje, value); } }
        DateTime _upis;
        public DateTime DatumUpisa { get { return _upis; } set { SetProperty(ref _upis, value); } }
        string _adresa;
        public string Adresa { get { return _adresa; } set { SetProperty(ref _adresa, value); } }
        string _spol;
        public string Spol { get { return _spol; } set { SetProperty(ref _spol, value); } }
        string _sifra;
        public string Sifra { get { return _sifra; } set { SetProperty(ref _sifra, value); } }
        string _sifraPotvrda;
        public string SifraPotvrda { get { return _sifraPotvrda; } set { SetProperty(ref _sifraPotvrda, value); } }
        string _telefon;
        public string Telefon { get { return _telefon; } set { SetProperty(ref _telefon, value); } }
        string _status;
        public string Status { get { return _status; } set { SetProperty(ref _status, value); } }
        string _ns;
        public string NacinStudiranja { get { return _ns; } set { SetProperty(ref _ns, value); } }
        int? _us;
        public int? UpisanSemastar { get { return _us; } set { SetProperty(ref _us, value); } }
        int? _os;
        public int? OvjerenSemastar { get { return _os; } set { SetProperty(ref _os, value); } }
        string _og;
        public string ObnavljaGodinu { get { return _og; } set { SetProperty(ref _og, value); } }
        double? _ocjena;
        public double? Ocjena{ get { return _ocjena; } set { SetProperty(ref _ocjena, value); } }
    }
}

using StudentskiServis.MobileApp.Views;
using StudentskiServis.MobileApp.Views.Administracija;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Administracija
{
    public class AdminDodajAdministracijuVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Administracija");

        public AdminDodajAdministracijuVM()
        {

        }

        public AdminDodajAdministracijuVM(int role, int userId)
        {
            UserID = userId;
            Role = role;

            listaSpol.Insert(0, "Muško");
            listaSpol.Insert(1, "Žensko");

            NazadCommand = new Command(async() =>
            {
                List<AdministracijaAdmin> lista = await _service.Get<List<AdministracijaAdmin>>(null);

                Application.Current.MainPage = new AdminPrikazAdministracijePage(userId, role, lista);
            });

            SnimiCommand = new Command(async() =>
            {
                if (Sifra != SifraPotvrda)
                {
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Unesene šifre se podudaraju", "OK");
                }
                else if (Sifra == SifraPotvrda) {
                    temp.Adresa = Adresa;
                    temp.DatumRodjenja = DatumRodjenja;
                    temp.DatumZaposlenja = DatumZaposlenja;
                    temp.Ime = Ime;
                    temp.Kancelarija = Kancelarija;
                    temp.KorisnickoIme = KorisnickoIme;
                    temp.LozinkaHash = Sifra;
                    temp.LozinkaSalt = Sifra;
                    temp.Mail = Mail;
                    temp.Prezime = Prezime;
                    temp.Slika = null;
                    temp.Spol = Spol;
                    temp.Staz = Staz;
                    temp.VrstaUgovora = Ugovor;
                    try
                    {
                            await _service.Insert(temp);
                            Application.Current.MainPage = new AdminPage(role, userId);
                            await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste unijeli nove podatake", "OK");

                    }
                    catch (Exception exc)
                    {
                        await Application.Current.MainPage.DisplayAlert("Poruka", "Unseni podaci nisu dobri", "OK");
                    } 
                }
            });
        }

        public ICommand SnimiCommand { get; set; }
        public ICommand NazadCommand { get; set; }

        int _userId;
        public int UserID { get { return _userId; } set { SetProperty(ref _userId, value); } }

        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }

        public AdministracijaAdmin temp { get; set; } = new AdministracijaAdmin();

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
        public string Adresa { get { return _adresa; } set { SetProperty(ref _adresa, value); } }
        string _spol;
        public string Spol { get { return _spol; } set { SetProperty(ref _spol, value); } }
        int? _staz;
        public int? Staz { get { return _staz; } set { SetProperty(ref _staz, value); } }
        string _ugovor;
        public string Ugovor { get { return _ugovor; } set { SetProperty(ref _ugovor, value); } }
        string _sifra;
        public string Sifra { get { return _sifra; } set { SetProperty(ref _sifra, value); } }
        string _sifraPotvrsa;
        public string SifraPotvrda { get { return _sifraPotvrsa; } set { SetProperty(ref _sifraPotvrsa, value); } }

        public List<string> listaSpol { get; set; } = new List<string>();

    }
}

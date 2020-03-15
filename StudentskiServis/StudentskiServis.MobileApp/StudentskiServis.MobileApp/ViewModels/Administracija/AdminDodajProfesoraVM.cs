using StudentskiServis.MobileApp.Views;
using StudentskiServis.MobileApp.Views.Administracija;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Administracija
{
    public class AdminDodajProfesoraVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Profesor");
        public AdminDodajProfesoraVM()
        {

        }

        public AdminDodajProfesoraVM(int role, int userId)
        {
            NazadCommand = new Command(async() =>
            {
                List<ProfesorAdmin> lista = await _service.Get<List<ProfesorAdmin>>(null);

                Application.Current.MainPage = new AdminPrikazProfesoraPage(userId, role, lista);
            });

            SnimiCommand = new Command(async () =>
            {
                if (Sifra != SifraPotvrda)
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Unesene šifre se ne podudaraju", "OK");
                else if (Sifra == SifraPotvrda)
                {
                    ProfesorAdmin temp = new ProfesorAdmin
                    {
                        Adresa=Adresa,
                        DatumRodjenja=DatumRodjenja,
                        DatumZaposlenja=DatumZaposlenja,
                        Ime=Ime,
                        Kancelarija=Kancelarija,
                        KorisnickoIme=KorisnickoIme,
                        LozinkaHash=Sifra,
                        LozinkaSalt=Sifra,
                        Mail=Mail,
                        Prezime=Prezime,
                        Slika=null,
                        Spol=Spol,
                        Staz=Staz,
                        VrstaUgovora=Ugovor,
                        Zvanje=Zvanje
                    };

                    try
                    {
                        await _service.Insert(temp);
                        Application.Current.MainPage = new AdminPage(role, userId);
                        await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste sačuvali nove podatke", "OK");
                    }
                    catch (Exception e)
                    {
                       await Application.Current.MainPage.DisplayAlert("Poruka", "Uneseni podaci nisu ispravni", "OK");
                    }
                }
            });

            listaSpol.Insert(0, "Žensko");
            listaSpol.Insert(0, "Muško");
        }

        public ICommand NazadCommand { get; set; }

        public ICommand SnimiCommand { get; set; }

        string _ime;
        public string Ime { get { return _ime; } set { SetProperty(ref _ime, value); } }

        string _prezime;
        public string Prezime { get { return _prezime; } set { SetProperty(ref _prezime, value); } }

        string _zvanje;
        public string Zvanje { get { return _zvanje; } set { SetProperty(ref _zvanje, value); } }

        DateTime _rodjenje;
        public DateTime DatumRodjenja { get { return _rodjenje; } set { SetProperty(ref _rodjenje, value); } }

        DateTime _zaposlenje;
        public DateTime DatumZaposlenja { get { return _zaposlenje; } set { SetProperty(ref _zaposlenje, value); } }

        string _adresa;
        public string Adresa { get { return _adresa; } set { SetProperty(ref _adresa, value); } }

        string _mail;
        public string Mail { get { return _mail; } set { SetProperty(ref _mail, value); } }

        string _spol;
        public string Spol { get { return _spol; } set { SetProperty(ref _spol, value); } }

        int? _staz;
        public int? Staz { get { return _staz; } set { SetProperty(ref _staz, value); } }

        string _ugovor;
        public string Ugovor { get { return _ugovor; } set { SetProperty(ref _ugovor, value); } }

        string _kancelarija;
        public string Kancelarija { get { return _kancelarija; } set { SetProperty(ref _kancelarija, value); } }

        ImageSource _slika;
        public ImageSource Slika { get { return _slika; } set { SetProperty(ref _slika, value); } }

        string _sifra;
        public string Sifra { get { return _sifra; } set { SetProperty(ref _sifra, value); } }

        string _sifraPotvrda;
        public string SifraPotvrda { get { return _sifraPotvrda; } set { SetProperty(ref _sifraPotvrda, value); } }

        string _korisnickoIme;
        public string KorisnickoIme { get { return _korisnickoIme; } set { SetProperty(ref _korisnickoIme, value); } }

        public List<string> listaSpol { get; set; } = new List<string>();

    }

}

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
    public class AdminPrikazAdministracijeVM:BaseViewModel
    {
        public AdminPrikazAdministracijeVM()
        {

        }

        public AdminPrikazAdministracijeVM(int userId, int role, List<AdministracijaAdmin> lista)
        {
            NazadCommand = new Command(()=> {

                Application.Current.MainPage = new AdminPage(role, userId);

            });

            DodajCommand = new Command(() => {

                Application.Current.MainPage = new AdminDodajAdministracijuPage(role, userId);

            });

            foreach (var x in lista)
            {
                listaAdmin.Add(new AdministracijaAdmin
                {
                    AdministracijaId=x.AdministracijaId,
                    Adresa=x.Adresa,
                    DatumRodjenja=x.DatumRodjenja,
                    DatumZaposlenja=x.DatumZaposlenja,
                    Ime=x.Ime,
                    Kancelarija=x.Kancelarija,
                    KorisnickoIme=x.KorisnickoIme,
                    LozinkaHash=x.LozinkaHash,
                    LozinkaSalt=x.LozinkaSalt,
                    Mail=x.Mail,
                    Prezime=x.Prezime,
                    Slika=x.Slika,
                    Spol=x.Spol,
                    Staz=x.Staz,
                    VrstaUgovora=x.VrstaUgovora
                });
            }

            UserID = userId;
            Role = role;
        }

        public ICommand NazadCommand { get; set; }
        public ICommand DodajCommand { get; set; }

        public List<AdministracijaAdmin> listaAdmin { get; set; } = new List<AdministracijaAdmin>();

        int _userId;
        public int UserID { get { return _userId; } set { SetProperty(ref _userId, value); } }

        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }
    }
}

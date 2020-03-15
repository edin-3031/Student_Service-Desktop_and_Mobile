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
    public class AdminPrikazProfesoraVM:BaseViewModel
    {
        public AdminPrikazProfesoraVM()
        {

        }

        public AdminPrikazProfesoraVM(int userId, int role, List<ProfesorAdmin> lista)
        {
            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new AdminPage(role, userId);
            });

            DodajCommand = new Command(() =>
            {
                Application.Current.MainPage = new AdminDodajProfesoraPage(role, userId);
            });

            foreach(var x in lista)
            {
                listaProf.Add(new ProfesorAdmin
                {
                    Adresa=x.Adresa,
                    DatumRodjenja=x.DatumRodjenja,
                    DatumZaposlenja=x.DatumZaposlenja,
                    Ime=x.Ime,
                    Kancelarija=x.Kancelarija,
                    KorisnickiNalogId=x.KorisnickiNalogId,
                    KorisnickoIme=x.KorisnickoIme,
                    LozinkaHash=x.LozinkaHash,
                    LozinkaSalt=x.LozinkaSalt,
                    Mail=x.Mail,
                    Prezime=x.Prezime,
                    ProfesorId=x.ProfesorId,
                    Slika=x.Slika,
                    Spol=x.Spol,
                    Staz=x.Staz,
                    VrstaUgovora=x.VrstaUgovora,
                    Zvanje=x.Zvanje
                });
            }
        }

        public List<ProfesorAdmin> listaProf { get; set; } = new List<ProfesorAdmin>();
        public ICommand NazadCommand { get; set; }
        public ICommand DodajCommand { get; set; }

        
    }
}

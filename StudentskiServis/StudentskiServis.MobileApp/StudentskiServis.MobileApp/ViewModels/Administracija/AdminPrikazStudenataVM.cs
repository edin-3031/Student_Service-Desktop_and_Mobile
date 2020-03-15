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
    public class AdminPrikazStudenataVM:BaseViewModel
    {
        public AdminPrikazStudenataVM()
        {

        }

        public AdminPrikazStudenataVM(int userId, int role, List<StudentAdmin> lista)
        {
            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new AdminPage(role, userId);
            });

            DodajCommand = new Command(() =>
            {
                Application.Current.MainPage = new AdminDodajStudentaPage(role, userId);
            });

            foreach(var x in lista)
            {
                listaStudenata.Add(new StudentAdmin
                {
                    Adresa=x.Adresa,
                    DatumRodjenja=x.DatumRodjenja,
                    DatumUpisa=x.DatumUpisa,
                    Ime=x.Ime,
                    Indeks=x.Indeks,
                    KorisnickoIme=x.KorisnickoIme,
                    LozinkaHash=x.LozinkaHash,
                    LozinkaSalt=x.LozinkaSalt,
                    Mail=x.Mail,
                    NacinStudiranja=x.NacinStudiranja,
                    ObnavljaGodinu=x.ObnavljaGodinu,
                    OvjerenSemestar=x.OvjerenSemestar,
                    Prezime=x.Prezime,
                    ProsjecnaOcjena=x.ProsjecnaOcjena,
                    Slika=x.Slika,
                    Spol=x.Spol,
                    Status=x.Status,
                    StudentID=x.StudentID,
                    Telefon=x.Telefon,
                    UpisanSemestar=x.UpisanSemestar
                });
            }
        }

        public ICommand NazadCommand { get; set; }
        public ICommand DodajCommand { get; set; }
        public List<StudentAdmin> listaStudenata { get; set; } = new List<StudentAdmin>();
    }
}

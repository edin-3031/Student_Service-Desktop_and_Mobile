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
    public class AdminPrikazKursevaVM:BaseViewModel
    {
        public AdminPrikazKursevaVM()
        {

        }

        public AdminPrikazKursevaVM(int userId, int role, List<kursevi> lista)
        {
            foreach(var x in lista)
            {
                listaKurseva.Add(new kursevi
                {
                    Ects=x.Ects,
                    KursId=x.KursId,
                    Naziv=x.Naziv,
                    PosjedujePraksu=x.PosjedujePraksu,
                    PosjedujeSeminarski=x.PosjedujeSeminarski
                });
            }

            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new AdminPage(role, userId);
            });

            DodajCommand = new Command(() =>
            {
                Application.Current.MainPage = new AdminDodajKursPage(role, userId);
            });
        }

        public ICommand DodajCommand { get; set; }
        public ICommand NazadCommand { get; set; }

        public List<kursevi> listaKurseva { get; set; } = new List<kursevi>();
    }
}

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
    public class AdminPrikazUplataVM:BaseViewModel
    {

        public AdminPrikazUplataVM()
        {

        }

        public AdminPrikazUplataVM(int userId, int role, List<uplate> lista)
        {
            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new AdminPage(role, userId);
            });

            DodajCommand = new Command(() =>
            {
                Application.Current.MainPage = new AdminDodajUplatuPage(role, userId);
            });


            foreach(var x in lista)
            {
                listaUplata.Add(new uplate
                {
                    AdministracijaId=x.AdministracijaId,
                    DatumUplate=x.DatumUplate,
                    Evidentirao=x.Evidentirao,
                    Iznos=x.Iznos,
                    Ovjereno=x.Ovjereno,
                    Slika=x.Slika,
                    StudentId=x.StudentId,
                    Svrha=x.Svrha,
                    UplataId=x.UplataId,
                    Uplatio=x.Uplatio
                });
            }

        }

        public ICommand NazadCommand { get; set; }
        public ICommand DodajCommand { get; set; }

        public List<uplate> listaUplata { get; set; } = new List<uplate>();
    }
}

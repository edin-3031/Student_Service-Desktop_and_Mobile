using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudProfPrikazVM:BaseViewModel
    {
        public StudProfPrikazVM()
        {

        }

        public StudProfPrikazVM(int userId, int role, List<ProfesorAll> listaProf)
        {
            foreach(var x in listaProf)
            {
                lista.Add(new ProfesorAll
                {
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    Zvanje = x.Zvanje,
                    Kancelarija = x.Kancelarija,
                    KorisnickiNalogId = x.KorisnickiNalogId,
                    Mail = x.Mail,
                    ProfesorId = x.ProfesorId,
                    Slika = x.Slika
                });
            }

            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new StudPage(role, userId);
            });
        }

        public ICommand NazadCommand { get; set; }

        public List<ProfesorAll> lista { get; set; } = new List<ProfesorAll>();

        

    }
}

using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudMojRasporedPrikazVM:BaseViewModel
    {
        public StudMojRasporedPrikazVM()
        {

        }

        public StudMojRasporedPrikazVM(int userId, int role, List<Raspored> listaRaspored)
        {
            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new StudPage(role, userId);
            });

            Load(userId, role, listaRaspored);
        }

        public ICommand NazadCommand { get; set; }

        public List<Raspored> lista { get; set; } = new List<Raspored>();

        void Load(int userId, int role, List<Raspored> listaRaspored)
        {
            foreach(var x in listaRaspored)
            {
                lista.Add(new Raspored
                {
                    Datum=x.Datum,
                    Naslov=x.Naslov,
                    Opis=x.Opis,
                    RasporedId=x.RasporedId,
                    StudentId=x.StudentId,
                    Vazno=x.Vazno
                });
            }
        }
    }
}

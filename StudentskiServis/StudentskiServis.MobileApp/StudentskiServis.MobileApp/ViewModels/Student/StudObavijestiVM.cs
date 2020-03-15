using StudentskiServis.MobileApp.Views;
using StudentskiServis.MobileApp.Views.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    class StudObavijestiVM:BaseViewModel
    {

        public StudObavijestiVM()
        {

        }

        public StudObavijestiVM(int userId, int role, List<obavijesti> listaObavijesti)
        {
            LoadNotifications(userId, role, listaObavijesti);

            NazadCommand = new Command(() =>
            {
                Nazad(userId,role);
            });
        }

        public void Nazad(int userId, int role)
        {
            Application.Current.MainPage = new StudPage(role, userId);
        }
        public void LoadNotifications(int userId, int role, List<obavijesti> listaObavijesti)
        {
            foreach(var x in listaObavijesti)
            {
                _listaObavijesti.Add(new obavijesti
                {
                    DatumObjave = x.DatumObjave,
                    Naslov = x.Naslov,
                    ObavijestId = x.ObavijestId,
                    Objavio = x.Objavio,
                    ProfesorID = x.ProfesorID,
                    Sadrzaj = x.Sadrzaj
                });
            }
        }

        int _userId;
        public int UserID { get { return _userId; } set { SetProperty(ref _userId,value); } }

        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }

        public ICommand NazadCommand { get; set; }
        public List<obavijesti> _listaObavijesti { get; set; } = new List<obavijesti>();
    }
}

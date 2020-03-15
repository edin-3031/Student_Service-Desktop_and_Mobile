using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    class StudMojiIspitiPrikazVM:BaseViewModel
    {
        public StudMojiIspitiPrikazVM()
        {

        }

        public StudMojiIspitiPrikazVM(int userId, int role, List<ispiti> listaIspita)
        {
            LoadData(userId, role, listaIspita);

            NazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new StudPage(role, userId);
                UserID = userId;
                Role = role;
            });
        }

        public ICommand NazadCommand { get; set; }

        public List<ispiti> lista { get; set; } = new List<ispiti>();

        public void LoadData(int userId, int role, List<ispiti> listaIspita) { 
            foreach(var x in listaIspita)
            {
                lista.Add(new ispiti
                {
                    BrojPitanja = x.BrojPitanja,
                    Datum=x.Datum,
                    IspitId=x.IspitId,
                    Kurs=x.Kurs,
                    KursId=x.KursId,
                    MaxBodova=x.MaxBodova,
                    ParcijalnoBodovanje=x.ParcijalnoBodovanje,
                    Profesor=x.Profesor,
                    ProfesorId=x.ProfesorId,
                    Trajanje=x.Trajanje,
                    Ucionica=x.Ucionica
                });
            }
            UserID = userId;
            Role = role;
        }

        int _userId;
        public int UserID { get { return _userId; } set { SetProperty(ref _userId, value); } }

        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }
    }
}

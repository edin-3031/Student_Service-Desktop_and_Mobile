using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudMojeUplatePrikazVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Uplata");
        public StudMojeUplatePrikazVM()
        {

        }

        public StudMojeUplatePrikazVM(int userId, int role, List<uplate> lista)
        {
            //Load(userId, role, lista);

            Nazad_Command = new Command(() =>
            {
                Application.Current.MainPage = new StudPage(role, userId);
            });
        }

        public List<uplate> listaUplata { get; set; } = new List<uplate>();

        public ICommand Nazad_Command { get; set; }

        public void Load(int userId, int role, List<uplate> lista)
        {
            foreach(var x in lista)
            {
                if (x.StudentId == userId)
                {
                    listaUplata.Add(new uplate
                    {
                        AdministracijaId = x.AdministracijaId,
                        DatumUplate = x.DatumUplate,
                        Evidentirao = x.Evidentirao,
                        Iznos = x.Iznos,
                        Ovjereno = x.Ovjereno,
                        Slika = x.Slika,
                        StudentId = x.StudentId,
                        Svrha = x.Svrha,
                        UplataId = x.UplataId,
                        Uplatio = x.Uplatio
                    });
                }
            }
        }
    }
}

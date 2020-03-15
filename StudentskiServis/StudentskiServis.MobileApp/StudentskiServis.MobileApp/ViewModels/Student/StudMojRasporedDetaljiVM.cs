using StudentskiServis.MobileApp.Views.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudMojRasporedDetaljiVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Raspored");
        public StudMojRasporedDetaljiVM()
        {

        }

        public StudMojRasporedDetaljiVM(int userId, int role, Raspored raspored)
        {
            IzmijeniCommand = new Command(() => {
                Application.Current.MainPage = new StudMojRasporedDetaljiIzmijeniPage(userId, role, raspored);
            });

            NazadCommand = new Command(async() =>
            {
                var source = await _service.Get<List<Raspored>>(null);

                List<Raspored> lista = new List<Raspored>();

                foreach(var x in source)
                {
                    if (x.StudentId == userId)
                    {
                        lista.Add(new Raspored
                        {
                            RasporedId = x.RasporedId,
                            StudentId = x.StudentId,
                            Datum = x.Datum,
                            Naslov = x.Naslov,
                            Opis = x.Opis,
                            Vazno = x.Vazno
                        });
                    }
                }

                Application.Current.MainPage = new StudMojRasporedPrikazPage(userId, role, lista);
            });

            Role = role;
            UserID = userId;
            Naslov = raspored.Naslov;
            Opis = raspored.Opis;
            Datum = raspored.Datum.Value;
            if (raspored.Vazno == "Da")
                Vazno = true;
        }

        public ICommand NazadCommand { get; set; }
        public ICommand IzmijeniCommand { get; set; }

        string _naslov;
        public string Naslov { get { return _naslov; } set { SetProperty(ref _naslov,value); } }
        string _opis;
        public string Opis { get { return _opis; } set { SetProperty(ref _opis,value); } }
        DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }
        bool _vazno=false;
        public bool Vazno { get { return _vazno; } set { SetProperty(ref _vazno, value); } }
        int _userId;
        public int UserID{ get { return _userId; } set { SetProperty(ref _userId, value); } }
        int _role;
        public int Role{ get { return _role; } set { SetProperty(ref _role, value); } }


    }
}

using StudentskiServis.MobileApp.Views.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudObavijestiDetaljiVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Obavijest");
        public StudObavijestiDetaljiVM()
        {

        }

        public StudObavijestiDetaljiVM(int UserID, int Role, obavijesti temp)
        {
            Objavio = temp.Objavio;
            Naslov = temp.Naslov;
            Datum = temp.DatumObjave;
            Sadrzaj = temp.Sadrzaj;

            NazadCommand = new Command( async() =>
            {
                var t = await _service.Get<List<obavijesti>>(null);

                Application.Current.MainPage = new StudObavijestiPage(UserID, Role, t);
            });
        }

        public ICommand NazadCommand { get; set; }
        string _objavio;
        public string Objavio { get { return _objavio; } set { SetProperty(ref _objavio,value); } }
        string _naslov;
        public string Naslov { get { return _naslov; } set { SetProperty(ref _naslov, value); } }
        string _sadrzaj;
        public string Sadrzaj { get { return _sadrzaj; } set { SetProperty(ref _sadrzaj, value); } }
        DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }
    }
}

using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class ObavijestiPrikazVM:BaseViewModel
    {
        public ObavijestiPrikazVM()
        {

        }
        public List<obavijesti> listaSource { get; set; } = new List<obavijesti>();

        public ObavijestiPrikazVM(List<obavijesti> lista, int profId, int role)
        {
            ProfID = profId;
            Role = role;
            
            foreach(var x in lista)
            {
                listaSource.Add(new obavijesti
                {
                    DatumObjave=x.DatumObjave,
                    Naslov=x.Naslov,
                    ObavijestId=x.ObavijestId,
                    ProfesorID=x.ProfesorID,
                    Objavio=x.Objavio
                });
            }

            NazadCommand = new Command(() =>
            {
                Nazad(ProfID, Role);
            });

            DodajCommand = new Command(() =>
            {
                Dodaj(ProfID, Role);
            });
        }

        public ICommand NazadCommand { get; set; }
        public ICommand DodajCommand { get; set; }

        public void Nazad(int id, int role)
        {
            Application.Current.MainPage = new ProfPage(id, role);
        }

        public void Dodaj(int id, int role)
        {
            Application.Current.MainPage = new ObavijestDodajProf(id, role);
        }

        public void LoadNotification(int userId, int role, obavijesti temp)
        {
            //var temp = new obavijesti
            //{
            //    DatumObjave = _datum,
            //    Naslov = _naslov,
            //    ObavijestId = _obavijestId,
            //    Objavio = _objavio,
            //    ProfesorID = _prof_id,
            //    Sadrzaj = _sadrzaj
            //};

            Application.Current.MainPage = new ObavijestiDetaljiProf(userId, role, temp);
        }

        int ProfID;
        public int _profId { get { return ProfID; } set { SetProperty(ref ProfID, value); } }

        int Role;
        public int _role { get { return Role; } set { SetProperty(ref Role, value); } }

        int _obavijestId;
        public int ObavijestId { get { return _obavijestId; } set { SetProperty(ref _obavijestId, value); } }

        int? _prof_id;
        public int? ProfesorID { get { return _prof_id; } set { SetProperty(ref _prof_id, value); } }

        string _objavio = string.Empty;
        public string Objavio { get { return _objavio; } set { SetProperty(ref _objavio,value); } }

        DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }

        string _naslov = string.Empty;
        public string Naslov { get { return _naslov; } set { SetProperty(ref _naslov, value); } }

        string _sadrzaj = string.Empty;
        public string Sadrzaj { get { return _sadrzaj; } set { SetProperty(ref _sadrzaj, value); } }
    }
}

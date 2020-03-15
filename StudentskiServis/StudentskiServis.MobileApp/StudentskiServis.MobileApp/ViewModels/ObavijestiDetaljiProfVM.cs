using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class ObavijestiDetaljiProfVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Obavijest");
        public ObavijestiDetaljiProfVM()
        {

        }

        public ObavijestiDetaljiProfVM(int userId, int role, obavijesti temp)
        {
            ProfID = userId;
            Role = role;
            ObavijestId = temp.ObavijestId;
            ProfesorID = temp.ProfesorID;
            Objavio = temp.Objavio;
            Datum = temp.DatumObjave;
            Naslov = temp.Naslov;
            Sadrzaj = temp.Sadrzaj;

            NazadCommand = new Command(() =>
            {
                Nazad(userId,role);
            });

            IzmijeniCommand = new Command(() =>
            {
                Izmijeni(userId,role,ObavijestId,ProfesorID);
            });

            UkloniCommand = new Command(() =>
            {
                Ukloni(userId,role, ObavijestId);
            });
        }
        public ICommand NazadCommand { get; set; }
        public ICommand IzmijeniCommand { get; set; }
        public ICommand UkloniCommand { get; set; }

        public async void Ukloni(int userId, int role, int obavijestId)
        {
            var t = await Application.Current.MainPage.DisplayAlert("Upozorenje", "Da li ste sigurni da želite uklonuti odabranu obavijest?", "Da", "Ne");

            if (t == true)
            {
                var temp = await _service.Delete(obavijestId);
                List<obavijesti> lista = await _service.Get<List<obavijesti>>(null);
                Application.Current.MainPage = new ObavijestiPage(lista, userId, role);
                await Application.Current.MainPage.DisplayAlert("Poruka","Uspješno ste uklonuli obavijest","OK");
            }
        }

        public void Izmijeni(int userId, int role, int obavijestId, int? objavioId)
        {
            Application.Current.MainPage = new ObavijestIzmijeniProf(userId, role, obavijestId, objavioId);

        }

        public async void Nazad(int userId, int role)
        {
            var list = await _service.Get<List<obavijesti>>(null);

            Application.Current.MainPage = new ObavijestiPage(list,userId,role);
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
        public string Objavio { get { return _objavio; } set { SetProperty(ref _objavio, value); } }

        DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }

        string _naslov = string.Empty;
        public string Naslov { get { return _naslov; } set { SetProperty(ref _naslov, value); } }

        string _sadrzaj = string.Empty;
        public string Sadrzaj { get { return _sadrzaj; } set { SetProperty(ref _sadrzaj, value); } }
    }
}

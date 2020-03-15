using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class ObavijestDodajProfVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Obavijest");
        private readonly APIService _service_profesori = new APIService("Profesor");
        public ObavijestDodajProfVM()
        {

        }

        public ObavijestDodajProfVM(int userId, int role)
        {
            NazadCommand = new Command(() =>
            {
                Nazad(userId, role);
            });

            DodajCommand = new Command(() =>
            {
                Dodaj(userId,role);
            });
        }

        public async void Dodaj(int userId, int role)
        {
            var objavio = await _service_profesori.GetById<ProfesorAll>(userId);

            obavijesti temp = new obavijesti
            {
                DatumObjave = Datum,
                Naslov = Naslov,
                Objavio = objavio.Ime + " " + objavio.Prezime,
                ProfesorID = userId,
                Sadrzaj = Sadrzaj
            };

            await _service.Insert(temp);
            var lista = await _service.Get<List<obavijesti>>(null);
            Application.Current.MainPage = new ObavijestiPage(lista, userId, role);
            await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste dodali novu obavijest", "OK");
        }

        public async void Nazad(int userId, int role)
        {
            var t = await _service.Get<List<obavijesti>>(null);

            Application.Current.MainPage = new ObavijestiPage(t, userId, role);
        }

        public ICommand NazadCommand { get; set; }
        public ICommand DodajCommand { get; set; }

        string _naslov;
        public string Naslov { get { return _naslov; } set { SetProperty(ref _naslov,value); } }
        string _sadrzaj;
        public string Sadrzaj{ get { return _sadrzaj; } set { SetProperty(ref _sadrzaj, value); } }
        DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }
        int _objavioId;
        public int ObjavioID { get { return _objavioId; } set { SetProperty(ref _objavioId, value); } }
    }
}

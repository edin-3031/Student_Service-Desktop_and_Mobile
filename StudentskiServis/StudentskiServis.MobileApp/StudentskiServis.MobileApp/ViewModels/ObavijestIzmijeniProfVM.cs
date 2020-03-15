using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class ObavijestIzmijeniProfVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Obavijest");
        private readonly APIService _service_profesori = new APIService("PROF");
        public ObavijestIzmijeniProfVM()
        {

        }

        public ObavijestIzmijeniProfVM(int userId, int role, int obavijestId, int? objavioId)
        {
            NazadCommand = new Command(() =>
            {
                Nazad(userId, role,obavijestId);
            });

            IzmijeniCommand = new Command(() =>
            {
                Izmijeni(userId, role, obavijestId, objavioId);
            });
        }

        public async void Izmijeni(int userId, int role, int obavijestId, int? objavioId)
        {
            var t = await _service.GetById<obavijesti>(obavijestId);
            var lista = await _service.Get<List<obavijesti>>(null);

            t.Naslov = Naslov;
            t.DatumObjave = Datum;
            t.Sadrzaj = Sadrzaj;

            try
            {
                t.ProfesorID = Izabrani.ProfesorId;
            }
            catch (NullReferenceException e)
            {
                t.ProfesorID = userId;
            }
            await _service.Update<obavijesti>(obavijestId, t);
            Application.Current.MainPage = new ObavijestiPage(lista, userId, role);
            await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste izmijenili obavijest","OK");
        }

        public async void Nazad(int userId, int role, int obavijestiId)
        {
            var t = await _service.GetById<obavijesti>(obavijestiId);

            Application.Current.MainPage = new ObavijestiDetaljiProf(userId, role, t);
        }

        public ObservableCollection<PROF> lista { get; set; } = new ObservableCollection<PROF>();

        public async void LoadData(int userId, int role, int obavijestId, int? objavioId)
        {
            var t = await _service.GetById<obavijesti>(obavijestId);
            var sourcePROF = await _service_profesori.Get<List<PROF>>(null);

            foreach(var x in sourcePROF)
            {
                lista.Add(x);
            }

            ProfesorId = t.ProfesorID;
            Naslov = t.Naslov;
            Sadrzaj = t.Sadrzaj;
            Datum = t.DatumObjave;
            Objavio = t.Objavio;
        }

        PROF _izabrani;
        public PROF Izabrani { get { return _izabrani; } set { SetProperty(ref _izabrani, value); } }

        public ICommand NazadCommand { get; set; }
        public ICommand IzmijeniCommand { get; set; }

        int? _profesorId;
        public int? ProfesorId { get { return _profesorId; } set { SetProperty(ref _profesorId,value); } }
        
        string _naslov;
        public string Naslov{ get { return _naslov; } set { SetProperty(ref _naslov,value); } }

        string _sadrzaj;
        public string Sadrzaj { get { return _sadrzaj; } set { SetProperty(ref _sadrzaj, value); } }

        DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }

        string _objavio;
        public string Objavio { get { return _objavio; } set { SetProperty(ref _objavio, value); } }


    }
}

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
    public class IspitDodajProfVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Profesor");
        private readonly APIService _service_ispit = new APIService("Ispit");
        private readonly APIService _service_kurs = new APIService("Kurs");
        public IspitDodajProfVM()
        {

        }

        public IspitDodajProfVM(int id, int role)
        {
            LoadKurseve();

            NazadCommand = new Command( async() =>
            {
                var t = await _service_ispit.Get<List<ispiti>>(null);

                Nazad(id, role, t);
            });

            DodajCommand = new Command(async() =>
            {
                ProfesorAll temp = await _service.GetById<ProfesorAll>(id);

                ispiti podaci = new ispiti
                {
                    BrojPitanja = Bodovi,
                    Datum = DatumOdrzavanja,
                    KursId = Izabrani.KursId,
                    MaxBodova = Bodovi,
                    ParcijalnoBodovanje = Parcijalno,
                    ProfesorId = id,
                    Trajanje = Trajanje,
                    Ucionica = Ucionica,
                    Kurs = Izabrani.Naziv,
                    Profesor = temp.Zvanje + " " + temp.Ime + " " + temp.Prezime
                };
                Dodaj(id, role, podaci);
            });
        }

        KURS_ _izabrani;
        public KURS_ Izabrani { get { return _izabrani; } set { SetProperty(ref _izabrani,value); } }

        public void Nazad(int id, int role, List<ispiti> podaci)
        {
            Application.Current.MainPage = new ProfPage(id, role);
        }

        public ObservableCollection<KURS_> kurseviLista { get; set; } = new ObservableCollection<KURS_>();

        public async void LoadKurseve()
        {
            var t = await _service_kurs.Get<List<KURS_>>(null);

            foreach(var x in t)
            {
                kurseviLista.Add(x);
            }
        }

        public async void Dodaj(int id, int role, ispiti podaci)
        {
            if (podaci.ParcijalnoBodovanje == "")
                podaci.ParcijalnoBodovanje = "Ne";
            if (podaci.Datum.ToString() == "1/1/0001 12:00:00 AM")
                podaci.Datum = DateTime.Today;
            await _service_ispit.Insert(podaci);
            var t = await _service_ispit.Get<List<ispiti>>(null);
            Application.Current.MainPage = new ProfPage(id, role);
            await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste dodali novi ispit", "OK");
        }

        public ICommand DodajCommand { get; set; }

        public ICommand NazadCommand { get; set; }

        string _parcijalo = string.Empty;
        public string Parcijalno { get { return _parcijalo; } set { SetProperty(ref _parcijalo, value); } }

        int _kursId;
        public int KursID { get { return _kursId; } set { SetProperty(ref _kursId, value); } }

        DateTime _datumOdrzavanja;
        public DateTime DatumOdrzavanja { get { return _datumOdrzavanja; } set { SetProperty(ref _datumOdrzavanja, value); } }

        string _ucionica;
        public string Ucionica { get { return _ucionica; } set { SetProperty(ref _ucionica, value); } }

        int _trajanje;
        public int Trajanje { get { return _trajanje; } set { SetProperty(ref _trajanje, value); } }

        int _bodovi;
        public int Bodovi { get { return _bodovi; } set { SetProperty(ref _bodovi, value); } }

        int _pitanja;
        public int Pitanja { get { return _pitanja; } set { SetProperty(ref _pitanja, value); } }


    }
}

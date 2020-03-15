using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class IspitIzmjenaProfVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("ispit");
        private readonly APIService _service_kurs = new APIService("KURS_");
        public IspitIzmjenaProfVM()
        {
        }
        public IspitIzmjenaProfVM(int userId, int role, int ispitId, ispiti podaci)
        {
            //LoadPodatke(userId, role, ispitId, podaci);
            SnimiCommand = new Command(() =>
            {
                Snimi(userId, role, ispitId, podaci);
            });

            nazadCommand=new Command(() =>{

                Nazad(userId, role);
            });
        }

        public async void Nazad(int userId, int role)
        {
            var t = await _service.Get<List<ispiti>>(null);

            Application.Current.MainPage = new ProfPage(userId, role);
        }

        public async void Snimi(int userId, int role, int ispitId, ispiti podaci)
        {
            var t = await _service.Get<List<ispiti>>(null);

            podaci.BrojPitanja = int.Parse(_pitanja);
            podaci.Datum = _datum;
            podaci.KursId = 1;
            podaci.MaxBodova = int.Parse(_bodovi);
            if (_parcijalno == false)
                podaci.ParcijalnoBodovanje = "Ne";
            else if (_parcijalno == true)
                podaci.ParcijalnoBodovanje = "Da";
            podaci.ProfesorId = userId;
            podaci.Trajanje =int.Parse(_trajanje);
            podaci.Ucionica = _ucionica;



            await _service.Update<ispiti>(ispitId, podaci);
            Application.Current.MainPage = new ProfPage(userId, role);
            await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste izmijenili ispit", "OK");
        }

        public async void LoadPodatke(int userId, int role, int ispitId, ispiti podaci)
        {
            var lista = await _service_kurs.Get<List<KURS_>>(null);

            foreach(var x in lista)
            {
                listaKurseva.Add(new KURS_
                {
                    KursId=x.KursId,
                    Naziv=x.Naziv
                });
            }

            Ucionica = podaci.Ucionica;
            Datum = podaci.Datum.Value;
            Trajanje = podaci.Trajanje.ToString();
            Pitanja=podaci.BrojPitanja.ToString();
            Bodovi=podaci.MaxBodova.ToString();
            if (podaci.ParcijalnoBodovanje == "Da")
                Parcijalno = true;
        }

        public ICommand SnimiCommand { get; set; }
        public ICommand nazadCommand { get; set; }

        public List<KURS_> listaKurseva { get; set; } = new List<KURS_>();

        public string _ucionica = string.Empty;
        public string Ucionica { get { return _ucionica; } set { SetProperty(ref _ucionica, value); } }

        public DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }

        public string _trajanje = string.Empty;
        public string Trajanje { get { return _trajanje; } set { SetProperty(ref _trajanje, value); } }

        public string _pitanja = string.Empty;
        public string Pitanja { get { return _pitanja; } set { SetProperty(ref _pitanja, value); } }

        public string _bodovi = string.Empty;
        public string Bodovi { get { return _bodovi; } set { SetProperty(ref _bodovi, value); } }

        public bool _parcijalno = false;
        public bool Parcijalno { get { return _parcijalno; } set { SetProperty(ref _parcijalno, value); } }
    }
}

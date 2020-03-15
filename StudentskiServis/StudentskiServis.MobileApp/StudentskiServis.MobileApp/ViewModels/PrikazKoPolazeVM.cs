using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class PrikazKoPolazeVM:BaseViewModel
    {
        private readonly APIService _service_KURS = new APIService("KURS_");
        private readonly APIService _service_ISPITI = new APIService("Ispit");
        private readonly APIService _service_Tragaj = new APIService("Tragaj");

        public PrikazKoPolazeVM()
        {

        }
        public PrikazKoPolazeVM(int userId, int role, List<KoPohadja> lista)
        {
            LoadList(lista);
            nazadCommand = new Command(() =>
            {
                Application.Current.MainPage = new KoPohadjaPage(userId, role);
            });
            LoadKurseve();
            Role = role;
            UserID = userId;
            Trazi = new Command(() =>
            {
                Tragaj(IzabraniKurs.KursId, DatumOD, DatumDO);
            });
        }

        public async void Tragaj(int kursId, DateTime DatumOd, DateTime DatumDo)
        {
            lista.Clear();
            lista = new List<KoPohadja>();
            TragajRequest request = new TragajRequest
            {
                DO = DatumDo,
                KursId = kursId,
                OD = DatumOd
            };

            List<KoPohadja> listaPohadjanja = await _service_Tragaj.Get<List<KoPohadja>>(request);

            foreach (var x in listaPohadjanja)
            {
                lista.Add(new KoPohadja
                {
                    Ime = x.Ime,
                    Ocjena = x.Ocjena,
                    Prezime = x.Prezime
                });
            }

            Application.Current.MainPage = new PrikazKoPolazePage(UserID, Role, lista);
        }

        public async void LoadKurseve()
        {
            var source = await _service_KURS.Get<List<KURS_>>(null);

            foreach (var x in source)
            {
                listaKurseva.Add(x);
            }
        }

        public void LoadList(List<KoPohadja> lista)
        {
            foreach(var x in lista)
            {
                Lista.Add(new KoPohadja
                {
                    Ime=x.Ime,
                    Ocjena=x.Ocjena,
                    Prezime=x.Prezime
                });
            }
        }

        public ICommand nazadCommand { get; set; }

        public List<KoPohadja> Lista { get; set; } = new List<KoPohadja>();

        public ICommand Trazi { get; set; }

        public List<KoPohadja> lista { get; set; } = new List<KoPohadja>();

        public ObservableCollection<KURS_> listaKurseva { get; set; } = new ObservableCollection<KURS_>();

        int _user;
        public int UserID { get { return _user; } set { SetProperty(ref _user, value); } }

        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }


        DateTime _datumOD;
        public DateTime DatumOD { get { return _datumOD; } set { SetProperty(ref _datumOD, value); } }

        DateTime _datumDO;
        public DateTime DatumDO { get { return _datumDO; } set { SetProperty(ref _datumDO, value); } }

        KURS_ _izabrani;
        public KURS_ IzabraniKurs { get { return _izabrani; } set { SetProperty(ref _izabrani, value); } }
    }
}

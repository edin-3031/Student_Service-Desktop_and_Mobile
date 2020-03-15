using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class MojiPodaciProfVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Profesor");
        public MojiPodaciProfVM(int id, int role)
        {
            ProfID = id;
            Role = role;

            NazadCommand = new Command(() =>
            {
                Nazad(_profId, role);
            });

            UrediCommand = new Command(() =>
            {
                Uredi(_profId, role, temp);
            });
        }

        //public MojiPodaciProfVM()
        //{
        //    NazadCommand = new Command(() =>
        //    {
        //        Nazad(ProfID, Role);
        //    });
        //}


        int ProfID;
        public int _profId { get { return ProfID; } set { SetProperty(ref ProfID,value); } }

        int Role;
        public int _role { get { return Role; } set { SetProperty(ref Role, value); } }

        string Ime=string.Empty;
        public string _ime { get { return Ime; } set { SetProperty(ref Ime, value); } }

        string Prezime = string.Empty;
        public string _prezime { get { return Prezime; } set { SetProperty(ref Prezime, value); } }

        string Zvanje = string.Empty;
        public string _zvanje { get { return Zvanje; } set { SetProperty(ref Zvanje, value); } }

        string Mail = string.Empty;
        public string _mail { get { return Mail; } set { SetProperty(ref Mail, value); } }

        string Kancelarija = string.Empty;
        public string _kancelarija { get { return Kancelarija; } set { SetProperty(ref Kancelarija, value); } }

        string VrstaUgovora = string.Empty;
        public string _vrstaUgovora { get { return VrstaUgovora; } set { SetProperty(ref VrstaUgovora, value); } }

        string DatumRodjenja = string.Empty;
        public string _datumRodjenja{ get { return DatumRodjenja; } set { SetProperty(ref DatumRodjenja, value); } }

        string DatumZaposlenja = string.Empty;
        public string _datumZaposlenja { get { return DatumZaposlenja; } set { SetProperty(ref DatumZaposlenja, value); } }

        string KorisnickoIme = string.Empty;
        public string _korisnickoIme{ get { return KorisnickoIme; } set { SetProperty(ref KorisnickoIme, value); } }

        string Adresa= string.Empty;
        public string _adresa{ get { return Adresa; } set { SetProperty(ref Adresa, value); } }

        string Spol= string.Empty;
        public string _spol{ get { return Spol; } set { SetProperty(ref Spol, value); } }

        string Staz= string.Empty;
        public string _staz{ get { return Staz; } set { SetProperty(ref Staz, value); } }

        ImageSource Slika = null;
        public ImageSource _slika { get { return Slika; } set { SetProperty(ref Slika, value); } }

        public ProfesorAdmin Temp { get; set; } = new ProfesorAdmin();


        public ICommand NazadCommand { get; set; }
        public void Nazad(int id, int role)
        {
            Application.Current.MainPage = new ProfPage(id, role);
        }

        public ICommand UrediCommand { get; set; }
        public void Uredi(int id, int role, ProfesorAdmin podaci)
        {
            Application.Current.MainPage = new MojiPodaciUrediProf(id, role, podaci);
        }

        ProfesorAdmin temp { get; set; } = new ProfesorAdmin();
        public async void LoadData(int _id2, int _role2)
        {
            temp = await _service.GetById<ProfesorAdmin>(_id2);

            ProfID = _id2;
            Role = _role;
            _profId = _id2;
            _role = _role2;
            Temp = await _service.GetById<ProfesorAdmin>(_id2);
            _profId = _id2;
            _ime = Temp.Ime;
            _prezime = Temp.Prezime;
            _zvanje = Temp.Zvanje;
            _mail = Temp.Mail;
            _kancelarija = Temp.Kancelarija;
            _vrstaUgovora = Temp.VrstaUgovora;
            _datumRodjenja = Temp.DatumRodjenja.ToString();
            _datumZaposlenja = Temp.DatumZaposlenja.ToString();
            _korisnickoIme = Temp.KorisnickoIme;
            _adresa = Temp.Adresa;
            _spol = Temp.Spol;
            _staz = Temp.Staz.ToString();
            _slika = ImageSource.FromStream(() => new MemoryStream(Temp.Slika));
        }

    }
}

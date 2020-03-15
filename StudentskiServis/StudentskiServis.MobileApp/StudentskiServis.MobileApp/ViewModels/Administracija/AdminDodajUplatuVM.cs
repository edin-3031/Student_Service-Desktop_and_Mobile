using StudentskiServis.MobileApp.Views;
using StudentskiServis.MobileApp.Views.Administracija;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Administracija
{
    public class AdminDodajUplatuVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Uplata");
        private readonly APIService _service_admin = new APIService("Administracija");
        private readonly APIService _service_stud = new APIService("Student");
        private readonly APIService _service_s = new APIService("STUD");
        private readonly APIService _service_a = new APIService("ADMIN");
        public AdminDodajUplatuVM()
        {

        }

        public AdminDodajUplatuVM(int role, int userId)
        {
            LoadUsers();


            NazadCommand = new Command(async() =>
            {
                List<uplate> lista = await _service.Get<List<uplate>>(null);

                Application.Current.MainPage = new AdminPrikazUplataPage(userId, role, lista);
            });

            SnimiCommand = new Command(async() =>
            {
                //var ev = await _service_admin.GetById<AdministracijaAll>(userId);
                //var uplatio = await _service_stud.GetById<StudentAdmin>(20);


                uplate temp = new uplate
                {
                    AdministracijaId = IzbaraniADMIN.AdministracijaId,
                    DatumUplate = Datum,
                    Evidentirao = IzbaraniADMIN.Ime,
                    Iznos = Iznos,
                    Slika = null,
                    StudentId = IzbaraniSTUD.StudentId,
                    Svrha = Svrha,
                    Uplatio = IzbaraniSTUD.Ime
                };

                if (Ovjereno == true)
                    temp.Ovjereno = "Da";
                else if (Ovjereno == false)
                    temp.Ovjereno = "Ne";

                try
                {
                    if (!string.IsNullOrWhiteSpace(temp.Evidentirao) &&
                    Iznos>0 &&
                    !string.IsNullOrWhiteSpace(temp.Svrha) &&
                    !string.IsNullOrWhiteSpace(temp.Uplatio)) {
                        await _service.Insert(temp);
                        Application.Current.MainPage = new AdminPage(role, userId);
                        await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste dodali nove podatke", "OK");
                    } 
                }
                catch (Exception e)
                {
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Niste unijeli ispravne podatke", "OK");
                };
                
            });


        }

        STUD _izbaraniSTUD;
        public STUD IzbaraniSTUD { get { return _izbaraniSTUD; } set { SetProperty(ref _izbaraniSTUD,value); } }
        ADMIN _zbaraniADMIN;
        public ADMIN IzbaraniADMIN { get { return _zbaraniADMIN; } set { SetProperty(ref _zbaraniADMIN, value); } }

        public async void LoadUsers()
        {
            List<STUD> listaS = await _service_s.Get<List<STUD>>(null);
            List<ADMIN> listaA = await _service_a.Get<List<ADMIN>>(null);

            foreach (var x in listaA)
            {
                listaADMIN.Add(x);
            }

            foreach (var y in listaS)
            {
                listaSTUD.Add(y);
            }
        }
        public ObservableCollection<ADMIN> listaADMIN { get; set; } = new ObservableCollection<ADMIN>();
        public ObservableCollection<STUD> listaSTUD { get; set; } = new ObservableCollection<STUD>();

        public ICommand NazadCommand { get; set; }
        public ICommand SnimiCommand { get; set; }

        double? _iznos;
        public double? Iznos { get { return _iznos; } set { SetProperty(ref _iznos, value); } }

        string _svrha;
        public string Svrha { get { return _svrha; } set { SetProperty(ref _svrha, value); } }

        bool _ovjereno = false;
        public bool Ovjereno { get { return _ovjereno; } set { SetProperty(ref _ovjereno, value); } }

        ImageSource _slika;
        public ImageSource Slika { get { return _slika; } set { SetProperty(ref _slika, value); } }

        DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }

        int? _adminId;
        public int? AdminID { get { return _adminId; } set { SetProperty(ref _adminId, value); } }

        int? _studId;
        public int? StudID { get { return _studId; } set { SetProperty(ref _studId, value); } }

        string _evidentirao;
        public string Evidentirao { get { return _evidentirao; } set { SetProperty(ref _evidentirao, value); } }

        string _uplatio;
        public string Uplatio { get { return _uplatio; } set { SetProperty(ref _uplatio, value); } }


    }
}

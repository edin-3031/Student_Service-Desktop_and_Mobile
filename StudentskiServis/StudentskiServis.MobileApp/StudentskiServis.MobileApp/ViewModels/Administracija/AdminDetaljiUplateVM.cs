using StudentskiServis.MobileApp.Views;
using StudentskiServis.MobileApp.Views.Administracija;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Administracija
{
    public class AdminDetaljiUplateVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Uplata");
        public AdminDetaljiUplateVM()
        {

        }

        public AdminDetaljiUplateVM(int userId, int role, uplate t)
        {
            Iznos = t.Iznos;
            Svrha = t.Svrha;
            if (t.Ovjereno == "Da")
                Ovjereno = true;
            Slika = ImageSource.FromStream(() => new MemoryStream(t.Slika));
            Datum = t.DatumUplate.Value;
            AdminID = t.AdministracijaId;
            StudID = t.StudentId;
            Evidentirao = t.Evidentirao;
            Uplatio = t.Uplatio;
            UplataID = t.UplataId;

            NazadCommand = new Command(async() =>
            {
                List<uplate> listaSource = await _service.Get<List<uplate>>(null);

                Application.Current.MainPage = new AdminPrikazUplataPage(userId, role, listaSource);
            });

            UkloniCommand = new Command(async() =>
            {
                var tmp = await Application.Current.MainPage.DisplayAlert("Poruka", "Da li ste sigurni da želite obrisati odabranu uplatu", "Da","Ne");

                if (tmp == true)
                {

                    await _service.Delete(UplataID);

                    Application.Current.MainPage = new AdminPage(role, userId);

                    await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno te uklonuli uplatu", "OK");
                }
            });
        }

        public ICommand NazadCommand { get; set; }
        public ICommand UkloniCommand { get; set; }

        int _uplataId;
        public int UplataID{ get { return _uplataId; } set { SetProperty(ref _uplataId, value); } }

         double? _iznos;
        public double? Iznos { get { return _iznos; } set { SetProperty(ref _iznos, value); } }

        string _svrha;
        public string Svrha { get { return _svrha; } set { SetProperty(ref _svrha, value); } }

        bool _ovjereno=false;
        public bool Ovjereno { get { return _ovjereno; } set { SetProperty(ref _ovjereno, value); } }

        ImageSource _slika;
        public ImageSource Slika{ get { return _slika; } set { SetProperty(ref _slika, value); } }

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

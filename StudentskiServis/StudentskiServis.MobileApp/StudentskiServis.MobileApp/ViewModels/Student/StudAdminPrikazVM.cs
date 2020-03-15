using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudAdminPrikazVM:BaseViewModel
    {
        public StudAdminPrikazVM()
        {

        }

        public StudAdminPrikazVM(int userId, int role, List<AdministracijaAll> listaAdmin)
        {
            nazadCommand = new Command(()=> {
                Application.Current.MainPage = new StudPage(role, userId);
            });

            foreach(var x in listaAdmin)
            {
                lista.Add(new AdministracijaAll
                {
                    Ime = x.Ime,
                    AdministracijaId = x.AdministracijaId,
                    Kancelarija = x.Kancelarija,
                    Mail = x.Mail,
                    Prezime = x.Prezime,
                    Slika = x.Slika
                });
            }
        }

        public ICommand nazadCommand { get; set; }

        public List<AdministracijaAll> lista { get; set; } = new List<AdministracijaAll>();

        int _userId;
        public int UserID { get { return _userId; } set { SetProperty(ref _userId, value); } }
        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }
        string _ime;
        public string Ime { get { return _ime; } set { SetProperty(ref _ime, value); } }
        string _prezime;
        public string Prezime { get { return _prezime; } set { SetProperty(ref _prezime, value); } }
        string _mail;
        public string Mail { get { return _mail; } set { SetProperty(ref _mail, value); } }
        string _kancelarija;
        public string Kancelarija { get { return _kancelarija; } set { SetProperty(ref _kancelarija, value); } }
        ImageSource _slika;
        public ImageSource Slika { get { return _slika; } set { SetProperty(ref _slika, value); } }

    }
}

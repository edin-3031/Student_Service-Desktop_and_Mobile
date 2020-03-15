using StudentskiServis.MobileApp.Views;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels
{
    public class AuthVM : BaseViewModel
    {
        private readonly APIService _service = new APIService("Auth");
        private readonly APIService _service_uloga = new APIService("Uloga");
        public AuthVM()
        {
            //LoadRole();

            AuthCommand = new Command(async () =>
            {
                try
                {
                    await Auth();
                }
                catch(Exception e)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste unijeli ispravne podatke", "OK");
                };
            });
        }

        public ObservableCollection<ULOGA> ListaUloga { get; set; } = new ObservableCollection<ULOGA>();
        public ICommand AuthCommand { get; set; }

        string _username = string.Empty;
        public string Username {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        int _role;
        public int Role
        {
            get { return _role; }
            set { SetProperty(ref _role, value); }
        }

        

       

        public async Task LoadRole()
        {
            if (ListaUloga.Count == 0)
            {
                var listaSource =await  _service_uloga.Get<List<ULOGA>>(null);
                foreach (var role in listaSource)
                {
                    ListaUloga.Add(role);
                }
            }
        }

        ULOGA _selectedVrstaProizvoda = null;

        public ULOGA SelectedVrstaProizvoda
        {
            get { return _selectedVrstaProizvoda; }
            set
            {
                SetProperty(ref _selectedVrstaProizvoda, value);
            }
        }

        public async Task Auth()
        {
            try
            {
                var t=await _service.Auth(Username, Password, _selectedVrstaProizvoda.UlogaId);
                int roleId = t.Last;
                int userId = t.First;

                ULOGA u = await _service_uloga.GetById<ULOGA>(roleId);

                if (u.Naziv=="Administrator")
                    Application.Current.MainPage = new AdminPage(roleId, userId);
                else if (u.Naziv == "Student")
                    Application.Current.MainPage = new StudPage(roleId, userId);
                else if (u.Naziv == "Profesor")
                    Application.Current.MainPage = new ProfPage(userId,roleId);

            }
            catch (NullReferenceException e)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste unijeli ispravne podatke","OK");
            }
        }
    }
}

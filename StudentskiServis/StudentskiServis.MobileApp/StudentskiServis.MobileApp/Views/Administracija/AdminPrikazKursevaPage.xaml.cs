using StudentskiServis.MobileApp.ViewModels.Administracija;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentskiServis.MobileApp.Views.Administracija
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPrikazKursevaPage : ContentPage
    {
        private readonly AdminPrikazKursevaVM model = null;
        
        public AdminPrikazKursevaPage()
        {
            InitializeComponent();
        }
        int _user, _role;
        public AdminPrikazKursevaPage(int userId, int role, List<kursevi> lista)
        {
            BindingContext = model = new AdminPrikazKursevaVM(userId, role, lista);
            _user = userId;
            _role = role;
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            kursevi t = (kursevi)e.SelectedItem;

            Application.Current.MainPage = new AdminDetaljiKursaPage(_user,_role,t);
        }
    }
}
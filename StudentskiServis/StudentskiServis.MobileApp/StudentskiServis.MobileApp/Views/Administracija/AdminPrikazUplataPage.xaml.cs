using StudentskiServis.MobileApp.ViewModels.Administracija;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentskiServis.MobileApp.Views.Administracija
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPrikazUplataPage : ContentPage
    {
        private readonly AdminPrikazUplataVM model = null;

        public AdminPrikazUplataPage()
        {
            InitializeComponent();
        }
        int _user, _role;
        public AdminPrikazUplataPage(int userId, int role, List<uplate> lista)
        {
            BindingContext = model = new AdminPrikazUplataVM(userId, role, lista);
            _user = userId;
            _role = role;
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            uplate t = (uplate)e.SelectedItem;

            Application.Current.MainPage=new AdminDetaljiUplatePage(_user, _role, t);
        }
    }
}
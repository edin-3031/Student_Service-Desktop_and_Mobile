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
    public partial class AdminPrikazProfesoraPage : ContentPage
    {
        private readonly AdminPrikazProfesoraVM model = null;

        public AdminPrikazProfesoraPage()
        {
            InitializeComponent();
        }
        int _user, _role;
        public AdminPrikazProfesoraPage(int userId, int role, List<ProfesorAdmin> lista)
        {
            BindingContext = model = new AdminPrikazProfesoraVM(userId,role, lista);
            _user = userId;
            _role = role;
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ProfesorAdmin t = (ProfesorAdmin)e.SelectedItem;
            Application.Current.MainPage = new AdminDetaljiProfesorPage(_user, _role, t);
        }
    }
}
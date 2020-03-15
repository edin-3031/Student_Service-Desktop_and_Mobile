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
    public partial class AdminPrikazAdministracijePage : ContentPage
    {
        private readonly AdminPrikazAdministracijeVM model = null;

        public AdminPrikazAdministracijePage()
        {
            InitializeComponent();
        }
        
        public AdminPrikazAdministracijePage(int userId, int role, List<AdministracijaAdmin> lista)
        {

            BindingContext = model = new AdminPrikazAdministracijeVM(userId, role, lista);
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            AdministracijaAdmin t = (AdministracijaAdmin)e.SelectedItem;
            Application.Current.MainPage = new AdminDetaljiAdministracijaPage(model.UserID, model.Role, t);
        }
    }
}
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
    public partial class AdminDetaljiAdministracijaPage : ContentPage
    {
        private readonly AdminDetaljiAdministracijaVM model = null;

        public AdminDetaljiAdministracijaPage()
        {
            InitializeComponent();
        }
        
        public AdminDetaljiAdministracijaPage(int userId, int role, AdministracijaAdmin t)
        {
            BindingContext = model = new AdminDetaljiAdministracijaVM(userId, role, t);

            InitializeComponent();
            
        }
    }
}
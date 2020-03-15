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
    public partial class AdminDetaljiProfesorPage : ContentPage
    {
        private AdminDetaljiProfesorVM model = null;

        public AdminDetaljiProfesorPage()
        {
            InitializeComponent();
        }
        
        public AdminDetaljiProfesorPage(int _user, int _role,ProfesorAdmin t)
        {
            InitializeComponent();
            BindingContext = model = new AdminDetaljiProfesorVM(_user, _role, t);
        }
    }
}
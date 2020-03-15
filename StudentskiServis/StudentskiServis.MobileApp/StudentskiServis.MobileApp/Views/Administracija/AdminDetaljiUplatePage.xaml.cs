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
    public partial class AdminDetaljiUplatePage : ContentPage
    {
        private readonly AdminDetaljiUplateVM model = null;

        public AdminDetaljiUplatePage()
        {
            InitializeComponent();
        }

        public AdminDetaljiUplatePage(int userId, int role, uplate lista)
        {
            BindingContext = model = new AdminDetaljiUplateVM(userId,role,lista);

            InitializeComponent();
        }
    }
}
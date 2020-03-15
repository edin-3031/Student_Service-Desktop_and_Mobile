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
    public partial class AdminMojiPodaciPage : ContentPage
    {
        private readonly AdminMojiPodaciVM model = null;
        public AdminMojiPodaciPage()
        {
            InitializeComponent();
        }
        
        public AdminMojiPodaciPage(int userId, int role, AdministracijaAdmin t)
        {
            BindingContext = model = new AdminMojiPodaciVM(userId,role,t);
            InitializeComponent();
        }

    }
}
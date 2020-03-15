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
    public partial class AdminMojiPodaciIzmjenaPage : ContentPage
    {
        private readonly AdminMojiPodaciIzmjenaVM model = null;
        public AdminMojiPodaciIzmjenaPage()
        {
            InitializeComponent();
        }
        
        public AdminMojiPodaciIzmjenaPage(int role, int userId, AdministracijaAdmin t)
        {
            BindingContext = model = new AdminMojiPodaciIzmjenaVM(role,userId,t);

            InitializeComponent();
        }
    }
}
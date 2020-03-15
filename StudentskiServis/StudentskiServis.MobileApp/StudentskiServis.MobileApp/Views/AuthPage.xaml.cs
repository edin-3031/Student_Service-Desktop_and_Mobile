using StudentskiServis.MobileApp.ViewModels;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentskiServis.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        private readonly AuthVM model = null;
        public AuthPage()
        {
            InitializeComponent();
            BindingContext = model = new AuthVM();
        }

        protected override async void OnAppearing()
        {
            

            base.OnAppearing();
            await model.LoadRole();
        }
    }
}
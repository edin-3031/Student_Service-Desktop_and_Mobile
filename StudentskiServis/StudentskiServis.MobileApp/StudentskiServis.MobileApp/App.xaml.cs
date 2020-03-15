using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StudentskiServis.MobileApp.Services;
using StudentskiServis.MobileApp.Views;

namespace StudentskiServis.MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new StudPage(2, 20);

            //Admin AdminPage(1, 1035);
            //Profesor ProfPage(4, 15);
            //Student StudPage(2, 20);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

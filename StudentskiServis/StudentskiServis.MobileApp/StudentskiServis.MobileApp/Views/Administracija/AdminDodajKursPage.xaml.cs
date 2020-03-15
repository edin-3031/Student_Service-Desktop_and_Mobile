using StudentskiServis.MobileApp.ViewModels.Administracija;
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
    public partial class AdminDodajKursPage : ContentPage
    {
        private readonly AdminDodajKursVM model = null;
        public AdminDodajKursPage()
        {
            InitializeComponent();
        }

        public AdminDodajKursPage(int role, int userId)
        {
            BindingContext = model = new AdminDodajKursVM(role, userId);

            InitializeComponent();
        }

        private void CheckBox_Seminarksi(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
                model.Seminarski = true;
            else if(e.Value == false)
                model.Seminarski = false;
        }

        private void CheckBox_Praksa(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
                model.Praksa = true;
            else if (e.Value == false)
                model.Praksa = false;
        }
    }
}
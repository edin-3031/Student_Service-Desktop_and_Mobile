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
    public partial class AdminDodajUplatuPage : ContentPage
    {
        private readonly AdminDodajUplatuVM model = null;
        public AdminDodajUplatuPage()
        {
            InitializeComponent();
        }
        
        public AdminDodajUplatuPage(int role, int userId)
        {
            BindingContext = model = new AdminDodajUplatuVM(role, userId);

            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
                model.Ovjereno = true;
            else if (e.Value == false)
                model.Ovjereno = false;
        }
    }
}
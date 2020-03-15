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
    public partial class AdminDodajProfesoraPage : ContentPage
    {
        private readonly AdminDodajProfesoraVM model = null;

        public AdminDodajProfesoraPage()
        {
            InitializeComponent();
        }
        
        public AdminDodajProfesoraPage(int role, int userId)
        {
            BindingContext = model = new AdminDodajProfesoraVM(role,userId);

            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            var selectedItem = picker.SelectedItem;

            if (selectedItem == "Muško")
                model.Spol = "M";
            else if (selectedItem == "Žensko")
                model.Spol = "Ž";
        }
    }
}
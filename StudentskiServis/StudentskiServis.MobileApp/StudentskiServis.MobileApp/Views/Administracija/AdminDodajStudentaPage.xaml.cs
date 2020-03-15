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
    public partial class AdminDodajStudentaPage : ContentPage
    {
        private readonly AdminDodajStudentaVM model = null;
        public AdminDodajStudentaPage()
        {
            InitializeComponent();
        }
        
        public AdminDodajStudentaPage(int role, int userId)
        {

            BindingContext = model = new AdminDodajStudentaVM(role, userId);
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;

            string t = (string)picker.SelectedItem;

            if (t == "Muško")
                model.Spol = "M";
            else if (t == "Žensko")
                model.Spol = "Ž";
        }

        private void Picker_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;

            string t = (string) picker.SelectedItem;

            if (t == "IN-CLASS")
                model.NacinStudiranja = "IN-CLASS";
            else if (t == "DL")
                model.NacinStudiranja = "DL";
            else if (t == "Vanredno")
                model.NacinStudiranja = "Vanredno";

            model.Ocjena = 0;
        }

        private void Picker_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;

            string t = (string) picker.SelectedItem;

            if (t == "Da")
                model.ObnavljaGodinu = "Da";
            else if (t == "Ne")
                model.ObnavljaGodinu = "Ne";
        }
    }
}
using StudentskiServis.MobileApp.ViewModels.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentskiServis.MobileApp.Views.Student
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudAdminPrikazPage : ContentPage
    {
        private readonly StudAdminPrikazVM model = null;

        public StudAdminPrikazPage()
        {
            InitializeComponent();
        }
        int _user, _role;
        public StudAdminPrikazPage(int userId, int role, List<AdministracijaAll>listaAdmin)
        {
            BindingContext = model = new StudAdminPrikazVM(userId, role, listaAdmin);
            _user = userId;
            _role = role;
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            AdministracijaAll t = (AdministracijaAll)e.SelectedItem;

            Application.Current.MainPage = new StudAdminDetaljiPage(_user, _role, t);
        }
    }
}
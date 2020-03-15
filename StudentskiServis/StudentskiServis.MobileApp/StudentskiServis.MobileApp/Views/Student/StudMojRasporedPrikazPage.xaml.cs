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
    public partial class StudMojRasporedPrikazPage : ContentPage
    {
        private readonly StudMojRasporedPrikazVM model = null;
        public StudMojRasporedPrikazPage()
        {
            InitializeComponent();
        }
        int _user, _role;
        public StudMojRasporedPrikazPage(int userId, int role, List<Raspored> listaRaspored)
        {
            BindingContext = model = new StudMojRasporedPrikazVM(userId, role, listaRaspored);
            InitializeComponent();
            _user = userId;
            _role = role;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Raspored temp = (Raspored)e.SelectedItem;

            Application.Current.MainPage = new StudMojRasporedDetaljiPage(_user, _role, temp);
        }
    }
}
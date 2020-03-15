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
    public partial class StudProfPrikazPage : ContentPage
    {
        private readonly StudProfPrikazVM model = null;

        public StudProfPrikazPage()
        {
            InitializeComponent();
        }
        int _user, _role;
        public StudProfPrikazPage(int userId, int role, List<ProfesorAll> listaProf)
        {
            BindingContext = model = new StudProfPrikazVM(userId, role, listaProf);
            InitializeComponent();
            _user = userId;
            _role = role;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var t = (ProfesorAll)e.SelectedItem;

            Application.Current.MainPage = new StudProfDetaljiPage(_user, _role, t);
        }
    }
}
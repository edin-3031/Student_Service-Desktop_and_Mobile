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
    public partial class AdminPrikazStudenataPage : ContentPage
    {
        private APIService _servis = new APIService("Student");

        private readonly AdminPrikazStudenataVM model = null;

        public AdminPrikazStudenataPage()
        {
            InitializeComponent();
        }
        int _user, _role;
        public AdminPrikazStudenataPage(int userId,int role, List<StudentAdmin> lista)
        {
            BindingContext = model = new AdminPrikazStudenataVM(userId, role, lista);
            _role = role;
            _user = userId;
            InitializeComponent();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            StudentAdmin t = (StudentAdmin)e.SelectedItem;

            StudentAdmin temp = await _servis.GetById<StudentAdmin>(t.StudentID);

            Application.Current.MainPage = new AdminDetaljiStudentPage(_user, _role, temp);
        }
    }
}
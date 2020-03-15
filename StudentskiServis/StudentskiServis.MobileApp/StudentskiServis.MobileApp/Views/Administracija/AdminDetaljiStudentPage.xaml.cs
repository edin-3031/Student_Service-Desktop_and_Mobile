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
    public partial class AdminDetaljiStudentPage : ContentPage
    {
        private readonly AdminDetaljiStudentVM model = null;
        public AdminDetaljiStudentPage()
        {
            InitializeComponent();
        }
        
        public AdminDetaljiStudentPage(int _user, int _role, StudentAdmin t)
        {
            BindingContext = model = new AdminDetaljiStudentVM(_user,_role,t);

            InitializeComponent();
        }
    }
}
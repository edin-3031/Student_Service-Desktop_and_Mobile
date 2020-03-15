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
    public partial class StudAdminDetaljiPage : ContentPage
    {
        private readonly StudAdminDetaljiVM model = null;

        public StudAdminDetaljiPage()
        {
            InitializeComponent();
        }
        
        public StudAdminDetaljiPage(int userId, int role, AdministracijaAll t)
        {
            BindingContext = model = new StudAdminDetaljiVM(userId, role, t);

            InitializeComponent();
        }
    }
}
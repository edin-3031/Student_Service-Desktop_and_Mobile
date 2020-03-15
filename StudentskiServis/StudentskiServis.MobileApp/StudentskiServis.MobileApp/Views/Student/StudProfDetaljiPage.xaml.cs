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
    public partial class StudProfDetaljiPage : ContentPage
    {
        private readonly StudProfDetaljiVM model = null;
        public StudProfDetaljiPage()
        {
            InitializeComponent();
        }
        
        public StudProfDetaljiPage(int userId, int role, ProfesorAll t)
        {
            BindingContext = model = new StudProfDetaljiVM(userId,role,t);
            InitializeComponent();
        }
    }
}
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
    public partial class StudMojiispitiDetaljiPage : ContentPage
    {
        private readonly StudMojiispitiDetaljiVM model = null;

        public StudMojiispitiDetaljiPage()
        {
            InitializeComponent();
        }
        
        public StudMojiispitiDetaljiPage(ispiti temp, int userId, int role)
        {
            BindingContext = model = new StudMojiispitiDetaljiVM(temp, userId, role);
            InitializeComponent();

        }
    }
}
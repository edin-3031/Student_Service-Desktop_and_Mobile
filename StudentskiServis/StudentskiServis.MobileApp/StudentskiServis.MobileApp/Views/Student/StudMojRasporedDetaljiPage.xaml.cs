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
    public partial class StudMojRasporedDetaljiPage : ContentPage
    {
        private readonly StudMojRasporedDetaljiVM model = null;

        public StudMojRasporedDetaljiPage()
        {
            InitializeComponent();
        }
        
        public StudMojRasporedDetaljiPage(int userId, int role, Raspored raspored)
        {
            BindingContext = model = new StudMojRasporedDetaljiVM(userId, role, raspored);
            InitializeComponent();
        }
    }
}
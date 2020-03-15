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
    public partial class StudObavijestiDetaljiPage : ContentPage
    {
        private StudObavijestiDetaljiVM model = null;

        public StudObavijestiDetaljiPage()
        {
            InitializeComponent();
        }

        public StudObavijestiDetaljiPage(int UserID, int Role, obavijesti temp)
        {
            BindingContext = model = new StudObavijestiDetaljiVM(UserID, Role, temp);
            InitializeComponent();
        }
    }
}